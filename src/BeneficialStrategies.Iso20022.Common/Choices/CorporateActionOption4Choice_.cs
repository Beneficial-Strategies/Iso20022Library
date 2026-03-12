// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of the corporate action option.
    /// </summary>
    [KnownType(typeof(CorporateActionOption4Choice.Code))]
    [KnownType(typeof(CorporateActionOption4Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionOption4Choice.Code),nameof(CorporateActionOption4Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption4Choice.Proprietary),nameof(CorporateActionOption4Choice.Proprietary))]
    [IsoId("_Q0yQ9Np-Ed-ak6NoX_4Aeg_-2121441148")]
    [DisplayName("Corporate Action Option 4 Choice")]
    public abstract partial record CorporateActionOption4Choice_
    {
    }
}
