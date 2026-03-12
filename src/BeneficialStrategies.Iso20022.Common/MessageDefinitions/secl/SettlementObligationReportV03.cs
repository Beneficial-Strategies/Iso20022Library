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



namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// This record is an implementation of the secl.010.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SettlementObligationReport message is sent by the central counterparty (CCP) to a clearing member to report on the settlement obligation that will be submitted for settlement.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// The SettlementObligationReport message may also be sent to a third party processing the settlement obligation(s) on behalf of more than one clearing member.
/// The Settlement Obligation Report message is provided per delivery account and per instrument. The report can be provided for one specific delivering party or one specific receiving party. It can also be generated per non clearing member.
/// </summary>
[Description(@"Scope|The SettlementObligationReport message is sent by the central counterparty (CCP) to a clearing member to report on the settlement obligation that will be submitted for settlement.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The SettlementObligationReport message may also be sent to a third party processing the settlement obligation(s) on behalf of more than one clearing member.|The Settlement Obligation Report message is provided per delivery account and per instrument. The report can be provided for one specific delivering party or one specific receiving party. It can also be generated per non clearing member.")]
[IsoId("_suRVUS9dEeS94oXWDaBauA")]
[DisplayName("Settlement Obligation Report V")]
public partial record SettlementObligationReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.010.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SttlmOblgtnRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.010.001.03";
    
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
    /// Provides details about the report such as the report identification, the creation date and time.
    /// </summary>
    [IsoId("_suRVUy9dEeS94oXWDaBauA")]
    [DisplayName("Report Parameters")]
    [IsoXmlTag("RptParams")]
    public required ReportParameters4 ReportParameters { get; init; } 
    
    /// <summary>
    /// Page number of the message (within a report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_suRVVS9dEeS94oXWDaBauA")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination Pagination { get; init; } 
    
    /// <summary>
    /// Provides the identification of the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_suRVVy9dEeS94oXWDaBauA")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public PartyIdentification35Choice_? ClearingMember { get; init; } 
    
    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows Clearing Member Firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, Clearing Member Firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_suRVWS9dEeS94oXWDaBauA")]
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    
    /// <summary>
    /// Provides the identification of the account used for netting. This is an account opened by the central counterparty in the name of the clearing member or its settlement agent within the account structure, for settlement purposes (gives information about the clearing member/its settlement agent account at the central securities depository).
    /// </summary>
    [IsoId("_suRVWy9dEeS94oXWDaBauA")]
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; } 
    
    /// <summary>
    /// Provides details on the settlement obligation report.
    /// </summary>
    [IsoId("_suRVXS9dEeS94oXWDaBauA")]
    [DisplayName("Report Details")]
    [IsoXmlTag("RptDtls")]
    public required Report5 ReportDetails { get; init; } 
    
    /// <summary>
    /// Provides details about the receiving parties involved in the settlement chain.
    /// </summary>
    [IsoId("_suRVXy9dEeS94oXWDaBauA")]
    [DisplayName("Settlement Parties")]
    [IsoXmlTag("SttlmPties")]
    public SettlementParties2Choice_? SettlementParties { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_suRVYS9dEeS94oXWDaBauA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since SettlementObligationReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SettlementObligationReportV03.

