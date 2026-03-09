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
    [KnownType(typeof(PartyIdentification37Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification37Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification37Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification37Choice.Country))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification37Choice.AnyBIC),nameof(PartyIdentification37Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification37Choice.ProprietaryIdentification),nameof(PartyIdentification37Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification37Choice.NameAndAddress),nameof(PartyIdentification37Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification37Choice.Country),nameof(PartyIdentification37Choice.Country))]
    #endif
    [IsoId("_7H6pweaPEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 37 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification37Choice_
    #else
    public abstract partial class PartyIdentification37Choice_
    #endif
    {
    }
}
