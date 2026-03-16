// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat22Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat22Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat22Choice.Code),
        nameof(AdditionalBusinessProcessFormat22Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat22Choice.Proprietary),
        nameof(AdditionalBusinessProcessFormat22Choice.Proprietary)
    )]
    [IsoId("_p4YCtTi7Eeydid5dcNPKvg")]
    [DisplayName("Additional Business Process Format 22 Choice")]
    public abstract record AdditionalBusinessProcessFormat22Choice_ { }
}
