// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat14Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat14Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat14Choice.Code),
        nameof(AdditionalBusinessProcessFormat14Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat14Choice.Proprietary),
        nameof(AdditionalBusinessProcessFormat14Choice.Proprietary)
    )]
    [IsoId("_979uqZqZEeWNO_b7eN4F_w")]
    [DisplayName("Additional Business Process Format 14 Choice")]
    public abstract record AdditionalBusinessProcessFormat14Choice_ { }
}
