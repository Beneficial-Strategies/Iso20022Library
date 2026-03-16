// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the deposit transaction.
/// </summary>
[IsoId("_7175Qa4AEeWL1uap3dNhCQ")]
[DisplayName("Detailed Amount")]
public record DetailedAmount16
{
    /// <summary>
    /// Link to the account for multi-account deposit.
    /// </summary>
    [IsoId("_FgDOIK4BEeWL1uap3dNhCQ")]
    [DisplayName("Account Sequence Number")]
    [IsoXmlTag("AcctSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? AccountSequenceNumber { get; init; }

    /// <summary>
    /// Amount of the deposit to be made on the ATM after the approval of the deposit transaction.
    /// </summary>
    [IsoId("_8BHOga4AEeWL1uap3dNhCQ")]
    [DisplayName("Amount To Deposit")]
    [IsoXmlTag("AmtToDpst")]
    public ImpliedCurrencyAndAmount? AmountToDeposit { get; init; }

    /// <summary>
    /// Currency of the amount to deposit when different from the base currency of the ATM.
    /// </summary>
    [IsoId("_8BHOg64AEeWL1uap3dNhCQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Cashback amount value.
    /// </summary>
    [IsoId("_RuWLUK-TEeWJvLRJ8PsD_w")]
    [DisplayName("Cash Back Amount")]
    [IsoXmlTag("CshBckAmt")]
    public ImpliedCurrencyAndAmount? CashBackAmount { get; init; }

    /// <summary>
    /// Deposit fees, accepted by the customer.
    /// </summary>
    [IsoId("_8BHOha4AEeWL1uap3dNhCQ")]
    [DisplayName("Fees")]
    [IsoXmlTag("Fees")]
    public ValueList<DetailedAmount13> Fees { get; init; } = [];

    /// <summary>
    /// Amount of the donation.
    /// </summary>
    [IsoId("_8BHOh64AEeWL1uap3dNhCQ")]
    [DisplayName("Donation")]
    [IsoXmlTag("Dontn")]
    public ValueList<DetailedAmount13> Donation { get; init; } = [];
}
