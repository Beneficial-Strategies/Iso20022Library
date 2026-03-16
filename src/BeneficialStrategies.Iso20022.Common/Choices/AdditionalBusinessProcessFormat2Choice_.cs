// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat2Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat2Choice.Code),
        nameof(AdditionalBusinessProcessFormat2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat2Choice.Proprietary),
        nameof(AdditionalBusinessProcessFormat2Choice.Proprietary)
    )]
    [IsoId("_Q4XJZNp-Ed-ak6NoX_4Aeg_-329682049")]
    [DisplayName("Additional Business Process Format 2 Choice")]
    public abstract record AdditionalBusinessProcessFormat2Choice_ { }
}
