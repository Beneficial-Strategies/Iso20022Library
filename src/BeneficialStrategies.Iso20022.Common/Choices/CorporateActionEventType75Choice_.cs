// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType75Choice.Code))]
    [KnownType(typeof(CorporateActionEventType75Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType75Choice.Code),nameof(CorporateActionEventType75Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType75Choice.Proprietary),nameof(CorporateActionEventType75Choice.Proprietary))]
    [IsoId("_b3m-xZSfEeeh5JjedkaA_g")]
    [DisplayName("Corporate Action Event Type 75 Choice")]
    public abstract partial record CorporateActionEventType75Choice_
    {
    }
}
