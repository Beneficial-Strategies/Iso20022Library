// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption5Choice.Code))]
    [KnownType(typeof(CorporateActionOption5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption5Choice.Code),
        nameof(CorporateActionOption5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption5Choice.Proprietary),
        nameof(CorporateActionOption5Choice.Proprietary)
    )]
    [IsoId("_Q0CqEtp-Ed-ak6NoX_4Aeg_-289326808")]
    [DisplayName("Corporate Action Option 5 Choice")]
    public abstract record CorporateActionOption5Choice_ { }
}
