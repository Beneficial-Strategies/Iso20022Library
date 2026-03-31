// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat15Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat15Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat15Choice.Code),
        nameof(AdditionalBusinessProcessFormat15Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat15Choice.Proprietary),
        nameof(AdditionalBusinessProcessFormat15Choice.Proprietary)
    )]
    [IsoId("_0bgBkZcEEee8S7xwGG7Veg")]
    [DisplayName("Additional Business Process Format 15 Choice")]
    public abstract record AdditionalBusinessProcessFormat15Choice_ { }
}
