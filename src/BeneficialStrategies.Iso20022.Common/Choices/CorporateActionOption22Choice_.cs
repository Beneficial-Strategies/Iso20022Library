// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption22Choice.Code))]
    [KnownType(typeof(CorporateActionOption22Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption22Choice.Code),
        nameof(CorporateActionOption22Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption22Choice.Proprietary),
        nameof(CorporateActionOption22Choice.Proprietary)
    )]
    [IsoId("_cfAHtZKQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Option 22 Choice")]
    public abstract record CorporateActionOption22Choice_ { }
}
