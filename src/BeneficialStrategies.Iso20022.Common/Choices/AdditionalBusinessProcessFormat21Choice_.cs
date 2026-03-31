// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat21Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat21Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat21Choice.Code),
        nameof(AdditionalBusinessProcessFormat21Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat21Choice.Proprietary),
        nameof(AdditionalBusinessProcessFormat21Choice.Proprietary)
    )]
    [IsoId("_ptGmlzi7Eeydid5dcNPKvg")]
    [DisplayName("Additional Business Process Format 21 Choice")]
    public abstract record AdditionalBusinessProcessFormat21Choice_ { }
}
