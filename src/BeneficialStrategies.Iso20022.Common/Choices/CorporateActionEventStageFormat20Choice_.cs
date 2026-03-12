// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the event stage type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStageFormat20Choice.Code))]
    [KnownType(typeof(CorporateActionEventStageFormat20Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat20Choice.Code),nameof(CorporateActionEventStageFormat20Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat20Choice.Proprietary),nameof(CorporateActionEventStageFormat20Choice.Proprietary))]
    [IsoId("_c5V6I5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Stage Format 20 Choice")]
    public abstract partial record CorporateActionEventStageFormat20Choice_
    {
    }
}
