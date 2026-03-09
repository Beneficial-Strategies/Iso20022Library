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
    [KnownType(typeof(PartyIdentification102Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification102Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification102Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification102Choice.AnyBIC),nameof(PartyIdentification102Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification102Choice.NameAndAddress),nameof(PartyIdentification102Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification102Choice.Country),nameof(PartyIdentification102Choice.Country))]
    #endif
    [IsoId("_JIXkAYbCEeWguotXa4lFgg")]
    [DisplayName("Party Identification 102 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification102Choice_
    #else
    public abstract partial class PartyIdentification102Choice_
    #endif
    {
    }
}
