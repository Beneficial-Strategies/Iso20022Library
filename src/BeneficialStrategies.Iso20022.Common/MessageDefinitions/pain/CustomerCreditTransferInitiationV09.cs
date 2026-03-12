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



namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.001.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerCreditTransferInitiation message is sent by the initiating party to the forwarding agent or debtor agent. It is used to request movement of funds from the debtor account to a creditor.
/// Usage
/// The CustomerCreditTransferInitiation message can contain one or more customer credit transfer instructions.
/// The CustomerCreditTransferInitiation message is used to exchange:
/// - One or more instances of a credit transfer initiation;
/// - Payment transactions that result in book transfers at the debtor agent or payments to another financial institution;
/// - Payment transactions that result in an electronic cash transfer to the creditor account or in the emission of a cheque.
/// The message can be used in a direct or a relay scenario:
/// - In a direct scenario, the message is sent directly to the debtor agent. The debtor agent is the account servicer of the debtor.
/// - In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerCreditTransferInitiation message to the debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the debtor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.
/// The CustomerCreditTransferInitiation message can be used in domestic and cross-border scenarios.
/// The CustomerCreditTransferInitiation message must not be used by the debtor agent to execute the credit transfer instruction(s). The FIToFICustomerCreditTransfer message must be used instead.
/// </summary>
[Description(@"Scope|The CustomerCreditTransferInitiation message is sent by the initiating party to the forwarding agent or debtor agent. It is used to request movement of funds from the debtor account to a creditor.|Usage|The CustomerCreditTransferInitiation message can contain one or more customer credit transfer instructions.|The CustomerCreditTransferInitiation message is used to exchange:|- One or more instances of a credit transfer initiation;|- Payment transactions that result in book transfers at the debtor agent or payments to another financial institution;|- Payment transactions that result in an electronic cash transfer to the creditor account or in the emission of a cheque.|The message can be used in a direct or a relay scenario:|- In a direct scenario, the message is sent directly to the debtor agent. The debtor agent is the account servicer of the debtor.|- In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerCreditTransferInitiation message to the debtor agent.|The message can also be used by an initiating party that has authority to send the message on behalf of the debtor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.|The CustomerCreditTransferInitiation message can be used in domestic and cross-border scenarios.|The CustomerCreditTransferInitiation message must not be used by the debtor agent to execute the credit transfer instruction(s). The FIToFICustomerCreditTransfer message must be used instead.")]
[IsoId("_eYI_qW2PEei3KuUgpx7Xcw")]
[DisplayName("Customer Credit Transfer Initiation V")]
public partial record CustomerCreditTransferInitiationV09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.001.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmrCdtTrfInitn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09";
    
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
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_eYI_rW2PEei3KuUgpx7Xcw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader85 GroupHeader { get; init; } 
    
    /// <summary>
    /// Set of characteristics that applies to the debit side of the payment transactions included in the credit transfer initiation.
    /// </summary>
    [IsoId("_eYI_r22PEei3KuUgpx7Xcw")]
    [DisplayName("Payment Information")]
    [IsoXmlTag("PmtInf")]
    public required PaymentInstruction30 PaymentInformation { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eYI_sW2PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since CustomerCreditTransferInitiationV09Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustomerCreditTransferInitiationV09.

