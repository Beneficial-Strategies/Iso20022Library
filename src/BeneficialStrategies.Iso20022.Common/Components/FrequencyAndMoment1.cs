// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines a frequency in terms a specific moment within a specified period type.
/// </summary>
[IsoId("_CWY182k3Eeanu6HLe77Rkg")]
[DisplayName("Frequency And Moment")]
public record FrequencyAndMoment1
{
    /// <summary>
    /// Period for which the number of instructions are to be created and processed.
    /// </summary>
    [IsoId("_CWY19Wk3Eeanu6HLe77Rkg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required Frequency6Code Type { get; init; }

    /// <summary>
    /// Further information on the exact point in time the event should take place.
    /// </summary>
    [IsoId("_CWY19Gk3Eeanu6HLe77Rkg")]
    [DisplayName("Point In Time")]
    [IsoXmlTag("PtInTm")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public required IsoExact2NumericText PointInTime { get; init; }
}
