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
    [KnownType(typeof(PartyIdentification5Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification5Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification5Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification5Choice.TaxIdentificationNumber))]
    [KnownType(typeof(PartyIdentification5Choice.NationalRegistrationNumber))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification5Choice.BICOrBEI),nameof(PartyIdentification5Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification5Choice.ProprietaryIdentification),nameof(PartyIdentification5Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification5Choice.NameAndAddress),nameof(PartyIdentification5Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification5Choice.TaxIdentificationNumber),nameof(PartyIdentification5Choice.TaxIdentificationNumber))]
    [JsonDerivedType(typeof(PartyIdentification5Choice.NationalRegistrationNumber),nameof(PartyIdentification5Choice.NationalRegistrationNumber))]
    #endif
    [IsoId("_QRLNltp-Ed-ak6NoX_4Aeg_2069121051")]
    [DisplayName("Party Identification 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification5Choice_
    #else
    public abstract partial class PartyIdentification5Choice_
    #endif
    {
    }
}
