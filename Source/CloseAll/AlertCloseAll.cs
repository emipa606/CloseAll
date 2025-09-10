using System.Linq;
using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace CloseAll;

public class AlertCloseAll : Alert
{
    public AlertCloseAll()
    {
        defaultLabel = "CloseAll".Translate();
        defaultPriority = AlertPriority.High;
        defaultExplanation = "CloseAllDesc".Translate();
    }

    protected override Color BGColor => new(1f, 1f, 1f, 0.2f);

    protected override void OnClick()
    {
        Find.LetterStack.LettersListForReading.ListFullCopy().Where(letter => letter.CanDismissWithRightClick)
            .Do(letter => Find.LetterStack.RemoveLetter(letter));
    }

    public override AlertReport GetReport()
    {
        return Find.LetterStack.LettersListForReading.Any(letter => letter.CanDismissWithRightClick);
    }
}