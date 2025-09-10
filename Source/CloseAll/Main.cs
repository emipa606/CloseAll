using System.Reflection;
using HarmonyLib;
using Verse;

namespace CloseAll;

public class Main : Mod
{
    public Main(ModContentPack content) : base(content)
    {
        new Harmony("se.gorymoon.rimworld.mod.closeall").PatchAll(Assembly.GetExecutingAssembly());
    }
}