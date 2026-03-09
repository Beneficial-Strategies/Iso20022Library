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
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification116Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification116Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification116Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification116Choice.AnyBIC),nameof(PartyIdentification116Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification116Choice.NameAndAddress),nameof(PartyIdentification116Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification116Choice.Country),nameof(PartyIdentification116Choice.Country))]
    #endif
    [IsoId("_GXyTIZEpEeakHoV5BVecAQ")]
    [DisplayName("Party Identification 116 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification116Choice_
    #else
    public abstract partial class PartyIdentification116Choice_
    #endif
    {
    }
}
