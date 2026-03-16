// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// System Party Modification3Choice.
    /// </summary>
    [KnownType(typeof(SystemPartyModification3Choice.ContactDetails))]
    [KnownType(typeof(SystemPartyModification3Choice.LockStatus))]
    [KnownType(typeof(SystemPartyModification3Choice.MarketSpecificAttribute))]
    [KnownType(typeof(SystemPartyModification3Choice.PartyAddress))]
    [KnownType(typeof(SystemPartyModification3Choice.PartyIdentification))]
    [KnownType(typeof(SystemPartyModification3Choice.PartyName))]
    [KnownType(typeof(SystemPartyModification3Choice.ResidenceType))]
    [KnownType(typeof(SystemPartyModification3Choice.SystemPartyDate))]
    [KnownType(typeof(SystemPartyModification3Choice.SystemRestriction))]
    [KnownType(typeof(SystemPartyModification3Choice.TechnicalAddress))]
    [JsonDerivedType(typeof(SystemPartyModification3Choice.ContactDetails),nameof(SystemPartyModification3Choice.ContactDetails))]
    [JsonDerivedType(typeof(SystemPartyModification3Choice.LockStatus),nameof(SystemPartyModification3Choice.LockStatus))]
    [JsonDerivedType(typeof(SystemPartyModification3Choice.MarketSpecificAttribute),nameof(SystemPartyModification3Choice.MarketSpecificAttribute))]
    [JsonDerivedType(typeof(SystemPartyModification3Choice.PartyAddress),nameof(SystemPartyModification3Choice.PartyAddress))]
    [JsonDerivedType(typeof(SystemPartyModification3Choice.PartyIdentification),nameof(SystemPartyModification3Choice.PartyIdentification))]
    [JsonDerivedType(typeof(SystemPartyModification3Choice.PartyName),nameof(SystemPartyModification3Choice.PartyName))]
    [JsonDerivedType(typeof(SystemPartyModification3Choice.ResidenceType),nameof(SystemPartyModification3Choice.ResidenceType))]
    [JsonDerivedType(typeof(SystemPartyModification3Choice.SystemPartyDate),nameof(SystemPartyModification3Choice.SystemPartyDate))]
    [JsonDerivedType(typeof(SystemPartyModification3Choice.SystemRestriction),nameof(SystemPartyModification3Choice.SystemRestriction))]
    [JsonDerivedType(typeof(SystemPartyModification3Choice.TechnicalAddress),nameof(SystemPartyModification3Choice.TechnicalAddress))]
    [IsoId("_Y9qsATE_Ee62xuUQ2zyZww")]
    [DisplayName("System Party Modification3Choice")]
    public abstract partial record SystemPartyModification3Choice_
    {
    }
}
