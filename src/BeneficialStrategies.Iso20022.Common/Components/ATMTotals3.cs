// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Totals of the ATM.
/// </summary>
[IsoId("_A8HNEYtzEeSLQutgI1Ulfw")]
[DisplayName("ATM Totals")]
public record ATMTotals3
{
    /// <summary>
    /// Identification of the type of transaction. The following values are predefined: Withdrawal, QuickWithdrawal, WithdrawalForDisabledPerson, CashDeposit, Transfer, InternationalTransfer, PeriodicTransfer, CheckCommand, MobileTopUp, Moneo.
    /// </summary>
    [IsoId("_cyRboItzEeSLQutgI1Ulfw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Identification { get; init; }

    /// <summary>
    /// Additional identification of the type of transaction. The following values are predefined: Vodaphone, TMobile, Verizon.
    /// </summary>
    [IsoId("_h4nDUItzEeSLQutgI1Ulfw")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalIdentification { get; init; }

    /// <summary>
    /// Period of computation for the counters.
    /// </summary>
    [IsoId("_Waj2MOg6EeSbwP3G-MV9YA")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public required ATMCounterType2Code Period { get; init; }

    /// <summary>
    /// Currency of the totals.
    /// </summary>
    [IsoId("_BIxwE4tzEeSLQutgI1Ulfw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Number of transaction with the defined currency.
    /// </summary>
    [IsoId("_BIxwGYtzEeSLQutgI1Ulfw")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Count { get; init; }

    /// <summary>
    /// Amount of transaction with the defined currency.
    /// </summary>
    [IsoId("_BIxwFYtzEeSLQutgI1Ulfw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; }
}
