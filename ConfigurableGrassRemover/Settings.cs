using System;
using System.Collections.Generic;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis.Settings;

namespace ConfigurableGrassRemover;

public class Settings
{
    [SynthesisOrder]
    [SynthesisSettingName("Mode")]
    [SynthesisDescription(
        "Blacklist: All listed Worldspaces wont get altered.\nWhitelist: Only the listed Worldspaces get altered.")]
    [SynthesisTooltip(
        "Blacklist: All listed Worldspaces wont get altered.\nWhitelist: Only the listed Worldspaces get altered.")]
    public Mode Mode = Mode.Blacklist;
    [SynthesisOrder]
    [SynthesisSettingName("WorldSpaces")]
    [SynthesisDescription("List WorldSpaces")]
    [SynthesisTooltip("List WorldSpaces")]
    public HashSet<IFormLinkGetter<IWorldspaceGetter>> Worldspaces { get; set; } = new()
    {
        Skyrim.Worldspace.Tamriel,
        Skyrim.Worldspace.EldergleamSanctuaryWorld,
        Skyrim.Worldspace.Sovngarde,
        Skyrim.Worldspace.MossMotherCavernWorld,
        Skyrim.Worldspace.BloatedMansGrottoWorld,
        Skyrim.Worldspace.FallowstoneCaveWorldEnd,
        Skyrim.Worldspace.SouthfringeWorld,
        Skyrim.Worldspace.RiftenWorld,
        Skyrim.Worldspace.SkuldafnWorld,
        Skyrim.Worldspace.JaphetsFollyWorld,
        Skyrim.Worldspace.LabyrinthianWorld,
        Skyrim.Worldspace.BluePalaceWingWorld,
        Dawnguard.Worldspace.DLC1VampireCastleCourtyard,
        Dawnguard.Worldspace.DLC01FalmerValley,
        Dawnguard.Worldspace.DLC1HunterHQWorld,
        Dawnguard.Worldspace.DLC1AncestorsGladeWorld,
        Dawnguard.Worldspace.DLC1VampireCastleCourtyard,
        Dragonborn.Worldspace.DLC2SolstheimWorld,
    };
}