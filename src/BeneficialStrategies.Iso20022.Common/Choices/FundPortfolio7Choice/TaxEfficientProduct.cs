// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio7Choice
{
    /// <summary>
    /// Portfolio is a government scheme to encourage investment in securities based unit and investment trusts, offering certain tax benefits. These are not investments in their own right but are tax exempt &apos;wrappers&apos; in which equities, bonds and funds can be held to shelter them from various types of tax.
    /// In the UK, a typical tax wrapper product is known as an &apos;ISA&apos; (Individual Savings Account).
    /// </summary>
    [IsoId("_X-C5IelfEeu9cf4XM82AQQ")]
    [DisplayName("Tax Efficient Product")]
    public record TaxEfficientProduct : FundPortfolio7Choice_
    {
        /// <summary>
        /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
        /// </summary>
        [IsoId("_YUPyo-lfEeu9cf4XM82AQQ")]
        [DisplayName("Tax Efficient Product Type")]
        [IsoXmlTag("TaxEffcntPdctTp")]
        public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; }

        /// <summary>
        /// Indicates that all the current fiscal year’s products are included.
        /// </summary>
        [IsoId("_YUPypelfEeu9cf4XM82AQQ")]
        [DisplayName("Current Year")]
        [IsoXmlTag("CurYr")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? CurrentYear { get; init; }

        /// <summary>
        /// Indicates whether, for the current year, the product contains a cash asset for transfer.
        /// </summary>
        [IsoId("_YUPyp-lfEeu9cf4XM82AQQ")]
        [DisplayName("Cash Component Indicator")]
        [IsoXmlTag("CshCmpntInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? CashComponentIndicator { get; init; }

        /// <summary>
        /// Investment plans issued during previous years.
        /// </summary>
        [IsoId("_YUPyqelfEeu9cf4XM82AQQ")]
        [DisplayName("Previous Years")]
        [IsoXmlTag("PrvsYrs")]
        public PreviousYear4? PreviousYears { get; init; }

        /// <summary>
        /// Subscriptions from the previous subscription year.
        /// </summary>
        [IsoId("_YUPyq-lfEeu9cf4XM82AQQ")]
        [DisplayName("Previous Year Subscription Amount")]
        [IsoXmlTag("PrvsYrSbcptAmt")]
        public ActiveCurrencyAnd13DecimalAmount? PreviousYearSubscriptionAmount { get; init; }

        /// <summary>
        /// Amount subscribed in all previous years.
        /// </summary>
        [IsoId("_YUPyrelfEeu9cf4XM82AQQ")]
        [DisplayName("Previous Years Subscription Amount")]
        [IsoXmlTag("PrvsYrsSbcptAmt")]
        public ActiveCurrencyAnd13DecimalAmount? PreviousYearsSubscriptionAmount { get; init; }

        /// <summary>
        /// Date the investment plan started.
        /// </summary>
        [IsoId("_YUPyr-lfEeu9cf4XM82AQQ")]
        [DisplayName("Date Of First Subscription")]
        [IsoXmlTag("DtOfFrstSbcpt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DateOfFirstSubscription { get; init; }

        /// <summary>
        /// Amounts already subscribed for the current year.
        /// </summary>
        [IsoId("_YUPyselfEeu9cf4XM82AQQ")]
        [DisplayName("Current Year Subscription Details")]
        [IsoXmlTag("CurYrSbcptDtls")]
        public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; }

        /// <summary>
        /// Bonus paid out or withdrawn.
        /// </summary>
        [IsoId("_YUPys-lfEeu9cf4XM82AQQ")]
        [DisplayName("Bonus Or Withdrawal")]
        [IsoXmlTag("BnsOrWdrwl")]
        public BonusWithdrawal2? BonusOrWithdrawal { get; init; }

        /// <summary>
        /// Indicates if there is a related property purchase in progress at the point of transfer. May be applicable to products such as Lifetime Individual Savings Account (LISA) products.
        /// </summary>
        [IsoId("_wUjxAOlfEeu9cf4XM82AQQ")]
        [DisplayName("Withdrawal For Residential Purchase Progress")]
        [IsoXmlTag("WdrwlForResdtlPurchsPrgrs")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? WithdrawalForResidentialPurchaseProgress { get; init; }

        /// <summary>
        /// Alternative identification for the transferor (ceding party), for example, the &apos;ISA manager Z reference&apos; in the UK.
        /// </summary>
        [IsoId("_YUPytelfEeu9cf4XM82AQQ")]
        [DisplayName("Transferor Alternate Identification")]
        [IsoXmlTag("TrfrAltrnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? TransferorAlternateIdentification { get; init; }

        /// <summary>
        /// Total amount subscribed over the lifetime of the product.
        /// </summary>
        [IsoId("_YUPyt-lfEeu9cf4XM82AQQ")]
        [DisplayName("Total Subscription Amount")]
        [IsoXmlTag("TtlSbcptAmt")]
        public ActiveCurrencyAndAmount? TotalSubscriptionAmount { get; init; }

        /// <summary>
        /// Another amount such as the total qualifying additions in the year of transfer, interest capitalised in the current year, total outstanding dividend and so on.
        /// </summary>
        [IsoId("_YUPyuelfEeu9cf4XM82AQQ")]
        [DisplayName("Other Amount")]
        [IsoXmlTag("OthrAmt")]
        public OtherAmount3? OtherAmount { get; init; }

        /// <summary>
        /// Date the first qualifying additional amount was made to the product.  Qualifying additional amounts may be made to a Lifetime Individual Savings Account (LISA) product.
        /// </summary>
        [IsoId("_YUPyu-lfEeu9cf4XM82AQQ")]
        [DisplayName("Date First Qualifying Addition")]
        [IsoXmlTag("DtFrstQlfygAddtn")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DateFirstQualifyingAddition { get; init; }

        /// <summary>
        /// Identification of the investor as assigned by a tax authority.
        /// </summary>
        [IsoId("_YUPyvelfEeu9cf4XM82AQQ")]
        [DisplayName("Investor Tax Reference")]
        [IsoXmlTag("InvstrTaxRef")]
        public TaxReference2? InvestorTaxReference { get; init; }

        /// <summary>
        /// Value of the investments to follow.
        /// </summary>
        [IsoId("_YUPyv-lfEeu9cf4XM82AQQ")]
        [DisplayName("Investments To Follow Value")]
        [IsoXmlTag("InvstmtsToFllwVal")]
        public DateAndAmount2? InvestmentsToFollowValue { get; init; }

        /// <summary>
        /// Information about an innovative finance product.
        /// </summary>
        [IsoId("_YUPywelfEeu9cf4XM82AQQ")]
        [DisplayName("Innovative Finance")]
        [IsoXmlTag("InnvtvFinc")]
        public InnovativeFinance1? InnovativeFinance { get; init; }

        /// <summary>
        /// Lowest investment amount in the current year, used to calculate a tax deduction amount.
        /// </summary>
        [IsoId("_YUPyw-lfEeu9cf4XM82AQQ")]
        [DisplayName("Lowest Invested Amount Current Year")]
        [IsoXmlTag("LwstInvstdAmtCurYr")]
        public ActiveCurrencyAnd13DecimalAmount? LowestInvestedAmountCurrentYear { get; init; }

        /// <summary>
        /// Amount of money from which the tax deduction is calculated.
        /// </summary>
        [IsoId("_YUPyxelfEeu9cf4XM82AQQ")]
        [DisplayName("Tax Calculation Base")]
        [IsoXmlTag("TaxClctnBase")]
        public ActiveCurrencyAnd13DecimalAmount? TaxCalculationBase { get; init; }

        /// <summary>
        /// Unused tax deduction amount.
        /// </summary>
        [IsoId("_YUPyx-lfEeu9cf4XM82AQQ")]
        [DisplayName("Unused Tax Deduction")]
        [IsoXmlTag("UusdTaxDdctn")]
        public ActiveCurrencyAnd13DecimalAmount? UnusedTaxDeduction { get; init; }

        /// <summary>
        /// Amount of money invested.
        /// </summary>
        [IsoId("_YUPyyelfEeu9cf4XM82AQQ")]
        [DisplayName("Current Investment Amount")]
        [IsoXmlTag("CurInvstmtAmt")]
        public ActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; }

        /// <summary>
        /// Estimated value of the assets of the tax efficient product to be transferred.
        /// </summary>
        [IsoId("_YUPyy-lfEeu9cf4XM82AQQ")]
        [DisplayName("Estimated Value")]
        [IsoXmlTag("EstmtdVal")]
        public DateAndAmount2? EstimatedValue { get; init; }

        /// <summary>
        /// Additional information about the tax efficient product.
        /// </summary>
        [IsoId("_YUPyzelfEeu9cf4XM82AQQ")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; }
    }
}
