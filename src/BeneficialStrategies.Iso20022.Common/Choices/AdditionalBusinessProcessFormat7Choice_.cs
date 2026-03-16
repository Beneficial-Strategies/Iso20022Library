// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat7Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat7Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat7Choice.Code),
        nameof(AdditionalBusinessProcessFormat7Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat7Choice.Proprietary),
        nameof(AdditionalBusinessProcessFormat7Choice.Proprietary)
    )]
    [IsoId("_64ajEfpNEeCLrd06h-p51g")]
    [DisplayName("Additional Business Process Format 7 Choice")]
    public abstract record AdditionalBusinessProcessFormat7Choice_ { }
}
