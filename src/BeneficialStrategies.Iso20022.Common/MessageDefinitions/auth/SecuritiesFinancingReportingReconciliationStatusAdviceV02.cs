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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.080.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritesFinancingReportingReconciliationStatusAdvice message is sent by the trade repositories (TRs) ) to other TR and to the authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, to provide a status advice for reconciliation.
/// </summary>
[Description(@"The SecuritesFinancingReportingReconciliationStatusAdvice message is sent by the trade repositories (TRs) ) to other TR and to the authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, to provide a status advice for reconciliation.")]
[IsoId("_gt-cEcKvEeuzU9S_IANlog")]
[DisplayName("Securities Financing Reporting Reconciliation Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancingReportingReconciliationStatusAdviceV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.080.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgRcncltnStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.080.001.02";
    
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
    /// Constructs a SecuritiesFinancingReportingReconciliationStatusAdviceV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesFinancingReportingReconciliationStatusAdviceV02( TradeData34Choice_ reqReconciliationData )
    {
        ReconciliationData = reqReconciliationData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of data concerning the reconciliation results.
    /// </summary>
    [IsoId("_gt-cE8KvEeuzU9S_IANlog")]
    [DisplayName("Reconciliation Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnData")]
    #endif
    [IsoXmlTag("RcncltnData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeData34Choice_ ReconciliationData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeData34Choice_ ReconciliationData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeData34Choice_ ReconciliationData { get; init; } 
    #else
    public TradeData34Choice_ ReconciliationData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_gt-cFcKvEeuzU9S_IANlog")]
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


// Since SecuritiesFinancingReportingReconciliationStatusAdviceV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesFinancingReportingReconciliationStatusAdviceV02.

