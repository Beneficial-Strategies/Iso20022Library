// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines a frequency in terms on counts per period for a specific period type.
/// </summary>
[IsoId("_B0q0IR7zEeSxevWRRWxNAg")]
[DisplayName("Frequency Period")]
public record FrequencyPeriod1
{
    /// <summary>
    /// Period for which the number of instructions are to be created and processed.
    /// </summary>
    [IsoId("_1bz5sB71EeSxevWRRWxNAg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required Frequency6Code Type { get; init; }

    /// <summary>
    /// Number of instructions to be created and processed during the specified period.
    /// </summary>
    [IsoId("_OPlVUB72EeSxevWRRWxNAg")]
    [DisplayName("Count Per Period")]
    [IsoXmlTag("CntPerPrd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber CountPerPeriod { get; init; }
}
