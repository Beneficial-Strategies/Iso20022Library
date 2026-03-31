// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the netting eligibility information.
    /// </summary>
    [KnownType(typeof(NettingEligibility3Choice.Indicator))]
    [KnownType(typeof(NettingEligibility3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(NettingEligibility3Choice.Indicator),
        nameof(NettingEligibility3Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(NettingEligibility3Choice.Proprietary),
        nameof(NettingEligibility3Choice.Proprietary)
    )]
    [IsoId("_Aac80dokEeC60axPepSq7g_-763075890")]
    [DisplayName("Netting Eligibility 3 Choice")]
    public abstract record NettingEligibility3Choice_ { }
}
