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
    /// Identifies which information are involved by a modification request for party reference data.
    /// </summary>
    [KnownType(typeof(SystemPartyModification1Choice.SystemParty))]
    [KnownType(typeof(SystemPartyModification1Choice.PartyIdentification))]
    [KnownType(typeof(SystemPartyModification1Choice.PartyName))]
    [KnownType(typeof(SystemPartyModification1Choice.TechnicalAddress))]
    [KnownType(typeof(SystemPartyModification1Choice.PartyAddress))]
    [KnownType(typeof(SystemPartyModification1Choice.SystemRestriction))]
    [KnownType(typeof(SystemPartyModification1Choice.MarketSpecificAttribute))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemPartyModification1Choice.SystemParty),nameof(SystemPartyModification1Choice.SystemParty))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.PartyIdentification),nameof(SystemPartyModification1Choice.PartyIdentification))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.PartyName),nameof(SystemPartyModification1Choice.PartyName))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.TechnicalAddress),nameof(SystemPartyModification1Choice.TechnicalAddress))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.PartyAddress),nameof(SystemPartyModification1Choice.PartyAddress))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.SystemRestriction),nameof(SystemPartyModification1Choice.SystemRestriction))]
    [JsonDerivedType(typeof(SystemPartyModification1Choice.MarketSpecificAttribute),nameof(SystemPartyModification1Choice.MarketSpecificAttribute))]
    #endif
    [IsoId("_kouas-5NEeCisYr99QEiWA_-2059945022")]
    [DisplayName("System Party Modification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemPartyModification1Choice_
    #else
    public abstract partial class SystemPartyModification1Choice_
    #endif
    {
    }
}
