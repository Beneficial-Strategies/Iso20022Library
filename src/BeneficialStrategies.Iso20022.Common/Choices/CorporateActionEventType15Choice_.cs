// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType15Choice.Code))]
    [KnownType(typeof(CorporateActionEventType15Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventType15Choice.Code),nameof(CorporateActionEventType15Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType15Choice.Proprietary),nameof(CorporateActionEventType15Choice.Proprietary))]
    [IsoId("_6aV0YRG6EeKHC-9MYSJwtQ")]
    [DisplayName("Corporate Action Event Type 15 Choice")]
    public abstract partial record CorporateActionEventType15Choice_
    {
    }
}
