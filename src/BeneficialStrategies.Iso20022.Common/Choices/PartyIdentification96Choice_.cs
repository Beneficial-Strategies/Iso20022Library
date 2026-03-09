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
    /// Choice of formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification96Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification96Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification96Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification96Choice.TaxIdentificationNumber))]
    [KnownType(typeof(PartyIdentification96Choice.NationalRegistrationNumber))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification96Choice.AnyBIC),nameof(PartyIdentification96Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification96Choice.ProprietaryIdentification),nameof(PartyIdentification96Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification96Choice.NameAndAddress),nameof(PartyIdentification96Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification96Choice.TaxIdentificationNumber),nameof(PartyIdentification96Choice.TaxIdentificationNumber))]
    [JsonDerivedType(typeof(PartyIdentification96Choice.NationalRegistrationNumber),nameof(PartyIdentification96Choice.NationalRegistrationNumber))]
    #endif
    [IsoId("_vsuhsSGYEeWKAaDJcYGKLw")]
    [DisplayName("Party Identification 96 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification96Choice_
    #else
    public abstract partial class PartyIdentification96Choice_
    #endif
    {
    }
}
