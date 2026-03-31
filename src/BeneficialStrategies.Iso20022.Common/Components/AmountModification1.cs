// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to an amount.
/// </summary>
[IsoId("_hZ5eIA4qEeK3IMoVvcTkkg")]
[DisplayName("Amount Modification")]
public record AmountModification1
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_pkN0MA4qEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Amount.
    /// </summary>
    [IsoId("_tW-UIA4qEeK3IMoVvcTkkg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }
}
