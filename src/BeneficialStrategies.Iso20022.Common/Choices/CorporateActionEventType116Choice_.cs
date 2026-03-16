// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type116Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType116Choice.Code))]
    [KnownType(typeof(CorporateActionEventType116Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType116Choice.Code),nameof(CorporateActionEventType116Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType116Choice.Proprietary),nameof(CorporateActionEventType116Choice.Proprietary))]
    [IsoId("_jub5zpt3Ee-wQIOX0djF2w")]
    [DisplayName("Corporate Action Event Type116Choice")]
    public abstract partial record CorporateActionEventType116Choice_
    {
    }
}
