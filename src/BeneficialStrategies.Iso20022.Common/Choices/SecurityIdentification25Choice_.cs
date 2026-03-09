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
    /// Choice of formats for the identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityIdentification25Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification25Choice.SEDOL))]
    [KnownType(typeof(SecurityIdentification25Choice.CUSIP))]
    [KnownType(typeof(SecurityIdentification25Choice.RIC))]
    [KnownType(typeof(SecurityIdentification25Choice.TickerSymbol))]
    [KnownType(typeof(SecurityIdentification25Choice.Bloomberg))]
    [KnownType(typeof(SecurityIdentification25Choice.CTA))]
    [KnownType(typeof(SecurityIdentification25Choice.QUICK))]
    [KnownType(typeof(SecurityIdentification25Choice.Wertpapier))]
    [KnownType(typeof(SecurityIdentification25Choice.Dutch))]
    [KnownType(typeof(SecurityIdentification25Choice.Valoren))]
    [KnownType(typeof(SecurityIdentification25Choice.Sicovam))]
    [KnownType(typeof(SecurityIdentification25Choice.Belgian))]
    [KnownType(typeof(SecurityIdentification25Choice.Common))]
    [KnownType(typeof(SecurityIdentification25Choice.OtherProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecurityIdentification25Choice.ISIN),nameof(SecurityIdentification25Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.SEDOL),nameof(SecurityIdentification25Choice.SEDOL))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.CUSIP),nameof(SecurityIdentification25Choice.CUSIP))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.RIC),nameof(SecurityIdentification25Choice.RIC))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.TickerSymbol),nameof(SecurityIdentification25Choice.TickerSymbol))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.Bloomberg),nameof(SecurityIdentification25Choice.Bloomberg))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.CTA),nameof(SecurityIdentification25Choice.CTA))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.QUICK),nameof(SecurityIdentification25Choice.QUICK))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.Wertpapier),nameof(SecurityIdentification25Choice.Wertpapier))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.Dutch),nameof(SecurityIdentification25Choice.Dutch))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.Valoren),nameof(SecurityIdentification25Choice.Valoren))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.Sicovam),nameof(SecurityIdentification25Choice.Sicovam))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.Belgian),nameof(SecurityIdentification25Choice.Belgian))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.Common),nameof(SecurityIdentification25Choice.Common))]
    [JsonDerivedType(typeof(SecurityIdentification25Choice.OtherProprietaryIdentification),nameof(SecurityIdentification25Choice.OtherProprietaryIdentification))]
    #endif
    [IsoId("_buiiIDnxEeabspMEjqY5TQ")]
    [DisplayName("Security Identification 25 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification25Choice_
    #else
    public abstract partial class SecurityIdentification25Choice_
    #endif
    {
    }
}
