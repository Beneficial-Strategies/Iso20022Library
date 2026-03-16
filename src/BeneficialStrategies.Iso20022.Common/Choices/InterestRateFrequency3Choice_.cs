// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Describes frequency of payments for interest rates, either using term notation or a proprietary notation.
    /// </summary>
    [KnownType(typeof(InterestRateFrequency3Choice.Term))]
    [KnownType(typeof(InterestRateFrequency3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InterestRateFrequency3Choice.Term),
        nameof(InterestRateFrequency3Choice.Term)
    )]
    [JsonDerivedType(
        typeof(InterestRateFrequency3Choice.Proprietary),
        nameof(InterestRateFrequency3Choice.Proprietary)
    )]
    [IsoId("_61uTH1fREeqqKf65rDYWYw")]
    [DisplayName("Interest Rate Frequency 3 Choice")]
    public abstract record InterestRateFrequency3Choice_ { }
}
