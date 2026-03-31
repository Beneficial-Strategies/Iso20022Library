// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of corporate action options.
    /// </summary>
    [KnownType(typeof(CorporateActionOption36Choice.Code))]
    [KnownType(typeof(CorporateActionOption36Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionOption36Choice.Code),
        nameof(CorporateActionOption36Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionOption36Choice.Proprietary),
        nameof(CorporateActionOption36Choice.Proprietary)
    )]
    [IsoId("_DkeR5wVSEeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Option 36 Choice")]
    public abstract record CorporateActionOption36Choice_ { }
}
