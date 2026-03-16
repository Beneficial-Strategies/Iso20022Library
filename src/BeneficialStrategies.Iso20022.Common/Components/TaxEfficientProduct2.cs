// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of a tax efficient product.
/// </summary>
[IsoId("_7HpiwU4aEeiQHa-q1Uephw")]
[DisplayName("Tax Efficient Product")]
public record TaxEfficientProduct2
{
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    [IsoId("_Mxu-404bEeiQHa-q1Uephw")]
    [DisplayName("Tax Efficient Product Type")]
    [IsoXmlTag("TaxEffcntPdctTp")]
    public required TaxEfficientProductType1Choice_ TaxEfficientProductType { get; init; }

    /// <summary>
    /// Indicates whether, for the current year, the product contains a cash asset for transfer.
    /// </summary>
    [IsoId("_7XtYB04aEeiQHa-q1Uephw")]
    [DisplayName("Cash Component Indicator")]
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CashComponentIndicator { get; init; }

    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    [IsoId("_7XtYCU4aEeiQHa-q1Uephw")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYear4? PreviousYears { get; init; }

    /// <summary>
    /// Date the investment plan started.
    /// </summary>
    [IsoId("_pznNQV2_EeiFXdiLi_Nf4A")]
    [DisplayName("Date Of First Subscription")]
    [IsoXmlTag("DtOfFrstSbcpt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfFirstSubscription { get; init; }

    /// <summary>
    /// Amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_7XtYC04aEeiQHa-q1Uephw")]
    [DisplayName("Current Year Subscription Details")]
    [IsoXmlTag("CurYrSbcptDtls")]
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; }

    /// <summary>
    /// Bonus paid out or withdrawn.
    /// </summary>
    [IsoId("_uXXFQl2_EeiFXdiLi_Nf4A")]
    [DisplayName("Bonus Or Withdrawal")]
    [IsoXmlTag("BnsOrWdrwl")]
    public BonusWithdrawal1? BonusOrWithdrawal { get; init; }

    /// <summary>
    /// Identification of the investor as assigned by a tax authority.
    /// </summary>
    [IsoId("_uXXFQ12_EeiFXdiLi_Nf4A")]
    [DisplayName("Investor Tax Reference")]
    [IsoXmlTag("InvstrTaxRef")]
    public TaxReference2? InvestorTaxReference { get; init; }

    /// <summary>
    /// Value of the investments to follow.
    /// </summary>
    [IsoId("_71Xu8E4bEeiQHa-q1Uephw")]
    [DisplayName("Investments To Follow Value")]
    [IsoXmlTag("InvstmtsToFllwVal")]
    public DateAndAmount2? InvestmentsToFollowValue { get; init; }

    /// <summary>
    /// Information about an innovative finance product.
    /// </summary>
    [IsoId("_FGYnUE4cEeiQHa-q1Uephw")]
    [DisplayName("Innovative Finance")]
    [IsoXmlTag("InnvtvFinc")]
    public InnovativeFinance1? InnovativeFinance { get; init; }

    /// <summary>
    /// Lowest investment amount in the current year, used to calculate a tax deduction amount.
    /// </summary>
    [IsoId("_MosWtKVGEeiYMvosZPzV4g")]
    [DisplayName("Lowest Invested Amount Current Year")]
    [IsoXmlTag("LwstInvstdAmtCurYr")]
    public ActiveCurrencyAnd13DecimalAmount? LowestInvestedAmountCurrentYear { get; init; }

    /// <summary>
    /// Amount of money from which the tax deduction is calculated.
    /// </summary>
    [IsoId("_MosWtaVGEeiYMvosZPzV4g")]
    [DisplayName("Tax Calculation Base")]
    [IsoXmlTag("TaxClctnBase")]
    public ActiveCurrencyAnd13DecimalAmount? TaxCalculationBase { get; init; }

    /// <summary>
    /// Unused tax deduction amount.
    /// </summary>
    [IsoId("_MosWtqVGEeiYMvosZPzV4g")]
    [DisplayName("Unused Tax Deduction")]
    [IsoXmlTag("UusdTaxDdctn")]
    public ActiveCurrencyAnd13DecimalAmount? UnusedTaxDeduction { get; init; }

    /// <summary>
    /// Amount of money invested.
    /// </summary>
    [IsoId("_MosWt6VGEeiYMvosZPzV4g")]
    [DisplayName("Current Investment Amount")]
    [IsoXmlTag("CurInvstmtAmt")]
    public ActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; }

    /// <summary>
    /// Estimated value of the assets of the tax efficient product to be transferred.
    /// </summary>
    [IsoId("_5953AE4bEeiQHa-q1Uephw")]
    [DisplayName("Estimated Value")]
    [IsoXmlTag("EstmtdVal")]
    public DateAndAmount2? EstimatedValue { get; init; }

    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    [IsoId("_GY9CcE4cEeiQHa-q1Uephw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
