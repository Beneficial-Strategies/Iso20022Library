// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat25Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat25Choice.Proprietary))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat25Choice.Code), nameof(AdditionalBusinessProcessFormat25Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat25Choice.Proprietary), nameof(AdditionalBusinessProcessFormat25Choice.Proprietary))]
    [IsoId("_bWpU4aNYEfC9id413JK-Ig")]
    [DisplayName("AdditionalBusinessProcessFormat25Choice")]
    public abstract record AdditionalBusinessProcessFormat25Choice_ { }
}
