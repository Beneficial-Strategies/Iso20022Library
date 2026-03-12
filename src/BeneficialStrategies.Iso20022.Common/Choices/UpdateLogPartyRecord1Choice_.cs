// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details related to an update of an individual record in the static data of a party.
    /// </summary>
    [KnownType(typeof(UpdateLogPartyRecord1Choice.Address))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.ContactDetails))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.OpeningDate))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.ClosingDate))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.Type))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.TechnicalAddress))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.MarketSpecificAttribute))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.Name))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.ResidenceType))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.LockStatus))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.Restriction))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.Other))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.Address),nameof(UpdateLogPartyRecord1Choice.Address))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.ContactDetails),nameof(UpdateLogPartyRecord1Choice.ContactDetails))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.OpeningDate),nameof(UpdateLogPartyRecord1Choice.OpeningDate))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.ClosingDate),nameof(UpdateLogPartyRecord1Choice.ClosingDate))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.Type),nameof(UpdateLogPartyRecord1Choice.Type))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.TechnicalAddress),nameof(UpdateLogPartyRecord1Choice.TechnicalAddress))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.MarketSpecificAttribute),nameof(UpdateLogPartyRecord1Choice.MarketSpecificAttribute))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.Name),nameof(UpdateLogPartyRecord1Choice.Name))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.ResidenceType),nameof(UpdateLogPartyRecord1Choice.ResidenceType))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.LockStatus),nameof(UpdateLogPartyRecord1Choice.LockStatus))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.Restriction),nameof(UpdateLogPartyRecord1Choice.Restriction))]
    [JsonDerivedType(typeof(UpdateLogPartyRecord1Choice.Other),nameof(UpdateLogPartyRecord1Choice.Other))]
    [IsoId("_xPtUfWjNEeiRg5NzP0jkQg")]
    [DisplayName("Update Log Party Record 1 Choice")]
    public abstract partial record UpdateLogPartyRecord1Choice_
    {
    }
}
