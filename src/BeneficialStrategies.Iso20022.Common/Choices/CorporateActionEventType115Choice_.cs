// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type115Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType115Choice.Code))]
    [KnownType(typeof(CorporateActionEventType115Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType115Choice.Code),
        nameof(CorporateActionEventType115Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType115Choice.Proprietary),
        nameof(CorporateActionEventType115Choice.Proprietary)
    )]
    [IsoId("_jhlJJ5t3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type115Choice")]
    public abstract record CorporateActionEventType115Choice_ { }
}
