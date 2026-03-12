// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the narrative type of corporate action.
    /// </summary>
    [KnownType(typeof(CorporateActionNarrative1Choice.Code))]
    [KnownType(typeof(CorporateActionNarrative1Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionNarrative1Choice.Code),nameof(CorporateActionNarrative1Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionNarrative1Choice.Proprietary),nameof(CorporateActionNarrative1Choice.Proprietary))]
    [IsoId("_Q10yxtp-Ed-ak6NoX_4Aeg_-1781540198")]
    [DisplayName("Corporate Action Narrative 1 Choice")]
    public abstract partial record CorporateActionNarrative1Choice_
    {
    }
}
