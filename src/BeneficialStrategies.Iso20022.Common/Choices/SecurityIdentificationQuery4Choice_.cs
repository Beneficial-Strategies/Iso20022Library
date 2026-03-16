// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery4Choice.ISIN),
        nameof(SecurityIdentificationQuery4Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery4Choice.AlternativeInstrumentIdentification),
        nameof(SecurityIdentificationQuery4Choice.AlternativeInstrumentIdentification)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery4Choice.NotAvailable),
        nameof(SecurityIdentificationQuery4Choice.NotAvailable)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery4Choice.UniqueProductIdentifier),
        nameof(SecurityIdentificationQuery4Choice.UniqueProductIdentifier)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery4Choice.Index),
        nameof(SecurityIdentificationQuery4Choice.Index)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery4Choice.Basket),
        nameof(SecurityIdentificationQuery4Choice.Basket)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentificationQuery4Choice.NotReported),
        nameof(SecurityIdentificationQuery4Choice.NotReported)
    )]
    [IsoId("_PHYIYZNeEeytjZlcgApf6A")]
    [DisplayName("Security Identification Query 4 Choice")]
    public abstract record SecurityIdentificationQuery4Choice_ { }
}
