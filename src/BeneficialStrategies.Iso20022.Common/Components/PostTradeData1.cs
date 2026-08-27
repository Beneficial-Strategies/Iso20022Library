// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Post-trade related data.
/// </summary>
[IsoId("_Mwc6wGIhEfCeoPFCHQnhvA")]
[DisplayName("Post Trade Data1")]
public record PostTradeData1
{
    /// <summary>
    /// Code used to identify the financial instrument.
    /// </summary>
    [IsoId("_Y5ESYGIhEfCeoPFCHQnhvA")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public required IsoISINOct2015Identifier ISIN { get; init; }

    /// <summary>
    /// Date and time when the transaction was executed.
    /// </summary>
    [IsoId("_igwlYGIhEfCeoPFCHQnhvA")]
    [DisplayName("Trading Date Time")]
    [IsoXmlTag("TradgDtTm")]
    public required IsoISODateTime TradingDateTime { get; init; }

    /// <summary>
    /// Data related to the venue where the transaction was executed.
    /// </summary>
    [IsoId("_8vABMITOEfClBYp_xDbOWg")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    public required TradingVenueIdentification4Choice_ TradingVenue { get; init; }

    /// <summary>
    /// Identification of the third-country trading venue where the transaction was executed.
    /// </summary>
    [IsoId("_q5AakITPEfClBYp_xDbOWg")]
    [DisplayName("Third Country Trading Venue Identification")]
    [IsoXmlTag("ThrdCtryTradgVnId")]
    public IsoMICIdentifier? ThirdCountryTradingVenueIdentification { get; init; }

    /// <summary>
    /// Alphanumerical code assigned by trading venues and Approved Publication Arrangements (APAs) and used in any subsequent reference to the underlying trade.
    /// Usage: Only applicable for the Bond Consolidated Tape Provider (CTP).
    /// </summary>
    [IsoId("_hjFKQGIjEfCeoPFCHQnhvA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public IsoMax52Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Number of transactions executed when deferred publication of details of several transactions in an aggregated form is required.
    /// Usage: Only applicable for the Bond Consolidated Tape Provider (CTP).
    /// </summary>
    [IsoId("_GkqmkGIkEfCeoPFCHQnhvA")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    public IsoDecimalNumber? NumberOfTransactions { get; init; }

    /// <summary>
    /// Type of trading system on which the transaction was executed.
    /// </summary>
    [IsoId("_mBqOYGIjEfCeoPFCHQnhvA")]
    [DisplayName("Trading System Type")]
    [IsoXmlTag("TradgSysTp")]
    public required TradingSystemType1Code TradingSystemType { get; init; }

    /// <summary>
    /// Traded price of the transaction excluding, where applicable, commission and accrued interest.
    ///
    /// Usage: Only applicable for the Bond Consolidated Tape Provider (CTP).
    /// </summary>
    [IsoId("_hUI54GIkEfCeoPFCHQnhvA")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public SecuritiesTransactionPrice26Choice_? Price { get; init; }

    /// <summary>
    /// Quantity being executed, when there is a partial or full execution.
    /// Usage: Only applicable for the Equity Consolidated Tape Provider (CTP).
    /// </summary>
    [IsoId("_rgnU8GIkEfCeoPFCHQnhvA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity25Choice_? Quantity { get; init; }

    /// <summary>
    /// Notional amount that is denominated.
    /// Usage: Only applicable for the Bond Consolidated Tape Provider (CTP).
    /// </summary>
    [IsoId("_1KEigGIkEfCeoPFCHQnhvA")]
    [DisplayName("Notional Amount")]
    [IsoXmlTag("NtnlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? NotionalAmount { get; init; }

    /// <summary>
    /// Data related to the transaction published by a contributor.
    /// </summary>
    [IsoId("_MVuJwGIlEfCeoPFCHQnhvA")]
    [DisplayName("Contributor")]
    [IsoXmlTag("Cntrbtr")]
    public required ContributorPublicationData1 Contributor { get; init; }

    /// <summary>
    /// Data related to the Consolidated Tape Provider.
    /// Usage: Only applicable for output data.
    /// </summary>
    [IsoId("_c9D6AGImEfCeoPFCHQnhvA")]
    [DisplayName("Consolidated Tape Provider")]
    [IsoXmlTag("CnsltdTapePrvdr")]
    public ConsolidatedTapeProviderData1? ConsolidatedTapeProvider { get; init; }

    /// <summary>
    /// Flags related to the post-trade related report.
    /// </summary>
    [IsoId("_8sjVIGInEfCeoPFCHQnhvA")]
    [DisplayName("Post Trade Data")]
    [IsoXmlTag("PstTradData")]
    public ValueList<PostTradeData1Choice_> PostTradeData { get; init; } = [];

    /// <summary>
    /// Indicates when the Consolidated Tape Provider (CTP) have identified trades that, in their view, might be subject to data quality issues.
    /// Usage: Only applicable for output data.
    /// </summary>
    [IsoId("_2tIwYGInEfCeoPFCHQnhvA")]
    [DisplayName("Suspicious Data")]
    [IsoXmlTag("SspcsData")]
    public IsoTrueFalseIndicator? SuspiciousData { get; init; }
}
