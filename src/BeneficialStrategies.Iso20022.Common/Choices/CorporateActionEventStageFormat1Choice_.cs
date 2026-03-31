// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the event stage type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStageFormat1Choice.Code))]
    [KnownType(typeof(CorporateActionEventStageFormat1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionEventStageFormat1Choice.Code),
        nameof(CorporateActionEventStageFormat1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionEventStageFormat1Choice.Proprietary),
        nameof(CorporateActionEventStageFormat1Choice.Proprietary)
    )]
    [IsoId("_Q3dxg9p-Ed-ak6NoX_4Aeg_1469868550")]
    [DisplayName("Corporate Action Event Stage Format 1 Choice")]
    public abstract record CorporateActionEventStageFormat1Choice_ { }
}
