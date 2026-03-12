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



namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.050.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RoleAndBaselineRejection message is sent by a secondary bank to the matching application if it rejects to join the transaction based on the baseline and the role that it is expected to play.
/// Usage
/// The RoleAndBaselineRejection message is sent in response to a message that is a direct request to join a transaction.
/// </summary>
[Description(@"Scope|The RoleAndBaselineRejection message is sent by a secondary bank to the matching application if it rejects to join the transaction based on the baseline and the role that it is expected to play.|Usage|The RoleAndBaselineRejection message is sent in response to a message that is a direct request to join a transaction.")]
[IsoId("_uJ5PuNE8Ed-BzquC8wXy7w_1408620878")]
[DisplayName("Role And Baseline Rejection V")]
public partial record RoleAndBaselineRejectionV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.050.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RoleAndBaselnRjctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.050.001.01";
    
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
    /// Identifies the rejection message.
    /// </summary>
    [IsoId("_uJ5PudE8Ed-BzquC8wXy7w_1408620914")]
    [DisplayName("Rejection Identification")]
    [IsoXmlTag("RjctnId")]
    public required MessageIdentification1 RejectionIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the message that contained the baseline and is rejected.
    /// </summary>
    [IsoId("_uJ5PutE8Ed-BzquC8wXy7w_-1800452718")]
    [DisplayName("Related Message Reference")]
    [IsoXmlTag("RltdMsgRef")]
    public required MessageIdentification1 RelatedMessageReference { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_uKCZoNE8Ed-BzquC8wXy7w_1408620999")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Reason why the user cannot accept the request.
    /// </summary>
    [IsoId("_uKCZodE8Ed-BzquC8wXy7w_1408621387")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public Reason2? RejectionReason { get; init; } 
    
    
    #nullable disable
    
}


// Since RoleAndBaselineRejectionV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RoleAndBaselineRejectionV01.

