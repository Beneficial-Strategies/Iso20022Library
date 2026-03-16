// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType88Choice.Code))]
    [KnownType(typeof(CorporateActionEventType88Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType88Choice.Code),
        nameof(CorporateActionEventType88Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType88Choice.Proprietary),
        nameof(CorporateActionEventType88Choice.Proprietary)
    )]
    [IsoId("_ZffRYemrEemUgrefIx730g")]
    [DisplayName("Corporate Action Event Type 88 Choice")]
    public abstract record CorporateActionEventType88Choice_ { }
}
