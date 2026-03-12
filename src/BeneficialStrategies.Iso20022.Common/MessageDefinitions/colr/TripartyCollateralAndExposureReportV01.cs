// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.022.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// This message is sent by a triparty agent to both the collateral giver and the collateral taker or to an account servicer, who manage the account at the triparty agent on behalf of a trading party, in the following circumstances:
/// - after all collateral movements have been affected (after settlement-initiated) to show the end (fixed) positions (current status) or,
/// - taking into account all collateral management instructions (including pending initiation and/or initiated.
/// 
/// Usage:
/// This message is sent to provide the details of the valuation of both the collateral and the exposure.
/// </summary>
[Description(@"Scope:|This message is sent by a triparty agent to both the collateral giver and the collateral taker or to an account servicer, who manage the account at the triparty agent on behalf of a trading party, in the following circumstances:|- after all collateral movements have been affected (after settlement-initiated) to show the end (fixed) positions (current status) or,|- taking into account all collateral management instructions (including pending initiation and/or initiated.||Usage:|This message is sent to provide the details of the valuation of both the collateral and the exposure.")]
[IsoId("_2uaM0Ss7EeySlt9bF77XfA")]
[DisplayName("Triparty Collateral And Exposure Report V")]
public partial record TripartyCollateralAndExposureReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.022.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollAndXpsrRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.022.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_2uaM2Ss7EeySlt9bF77XfA")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; } 
    
    /// <summary>
    /// Provides general information on the report.
    /// </summary>
    [IsoId("_2uaM2ys7EeySlt9bF77XfA")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement78 StatementGeneralDetails { get; init; } 
    
    /// <summary>
    /// Identifies the chain of collateral parties.
    /// </summary>
    [IsoId("_2uaM3Ss7EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    [IsoXmlTag("CollPties")]
    public required CollateralParties9 CollateralParties { get; init; } 
    
    /// <summary>
    /// Overall Collateral  contains the global collateral status of all transactions covered in the message, in the reporting currency, that is, the total of the exposure amount, of the posted collateral, of the margin amounts, of the accrued interest, of the fees or commissions and of the principals. In addition, it provides collateral-specific information.
    /// </summary>
    [IsoId("_2uaM3ys7EeySlt9bF77XfA")]
    [DisplayName("Overall Collateral Aggregation")]
    [IsoXmlTag("OvrllCollAggtn")]
    public OverallCollateralDetails2? OverallCollateralAggregation { get; init; } 
    
    /// <summary>
    /// Specifies the valuation details per exposure type aggregation.
    /// </summary>
    [IsoId("_2uaM4Ss7EeySlt9bF77XfA")]
    [DisplayName("Exposure Type Aggregation")]
    [IsoXmlTag("XpsrTpAggtn")]
    public ExposureTypeAggregation3? ExposureTypeAggregation { get; init; } 
    
    /// <summary>
    /// Specifies the valuation details per counterparty aggregation.
    /// </summary>
    [IsoId("_2uaM4ys7EeySlt9bF77XfA")]
    [DisplayName("Counterparty Aggregation")]
    [IsoXmlTag("CtrPtyAggtn")]
    public CounterpartyAggregation3? CounterpartyAggregation { get; init; } 
    
    /// <summary>
    /// Specifies the transaction,  the collateral and related valuation details.
    /// </summary>
    [IsoId("_2uaM5Ss7EeySlt9bF77XfA")]
    [DisplayName("Transactions")]
    [IsoXmlTag("Txs")]
    public Transaction124? Transactions { get; init; } 
    
    /// <summary>
    /// Total valuation amounts provided in the base currency of the account
    /// </summary>
    [IsoId("_2uaM5ys7EeySlt9bF77XfA")]
    [DisplayName("Account Base Currency Total Amounts")]
    [IsoXmlTag("AcctBaseCcyTtlAmts")]
    public TotalValueInPageAndStatement5? AccountBaseCurrencyTotalAmounts { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2uaM6Ss7EeySlt9bF77XfA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since TripartyCollateralAndExposureReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralAndExposureReportV01.

