// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType83Choice.Code))]
    [KnownType(typeof(CorporateActionEventType83Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType83Choice.Code),nameof(CorporateActionEventType83Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType83Choice.Proprietary),nameof(CorporateActionEventType83Choice.Proprietary))]
    [IsoId("_SKMi783yEee5nJBZsW8MFQ")]
    [DisplayName("Corporate Action Event Type 83 Choice")]
    public abstract partial record CorporateActionEventType83Choice_
    {
    }
}
