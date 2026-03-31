// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Resulting debit or credit amount of the netted amounts for all debit and credit entries.
/// </summary>
[IsoId("_mK6yUSmjEeKdFJmzhTDOvQ")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection35
{
    /// <summary>
    /// Resulting amount of the netted amounts for all debit and credit entries.
    /// </summary>
    [IsoId("_mgrm8SmjEeKdFJmzhTDOvQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    [IsoSimpleType(IsoSimpleType.NonNegativeDecimalNumber)]
    public required IsoNonNegativeDecimalNumber Amount { get; init; }

    /// <summary>
    /// Indicates whether the amount is a credit or a debit amount.
    /// </summary>
    [IsoId("_mgrm9SmjEeKdFJmzhTDOvQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }
}
