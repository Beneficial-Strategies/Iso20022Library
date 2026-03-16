// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType53Choice.Code))]
    [KnownType(typeof(CorporateActionEventType53Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType53Choice.Code),
        nameof(CorporateActionEventType53Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType53Choice.Proprietary),
        nameof(CorporateActionEventType53Choice.Proprietary)
    )]
    [IsoId("_a4eKo4r-EeaNFeVGetd6Xw")]
    [DisplayName("Corporate Action Event Type 53 Choice")]
    public abstract record CorporateActionEventType53Choice_ { }
}
