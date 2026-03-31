// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat18Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat18Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat18Choice.Code),
        nameof(AdditionalBusinessProcessFormat18Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat18Choice.Proprietary),
        nameof(AdditionalBusinessProcessFormat18Choice.Proprietary)
    )]
    [IsoId("_A3Fp2xewEeyroI8qKgB7Mg")]
    [DisplayName("Additional Business Process Format 18 Choice")]
    public abstract record AdditionalBusinessProcessFormat18Choice_ { }
}
