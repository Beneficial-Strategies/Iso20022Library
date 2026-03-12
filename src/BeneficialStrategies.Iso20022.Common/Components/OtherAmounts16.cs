// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies other amounts pertaining to the transaction.
/// </summary>
[IsoId("_AkJEUNokEeC60axPepSq7g_-185304496")]
[DisplayName("Other Amounts")]
public partial record OtherAmounts16
{
    #nullable enable
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_AkJEUdokEeC60axPepSq7g_-1118097243")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public AmountAndDirection29? ChargesFees { get; init; } 
    
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_AkJEUtokEeC60axPepSq7g_-416420599")]
    [DisplayName("Country National Federal Tax")]
    [IsoXmlTag("CtryNtlFdrlTax")]
    public AmountAndDirection29? CountryNationalFederalTax { get; init; } 
    
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_AkJEU9okEeC60axPepSq7g_1770562925")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public AmountAndDirection29? ExecutingBrokerAmount { get; init; } 
    
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_AkJEVNokEeC60axPepSq7g_951609244")]
    [DisplayName("Issue Discount Allowance")]
    [IsoXmlTag("IsseDscntAllwnc")]
    public AmountAndDirection29? IssueDiscountAllowance { get; init; } 
    
    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    [IsoId("_AkJEVdokEeC60axPepSq7g_-1106815068")]
    [DisplayName("Payment Levy Tax")]
    [IsoXmlTag("PmtLevyTax")]
    public AmountAndDirection29? PaymentLevyTax { get; init; } 
    
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_AkJEVtokEeC60axPepSq7g_-1925768749")]
    [DisplayName("Local Tax")]
    [IsoXmlTag("LclTax")]
    public AmountAndDirection29? LocalTax { get; init; } 
    
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_AkSOQNokEeC60axPepSq7g_1080168456")]
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection29? LocalBrokerCommission { get; init; } 
    
    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    [IsoId("_AkSOQdokEeC60axPepSq7g_261214775")]
    [DisplayName("Margin")]
    [IsoXmlTag("Mrgn")]
    public AmountAndDirection29? Margin { get; init; } 
    
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_AkSOQtokEeC60axPepSq7g_-1797209537")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public AmountAndDirection29? Other { get; init; } 
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_AkSOQ9okEeC60axPepSq7g_389773987")]
    [DisplayName("Regulatory Amount")]
    [IsoXmlTag("RgltryAmt")]
    public AmountAndDirection29? RegulatoryAmount { get; init; } 
    
    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_AkSORNokEeC60axPepSq7g_1807363290")]
    [DisplayName("Special Concession")]
    [IsoXmlTag("SpclCncssn")]
    public AmountAndDirection29? SpecialConcession { get; init; } 
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_AkSORdokEeC60axPepSq7g_988409609")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public AmountAndDirection29? StampDuty { get; init; } 
    
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_Akb_QNokEeC60axPepSq7g_-300620482")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public AmountAndDirection29? StockExchangeTax { get; init; } 
    
    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_Akb_QdokEeC60axPepSq7g_-1119574163")]
    [DisplayName("Transfer Tax")]
    [IsoXmlTag("TrfTax")]
    public AmountAndDirection29? TransferTax { get; init; } 
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_Akb_QtokEeC60axPepSq7g_1116968821")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public AmountAndDirection29? TransactionTax { get; init; } 
    
    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    [IsoId("_Akb_Q9okEeC60axPepSq7g_298015140")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public AmountAndDirection29? ValueAddedTax { get; init; } 
    
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_Akb_RNokEeC60axPepSq7g_-991014951")]
    [DisplayName("Withholding Tax")]
    [IsoXmlTag("WhldgTax")]
    public AmountAndDirection29? WithholdingTax { get; init; } 
    
    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    [IsoId("_Akb_RdokEeC60axPepSq7g_-1809968632")]
    [DisplayName("Net Gain Loss")]
    [IsoXmlTag("NetGnLoss")]
    public AmountAndDirection29? NetGainLoss { get; init; } 
    
    /// <summary>
    /// A tax on spending on goods and services.
    /// </summary>
    [IsoId("_Akb_RtokEeC60axPepSq7g_426574352")]
    [DisplayName("Consumption Tax")]
    [IsoXmlTag("CsmptnTax")]
    public AmountAndDirection29? ConsumptionTax { get; init; } 
    
    /// <summary>
    /// Amount of money charged for matching and/or confirmation.
    /// </summary>
    [IsoId("_AklwQNokEeC60axPepSq7g_220976439")]
    [DisplayName("Matching Confirmation Fee")]
    [IsoXmlTag("MtchgConfFee")]
    public AmountAndDirection29? MatchingConfirmationFee { get; init; } 
    
    /// <summary>
    /// Amount following a foreign exchange conversion.
    /// </summary>
    [IsoId("_AklwQdokEeC60axPepSq7g_-889934980")]
    [DisplayName("Converted Amount")]
    [IsoXmlTag("ConvtdAmt")]
    public AmountAndDirection29? ConvertedAmount { get; init; } 
    
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_AklwQtokEeC60axPepSq7g_-2065126005")]
    [DisplayName("Original Currency Amount")]
    [IsoXmlTag("OrgnlCcyAmt")]
    public AmountAndDirection29? OriginalCurrencyAmount { get; init; } 
    
    /// <summary>
    /// Cost of the securities. May be requested in some countries for tax purposes.
    /// </summary>
    [IsoId("_AklwQ9okEeC60axPepSq7g_-869025171")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection29? BookValue { get; init; } 
    
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    [IsoId("_AklwRNokEeC60axPepSq7g_-1266427787")]
    [DisplayName("Accrued Capitalisation Amount")]
    [IsoXmlTag("AcrdCptlstnAmt")]
    public AmountAndDirection29? AccruedCapitalisationAmount { get; init; } 
    
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    [IsoId("_AklwRdokEeC60axPepSq7g_-1826667761")]
    [DisplayName("Local Tax Country Specific")]
    [IsoXmlTag("LclTaxCtrySpcfc1")]
    public AmountAndDirection29? LocalTaxCountrySpecific1 { get; init; } 
    
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    [IsoId("_AklwRtokEeC60axPepSq7g_-629538772")]
    [DisplayName("Local Tax Country Specific")]
    [IsoXmlTag("LclTaxCtrySpcfc2")]
    public AmountAndDirection29? LocalTaxCountrySpecific2 { get; init; } 
    
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    [IsoId("_Aku6MNokEeC60axPepSq7g_655234286")]
    [DisplayName("Local Tax Country Specific")]
    [IsoXmlTag("LclTaxCtrySpcfc3")]
    public AmountAndDirection29? LocalTaxCountrySpecific3 { get; init; } 
    
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    [IsoId("_Aku6MdokEeC60axPepSq7g_354399335")]
    [DisplayName("Local Tax Country Specific")]
    [IsoXmlTag("LclTaxCtrySpcfc4")]
    public AmountAndDirection29? LocalTaxCountrySpecific4 { get; init; } 
    
    /// <summary>
    /// Amount paid as result of transactions subject to shared brokerage commissions.
    /// </summary>
    [IsoId("_Aku6MtokEeC60axPepSq7g_1030295959")]
    [DisplayName("Shared Brokerage Amount")]
    [IsoXmlTag("ShrdBrkrgAmt")]
    public AmountAndDirection29? SharedBrokerageAmount { get; init; } 
    
    /// <summary>
    /// Indicates the total fees related to the trade, with deduction of rebates (on brokerage, commission or differential) granted by the market member (fee amount with tax excluded).
    /// </summary>
    [IsoId("_Aku6M9okEeC60axPepSq7g_796132789")]
    [DisplayName("Market Member Fee Amount")]
    [IsoXmlTag("MktMmbFeeAmt")]
    public AmountAndDirection29? MarketMemberFeeAmount { get; init; } 
    
    /// <summary>
    /// Specifies that this information is available upon request.
    /// </summary>
    [IsoId("_Aku6NNokEeC60axPepSq7g_-871934786")]
    [DisplayName("Remuneration Amount Request")]
    [IsoXmlTag("RmnrtnAmtReq")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RemunerationAmountRequest { get; init; } 
    
    /// <summary>
    /// Specifies the source and amount of any other remuneration received or to be received by the broker in connection with the transaction.
    /// </summary>
    [IsoId("_Aku6NdokEeC60axPepSq7g_-2143702248")]
    [DisplayName("Remuneration Amount")]
    [IsoXmlTag("RmnrtnAmt")]
    public AmountAndDirection29? RemunerationAmount { get; init; } 
    
    /// <summary>
    /// Amount to be paid by the lender to the borrower calculated based on the interest rate.
    /// </summary>
    [IsoId("_Aku6NtokEeC60axPepSq7g_-872372487")]
    [DisplayName("Borrowing Interest Amount")]
    [IsoXmlTag("BrrwgIntrstAmt")]
    public AmountAndDirection29? BorrowingInterestAmount { get; init; } 
    
    /// <summary>
    /// Amount to be paid by the Borrower to the Lender for the securities borrowed calculated based on the bond loan rate.
    /// </summary>
    [IsoId("_Ak4rMNokEeC60axPepSq7g_1194275752")]
    [DisplayName("Borrowing Fee")]
    [IsoXmlTag("BrrwgFee")]
    public AmountAndDirection29? BorrowingFee { get; init; } 
    
    /// <summary>
    /// Net market value of the securities lent used to calculate the collateral amount.
    /// </summary>
    [IsoId("_Ak4rMdokEeC60axPepSq7g_-945645155")]
    [DisplayName("Net Market Value")]
    [IsoXmlTag("NetMktVal")]
    public AmountAndDirection29? NetMarketValue { get; init; } 
    
    /// <summary>
    /// Remaining nominal value of a security.
    /// </summary>
    [IsoId("_Ak4rMtokEeC60axPepSq7g_-653776665")]
    [DisplayName("Remaining Face Value")]
    [IsoXmlTag("RmngFaceVal")]
    public AmountAndDirection29? RemainingFaceValue { get; init; } 
    
    /// <summary>
    /// Remaining value at which an asset is carried on a balance sheet.
    /// </summary>
    [IsoId("_Ak4rM9okEeC60axPepSq7g_-1340367681")]
    [DisplayName("Remaining Book Value")]
    [IsoXmlTag("RmngBookVal")]
    public AmountAndDirection29? RemainingBookValue { get; init; } 
    
    /// <summary>
    /// Amount of commission paid to a clearing broker.
    /// </summary>
    [IsoId("_Ak4rNNokEeC60axPepSq7g_-1805097640")]
    [DisplayName("Clearing Broker Commission")]
    [IsoXmlTag("ClrBrkrComssn")]
    public AmountAndDirection29? ClearingBrokerCommission { get; init; } 
    
    /// <summary>
    /// Difference between the deal price and another reference price.
    /// </summary>
    [IsoId("_Ak4rNdokEeC60axPepSq7g_-2083089411")]
    [DisplayName("Difference In Price")]
    [IsoXmlTag("DiffInPric")]
    public AmountAndDirection29? DifferenceInPrice { get; init; } 
    
    /// <summary>
    /// Specifies that the odd-lot differential or equivalent fee has been paid by such customer in connection with the execution of an order for an odd-lot number of shares or units (or principal amount) of a security and the fact that the amount of any such differential or fee will be furnished upon oral or written request.
    /// </summary>
    [IsoId("_AlCcMNokEeC60axPepSq7g_-2089465782")]
    [DisplayName("Odd Lot Fee")]
    [IsoXmlTag("OddLotFee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OddLotFee { get; init; } 
    
    
    #nullable disable
    
}
