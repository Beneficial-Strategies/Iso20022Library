// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType103Choice.Code))]
    [KnownType(typeof(CorporateActionEventType103Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType103Choice.Code),nameof(CorporateActionEventType103Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType103Choice.Proprietary),nameof(CorporateActionEventType103Choice.Proprietary))]
    [IsoId("_i6MUBR9PEeuFz_FaCzCLgQ")]
    [DisplayName("Corporate Action Event Type 103 Choice")]
    public abstract partial record CorporateActionEventType103Choice_
    {
    }
}
