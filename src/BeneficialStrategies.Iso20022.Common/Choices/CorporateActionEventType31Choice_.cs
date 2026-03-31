// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType31Choice.Code))]
    [KnownType(typeof(CorporateActionEventType31Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType31Choice.Code),
        nameof(CorporateActionEventType31Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType31Choice.Proprietary),
        nameof(CorporateActionEventType31Choice.Proprietary)
    )]
    [IsoId("_lYaJ7UGLEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Event Type 31 Choice")]
    public abstract record CorporateActionEventType31Choice_ { }
}
