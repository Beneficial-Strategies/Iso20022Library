// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType35Choice.Code))]
    [KnownType(typeof(CorporateActionEventType35Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType35Choice.Code),nameof(CorporateActionEventType35Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType35Choice.Proprietary),nameof(CorporateActionEventType35Choice.Proprietary))]
    [IsoId("_cdRB8ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Type 35 Choice")]
    public abstract partial record CorporateActionEventType35Choice_
    {
    }
}
