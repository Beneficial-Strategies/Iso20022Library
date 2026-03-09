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
    [KnownType(typeof(PartyIdentification182Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification182Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification182Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification182Choice.TaxIdentificationNumber))]
    [KnownType(typeof(PartyIdentification182Choice.NationalRegistrationNumber))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification182Choice.AnyBIC),nameof(PartyIdentification182Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification182Choice.ProprietaryIdentification),nameof(PartyIdentification182Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification182Choice.NameAndAddress),nameof(PartyIdentification182Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification182Choice.TaxIdentificationNumber),nameof(PartyIdentification182Choice.TaxIdentificationNumber))]
    [JsonDerivedType(typeof(PartyIdentification182Choice.NationalRegistrationNumber),nameof(PartyIdentification182Choice.NationalRegistrationNumber))]
    #endif
    [IsoId("_NPY5wZTJEemqYPWMBuVawg")]
    [DisplayName("Party Identification 182 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification182Choice_
    #else
    public abstract partial class PartyIdentification182Choice_
    #endif
    {
    }
}
