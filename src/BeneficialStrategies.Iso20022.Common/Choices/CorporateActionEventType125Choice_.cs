// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType125Choice.Code))]
    [KnownType(typeof(CorporateActionEventType125Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType125Choice.Code), nameof(CorporateActionEventType125Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType125Choice.Proprietary), nameof(CorporateActionEventType125Choice.Proprietary))]
    [IsoId("_zrf3Id_MEe-Ned3-G07x_A")]
    [DisplayName("Corporate Action Event Type 125 Choice")]
    public abstract record CorporateActionEventType125Choice_ { }
}
