// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat3Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat3Choice.Code),
        nameof(AdditionalBusinessProcessFormat3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat3Choice.Proprietary),
        nameof(AdditionalBusinessProcessFormat3Choice.Proprietary)
    )]
    [IsoId("_Q10yw9p-Ed-ak6NoX_4Aeg_861159193")]
    [DisplayName("Additional Business Process Format 3 Choice")]
    public abstract record AdditionalBusinessProcessFormat3Choice_ { }
}
