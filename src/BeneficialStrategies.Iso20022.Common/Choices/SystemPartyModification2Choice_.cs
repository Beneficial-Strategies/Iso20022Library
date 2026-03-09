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
    [KnownType(typeof(SystemPartyModification2Choice.SystemPartyDate))]
    [KnownType(typeof(SystemPartyModification2Choice.PartyIdentification))]
    [KnownType(typeof(SystemPartyModification2Choice.PartyName))]
    [KnownType(typeof(SystemPartyModification2Choice.ContactDetails))]
    [KnownType(typeof(SystemPartyModification2Choice.TechnicalAddress))]
    [KnownType(typeof(SystemPartyModification2Choice.PartyAddress))]
    [KnownType(typeof(SystemPartyModification2Choice.ResidenceType))]
    [KnownType(typeof(SystemPartyModification2Choice.LockStatus))]
    [KnownType(typeof(SystemPartyModification2Choice.SystemRestriction))]
    [KnownType(typeof(SystemPartyModification2Choice.MarketSpecificAttribute))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemPartyModification2Choice.SystemPartyDate),nameof(SystemPartyModification2Choice.SystemPartyDate))]
    [JsonDerivedType(typeof(SystemPartyModification2Choice.PartyIdentification),nameof(SystemPartyModification2Choice.PartyIdentification))]
    [JsonDerivedType(typeof(SystemPartyModification2Choice.PartyName),nameof(SystemPartyModification2Choice.PartyName))]
    [JsonDerivedType(typeof(SystemPartyModification2Choice.ContactDetails),nameof(SystemPartyModification2Choice.ContactDetails))]
    [JsonDerivedType(typeof(SystemPartyModification2Choice.TechnicalAddress),nameof(SystemPartyModification2Choice.TechnicalAddress))]
    [JsonDerivedType(typeof(SystemPartyModification2Choice.PartyAddress),nameof(SystemPartyModification2Choice.PartyAddress))]
    [JsonDerivedType(typeof(SystemPartyModification2Choice.ResidenceType),nameof(SystemPartyModification2Choice.ResidenceType))]
    [JsonDerivedType(typeof(SystemPartyModification2Choice.LockStatus),nameof(SystemPartyModification2Choice.LockStatus))]
    [JsonDerivedType(typeof(SystemPartyModification2Choice.SystemRestriction),nameof(SystemPartyModification2Choice.SystemRestriction))]
    [JsonDerivedType(typeof(SystemPartyModification2Choice.MarketSpecificAttribute),nameof(SystemPartyModification2Choice.MarketSpecificAttribute))]
    #endif
    [IsoId("_x87oIYv-Eei289CGNqs21g")]
    [DisplayName("System Party Modification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemPartyModification2Choice_
    #else
    public abstract partial class SystemPartyModification2Choice_
    #endif
    {
    }
}
