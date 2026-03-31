// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType74Choice.Code))]
    [KnownType(typeof(CorporateActionEventType74Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType74Choice.Code),
        nameof(CorporateActionEventType74Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType74Choice.Proprietary),
        nameof(CorporateActionEventType74Choice.Proprietary)
    )]
    [IsoId("_HU3Tc5SfEeeh5JjedkaA_g")]
    [DisplayName("Corporate Action Event Type 74 Choice")]
    public abstract record CorporateActionEventType74Choice_ { }
}
