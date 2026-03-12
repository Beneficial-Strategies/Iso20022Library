// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType102Choice.Code))]
    [KnownType(typeof(CorporateActionEventType102Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType102Choice.Code),nameof(CorporateActionEventType102Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType102Choice.Proprietary),nameof(CorporateActionEventType102Choice.Proprietary))]
    [IsoId("_aMljRe5-Eeqc-LCjwLsUVg")]
    [DisplayName("Corporate Action Event Type 102 Choice")]
    public abstract partial record CorporateActionEventType102Choice_
    {
    }
}
