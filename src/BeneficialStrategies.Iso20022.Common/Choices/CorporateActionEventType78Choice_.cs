// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType78Choice.Code))]
    [KnownType(typeof(CorporateActionEventType78Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType78Choice.Code),nameof(CorporateActionEventType78Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType78Choice.Proprietary),nameof(CorporateActionEventType78Choice.Proprietary))]
    [IsoId("_sklCsc3wEee5nJBZsW8MFQ")]
    [DisplayName("Corporate Action Event Type 78 Choice")]
    public abstract partial record CorporateActionEventType78Choice_
    {
    }
}
