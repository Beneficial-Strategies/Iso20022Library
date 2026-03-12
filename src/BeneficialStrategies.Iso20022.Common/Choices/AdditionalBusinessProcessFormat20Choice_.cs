// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat20Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat20Choice.Proprietary))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat20Choice.Code),nameof(AdditionalBusinessProcessFormat20Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat20Choice.Proprietary),nameof(AdditionalBusinessProcessFormat20Choice.Proprietary))]
    [IsoId("_plRhEzi7Eeydid5dcNPKvg")]
    [DisplayName("Additional Business Process Format 20 Choice")]
    public abstract partial record AdditionalBusinessProcessFormat20Choice_
    {
    }
}
