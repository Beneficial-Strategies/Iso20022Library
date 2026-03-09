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
    [KnownType(typeof(PartyIdentification42Choice.BICFI))]
    [KnownType(typeof(PartyIdentification42Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification42Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification42Choice.BICFI),nameof(PartyIdentification42Choice.BICFI))]
    [JsonDerivedType(typeof(PartyIdentification42Choice.NameAndAddress),nameof(PartyIdentification42Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification42Choice.ProprietaryIdentification),nameof(PartyIdentification42Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_v1Alz_L-Ed-3lpUMQaXLjQ")]
    [DisplayName("Party Identification 42 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification42Choice_
    #else
    public abstract partial class PartyIdentification42Choice_
    #endif
    {
    }
}
