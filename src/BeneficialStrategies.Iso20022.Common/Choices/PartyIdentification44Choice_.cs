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
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification44Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification44Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification44Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification44Choice.AnyBIC),nameof(PartyIdentification44Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification44Choice.NameAndAddress),nameof(PartyIdentification44Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification44Choice.Country),nameof(PartyIdentification44Choice.Country))]
    #endif
    [IsoId("_Rpl8aeaPEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification44Choice_
    #else
    public abstract partial class PartyIdentification44Choice_
    #endif
    {
    }
}
