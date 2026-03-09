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
    /// Query based on various identification of the security.
    /// </summary>
    [KnownType(typeof(SecurityIdentificationQuery4Choice.ISIN))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.NotAvailable))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.UniqueProductIdentifier))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.Index))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.Basket))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.NotReported))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityIdentificationQuery4Choice.ISIN),nameof(SecurityIdentificationQuery4Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentificationQuery4Choice.AlternativeInstrumentIdentification),nameof(SecurityIdentificationQuery4Choice.AlternativeInstrumentIdentification))]
    [JsonDerivedType(typeof(SecurityIdentificationQuery4Choice.NotAvailable),nameof(SecurityIdentificationQuery4Choice.NotAvailable))]
    [JsonDerivedType(typeof(SecurityIdentificationQuery4Choice.UniqueProductIdentifier),nameof(SecurityIdentificationQuery4Choice.UniqueProductIdentifier))]
    [JsonDerivedType(typeof(SecurityIdentificationQuery4Choice.Index),nameof(SecurityIdentificationQuery4Choice.Index))]
    [JsonDerivedType(typeof(SecurityIdentificationQuery4Choice.Basket),nameof(SecurityIdentificationQuery4Choice.Basket))]
    [JsonDerivedType(typeof(SecurityIdentificationQuery4Choice.NotReported),nameof(SecurityIdentificationQuery4Choice.NotReported))]
    #endif
    [IsoId("_PHYIYZNeEeytjZlcgApf6A")]
    [DisplayName("Security Identification Query 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentificationQuery4Choice_
    #else
    public abstract partial class SecurityIdentificationQuery4Choice_
    #endif
    {
    }
}
