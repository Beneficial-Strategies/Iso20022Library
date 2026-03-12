// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption42Choice.Code))]
    [KnownType(typeof(CorporateActionOption42Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionOption42Choice.Code),nameof(CorporateActionOption42Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption42Choice.Proprietary),nameof(CorporateActionOption42Choice.Proprietary))]
    [IsoId("_BHW2aR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Corporate Action Option 42 Choice")]
    public abstract partial record CorporateActionOption42Choice_
    {
    }
}
