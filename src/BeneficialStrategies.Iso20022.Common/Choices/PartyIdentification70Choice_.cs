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
    [KnownType(typeof(PartyIdentification70Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification70Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification70Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification70Choice.AnyBIC),nameof(PartyIdentification70Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification70Choice.ProprietaryIdentification),nameof(PartyIdentification70Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification70Choice.NameAndAddress),nameof(PartyIdentification70Choice.NameAndAddress))]
    #endif
    [IsoId("_g-pD8NooEeCWg-hsBVGrDA_1464919328")]
    [DisplayName("Party Identification 70 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification70Choice_
    #else
    public abstract partial class PartyIdentification70Choice_
    #endif
    {
    }
}
