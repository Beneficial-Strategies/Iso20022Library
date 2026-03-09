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
    [KnownType(typeof(PartyIdentification39Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification39Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification39Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification39Choice.AnyBIC),nameof(PartyIdentification39Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification39Choice.NameAndAddress),nameof(PartyIdentification39Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification39Choice.Country),nameof(PartyIdentification39Choice.Country))]
    #endif
    [IsoId("_1Y13MfL9Ed-3lpUMQaXLjQ")]
    [DisplayName("Party Identification 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification39Choice_
    #else
    public abstract partial class PartyIdentification39Choice_
    #endif
    {
    }
}
