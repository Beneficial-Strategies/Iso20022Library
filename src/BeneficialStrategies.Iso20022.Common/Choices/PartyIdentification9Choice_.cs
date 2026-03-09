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
    [KnownType(typeof(PartyIdentification9Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification9Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification9Choice.NameAndAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyIdentification9Choice.BICOrBEI),nameof(PartyIdentification9Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification9Choice.ProprietaryIdentification),nameof(PartyIdentification9Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification9Choice.NameAndAddress),nameof(PartyIdentification9Choice.NameAndAddress))]
    #endif
    [IsoId("_QRUXhtp-Ed-ak6NoX_4Aeg_967984948")]
    [DisplayName("Party Identification 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification9Choice_
    #else
    public abstract partial class PartyIdentification9Choice_
    #endif
    {
    }
}
