// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType71Choice.Code))]
    [KnownType(typeof(CorporateActionEventType71Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType71Choice.Code),nameof(CorporateActionEventType71Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType71Choice.Proprietary),nameof(CorporateActionEventType71Choice.Proprietary))]
    [IsoId("_pAgP2ZwxEeazcsnODTksnQ")]
    [DisplayName("Corporate Action Event Type 71 Choice")]
    public abstract partial record CorporateActionEventType71Choice_
    {
    }
}
