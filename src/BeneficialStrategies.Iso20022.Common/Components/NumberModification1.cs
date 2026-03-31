// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to a number.
/// </summary>
[IsoId("_WtsIMA4sEeK3IMoVvcTkkg")]
[DisplayName("Number Modification")]
public record NumberModification1
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_d6Tf4A4sEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Number.
    /// </summary>
    [IsoId("_gko_MA4sEeK3IMoVvcTkkg")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public required IsoMax5NumericText Number { get; init; }
}
