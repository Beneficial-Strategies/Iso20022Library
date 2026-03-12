// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the netting eligibility information.
    /// </summary>
    [KnownType(typeof(NettingEligibility4Choice.Indicator))]
    [KnownType(typeof(NettingEligibility4Choice.Proprietary))]
    [JsonDerivedType(typeof(NettingEligibility4Choice.Indicator),nameof(NettingEligibility4Choice.Indicator))]
    [JsonDerivedType(typeof(NettingEligibility4Choice.Proprietary),nameof(NettingEligibility4Choice.Proprietary))]
    [IsoId("_0h_JkTqIEeWVrPy0StzzSg")]
    [DisplayName("Netting Eligibility 4 Choice")]
    public abstract partial record NettingEligibility4Choice_
    {
    }
}
