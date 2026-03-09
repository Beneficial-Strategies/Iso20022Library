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
    [KnownType(typeof(SecurityIdentificationQuery3Choice.ISIN))]
    [KnownType(typeof(SecurityIdentificationQuery3Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(SecurityIdentificationQuery3Choice.NotAvailable))]
    [KnownType(typeof(SecurityIdentificationQuery3Choice.UniqueProductIdentifier))]
    [KnownType(typeof(SecurityIdentificationQuery3Choice.Index))]
    [KnownType(typeof(SecurityIdentificationQuery3Choice.NotReported))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityIdentificationQuery3Choice.ISIN),nameof(SecurityIdentificationQuery3Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentificationQuery3Choice.AlternativeInstrumentIdentification),nameof(SecurityIdentificationQuery3Choice.AlternativeInstrumentIdentification))]
    [JsonDerivedType(typeof(SecurityIdentificationQuery3Choice.NotAvailable),nameof(SecurityIdentificationQuery3Choice.NotAvailable))]
    [JsonDerivedType(typeof(SecurityIdentificationQuery3Choice.UniqueProductIdentifier),nameof(SecurityIdentificationQuery3Choice.UniqueProductIdentifier))]
    [JsonDerivedType(typeof(SecurityIdentificationQuery3Choice.Index),nameof(SecurityIdentificationQuery3Choice.Index))]
    [JsonDerivedType(typeof(SecurityIdentificationQuery3Choice.NotReported),nameof(SecurityIdentificationQuery3Choice.NotReported))]
    #endif
    [IsoId("_P1cwcdGgEeaQk737TH1Fzw")]
    [DisplayName("Security Identification Query 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentificationQuery3Choice_
    #else
    public abstract partial class SecurityIdentificationQuery3Choice_
    #endif
    {
    }
}
