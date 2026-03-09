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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TripartyCollateralAndExposureReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TripartyCollateralAndExposureReportV01( Pagination1 reqPagination,Statement78 reqStatementGeneralDetails,CollateralParties9 reqCollateralParties )
    {
        Pagination = reqPagination;
        StatementGeneralDetails = reqStatementGeneralDetails;
        CollateralParties = reqCollateralParties;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_2uaM2Ss7EeySlt9bF77XfA")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination1 Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination1 Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1 Pagination { get; init; } 
    #else
    public Pagination1 Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Provides general information on the report.
    /// </summary>
    [IsoId("_2uaM2ys7EeySlt9bF77XfA")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement78 StatementGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Statement78 StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement78 StatementGeneralDetails { get; init; } 
    #else
    public Statement78 StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of collateral parties.
    /// </summary>
    [IsoId("_2uaM3Ss7EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPties")]
    #endif
    [IsoXmlTag("CollPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralParties9 CollateralParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralParties9 CollateralParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralParties9 CollateralParties { get; init; } 
    #else
    public CollateralParties9 CollateralParties { get; set; } 
    #endif
    
    /// <summary>
    /// Overall Collateral  contains the global collateral status of all transactions covered in the message, in the reporting currency, that is, the total of the exposure amount, of the posted collateral, of the margin amounts, of the accrued interest, of the fees or commissions and of the principals. In addition, it provides collateral-specific information.
    /// </summary>
    [IsoId("_2uaM3ys7EeySlt9bF77XfA")]
    [DisplayName("Overall Collateral Aggregation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrllCollAggtn")]
    #endif
    [IsoXmlTag("OvrllCollAggtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OverallCollateralDetails2? OverallCollateralAggregation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OverallCollateralDetails2? OverallCollateralAggregation { get; init; } 
    #else
    public OverallCollateralDetails2? OverallCollateralAggregation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the valuation details per exposure type aggregation.
    /// </summary>
    [IsoId("_2uaM4Ss7EeySlt9bF77XfA")]
    [DisplayName("Exposure Type Aggregation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTpAggtn")]
    #endif
    [IsoXmlTag("XpsrTpAggtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureTypeAggregation3? ExposureTypeAggregation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureTypeAggregation3? ExposureTypeAggregation { get; init; } 
    #else
    public ExposureTypeAggregation3? ExposureTypeAggregation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the valuation details per counterparty aggregation.
    /// </summary>
    [IsoId("_2uaM4ys7EeySlt9bF77XfA")]
    [DisplayName("Counterparty Aggregation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyAggtn")]
    #endif
    [IsoXmlTag("CtrPtyAggtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CounterpartyAggregation3? CounterpartyAggregation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyAggregation3? CounterpartyAggregation { get; init; } 
    #else
    public CounterpartyAggregation3? CounterpartyAggregation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the transaction,  the collateral and related valuation details.
    /// </summary>
    [IsoId("_2uaM5Ss7EeySlt9bF77XfA")]
    [DisplayName("Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Txs")]
    #endif
    [IsoXmlTag("Txs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Transaction124? Transactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction124? Transactions { get; init; } 
    #else
    public Transaction124? Transactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total valuation amounts provided in the base currency of the account
    /// </summary>
    [IsoId("_2uaM5ys7EeySlt9bF77XfA")]
    [DisplayName("Account Base Currency Total Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctBaseCcyTtlAmts")]
    #endif
    [IsoXmlTag("AcctBaseCcyTtlAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalValueInPageAndStatement5? AccountBaseCurrencyTotalAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalValueInPageAndStatement5? AccountBaseCurrencyTotalAmounts { get; init; } 
    #else
    public TotalValueInPageAndStatement5? AccountBaseCurrencyTotalAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2uaM6Ss7EeySlt9bF77XfA")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since TripartyCollateralAndExposureReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralAndExposureReportV01.

