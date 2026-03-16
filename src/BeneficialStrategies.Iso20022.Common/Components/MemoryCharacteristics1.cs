// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of a hardware memory module.
/// </summary>
[IsoId("_V7AH8Ax0EeKa_56Jbsi1RQ")]
[DisplayName("Memory Characteristics")]
public record MemoryCharacteristics1
{
    /// <summary>
    /// Identification or name of the memory.
    /// </summary>
    [IsoId("_gEGe4Ax0EeKa_56Jbsi1RQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Total size of the memory unit.
    /// </summary>
    [IsoId("_mRenIAx0EeKa_56Jbsi1RQ")]
    [DisplayName("Total Size")]
    [IsoXmlTag("TtlSz")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber TotalSize { get; init; }

    /// <summary>
    /// Total size of the available memory.
    /// </summary>
    [IsoId("_sxTKQAx0EeKa_56Jbsi1RQ")]
    [DisplayName("Free Size")]
    [IsoXmlTag("FreeSz")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber FreeSize { get; init; }

    /// <summary>
    /// Memory unit of the sizes.
    /// </summary>
    [IsoId("_344isAx0EeKa_56Jbsi1RQ")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public required MemoryUnit1Code Unit { get; init; }
}
