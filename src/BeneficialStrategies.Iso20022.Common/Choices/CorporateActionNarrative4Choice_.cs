// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the narrative type of corporate action.
    /// </summary>
    [KnownType(typeof(CorporateActionNarrative4Choice.Code))]
    [KnownType(typeof(CorporateActionNarrative4Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionNarrative4Choice.Code),nameof(CorporateActionNarrative4Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionNarrative4Choice.Proprietary),nameof(CorporateActionNarrative4Choice.Proprietary))]
    [IsoId("_c4cih5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Narrative 4 Choice")]
    public abstract partial record CorporateActionNarrative4Choice_
    {
    }
}
