// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Regulatory Reporting8.
/// </summary>
[IsoId("_Fm7PkUjrEe-KhcStGV4xTg")]
[DisplayName("Regulatory Reporting8")]
public record RegulatoryReporting8
{
    /// <summary>
    /// Additional Reporting Information.
    /// </summary>
    [DisplayName("Additional Reporting Information")]
    [IsoXmlTag("AddtlRptgInf")]
    public IsoMax210Text? AdditionalReportingInformation { get; init; }

    /// <summary>
    /// Allocation Indicator.
    /// </summary>
    [DisplayName("Allocation Indicator")]
    [IsoXmlTag("AllcnInd")]
    public AllocationIndicator1Code? AllocationIndicator { get; init; }

    /// <summary>
    /// Central Counterparty Clearing House.
    /// </summary>
    [DisplayName("Central Counterparty Clearing House")]
    [IsoXmlTag("CntrlCtrPtyClrHs")]
    public PartyIdentification242Choice_? CentralCounterpartyClearingHouse { get; init; }

    /// <summary>
    /// Cleared Product Identification.
    /// </summary>
    [DisplayName("Cleared Product Identification")]
    [IsoXmlTag("ClrdPdctId")]
    public IsoMax35Text? ClearedProductIdentification { get; init; }

    /// <summary>
    /// Clearing Broker.
    /// </summary>
    [DisplayName("Clearing Broker")]
    [IsoXmlTag("ClrBrkr")]
    public PartyIdentification242Choice_? ClearingBroker { get; init; }

    /// <summary>
    /// Clearing Broker Identification.
    /// </summary>
    [DisplayName("Clearing Broker Identification")]
    [IsoXmlTag("ClrBrkrId")]
    public ClearingBrokerIdentification1? ClearingBrokerIdentification { get; init; }

    /// <summary>
    /// Clearing Exception Party.
    /// </summary>
    [DisplayName("Clearing Exception Party")]
    [IsoXmlTag("ClrXcptnPty")]
    public PartyIdentification242Choice_? ClearingExceptionParty { get; init; }

    /// <summary>
    /// Clearing Threshold Indicator.
    /// </summary>
    [DisplayName("Clearing Threshold Indicator")]
    [IsoXmlTag("ClrThrshldInd")]
    public IsoYesNoIndicator? ClearingThresholdIndicator { get; init; }

    /// <summary>
    /// Clearing Timestamp.
    /// </summary>
    [DisplayName("Clearing Timestamp")]
    [IsoXmlTag("ClrTmstmp")]
    public IsoISOTime? ClearingTimestamp { get; init; }

    /// <summary>
    /// Collateralisation Indicator.
    /// </summary>
    [DisplayName("Collateralisation Indicator")]
    [IsoXmlTag("CollstnInd")]
    public CollateralisationIndicator1Code? CollateralisationIndicator { get; init; }

    /// <summary>
    /// Collateral Portfolio Code.
    /// </summary>
    [DisplayName("Collateral Portfolio Code")]
    [IsoXmlTag("CollPrtflCd")]
    public IsoMax10Text? CollateralPortfolioCode { get; init; }

    /// <summary>
    /// Collateral Portfolio Indicator.
    /// </summary>
    [DisplayName("Collateral Portfolio Indicator")]
    [IsoXmlTag("CollPrtflInd")]
    public IsoYesNoIndicator? CollateralPortfolioIndicator { get; init; }

    /// <summary>
    /// Commercial Or Treasury Financing Indicator.
    /// </summary>
    [DisplayName("Commercial Or Treasury Financing Indicator")]
    [IsoXmlTag("ComrclOrTrsrFincgInd")]
    public IsoYesNoIndicator? CommercialOrTreasuryFinancingIndicator { get; init; }

    /// <summary>
    /// Commissions And Fees.
    /// </summary>
    [DisplayName("Commissions And Fees")]
    [IsoXmlTag("ComssnsAndFees")]
    public ValueList<FXCommissionOrFee1> CommissionsAndFees { get; init; } = [];

    /// <summary>
    /// Confirmation Date And Timestamp.
    /// </summary>
    [DisplayName("Confirmation Date And Timestamp")]
    [IsoXmlTag("ConfDtAndTmstmp")]
    public IsoISODateTime? ConfirmationDateAndTimestamp { get; init; }

    /// <summary>
    /// Corporate Sector Indicator.
    /// </summary>
    [DisplayName("Corporate Sector Indicator")]
    [IsoXmlTag("CorpSctrInd")]
    public CorporateSectorIdentifier1Code? CorporateSectorIndicator { get; init; }

    /// <summary>
    /// Counterparty Side Transaction Reporting.
    /// </summary>
    [DisplayName("Counterparty Side Transaction Reporting")]
    [IsoXmlTag("CtrPtySdTxRptg")]
    public ValueList<CounterpartySideTransactionReporting3> CounterpartySideTransactionReporting { get; init; } =
        [];

    /// <summary>
    /// Execution Timestamp.
    /// </summary>
    [DisplayName("Execution Timestamp")]
    [IsoXmlTag("ExctnTmstmp")]
    public DateAndDateTime2Choice_? ExecutionTimestamp { get; init; }

    /// <summary>
    /// Execution Venue.
    /// </summary>
    [DisplayName("Execution Venue")]
    [IsoXmlTag("ExctnVn")]
    public IsoMax35Text? ExecutionVenue { get; init; }

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Financial Nature Of The Counterparty Indicator.
    /// </summary>
    [DisplayName("Financial Nature Of The Counterparty Indicator")]
    [IsoXmlTag("FinNtrOfTheCtrPtyInd")]
    public IsoYesNoIndicator? FinancialNatureOfTheCounterpartyIndicator { get; init; }

    /// <summary>
    /// Intragroup Trade Indicator.
    /// </summary>
    [DisplayName("Intragroup Trade Indicator")]
    [IsoXmlTag("NtrgrpTradInd")]
    public IsoYesNoIndicator? IntragroupTradeIndicator { get; init; }

    /// <summary>
    /// Link Swap Identification.
    /// </summary>
    [DisplayName("Link Swap Identification")]
    [IsoXmlTag("LkSwpId")]
    public IsoExact42Text? LinkSwapIdentification { get; init; }

    /// <summary>
    /// Non Standard Flag.
    /// </summary>
    [DisplayName("Non Standard Flag")]
    [IsoXmlTag("NonStdFlg")]
    public IsoYesNoIndicator? NonStandardFlag { get; init; }

    /// <summary>
    /// Portfolio Compression Indicator.
    /// </summary>
    [DisplayName("Portfolio Compression Indicator")]
    [IsoXmlTag("PrtflCmprssnInd")]
    public IsoYesNoIndicator? PortfolioCompressionIndicator { get; init; }

    /// <summary>
    /// Product Identifier.
    /// </summary>
    [DisplayName("Product Identifier")]
    [IsoXmlTag("PdctIdr")]
    public ProductIdentifier3Choice_? ProductIdentifier { get; init; }

    /// <summary>
    /// Trade With Non EEA Counterparty Indicator.
    /// </summary>
    [DisplayName("Trade With Non EEA Counterparty Indicator")]
    [IsoXmlTag("TradWthNonEEACtrPtyInd")]
    public IsoYesNoIndicator? TradeWithNonEEACounterpartyIndicator { get; init; }

    /// <summary>
    /// Trading Side Transaction Reporting.
    /// </summary>
    [DisplayName("Trading Side Transaction Reporting")]
    [IsoXmlTag("TradgSdTxRptg")]
    public ValueList<TradingSideTransactionReporting3> TradingSideTransactionReporting { get; init; } =
        [];
}
