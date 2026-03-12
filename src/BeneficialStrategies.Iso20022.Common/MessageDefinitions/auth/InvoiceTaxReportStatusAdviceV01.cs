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
/// This record is an implementation of the auth.038.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The InvoiceTaxReportStatusAdvice message is sent by the matching application to the party from which it received a message.
/// This message is used to acknowledge the InvoiceTaxReport message.
/// </summary>
[Description(@"The InvoiceTaxReportStatusAdvice message is sent by the matching application to the party from which it received a message.|This message is used to acknowledge the InvoiceTaxReport message.")]
[IsoId("_HjF1skshEeWvyKllQkSXyA")]
[DisplayName("Invoice Tax Report Status Advice V")]
public partial record InvoiceTaxReportStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.038.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcTaxRptStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.038.001.01";
    
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
    /// Provides the status on the InvoiceTaxReport.
    /// </summary>
    [IsoId("_uitmYE53Eeaine-lsNAGsA")]
    [DisplayName("Status Report Header")]
    [IsoXmlTag("StsRptHdr")]
    public required InvoiceTaxStatusReportHeader1 StatusReportHeader { get; init; } 
    
    /// <summary>
    /// Provides the status on an individual transaction and the related reason if required.
    /// </summary>
    [IsoId("_PM8n8E54Eeaine-lsNAGsA")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public InvoiceTaxReportTransactionStatus1? TransactionStatus { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific
    /// block.
    /// </summary>
    [IsoId("_XlusIE2ZEea-HpmqkM55Lg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since InvoiceTaxReportStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoiceTaxReportStatusAdviceV01.

