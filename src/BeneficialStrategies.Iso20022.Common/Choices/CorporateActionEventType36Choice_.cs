// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType36Choice.Code))]
    [KnownType(typeof(CorporateActionEventType36Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType36Choice.Code),nameof(CorporateActionEventType36Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType36Choice.Proprietary),nameof(CorporateActionEventType36Choice.Proprietary))]
    [IsoId("_cel30ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Type 36 Choice")]
    public abstract partial record CorporateActionEventType36Choice_
    {
    }
}
