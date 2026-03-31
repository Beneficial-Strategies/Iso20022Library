// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the beneficial ownership.
    /// </summary>
    [KnownType(typeof(BeneficialOwnership4Choice.Indicator))]
    [KnownType(typeof(BeneficialOwnership4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BeneficialOwnership4Choice.Indicator),
        nameof(BeneficialOwnership4Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(BeneficialOwnership4Choice.Proprietary),
        nameof(BeneficialOwnership4Choice.Proprietary)
    )]
    [IsoId("_TaICwTqGEeWVrPy0StzzSg")]
    [DisplayName("Beneficial Ownership 4 Choice")]
    public abstract record BeneficialOwnership4Choice_ { }
}
