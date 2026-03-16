// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(
        typeof(SecurityIdentification22Choice.ISIN),
        nameof(SecurityIdentification22Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification22Choice.AlternateIdentification),
        nameof(SecurityIdentification22Choice.AlternateIdentification)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification22Choice.RIC),
        nameof(SecurityIdentification22Choice.RIC)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification22Choice.TickerSymbol),
        nameof(SecurityIdentification22Choice.TickerSymbol)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification22Choice.Bloomberg),
        nameof(SecurityIdentification22Choice.Bloomberg)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification22Choice.CTA),
        nameof(SecurityIdentification22Choice.CTA)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification22Choice.Common),
        nameof(SecurityIdentification22Choice.Common)
    )]
    [IsoId("_BibBIVhxEeWDI58xzGOTTQ")]
    [DisplayName("Security Identification 22 Choice")]
    public abstract record SecurityIdentification22Choice_ { }
}
