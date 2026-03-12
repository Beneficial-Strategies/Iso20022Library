// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to indicate if a corporate action event is mandatory or not.
    /// </summary>
    [KnownType(typeof(CorporateActionMandatoryVoluntary3Choice.Code))]
    [KnownType(typeof(CorporateActionMandatoryVoluntary3Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary3Choice.Code),nameof(CorporateActionMandatoryVoluntary3Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary3Choice.Proprietary),nameof(CorporateActionMandatoryVoluntary3Choice.Proprietary))]
    [IsoId("_e9j1tzndEeWLJsP1cO-amg")]
    [DisplayName("Corporate Action Mandatory Voluntary 3 Choice")]
    public abstract partial record CorporateActionMandatoryVoluntary3Choice_
    {
    }
}
