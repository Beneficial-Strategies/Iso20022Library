// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies other amounts pertaining to the transaction.
/// </summary>
[IsoId("_9q6Y4dz1Ed-a791rB7tZXQ")]
[DisplayName("Other Amounts")]
public record OtherAmounts8
{
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_9q6Y49z1Ed-a791rB7tZXQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection23? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_9q6Y5dz1Ed-a791rB7tZXQ")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public AmountAndDirection23? ChargesFees { get; init; }

    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_9q6Y6dz1Ed-a791rB7tZXQ")]
    [DisplayName("Trade Amount")]
    [IsoXmlTag("TradAmt")]
    public AmountAndDirection23? TradeAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_9q6Y69z1Ed-a791rB7tZXQ")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public AmountAndDirection23? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_9q6Y8dz1Ed-a791rB7tZXQ")]
    [DisplayName("Local Tax")]
    [IsoXmlTag("LclTax")]
    public AmountAndDirection23? LocalTax { get; init; }

    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_9q6Y89z1Ed-a791rB7tZXQ")]
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection23? LocalBrokerCommission { get; init; }

    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_9q6Y99z1Ed-a791rB7tZXQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public AmountAndDirection23? Other { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_9q6ZAdz1Ed-a791rB7tZXQ")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public AmountAndDirection23? StampDuty { get; init; }

    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_9q6ZB9z1Ed-a791rB7tZXQ")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public AmountAndDirection23? TransactionTax { get; init; }

    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_9q6ZC9z1Ed-a791rB7tZXQ")]
    [DisplayName("Withholding Tax")]
    [IsoXmlTag("WhldgTax")]
    public AmountAndDirection23? WithholdingTax { get; init; }

    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    [IsoId("_9q6ZD9z1Ed-a791rB7tZXQ")]
    [DisplayName("Consumption Tax")]
    [IsoXmlTag("CsmptnTax")]
    public AmountAndDirection23? ConsumptionTax { get; init; }
}
