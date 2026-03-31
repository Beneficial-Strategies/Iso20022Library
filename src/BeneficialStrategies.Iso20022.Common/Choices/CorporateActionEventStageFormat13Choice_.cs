// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the event stage type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStageFormat13Choice.Code))]
    [KnownType(typeof(CorporateActionEventStageFormat13Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventStageFormat13Choice.Code),
        nameof(CorporateActionEventStageFormat13Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventStageFormat13Choice.Proprietary),
        nameof(CorporateActionEventStageFormat13Choice.Proprietary)
    )]
    [IsoId("_AEMGsUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Corporate Action Event Stage Format 13 Choice")]
    public abstract record CorporateActionEventStageFormat13Choice_ { }
}
