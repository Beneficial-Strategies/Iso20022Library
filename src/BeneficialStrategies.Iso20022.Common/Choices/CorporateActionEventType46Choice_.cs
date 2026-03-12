// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType46Choice.Code))]
    [KnownType(typeof(CorporateActionEventType46Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType46Choice.Code),nameof(CorporateActionEventType46Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType46Choice.Proprietary),nameof(CorporateActionEventType46Choice.Proprietary))]
    [IsoId("_5NdmS5NLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Event Type 46 Choice")]
    public abstract partial record CorporateActionEventType46Choice_
    {
    }
}
