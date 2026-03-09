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
    /// Choice between formats for the identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityIdentification22Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification22Choice.AlternateIdentification))]
    [KnownType(typeof(SecurityIdentification22Choice.RIC))]
    [KnownType(typeof(SecurityIdentification22Choice.TickerSymbol))]
    [KnownType(typeof(SecurityIdentification22Choice.Bloomberg))]
    [KnownType(typeof(SecurityIdentification22Choice.CTA))]
    [KnownType(typeof(SecurityIdentification22Choice.Common))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityIdentification22Choice.ISIN),nameof(SecurityIdentification22Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification22Choice.AlternateIdentification),nameof(SecurityIdentification22Choice.AlternateIdentification))]
    [JsonDerivedType(typeof(SecurityIdentification22Choice.RIC),nameof(SecurityIdentification22Choice.RIC))]
    [JsonDerivedType(typeof(SecurityIdentification22Choice.TickerSymbol),nameof(SecurityIdentification22Choice.TickerSymbol))]
    [JsonDerivedType(typeof(SecurityIdentification22Choice.Bloomberg),nameof(SecurityIdentification22Choice.Bloomberg))]
    [JsonDerivedType(typeof(SecurityIdentification22Choice.CTA),nameof(SecurityIdentification22Choice.CTA))]
    [JsonDerivedType(typeof(SecurityIdentification22Choice.Common),nameof(SecurityIdentification22Choice.Common))]
    #endif
    [IsoId("_BibBIVhxEeWDI58xzGOTTQ")]
    [DisplayName("Security Identification 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification22Choice_
    #else
    public abstract partial class SecurityIdentification22Choice_
    #endif
    {
    }
}
