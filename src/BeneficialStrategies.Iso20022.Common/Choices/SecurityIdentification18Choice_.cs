// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification18Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification18Choice.AlternativeInstrumentIdentification))]
    [JsonDerivedType(
        typeof(SecurityIdentification18Choice.ISIN),
        nameof(SecurityIdentification18Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification18Choice.AlternativeInstrumentIdentification),
        nameof(SecurityIdentification18Choice.AlternativeInstrumentIdentification)
    )]
    [IsoId("_b9RfIQOJEeWs3sTa9Sj6Lg")]
    [DisplayName("Security Identification 18 Choice")]
    public abstract record SecurityIdentification18Choice_ { }
}
