// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType101Choice.Code))]
    [KnownType(typeof(CorporateActionEventType101Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType101Choice.Code),
        nameof(CorporateActionEventType101Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType101Choice.Proprietary),
        nameof(CorporateActionEventType101Choice.Proprietary)
    )]
    [IsoId("__66qYQVUEeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Event Type 101 Choice")]
    public abstract record CorporateActionEventType101Choice_ { }
}
