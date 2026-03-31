// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption31Choice.Code))]
    [KnownType(typeof(CorporateActionOption31Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption31Choice.Code),
        nameof(CorporateActionOption31Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption31Choice.Proprietary),
        nameof(CorporateActionOption31Choice.Proprietary)
    )]
    [IsoId("_4gre7earEemtTOaHuc_63w")]
    [DisplayName("Corporate Action Option 31 Choice")]
    public abstract record CorporateActionOption31Choice_ { }
}
