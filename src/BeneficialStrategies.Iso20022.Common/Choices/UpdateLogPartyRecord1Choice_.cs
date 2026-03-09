// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
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
    #if NET7_0_OR_GREATER // C# 11 Records, required members
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
    #endif
    [IsoId("_xPtUfWjNEeiRg5NzP0jkQg")]
    [DisplayName("Update Log Party Record 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateLogPartyRecord1Choice_
    #else
    public abstract partial class UpdateLogPartyRecord1Choice_
    #endif
    {
    }
}
