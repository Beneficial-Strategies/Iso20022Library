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



namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.080.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritesFinancingReportingReconciliationStatusAdvice message is sent by the trade repositories (TRs) ) to other TR and to the authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, to provide a status advice for reconciliation.
/// </summary>
[Description(@"The SecuritesFinancingReportingReconciliationStatusAdvice message is sent by the trade repositories (TRs) ) to other TR and to the authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, to provide a status advice for reconciliation.")]
[IsoId("_2zvMAwuAEeqVvtu9Ny8FDA")]
[DisplayName("Securities Financing Reporting Reconciliation Status Advice V")]
public partial record SecuritiesFinancingReportingReconciliationStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.080.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgRcncltnStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.080.001.01";
    
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
    /// Data concerning the reconciliation results.
    /// </summary>
    [IsoId("_2zvMBQuAEeqVvtu9Ny8FDA")]
    [DisplayName("Reconciliation Data")]
    [IsoXmlTag("RcncltnData")]
    public required TradeData14Choice_ ReconciliationData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2zvMBwuAEeqVvtu9Ny8FDA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since SecuritiesFinancingReportingReconciliationStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesFinancingReportingReconciliationStatusAdviceV01.

