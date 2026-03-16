// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery3Choice.ISIN),
        nameof(SecurityIdentificationQuery3Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery3Choice.AlternativeInstrumentIdentification),
        nameof(SecurityIdentificationQuery3Choice.AlternativeInstrumentIdentification)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery3Choice.NotAvailable),
        nameof(SecurityIdentificationQuery3Choice.NotAvailable)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery3Choice.UniqueProductIdentifier),
        nameof(SecurityIdentificationQuery3Choice.UniqueProductIdentifier)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery3Choice.Index),
        nameof(SecurityIdentificationQuery3Choice.Index)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery3Choice.NotReported),
        nameof(SecurityIdentificationQuery3Choice.NotReported)
    )]
    [IsoId("_P1cwcdGgEeaQk737TH1Fzw")]
    [DisplayName("Security Identification Query 3 Choice")]
    public abstract record SecurityIdentificationQuery3Choice_ { }
}
