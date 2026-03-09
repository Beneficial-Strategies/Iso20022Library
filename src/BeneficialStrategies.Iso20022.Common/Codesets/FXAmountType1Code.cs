// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of amount for foreign exchange commissions or fees.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CcW-MANzEe2-vqzwMUAewg")]
[Description(@"Specifies the type of amount for foreign exchange commissions or fees.")]
[DerivedFrom(typeof(FXAmountTypeCode))]
public enum FXAmountType1Code
{
    /// <summary>
    /// Zwischengewinn.
    /// Encoded/decoded by serializers as &quot;ZWIS&quot;.
    /// </summary>
    [EnumMember(Value = "ZWIS")]
    [IsoId("_FIOukQNzEe2-vqzwMUAewg")]
    [Description(@"Zwischengewinn.")]
    Zwischengewinn = FXAmountTypeCode.Zwischengewinn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_FXHfIQNzEe2-vqzwMUAewg")]
    [Description(@"Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.")]
    WithholdingTax = FXAmountTypeCode.WithholdingTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is a value added tax.
    /// Encoded/decoded by serializers as &quot;VATA&quot;.
    /// </summary>
    [EnumMember(Value = "VATA")]
    [IsoId("_Fm6OoQNzEe2-vqzwMUAewg")]
    [Description(@"Tax is a value added tax.")]
    ValueAddedTax = FXAmountTypeCode.ValueAddedTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on a transfer.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_FpyjgQNzEe2-vqzwMUAewg")]
    [Description(@"Tax levied on a transfer.")]
    TransferTax = FXAmountTypeCode.TransferTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on a transaction.
    /// Encoded/decoded by serializers as &quot;TRAX&quot;.
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_FsstkQNzEe2-vqzwMUAewg")]
    [Description(@"Tax levied on a transaction.")]
    TransactionTax = FXAmountTypeCode.TransactionTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax collected by a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_FyksEQNzEe2-vqzwMUAewg")]
    [Description(@"Tax collected by a stock exchange.")]
    StockExchangeTax = FXAmountTypeCode.StockExchangeTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is on certain documents and transactions.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_F4efwQNzEe2-vqzwMUAewg")]
    [Description(@"Tax is on certain documents and transactions.")]
    StampDuty = FXAmountTypeCode.StampDuty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another type of commission or fees.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_GDyX4QNzEe2-vqzwMUAewg")]
    [Description(@"Another type of commission or fees.")]
    OtherAmount = FXAmountTypeCode.OtherAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is a country, national, or federal tax that is usually charged by the custodian.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_GJdiEQNzEe2-vqzwMUAewg")]
    [Description(@"Tax is a country, national, or federal tax that is usually charged by the custodian.")]
    NationalFederalTax = FXAmountTypeCode.NationalFederalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax that is charged by a local settlement system or local jurisdiction.
    /// Encoded/decoded by serializers as &quot;LOCL&quot;.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_GPIsQQNzEe2-vqzwMUAewg")]
    [Description(@"Tax that is charged by a local settlement system or local jurisdiction.")]
    LocalTax = FXAmountTypeCode.LocalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Local broker&apos;s commission amount.
    /// Encoded/decoded by serializers as &quot;LOCO&quot;.
    /// </summary>
    [EnumMember(Value = "LOCO")]
    [IsoId("_GSF5oQNzEe2-vqzwMUAewg")]
    [Description(@"Local broker's commission amount.")]
    LocalBrokerCommission = FXAmountTypeCode.LocalBrokerCommission, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Local tax (Ertrag Besitzanteilig) yield liable for interest down payment tax.
    /// Encoded/decoded by serializers as &quot;LYDT&quot;.
    /// </summary>
    [EnumMember(Value = "LYDT")]
    [IsoId("_GdpCUQNzEe2-vqzwMUAewg")]
    [Description(@"Local tax (Ertrag Besitzanteilig) yield liable for interest down payment tax.")]
    GermanLocalTax4 = FXAmountTypeCode.GermanLocalTax4, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Local tax (Zinstopf) offset interest per unit against tax exempt amount (variation to offset interest per unit in relation to tax exempt amount).
    /// Encoded/decoded by serializers as &quot;LOTE&quot;.
    /// </summary>
    [EnumMember(Value = "LOTE")]
    [IsoId("_GgilUQNzEe2-vqzwMUAewg")]
    [Description(@"Local tax (Zinstopf) offset interest per unit against tax exempt amount (variation to offset interest per unit in relation to tax exempt amount).")]
    GermanLocalTax3 = FXAmountTypeCode.GermanLocalTax3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Local tax (ZAS pflichtige Zinsen) - interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// Encoded/decoded by serializers as &quot;LIDT&quot;.
    /// </summary>
    [EnumMember(Value = "LIDT")]
    [IsoId("_GjzUsQNzEe2-vqzwMUAewg")]
    [Description(@"Local tax (ZAS pflichtige Zinsen) - interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).")]
    GermanLocalTax2 = FXAmountTypeCode.GermanLocalTax2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Executing broker&apos;s commission amount.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_GmsQoQNzEe2-vqzwMUAewg")]
    [Description(@"Executing broker's commission amount.")]
    ExecutingBrokerCommission = FXAmountTypeCode.ExecutingBrokerCommission, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as &quot;EUTR&quot;.
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_GpqFEQNzEe2-vqzwMUAewg")]
    [Description(@"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.")]
    EUTaxRetention = FXAmountTypeCode.EUTaxRetention, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_GsmEUQNzEe2-vqzwMUAewg")]
    [Description(@"Investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.")]
    Equalisation = FXAmountTypeCode.Equalisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_GzWMkQNzEe2-vqzwMUAewg")]
    [Description(@"Tax that is levied on goods and services purchased by customers, and is added to the retail price.")]
    ConsumptionTax = FXAmountTypeCode.ConsumptionTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as &quot;AKTI&quot;.
    /// </summary>
    [EnumMember(Value = "AKTI")]
    [IsoId("_HfrHEQNzEe2-vqzwMUAewg")]
    [Description(@"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).")]
    Aktiengewinn = FXAmountTypeCode.Aktiengewinn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Early redemption fees.
    /// Encoded/decoded by serializers as &quot;ERFE&quot;.
    /// </summary>
    [EnumMember(Value = "ERFE")]
    [IsoId("_BC4SoQRLEe29PP19jELcvQ")]
    [Description(@"Early redemption fees.")]
    EarlyRedemptionFeeAmount = FXAmountTypeCode.EarlyRedemptionFeeAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entrance fees amount
    /// Encoded/decoded by serializers as &quot;ENTF&quot;.
    /// </summary>
    [EnumMember(Value = "ENTF")]
    [IsoId("_BJOyQQRLEe29PP19jELcvQ")]
    [Description(@"Entrance fees amount")]
    EntranceFees = FXAmountTypeCode.EntranceFees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Margin amount related commissions and fees.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_BbEJIQRLEe29PP19jELcvQ")]
    [Description(@"Margin amount related commissions and fees.")]
    MarginAmount = FXAmountTypeCode.MarginAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee charged for matching and/or confirmation.
    /// Encoded/decoded by serializers as &quot;MACO&quot;.
    /// </summary>
    [EnumMember(Value = "MACO")]
    [IsoId("_BgcYYQRLEe29PP19jELcvQ")]
    [Description(@"Fee charged for matching and/or confirmation.")]
    MatchingOrConfirmationFees = FXAmountTypeCode.MatchingOrConfirmationFees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// Encoded/decoded by serializers as &quot;ANTO&quot;.
    /// </summary>
    [EnumMember(Value = "ANTO")]
    [IsoId("_BxPNcQRLEe29PP19jELcvQ")]
    [Description(@"Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.")]
    NetGainLoss = FXAmountTypeCode.NetGainLoss, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rebate or bonification fees or commission amount.
    /// Encoded/decoded by serializers as &quot;CREB&quot;.
    /// </summary>
    [EnumMember(Value = "CREB")]
    [IsoId("_B68jEQRLEe29PP19jELcvQ")]
    [Description(@"Rebate or bonification fees or commission amount.")]
    RebateBonification = FXAmountTypeCode.RebateBonification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fees, drawdown, or other reduction from or in addition to the deal price.
    /// Encoded/decoded by serializers as &quot;SPCN&quot;.
    /// </summary>
    [EnumMember(Value = "SPCN")]
    [IsoId("_CGdPgQRLEe29PP19jELcvQ")]
    [Description(@"Fees, drawdown, or other reduction from or in addition to the deal price.")]
    SpecialConcessions = FXAmountTypeCode.SpecialConcessions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Subscription interest.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_CQSg8QRLEe29PP19jELcvQ")]
    [Description(@"Subscription interest.")]
    Subscription = FXAmountTypeCode.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total amount of all commissions or fees
    /// Encoded/decoded by serializers as &quot;TOTL&quot;.
    /// </summary>
    [EnumMember(Value = "TOTL")]
    [IsoId("_CV2WYQRLEe29PP19jELcvQ")]
    [Description(@"Total amount of all commissions or fees")]
    Total = FXAmountTypeCode.Total, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade deal amount fees.
    /// Encoded/decoded by serializers as &quot;DEAL&quot;.
    /// </summary>
    [EnumMember(Value = "DEAL")]
    [IsoId("_CbcBAQRLEe29PP19jELcvQ")]
    [Description(@"Trade deal amount fees.")]
    TradeDealAmount = FXAmountTypeCode.TradeDealAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of interest earned on a debt, such as a bond, but not yet collected.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_DIgiYQRLEe29PP19jELcvQ")]
    [Description(@"Amount of interest earned on a debt, such as a bond, but not yet collected.")]
    AccruedInterest = FXAmountTypeCode.AccruedInterest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount paid by investors when selling mutual fund shares.
    /// Encoded/decoded by serializers as &quot;BAKL&quot;.
    /// </summary>
    [EnumMember(Value = "BAKL")]
    [IsoId("_DcWEYQRLEe29PP19jELcvQ")]
    [Description(@"Amount paid by investors when selling mutual fund shares.")]
    BackLoadFee = FXAmountTypeCode.BackLoadFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of money that cannot be categorised by another qualifier.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_DjywMQRLEe29PP19jELcvQ")]
    [Description(@"Amount of money that cannot be categorised by another qualifier.")]
    ChargesAndFees = FXAmountTypeCode.ChargesAndFees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge of the correspondent bank for transferring money.
    /// Encoded/decoded by serializers as &quot;CBCH&quot;.
    /// </summary>
    [EnumMember(Value = "CBCH")]
    [IsoId("_Dox94QRLEe29PP19jELcvQ")]
    [Description(@"Charge of the correspondent bank for transferring money.")]
    CorrespondentBankCharge = FXAmountTypeCode.CorrespondentBankCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Local tax (ZAS Anrechnungsbetrag) subject to interest down payment tax (proportion of interest liable for interest down payment tax/interim profit that is not covered by the tax exempt amount).
    /// Encoded/decoded by serializers as &quot;LADT&quot;.
    /// </summary>
    [EnumMember(Value = "LADT")]
    [IsoId("_5X7cUQROEe29PP19jELcvQ")]
    [Description(@"Local tax (ZAS Anrechnungsbetrag) subject to interest down payment tax (proportion of interest liable for interest down payment tax/interim profit that is not covered by the tax exempt amount).")]
    GermanLocalTax1 = FXAmountTypeCode.GermanLocalTax1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Aggregate amount of discount.
    /// Encoded/decoded by serializers as &quot;DSCA&quot;.
    /// </summary>
    [EnumMember(Value = "DSCA")]
    [IsoId("_5w25sQROEe29PP19jELcvQ")]
    [Description(@"Aggregate amount of discount.")]
    DiscountAmount = FXAmountTypeCode.DiscountAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount due and payable to a hedge counterparty under a hedge agreement during the relevant period.
    /// Encoded/decoded by serializers as &quot;HDGE&quot;.
    /// </summary>
    [EnumMember(Value = "HDGE")]
    [IsoId("_6mPCgQROEe29PP19jELcvQ")]
    [Description(@"Amount due and payable to a hedge counterparty under a hedge agreement during the relevant period.")]
    HedgingCost = FXAmountTypeCode.HedgingCost, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// Encoded/decoded by serializers as &quot;ISDI&quot;.
    /// </summary>
    [EnumMember(Value = "ISDI")]
    [IsoId("_6rYBMQROEe29PP19jELcvQ")]
    [Description(@"Amount of money defined as a discount on a new issue or on a tranche of an existing issue.")]
    IssueDiscountAllowance = FXAmountTypeCode.IssueDiscountAllowance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on a payment.
    /// Encoded/decoded by serializers as &quot;LEVY&quot;.
    /// </summary>
    [EnumMember(Value = "LEVY")]
    [IsoId("_6_-_QQROEe29PP19jELcvQ")]
    [Description(@"Tax levied on a payment.")]
    PaymentLevyTax = FXAmountTypeCode.PaymentLevyTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// Encoded/decoded by serializers as &quot;OCMT&quot;.
    /// </summary>
    [EnumMember(Value = "OCMT")]
    [IsoId("_Jx-iAQRREe29PP19jELcvQ")]
    [Description(@"Posting/settlement amount in its original currency when conversion from/into another currency has occurred.")]
    OriginalCurrencyAmount = FXAmountTypeCode.OriginalCurrencyAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// Encoded/decoded by serializers as &quot;PRMA&quot;.
    /// </summary>
    [EnumMember(Value = "PRMA")]
    [IsoId("_KrKMwQRREe29PP19jELcvQ")]
    [Description(@"Difference between the amount of money of the first leg and the amount of the second leg of the transaction.")]
    PremiumAmount = FXAmountTypeCode.PremiumAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount is an on top margin.
    /// Encoded/decoded by serializers as &quot;OTMG&quot;.
    /// </summary>
    [EnumMember(Value = "OTMG")]
    [IsoId("_KzZiwQRREe29PP19jELcvQ")]
    [Description(@"Amount is an on top margin.")]
    OnTopMargin = FXAmountTypeCode.OnTopMargin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// Encoded/decoded by serializers as &quot;REGF&quot;.
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_K76lkQRREe29PP19jELcvQ")]
    [Description(@"Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.")]
    RegulatoryFees = FXAmountTypeCode.RegulatoryFees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of any other remuneration received or to be received by the broker in connection with the transaction.
    /// Encoded/decoded by serializers as &quot;REMU&quot;.
    /// </summary>
    [EnumMember(Value = "REMU")]
    [IsoId("_LAPE4QRREe29PP19jELcvQ")]
    [Description(@"Amount of any other remuneration received or to be received by the broker in connection with the transaction.")]
    RemunerationAmount = FXAmountTypeCode.RemunerationAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counter value of a foreign exchange conversion.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_LHoGUQRREe29PP19jELcvQ")]
    [Description(@"Counter value of a foreign exchange conversion.")]
    ResultingAmount = FXAmountTypeCode.ResultingAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial metric used to assess a firm&apos;s financial health by revealing the proportion of money left over from revenues after accounting for the cost of goods sold. Gross profit margin serves as the source for paying additional expenses and future savings.
    /// Encoded/decoded by serializers as &quot;SAMG&quot;.
    /// </summary>
    [EnumMember(Value = "SAMG")]
    [IsoId("_LMcU4QRREe29PP19jELcvQ")]
    [Description(@"Financial metric used to assess a firm's financial health by revealing the proportion of money left over from revenues after accounting for the cost of goods sold. Gross profit margin serves as the source for paying additional expenses and future savings.")]
    SalesMargin = FXAmountTypeCode.SalesMargin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of all settled transactions.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_LTZRcQRREe29PP19jELcvQ")]
    [Description(@"Amount of all settled transactions.")]
    SettlementAmount = FXAmountTypeCode.SettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_LwDYQQRREe29PP19jELcvQ")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge = FXAmountTypeCode.ShippingCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently 
    /// restructured), which is capitalized and added to the original principal amount of the bond.
    /// Encoded/decoded by serializers as &quot;ACCA&quot;.
    /// </summary>
    [EnumMember(Value = "ACCA")]
    [IsoId("_Uxn0gQRTEe29PP19jELcvQ")]
    [Description(@"Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.")]
    AccruedCapitalisation = FXAmountTypeCode.AccruedCapitalisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Difference between the deal price and another reference price.
    /// Encoded/decoded by serializers as &quot;PRDF&quot;.
    /// </summary>
    [EnumMember(Value = "PRDF")]
    [IsoId("_VEj-oQRTEe29PP19jELcvQ")]
    [Description(@"Difference between the deal price and another reference price.")]
    DifferenceInPrice = FXAmountTypeCode.DifferenceInPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of the expected refund.
    /// Encoded/decoded by serializers as &quot;REFD&quot;.
    /// </summary>
    [EnumMember(Value = "REFD")]
    [IsoId("_VYF-oQRTEe29PP19jELcvQ")]
    [Description(@"Amount of the expected refund.")]
    ExpectedRefund = FXAmountTypeCode.ExpectedRefund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount retained by a fund and paid out later at a time decided by the fund.
    /// Encoded/decoded by serializers as &quot;PRWI&quot;.
    /// </summary>
    [EnumMember(Value = "PRWI")]
    [IsoId("_VyBhkQRTEe29PP19jELcvQ")]
    [Description(@"Amount retained by a fund and paid out later at a time decided by the fund.")]
    PartialRedemptionWithholdingAmount = FXAmountTypeCode.PartialRedemptionWithholdingAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge or commission paid by the investor to a distributor/intermediary or other service provider for the provision of financial research.
    /// Encoded/decoded by serializers as &quot;RSCH&quot;.
    /// </summary>
    [EnumMember(Value = "RSCH")]
    [IsoId("_V8ByIQRTEe29PP19jELcvQ")]
    [Description(@"Charge or commission paid by the investor to a distributor/intermediary or other service provider for the provision of financial research.")]
    ResearchFee = FXAmountTypeCode.ResearchFee, // same ordinal as derivation source for type conversions
    
}
