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
    [KnownType(typeof(PartyIdentification145Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification145Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification145Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification145Choice.AnyBIC),nameof(PartyIdentification145Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification145Choice.NameAndAddress),nameof(PartyIdentification145Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification145Choice.Country),nameof(PartyIdentification145Choice.Country))]
    #endif
    [IsoId("_6slou_fVEeiNZp_PtLohLw")]
    [DisplayName("Party Identification 145 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification145Choice_
    #else
    public abstract partial class PartyIdentification145Choice_
    #endif
    {
    }
}
