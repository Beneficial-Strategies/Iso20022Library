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
    [KnownType(typeof(PartyIdentification93Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification93Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification93Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification93Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification93Choice.AnyBIC),nameof(PartyIdentification93Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification93Choice.ProprietaryIdentification),nameof(PartyIdentification93Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification93Choice.NameAndAddress),nameof(PartyIdentification93Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification93Choice.Country),nameof(PartyIdentification93Choice.Country))]
    #endif
    [IsoId("_bF4nATqmEeWyoP0PbocV1Q")]
    [DisplayName("Party Identification 93 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification93Choice_
    #else
    public abstract partial class PartyIdentification93Choice_
    #endif
    {
    }
}
