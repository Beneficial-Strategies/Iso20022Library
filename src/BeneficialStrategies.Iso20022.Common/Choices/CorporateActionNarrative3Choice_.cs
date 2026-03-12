// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the narrative type of corporate action.
    /// </summary>
    [KnownType(typeof(CorporateActionNarrative3Choice.Code))]
    [KnownType(typeof(CorporateActionNarrative3Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionNarrative3Choice.Code),nameof(CorporateActionNarrative3Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionNarrative3Choice.Proprietary),nameof(CorporateActionNarrative3Choice.Proprietary))]
    [IsoId("_7s0bd0GVEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Narrative 3 Choice")]
    public abstract partial record CorporateActionNarrative3Choice_
    {
    }
}
