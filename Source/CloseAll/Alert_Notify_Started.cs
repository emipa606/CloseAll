using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using RimWorld;
using UnityEngine;

namespace CloseAll;

[HarmonyPatch(typeof(Alert), nameof(Alert.Notify_Started))]
public static class Alert_Notify_Started
{
    private static readonly MethodInfo levelLoad =
        AccessTools.Property(typeof(Time), nameof(Time.timeSinceLevelLoad)).GetMethod;

    private static readonly MethodInfo checkTypeInfo =
        AccessTools.Method(typeof(Alert_Notify_Started), nameof(checkType));

    private static bool checkType(Alert alert)
    {
        return alert.GetType() == typeof(AlertCloseAll);
    }

    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var injected = false;
        var foundLabel = false;
        var label = new Label?();
        foreach (var instruction in instructions)
        {
            if (!foundLabel && instruction.Branches(out label))
            {
                foundLabel = true;
            }

            if (!injected && instruction.Calls(levelLoad) && label.HasValue)
            {
                yield return new CodeInstruction(OpCodes.Ldarg_0);
                yield return new CodeInstruction(OpCodes.Call, checkTypeInfo);
                yield return new CodeInstruction(OpCodes.Brtrue, label.Value);

                injected = true;
            }

            yield return instruction;
        }
    }
}