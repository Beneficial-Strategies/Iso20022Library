// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to indicate if a corporate action event is mandatory or not.
    /// </summary>
    [KnownType(typeof(CorporateActionMandatoryVoluntary1Choice.Code))]
    [KnownType(typeof(CorporateActionMandatoryVoluntary1Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary1Choice.Code),nameof(CorporateActionMandatoryVoluntary1Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary1Choice.Proprietary),nameof(CorporateActionMandatoryVoluntary1Choice.Proprietary))]
    [IsoId("_Q4XJZ9p-Ed-ak6NoX_4Aeg_557244388")]
    [DisplayName("Corporate Action Mandatory Voluntary 1 Choice")]
    public abstract partial record CorporateActionMandatoryVoluntary1Choice_
    {
    }
}
