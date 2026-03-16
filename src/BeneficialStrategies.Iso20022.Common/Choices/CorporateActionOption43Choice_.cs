// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption43Choice.Code))]
    [KnownType(typeof(CorporateActionOption43Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption43Choice.Code),
        nameof(CorporateActionOption43Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption43Choice.Proprietary),
        nameof(CorporateActionOption43Choice.Proprietary)
    )]
    [IsoId("_eTv3_R9QEeuFz_FaCzCLgQ")]
    [DisplayName("Corporate Action Option 43 Choice")]
    public abstract record CorporateActionOption43Choice_ { }
}
