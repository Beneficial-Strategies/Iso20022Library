// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Corporate Action Event Type106Choice.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType106Choice.Code))]
    [KnownType(typeof(CorporateActionEventType106Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventType106Choice.Code),
        nameof(CorporateActionEventType106Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventType106Choice.Proprietary),
        nameof(CorporateActionEventType106Choice.Proprietary)
    )]
    [IsoId("_cPG5IUm2Ee-NocYul3BKXQ")]
    [DisplayName("Corporate Action Event Type106Choice")]
    public abstract record CorporateActionEventType106Choice_ { }
}
