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
    /// Unique and unambiguous way to identify an organisation using a choice between a BIC or the name and addres or the country code.
    /// </summary>
    [KnownType(typeof(PartyIdentification239Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification239Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification239Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification239Choice.AnyBIC),nameof(PartyIdentification239Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification239Choice.NameAndAddress),nameof(PartyIdentification239Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification239Choice.Country),nameof(PartyIdentification239Choice.Country))]
    #endif
    [IsoId("_dT1SEStKEeyOa655cLd-DQ")]
    [DisplayName("Party Identification 239 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification239Choice_
    #else
    public abstract partial class PartyIdentification239Choice_
    #endif
    {
    }
}
