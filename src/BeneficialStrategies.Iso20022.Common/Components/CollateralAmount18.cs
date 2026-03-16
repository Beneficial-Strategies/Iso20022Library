// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deal amount details.
/// </summary>
[IsoId("_qXrlIRIrEeyZaPkaPAzTvQ")]
[DisplayName("Collateral Amount")]
public record CollateralAmount18
{
    /// <summary>
    /// Amount of the principal.
    /// </summary>
    [IsoId("_qxKcIRIrEeyZaPkaPAzTvQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public AmountAndDirection49? Transaction { get; init; }

    /// <summary>
    /// Amount of principal plus interests at termination.
    /// </summary>
    [IsoId("_qxKcIxIrEeyZaPkaPAzTvQ")]
    [DisplayName("Termination")]
    [IsoXmlTag("Termntn")]
    public AmountAndDirection49? Termination { get; init; }

    /// <summary>
    /// Specifies the accrued interest on the value of the principal trade, in the currency of the principal trade.
    /// </summary>
    [IsoId("_qxKcJRIrEeyZaPkaPAzTvQ")]
    [DisplayName("Accrued")]
    [IsoXmlTag("Acrd")]
    public AmountAndDirection49? Accrued { get; init; }

    /// <summary>
    /// Specifies whether the interest calculation method is simple or compounding.
    /// </summary>
    [IsoId("_qxKcJxIrEeyZaPkaPAzTvQ")]
    [DisplayName("Compound Simple Accrual Calculation")]
    [IsoXmlTag("CmpndSmplAcrlClctn")]
    public CalculationMethod1Code? CompoundSimpleAccrualCalculation { get; init; }

    /// <summary>
    /// Specifies when the accrued interest is paid.
    /// </summary>
    [IsoId("_qxKcKRIrEeyZaPkaPAzTvQ")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency38Choice_? PaymentFrequency { get; init; }

    /// <summary>
    /// Number of days after the accrual payment is due.
    /// </summary>
    [IsoId("_qxKcKxIrEeyZaPkaPAzTvQ")]
    [DisplayName("Interest Payment Delay")]
    [IsoXmlTag("IntrstPmtDely")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? InterestPaymentDelay { get; init; }

    /// <summary>
    /// Breakdown of transaction amount (required value for the exposure)  into market value lots based on the underlying trades.
    /// </summary>
    [IsoId("_qxKcLRIrEeyZaPkaPAzTvQ")]
    [DisplayName("Transaction Amount Breakdown")]
    [IsoXmlTag("TxAmtBrkdwn")]
    public ValueList<CollateralTransactionAmountBreakdown2> TransactionAmountBreakdown { get; init; } =
        [];

    /// <summary>
    /// Value of collateral offered or sought.
    /// </summary>
    [IsoId("_qxKcLxIrEeyZaPkaPAzTvQ")]
    [DisplayName("Value Sought")]
    [IsoXmlTag("ValSght")]
    public AmountAndDirection49? ValueSought { get; init; }
}
