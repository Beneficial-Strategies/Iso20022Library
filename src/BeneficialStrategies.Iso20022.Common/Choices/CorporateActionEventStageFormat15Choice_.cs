// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the event stage type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStageFormat15Choice.Code))]
    [KnownType(typeof(CorporateActionEventStageFormat15Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat15Choice.Code),nameof(CorporateActionEventStageFormat15Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat15Choice.Proprietary),nameof(CorporateActionEventStageFormat15Choice.Proprietary))]
    [IsoId("_cdS3XZKQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Stage Format 15 Choice")]
    public abstract partial record CorporateActionEventStageFormat15Choice_
    {
    }
}
