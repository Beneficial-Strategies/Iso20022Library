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
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification198Choice.NationalRegistrationNumber))]
    [KnownType(typeof(PartyIdentification198Choice.LEI))]
    [KnownType(typeof(PartyIdentification198Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification198Choice.ClientIdentification))]
    [KnownType(typeof(PartyIdentification198Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification198Choice.NationalRegistrationNumber),nameof(PartyIdentification198Choice.NationalRegistrationNumber))]
    [JsonDerivedType(typeof(PartyIdentification198Choice.LEI),nameof(PartyIdentification198Choice.LEI))]
    [JsonDerivedType(typeof(PartyIdentification198Choice.AnyBIC),nameof(PartyIdentification198Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification198Choice.ClientIdentification),nameof(PartyIdentification198Choice.ClientIdentification))]
    [JsonDerivedType(typeof(PartyIdentification198Choice.ProprietaryIdentification),nameof(PartyIdentification198Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_vHuP0DtpEemIf7eyjCwinw")]
    [DisplayName("Party Identification 198 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification198Choice_
    #else
    public abstract partial class PartyIdentification198Choice_
    #endif
    {
    }
}
