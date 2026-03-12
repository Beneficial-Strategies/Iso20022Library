// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType54Choice.Code))]
    [KnownType(typeof(CorporateActionEventType54Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType54Choice.Code),nameof(CorporateActionEventType54Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType54Choice.Proprietary),nameof(CorporateActionEventType54Choice.Proprietary))]
    [IsoId("_uurDlYr_EeaNFeVGetd6Xw")]
    [DisplayName("Corporate Action Event Type 54 Choice")]
    public abstract partial record CorporateActionEventType54Choice_
    {
    }
}
