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
    [KnownType(typeof(PartyIdentification68Choice.BIC))]
    [KnownType(typeof(PartyIdentification68Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification68Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification68Choice.BIC),nameof(PartyIdentification68Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification68Choice.NameAndAddress),nameof(PartyIdentification68Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification68Choice.Country),nameof(PartyIdentification68Choice.Country))]
    #endif
    [IsoId("_AUMj09okEeC60axPepSq7g_-143821104")]
    [DisplayName("Party Identification 68 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification68Choice_
    #else
    public abstract partial class PartyIdentification68Choice_
    #endif
    {
    }
}
