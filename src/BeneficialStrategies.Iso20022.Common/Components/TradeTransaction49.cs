// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the trade transaction.
/// </summary>
[IsoId("_fVX4YWEfEe2P-L9DBerEgA")]
[DisplayName("Trade Transaction")]
public record TradeTransaction49
{
    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier as agreed with the counterparty.
    /// </summary>
    [IsoId("_fWRQQWEfEe2P-L9DBerEgA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; init; }

    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier assigned to the predecessor transaction that has given rise to the reported transaction due to a lifecycle event.
    /// |
    /// Usage: This data element is not applicable when reporting many-to-one and many-to-many relations between transactions (for example, in the case of a compression).
    /// This data element may be applicable when reporting one-to-one and one-to-many relations between transactions (for example, in the case of a clearing).|
    /// </summary>
    [IsoId("_fWRQQ2EfEe2P-L9DBerEgA")]
    [DisplayName("Prior Transaction Identification")]
    [IsoXmlTag("PrrTxId")]
    public UniqueTransactionIdentifier3Choice_? PriorTransactionIdentification { get; init; }

    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier of the position in which a derivative is included. This field is applicable only for the reports related to the termination of a derivative due to its inclusion in a position. |
    /// </summary>
    [IsoId("_fWRQRWEfEe2P-L9DBerEgA")]
    [DisplayName("Subsequent Transaction Identification")]
    [IsoXmlTag("SbsqntTxId")]
    public UniqueTransactionIdentifier3Choice_? SubsequentTransactionIdentification { get; init; }

    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// </summary>
    [IsoId("_fWRQR2EfEe2P-L9DBerEgA")]
    [DisplayName("Collateral Portfolio Code")]
    [IsoXmlTag("CollPrtflCd")]
    public CollateralPortfolioCode5Choice_? CollateralPortfolioCode { get; init; }

    /// <summary>
    /// Unique number to indicate a group of reports which relate to the same execution.
    /// </summary>
    [IsoId("_fWRQSWEfEe2P-L9DBerEgA")]
    [DisplayName("Report Tracking Number")]
    [IsoXmlTag("RptTrckgNb")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? ReportTrackingNumber { get; init; }

    /// <summary>
    /// Identifies the trading platform on which the derivative transaction was executed (for example, exchange, multilateral trading facility, swap execution facility).
    /// Usage: For transactions where no trading facility was involved, specific predefined codes have to be used.
    /// </summary>
    [IsoId("_fWRQS2EfEe2P-L9DBerEgA")]
    [DisplayName("Platform Identifier")]
    [IsoXmlTag("PltfmIdr")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? PlatformIdentifier { get; init; }

    /// <summary>
    /// Indicates whether the derivative transaction satisfies the definition of mirror transaction or trigger transaction.
    /// Usage: If the element is not present, the MirrorOrTriggerTransaction is False.
    /// </summary>
    [IsoId("_fWRQTWEfEe2P-L9DBerEgA")]
    [DisplayName("Mirror Or Trigger Transaction")]
    [IsoXmlTag("MrrrOrTrggrTx")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MirrorOrTriggerTransaction { get; init; }

    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    [IsoId("_fWRQT2EfEe2P-L9DBerEgA")]
    [DisplayName("Transaction Price")]
    [IsoXmlTag("TxPric")]
    public PriceData2? TransactionPrice { get; init; }

    /// <summary>
    /// Indicates monetary or converted amount for the derivatives transaction.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [IsoId("_fWRQUWEfEe2P-L9DBerEgA")]
    [DisplayName("Notional Amount")]
    [IsoXmlTag("NtnlAmt")]
    public NotionalAmountLegs5? NotionalAmount { get; init; }

    /// <summary>
    /// Indicates for each leg of the transaction the total notional quantity of the underlying asset for the term of the transaction.|
    /// </summary>
    [IsoId("_fWRQU2EfEe2P-L9DBerEgA")]
    [DisplayName("Notional Quantity")]
    [IsoXmlTag("NtnlQty")]
    public NotionalQuantityLegs5? NotionalQuantity { get; init; }

    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [IsoId("_fWRQVWEfEe2P-L9DBerEgA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity32Choice_? Quantity { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is settled physically or in cash or decided at expiration time by counterparty.
    /// </summary>
    [IsoId("_fWRQV2EfEe2P-L9DBerEgA")]
    [DisplayName("Delivery Type")]
    [IsoXmlTag("DlvryTp")]
    public PhysicalTransferType4Code? DeliveryType { get; init; }

    /// <summary>
    /// Indicates the date and time of the execution of the derivative transaction.
    /// </summary>
    [IsoId("_fWRQWWEfEe2P-L9DBerEgA")]
    [DisplayName("Execution Time Stamp")]
    [IsoXmlTag("ExctnTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExecutionTimeStamp { get; init; }

    /// <summary>
    /// Indicates the date when obligations under the contract come into effect.
    /// </summary>
    [IsoId("_fWRQW2EfEe2P-L9DBerEgA")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EffectiveDate { get; init; }

    /// <summary>
    /// Indicates the unadjusted date at which obligations under the derivative transaction stop being effective, as included in the confirmation.
    /// |
    /// For European style options, date on which the holder can exercise the right or let it lapse.|
    /// For American style options, the holder can exercise the right up to the expiry date.
    /// |
    /// Usage:
    /// An early termination shall not be reported in this field.
    /// </summary>
    [IsoId("_fWRQXWEfEe2P-L9DBerEgA")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpirationDate { get; init; }

    /// <summary>
    /// Indicates the effective date of the early termination of the reported derivative transaction.
    /// </summary>
    [IsoId("_fWRQX2EfEe2P-L9DBerEgA")]
    [DisplayName("Early Termination Date")]
    [IsoXmlTag("EarlyTermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EarlyTerminationDate { get; init; }

    /// <summary>
    /// Indicates the unadjusted date, as per the contract, by which all transfer of cash or assets should take place and the counterparties should no longer have any outstanding obligations to each other.||
    /// For products that may not have a final contractual settlement date (eg American options), this data element reflects the date by which the transfer of cash or asset would take place if termination were to occur on the expiration date.
    /// </summary>
    [IsoId("_fWRQYWEfEe2P-L9DBerEgA")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public SimpleValueList<IsoISODate> SettlementDate { get; init; } = [];

    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("_fWRQZWEfEe2P-L9DBerEgA")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement8? MasterAgreement { get; init; }

    /// <summary>
    /// Identifies whether the contract results from a compression operation or not.
    /// Usage: If the element is not present, the Compression is False.
    /// </summary>
    [IsoId("_fWRQZ2EfEe2P-L9DBerEgA")]
    [DisplayName("Compression")]
    [IsoXmlTag("Cmprssn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Compression { get; init; }

    /// <summary>
    /// Indicates whether the contract results from a PTRR operation.
    /// </summary>
    [IsoId("_fWRQaWEfEe2P-L9DBerEgA")]
    [DisplayName("Post Trade Risk Reduction Flag")]
    [IsoXmlTag("PstTradRskRdctnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PostTradeRiskReductionFlag { get; init; }

    /// <summary>
    /// Identify whether the contract results from a Post Trade Risk Reduction operation.
    /// </summary>
    [IsoId("_fWRQa2EfEe2P-L9DBerEgA")]
    [DisplayName("Post Trade Risk Reduction Event")]
    [IsoXmlTag("PstTradRskRdctnEvt")]
    public PTRREvent2? PostTradeRiskReductionEvent { get; init; }

    /// <summary>
    /// Indication of the derivative event of the transaction.
    /// </summary>
    [IsoId("_fWRQbWEfEe2P-L9DBerEgA")]
    [DisplayName("Derivative Event")]
    [IsoXmlTag("DerivEvt")]
    public DerivativeEvent6? DerivativeEvent { get; init; }

    /// <summary>
    /// Specifies whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed.
    /// </summary>
    [IsoId("_fWRQb2EfEe2P-L9DBerEgA")]
    [DisplayName("Trade Confirmation")]
    [IsoXmlTag("TradConf")]
    public TradeConfirmation1Choice_? TradeConfirmation { get; init; }

    /// <summary>
    /// Indicates whether the derivative transaction has one or more additional terms or provisions that materially affect the price of the transaction.
    /// Usage: If the element is not present, the NonStandardisedTerm is False.
    /// </summary>
    [IsoId("_fWRQcWEfEe2P-L9DBerEgA")]
    [DisplayName("Non Standardised Term")]
    [IsoXmlTag("NonStdsdTerm")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NonStandardisedTerm { get; init; }

    /// <summary>
    /// Information related to clearing of the reported contract.
    /// </summary>
    [IsoId("_fWRQc2EfEe2P-L9DBerEgA")]
    [DisplayName("Trade Clearing")]
    [IsoXmlTag("TradClr")]
    public TradeClearing11? TradeClearing { get; init; }

    /// <summary>
    /// Indicates whether an election has been made to report the derivative transaction as a block transaction.
    /// Usage: If the element is not present, the BlockTradeElection is False.
    /// </summary>
    [IsoId("_fWRQdWEfEe2P-L9DBerEgA")]
    [DisplayName("Block Trade Election")]
    [IsoXmlTag("BlckTradElctn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BlockTradeElection { get; init; }

    /// <summary>
    /// Indicates whether an election has been made to report the derivative transaction as a large notional off-facility transaction.
    /// Usage: If the element is not present, the LargeNotionalOffFacilityElection is False.
    /// </summary>
    [IsoId("_fWRQd2EfEe2P-L9DBerEgA")]
    [DisplayName("Large Notional Off Facility Election")]
    [IsoXmlTag("LrgNtnlOffFcltyElctn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LargeNotionalOffFacilityElection { get; init; }

    /// <summary>
    /// Information related to interest rate asset class type.
    /// </summary>
    [IsoId("_fWRQeWEfEe2P-L9DBerEgA")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRateLegs14? InterestRate { get; init; }

    /// <summary>
    /// Information related to currency asset class type.
    /// </summary>
    [IsoId("_fWRQe2EfEe2P-L9DBerEgA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyExchange22? Currency { get; init; }

    /// <summary>
    /// Information related to commodity asset class type.
    /// </summary>
    [IsoId("_fWRQfWEfEe2P-L9DBerEgA")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public AssetClassCommodity6Choice_? Commodity { get; init; }

    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_fWRQf2EfEe2P-L9DBerEgA")]
    [DisplayName("Option")]
    [IsoXmlTag("Optn")]
    public OptionOrSwaption10? Option { get; init; }

    /// <summary>
    /// Attributes specific for derivative contracts related to natural gas and electricity.
    /// </summary>
    [IsoId("_fWRQgWEfEe2P-L9DBerEgA")]
    [DisplayName("Energy Specific Attributes")]
    [IsoXmlTag("NrgySpcfcAttrbts")]
    public EnergySpecificAttribute9? EnergySpecificAttributes { get; init; }

    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_fWRQg2EfEe2P-L9DBerEgA")]
    [DisplayName("Credit")]
    [IsoXmlTag("Cdt")]
    public CreditDerivative4? Credit { get; init; }

    /// <summary>
    /// Payment related to elements not reported in dedicated fields.
    /// </summary>
    [IsoId("_fWRQhWEfEe2P-L9DBerEgA")]
    [DisplayName("Other Payment")]
    [IsoXmlTag("OthrPmt")]
    public ValueList<OtherPayment5> OtherPayment { get; init; } = [];

    /// <summary>
    /// A combination of two or more transactions that are reported separately but that are negotiated together as the product of a single economic agreement.
    /// </summary>
    [IsoId("_fWRQh2EfEe2P-L9DBerEgA")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public Package4? Package { get; init; }

    /// <summary>
    /// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
    /// </summary>
    [IsoId("_fWRQiWEfEe2P-L9DBerEgA")]
    [DisplayName("Trade Allocation Status")]
    [IsoXmlTag("TradAllcnSts")]
    public AllocationIndicator1Code? TradeAllocationStatus { get; init; }
}
