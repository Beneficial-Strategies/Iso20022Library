// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit of amounts for the customer.
/// </summary>
[IsoId("_ucGeUa-VEeWJvLRJ8PsD_w")]
[DisplayName("ATM Transaction Amounts")]
public record ATMTransactionAmounts8
{
    /// <summary>
    /// Default currency of the limits.
    /// </summary>
    [IsoId("_uoeGYa-VEeWJvLRJ8PsD_w")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Maximum amount allowed for a transaction in the service.
    /// </summary>
    [IsoId("_uoeGY6-VEeWJvLRJ8PsD_w")]
    [DisplayName("Maximum Possible Amount")]
    [IsoXmlTag("MaxPssblAmt")]
    public ImpliedCurrencyAndAmount? MaximumPossibleAmount { get; init; }

    /// <summary>
    /// Minimum amount allowed for a transaction in the service.
    /// </summary>
    [IsoId("_uoeGZa-VEeWJvLRJ8PsD_w")]
    [DisplayName("Minimum Possible Amount")]
    [IsoXmlTag("MinPssblAmt")]
    public ImpliedCurrencyAndAmount? MinimumPossibleAmount { get; init; }

    /// <summary>
    /// Additional amount that may be displayed to the customer, for instance the daily limit or the daily balance for the service.
    /// </summary>
    [IsoId("_uoeGZ6-VEeWJvLRJ8PsD_w")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<ATMTransactionAmounts7> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Limit of deposited media for the customer.
    /// </summary>
    [IsoId("_3g-YIK-VEeWJvLRJ8PsD_w")]
    [DisplayName("Deposit Limits")]
    [IsoXmlTag("DpstLmts")]
    public ValueList<ATMTransactionAmounts9> DepositLimits { get; init; } = [];
}
