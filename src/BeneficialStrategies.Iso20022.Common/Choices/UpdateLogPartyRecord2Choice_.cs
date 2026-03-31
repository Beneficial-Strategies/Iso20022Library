// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Update Log Party Record2Choice.
    /// </summary>
    [KnownType(typeof(UpdateLogPartyRecord2Choice.Address))]
    [KnownType(typeof(UpdateLogPartyRecord2Choice.ClosingDate))]
    [KnownType(typeof(UpdateLogPartyRecord2Choice.ContactDetails))]
    [KnownType(typeof(UpdateLogPartyRecord2Choice.LockStatus))]
    [KnownType(typeof(UpdateLogPartyRecord2Choice.MarketSpecificAttribute))]
    [KnownType(typeof(UpdateLogPartyRecord2Choice.Name))]
    [KnownType(typeof(UpdateLogPartyRecord2Choice.OpeningDate))]
    [KnownType(typeof(UpdateLogPartyRecord2Choice.Other))]
    [KnownType(typeof(UpdateLogPartyRecord2Choice.ResidenceType))]
    [KnownType(typeof(UpdateLogPartyRecord2Choice.Restriction))]
    [KnownType(typeof(UpdateLogPartyRecord2Choice.TechnicalAddress))]
    [KnownType(typeof(UpdateLogPartyRecord2Choice.Type))]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.Address),
        nameof(UpdateLogPartyRecord2Choice.Address)
    )]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.ClosingDate),
        nameof(UpdateLogPartyRecord2Choice.ClosingDate)
    )]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.ContactDetails),
        nameof(UpdateLogPartyRecord2Choice.ContactDetails)
    )]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.LockStatus),
        nameof(UpdateLogPartyRecord2Choice.LockStatus)
    )]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.MarketSpecificAttribute),
        nameof(UpdateLogPartyRecord2Choice.MarketSpecificAttribute)
    )]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.Name),
        nameof(UpdateLogPartyRecord2Choice.Name)
    )]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.OpeningDate),
        nameof(UpdateLogPartyRecord2Choice.OpeningDate)
    )]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.Other),
        nameof(UpdateLogPartyRecord2Choice.Other)
    )]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.ResidenceType),
        nameof(UpdateLogPartyRecord2Choice.ResidenceType)
    )]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.Restriction),
        nameof(UpdateLogPartyRecord2Choice.Restriction)
    )]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.TechnicalAddress),
        nameof(UpdateLogPartyRecord2Choice.TechnicalAddress)
    )]
    [JsonDerivedType(
        typeof(UpdateLogPartyRecord2Choice.Type),
        nameof(UpdateLogPartyRecord2Choice.Type)
    )]
    [IsoId("_YwDt2TE_Ee62xuUQ2zyZww")]
    [DisplayName("Update Log Party Record2Choice")]
    public abstract record UpdateLogPartyRecord2Choice_ { }
}
