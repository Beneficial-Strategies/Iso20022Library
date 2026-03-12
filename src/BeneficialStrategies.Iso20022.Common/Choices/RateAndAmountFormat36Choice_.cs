// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between rate and amount.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat36Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat36Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat36Choice.Rate),nameof(RateAndAmountFormat36Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat36Choice.Amount),nameof(RateAndAmountFormat36Choice.Amount))]
    [IsoId("_UZkV4XaCEeOzT_JN45r5OQ")]
    [DisplayName("Rate And Amount Format 36 Choice")]
    public abstract partial record RateAndAmountFormat36Choice_
    {
    }
}
