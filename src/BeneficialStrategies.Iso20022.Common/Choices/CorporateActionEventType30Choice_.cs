// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType30Choice.Code))]
    [KnownType(typeof(CorporateActionEventType30Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType30Choice.Code),nameof(CorporateActionEventType30Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType30Choice.Proprietary),nameof(CorporateActionEventType30Choice.Proprietary))]
    [IsoId("_9_IywTqDEeWVrPy0StzzSg")]
    [DisplayName("Corporate Action Event Type 30 Choice")]
    public abstract partial record CorporateActionEventType30Choice_
    {
    }
}
