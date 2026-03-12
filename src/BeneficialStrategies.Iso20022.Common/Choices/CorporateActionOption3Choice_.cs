// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code.
    /// </summary>
    [KnownType(typeof(CorporateActionOption3Choice.Code))]
    [KnownType(typeof(CorporateActionOption3Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionOption3Choice.Code),nameof(CorporateActionOption3Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption3Choice.Proprietary),nameof(CorporateActionOption3Choice.Proprietary))]
    [IsoId("_Q1FL59p-Ed-ak6NoX_4Aeg_882016043")]
    [DisplayName("Corporate Action Option 3 Choice")]
    public abstract partial record CorporateActionOption3Choice_
    {
    }
}
