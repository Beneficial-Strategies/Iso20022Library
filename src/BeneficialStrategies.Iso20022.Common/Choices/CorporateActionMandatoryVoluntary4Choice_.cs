// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to indicate if a corporate action event is mandatory or not.
    /// </summary>
    [KnownType(typeof(CorporateActionMandatoryVoluntary4Choice.Code))]
    [KnownType(typeof(CorporateActionMandatoryVoluntary4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionMandatoryVoluntary4Choice.Code),
        nameof(CorporateActionMandatoryVoluntary4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionMandatoryVoluntary4Choice.Proprietary),
        nameof(CorporateActionMandatoryVoluntary4Choice.Proprietary)
    )]
    [IsoId("_cdRCF5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Mandatory Voluntary 4 Choice")]
    public abstract record CorporateActionMandatoryVoluntary4Choice_ { }
}
