// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction Amounts11.
/// </summary>
[IsoId("_LyqdcaDtEe-MRKYsaX6JDg")]
[DisplayName("ATM Transaction Amounts11")]
public record ATMTransactionAmounts11
{
    /// <summary>
    /// Additional Amount.
    /// </summary>
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<ATMTransactionAmounts7> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Deposit Limits.
    /// </summary>
    [DisplayName("Deposit Limits")]
    [IsoXmlTag("DpstLmts")]
    public ValueList<ATMTransactionAmounts10> DepositLimits { get; init; } = [];

    /// <summary>
    /// Maximum Possible Amount.
    /// </summary>
    [DisplayName("Maximum Possible Amount")]
    [IsoXmlTag("MaxPssblAmt")]
    public ImpliedCurrencyAndAmount? MaximumPossibleAmount { get; init; }

    /// <summary>
    /// Minimum Possible Amount.
    /// </summary>
    [DisplayName("Minimum Possible Amount")]
    [IsoXmlTag("MinPssblAmt")]
    public ImpliedCurrencyAndAmount? MinimumPossibleAmount { get; init; }
}
