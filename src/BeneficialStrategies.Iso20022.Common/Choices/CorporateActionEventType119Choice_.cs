// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type119Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType119Choice.Code))]
    [KnownType(typeof(CorporateActionEventType119Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType119Choice.Code),
        nameof(CorporateActionEventType119Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType119Choice.Proprietary),
        nameof(CorporateActionEventType119Choice.Proprietary)
    )]
    [IsoId("_kV145Zt3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type119Choice")]
    public abstract record CorporateActionEventType119Choice_ { }
}
