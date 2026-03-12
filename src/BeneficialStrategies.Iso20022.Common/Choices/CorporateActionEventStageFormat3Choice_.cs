// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the event stage type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStageFormat3Choice.Code))]
    [KnownType(typeof(CorporateActionEventStageFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat3Choice.Code),nameof(CorporateActionEventStageFormat3Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStageFormat3Choice.Proprietary),nameof(CorporateActionEventStageFormat3Choice.Proprietary))]
    [IsoId("_Dw-HQeHPEd-1Ktb5rVaajw")]
    [DisplayName("Corporate Action Event Stage Format 3 Choice")]
    public abstract partial record CorporateActionEventStageFormat3Choice_
    {
    }
}
