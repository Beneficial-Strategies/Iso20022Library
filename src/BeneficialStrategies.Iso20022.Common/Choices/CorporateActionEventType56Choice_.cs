// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType56Choice.Code))]
    [KnownType(typeof(CorporateActionEventType56Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType56Choice.Code),
        nameof(CorporateActionEventType56Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType56Choice.Proprietary),
        nameof(CorporateActionEventType56Choice.Proprietary)
    )]
    [IsoId("_bDWGoZeUEeac76MbGuhitQ")]
    [DisplayName("Corporate Action Event Type 56 Choice")]
    public abstract record CorporateActionEventType56Choice_ { }
}
