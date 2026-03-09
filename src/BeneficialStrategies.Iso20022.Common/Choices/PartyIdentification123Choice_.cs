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
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification123Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification123Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification123Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification123Choice.AnyBIC),nameof(PartyIdentification123Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification123Choice.ProprietaryIdentification),nameof(PartyIdentification123Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification123Choice.NameAndAddress),nameof(PartyIdentification123Choice.NameAndAddress))]
    #endif
    [IsoId("_N_onAWpXEeipaMTLlhaKMQ")]
    [DisplayName("Party Identification 123 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification123Choice_
    #else
    public abstract partial class PartyIdentification123Choice_
    #endif
    {
    }
}
