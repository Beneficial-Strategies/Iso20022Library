// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType32Choice.Code))]
    [KnownType(typeof(CorporateActionEventType32Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType32Choice.Code),nameof(CorporateActionEventType32Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType32Choice.Proprietary),nameof(CorporateActionEventType32Choice.Proprietary))]
    [IsoId("_bkhJkUGSEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Event Type 32 Choice")]
    public abstract partial record CorporateActionEventType32Choice_
    {
    }
}
