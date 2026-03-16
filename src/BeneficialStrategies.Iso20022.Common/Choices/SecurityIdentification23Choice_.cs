// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityIdentification23Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification23Choice.SEDOL))]
    [KnownType(typeof(SecurityIdentification23Choice.CUSIP))]
    [KnownType(typeof(SecurityIdentification23Choice.RIC))]
    [KnownType(typeof(SecurityIdentification23Choice.TickerSymbol))]
    [KnownType(typeof(SecurityIdentification23Choice.Bloomberg))]
    [KnownType(typeof(SecurityIdentification23Choice.CTA))]
    [KnownType(typeof(SecurityIdentification23Choice.QUICK))]
    [KnownType(typeof(SecurityIdentification23Choice.Wertpapier))]
    [KnownType(typeof(SecurityIdentification23Choice.Dutch))]
    [KnownType(typeof(SecurityIdentification23Choice.Valoren))]
    [KnownType(typeof(SecurityIdentification23Choice.Sicovam))]
    [KnownType(typeof(SecurityIdentification23Choice.Belgian))]
    [KnownType(typeof(SecurityIdentification23Choice.Common))]
    [KnownType(typeof(SecurityIdentification23Choice.OtherProprietaryIdentification))]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.ISIN),
        nameof(SecurityIdentification23Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.SEDOL),
        nameof(SecurityIdentification23Choice.SEDOL)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.CUSIP),
        nameof(SecurityIdentification23Choice.CUSIP)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.RIC),
        nameof(SecurityIdentification23Choice.RIC)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.TickerSymbol),
        nameof(SecurityIdentification23Choice.TickerSymbol)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.Bloomberg),
        nameof(SecurityIdentification23Choice.Bloomberg)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.CTA),
        nameof(SecurityIdentification23Choice.CTA)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.QUICK),
        nameof(SecurityIdentification23Choice.QUICK)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.Wertpapier),
        nameof(SecurityIdentification23Choice.Wertpapier)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.Dutch),
        nameof(SecurityIdentification23Choice.Dutch)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.Valoren),
        nameof(SecurityIdentification23Choice.Valoren)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.Sicovam),
        nameof(SecurityIdentification23Choice.Sicovam)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.Belgian),
        nameof(SecurityIdentification23Choice.Belgian)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.Common),
        nameof(SecurityIdentification23Choice.Common)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification23Choice.OtherProprietaryIdentification),
        nameof(SecurityIdentification23Choice.OtherProprietaryIdentification)
    )]
    [IsoId("_B2G4ASGQEeW7gKYhAMEFCw")]
    [DisplayName("Security Identification 23 Choice")]
    public abstract record SecurityIdentification23Choice_ { }
}
