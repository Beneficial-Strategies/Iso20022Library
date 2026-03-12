// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType51Choice.Code))]
    [KnownType(typeof(CorporateActionEventType51Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType51Choice.Code),nameof(CorporateActionEventType51Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType51Choice.Proprietary),nameof(CorporateActionEventType51Choice.Proprietary))]
    [IsoId("_6qNRAYruEeaNFeVGetd6Xw")]
    [DisplayName("Corporate Action Event Type 51 Choice")]
    public abstract partial record CorporateActionEventType51Choice_
    {
    }
}
