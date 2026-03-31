// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType86Choice.Code))]
    [KnownType(typeof(CorporateActionEventType86Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType86Choice.Code),
        nameof(CorporateActionEventType86Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType86Choice.Proprietary),
        nameof(CorporateActionEventType86Choice.Proprietary)
    )]
    [IsoId("_BZERJeXnEemEj48jhmlA0Q")]
    [DisplayName("Corporate Action Event Type 86 Choice")]
    public abstract record CorporateActionEventType86Choice_ { }
}
