// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies which information are involved by a modification request for party reference data.
    /// </summary>
    [KnownType(typeof(SystemPartyModification1Choice.SystemParty))]
    [KnownType(typeof(SystemPartyModification1Choice.PartyIdentification))]
    [KnownType(typeof(SystemPartyModification1Choice.PartyName))]
    [KnownType(typeof(SystemPartyModification1Choice.TechnicalAddress))]
    [KnownType(typeof(SystemPartyModification1Choice.PartyAddress))]
    [KnownType(typeof(SystemPartyModification1Choice.SystemRestriction))]
    [KnownType(typeof(SystemPartyModification1Choice.MarketSpecificAttribute))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.SystemParty),nameof(SystemPartyModification1Choice.SystemParty))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.PartyIdentification),nameof(SystemPartyModification1Choice.PartyIdentification))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.PartyName),nameof(SystemPartyModification1Choice.PartyName))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.TechnicalAddress),nameof(SystemPartyModification1Choice.TechnicalAddress))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.PartyAddress),nameof(SystemPartyModification1Choice.PartyAddress))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.SystemRestriction),nameof(SystemPartyModification1Choice.SystemRestriction))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.MarketSpecificAttribute),nameof(SystemPartyModification1Choice.MarketSpecificAttribute))]
    [IsoId("_kouas-5NEeCisYr99QEiWA_-2059945022")]
    [DisplayName("System Party Modification 1 Choice")]
    public abstract partial record SystemPartyModification1Choice_
    {
    }
}
