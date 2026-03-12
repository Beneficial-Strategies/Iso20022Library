// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
/// </summary>
[IsoId("_R6YAANp-Ed-ak6NoX_4Aeg_-1110016344")]
[DisplayName("Investment Fund Transaction")]
public partial record InvestmentFundTransaction3
{
    #nullable enable
    
    /// <summary>
    /// Type of investment fund transaction.
    /// </summary>
    [IsoId("_R6YAAdp-Ed-ak6NoX_4Aeg_-1110016318")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required TransactionType2Code TransactionType { get; init; } 
    
    /// <summary>
    /// Type of investment fund transaction.
    /// </summary>
    [IsoId("_R6YAAtp-Ed-ak6NoX_4Aeg_-1995999534")]
    [DisplayName("Extended Transaction Type")]
    [IsoXmlTag("XtndedTxTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedTransactionType { get; init; } 
    
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_R6YAA9p-Ed-ak6NoX_4Aeg_-1110016302")]
    [DisplayName("Corporate Action Event Type")]
    [IsoXmlTag("CorpActnEvtTp")]
    public required CorporateActionEventType1Code CorporateActionEventType { get; init; } 
    
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_R6YABNp-Ed-ak6NoX_4Aeg_-2098509833")]
    [DisplayName("Extended Corporate Action Event Type")]
    [IsoXmlTag("XtndedCorpActnEvtTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedCorporateActionEventType { get; init; } 
    
    /// <summary>
    /// Status of an investment fund transaction.
    /// </summary>
    [IsoId("_R6YABdp-Ed-ak6NoX_4Aeg_-1110016284")]
    [DisplayName("Booking Status")]
    [IsoXmlTag("BookgSts")]
    public TransactionStatus1Code? BookingStatus { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_R6YABtp-Ed-ak6NoX_4Aeg_-1109096270")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Unique identifier for an order, as assigned by the sell-side. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_R6hJ8Np-Ed-ak6NoX_4Aeg_-1109096218")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OrderReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_R6hJ8dp-Ed-ak6NoX_4Aeg_1168308444")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_R6hJ8tp-Ed-ak6NoX_4Aeg_-1109096140")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DealReference { get; init; } 
    
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_R6hJ89p-Ed-ak6NoX_4Aeg_-1109096098")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LegIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for an instance of a leg execution within a switch confirmation.
    /// </summary>
    [IsoId("_R6hJ9Np-Ed-ak6NoX_4Aeg_-1109095588")]
    [DisplayName("Leg Execution Identification")]
    [IsoXmlTag("LegExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LegExecutionIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_R6hJ9dp-Ed-ak6NoX_4Aeg_-1109096080")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash payment with respect to the executed order is settled.
    /// </summary>
    [IsoId("_R6hJ9tp-Ed-ak6NoX_4Aeg_-1109096045")]
    [DisplayName("Settled Transaction Indicator")]
    [IsoXmlTag("SttldTxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SettledTransactionIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the executed order has a registered status on the books of the transfer agent.
    /// </summary>
    [IsoId("_R6hJ99p-Ed-ak6NoX_4Aeg_-1109096020")]
    [DisplayName("Registered Transaction Indicator")]
    [IsoXmlTag("RegdTxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator RegisteredTransactionIndicator { get; init; } 
    
    /// <summary>
    /// Number of investment funds units.
    /// </summary>
    [IsoId("_R6hJ-Np-Ed-ak6NoX_4Aeg_-1109096003")]
    [DisplayName("Units Quantity")]
    [IsoXmlTag("UnitsQty")]
    public required FinancialInstrumentQuantity1 UnitsQuantity { get; init; } 
    
    /// <summary>
    /// Direction of the transaction being reported, ie, securities are received (credited) or delivered (debited).
    /// </summary>
    [IsoId("_R6hJ-dp-Ed-ak6NoX_4Aeg_-1109095985")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public required CreditDebitCode CreditDebit { get; init; } 
    
    /// <summary>
    /// Transaction being reported is a reversal of previously reported transaction.
    /// </summary>
    [IsoId("_R6q68Np-Ed-ak6NoX_4Aeg_-1109095743")]
    [DisplayName("Reversal")]
    [IsoXmlTag("Rvsl")]
    public ReversalCode? Reversal { get; init; } 
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_R6q68dp-Ed-ak6NoX_4Aeg_-1109095726")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    
    /// <summary>
    /// Date on which the debtor expects the amount of money to be available to the creditor.
    /// </summary>
    [IsoId("_R6q68tp-Ed-ak6NoX_4Aeg_-1109095691")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; } 
    
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_R6q689p-Ed-ak6NoX_4Aeg_-1109095673")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    
    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_R6q69Np-Ed-ak6NoX_4Aeg_-1109095631")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the order has been partially executed, ie, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("_R6q69dp-Ed-ak6NoX_4Aeg_-1109095613")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; } 
    
    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_R6q69tp-Ed-ak6NoX_4Aeg_-1109095303")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public UnitPrice11? PriceDetails { get; init; } 
    
    
    #nullable disable
    
}
