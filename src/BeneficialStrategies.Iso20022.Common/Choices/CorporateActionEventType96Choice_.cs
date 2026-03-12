// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType96Choice.Code))]
    [KnownType(typeof(CorporateActionEventType96Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType96Choice.Code),nameof(CorporateActionEventType96Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType96Choice.Proprietary),nameof(CorporateActionEventType96Choice.Proprietary))]
    [IsoId("_-lkSYgVSEeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Event Type 96 Choice")]
    public abstract partial record CorporateActionEventType96Choice_
    {
    }
}
