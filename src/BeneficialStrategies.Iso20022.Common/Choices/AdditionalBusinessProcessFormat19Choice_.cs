// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat19Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat19Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat19Choice.Code),
        nameof(AdditionalBusinessProcessFormat19Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat19Choice.Proprietary),
        nameof(AdditionalBusinessProcessFormat19Choice.Proprietary)
    )]
    [IsoId("_Z5Hj9RewEeyroI8qKgB7Mg")]
    [DisplayName("Additional Business Process Format 19 Choice")]
    public abstract record AdditionalBusinessProcessFormat19Choice_ { }
}
