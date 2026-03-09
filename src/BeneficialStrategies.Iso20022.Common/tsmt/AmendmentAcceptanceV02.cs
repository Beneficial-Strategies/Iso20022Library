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


namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AmendmentAcceptance message is sent by the party requested to accept or reject an amendment to the matching application.
/// The message is used to accept an amendment request.
/// Usage
/// The AmendmentAcceptance message can be sent by the party requested to accept or reject an amendment to inform that it accepts the requested amendment.
/// The message can be sent in response to a FullPushThroughReport and DeltaReport message conveying the details of a BaselineAmendmentRequest message.
/// The rejection of an amendment request can be achieved by sending an AmendmentRejection message.
/// </summary>
[Description(@"Scope|The AmendmentAcceptance message is sent by the party requested to accept or reject an amendment to the matching application.|The message is used to accept an amendment request.|Usage|The AmendmentAcceptance message can be sent by the party requested to accept or reject an amendment to inform that it accepts the requested amendment.|The message can be sent in response to a FullPushThroughReport and DeltaReport message conveying the details of a BaselineAmendmentRequest message.|The rejection of an amendment request can be achieved by sending an AmendmentRejection message.")]
[IsoId("_j0IVwtE8Ed-BzquC8wXy7w_1561210255")]
[DisplayName("Amendment Acceptance V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmendmentAcceptanceV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.005.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AmdmntAccptnc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.005.001.02";
    
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
    /// Constructs a AmendmentAcceptanceV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmendmentAcceptanceV02( MessageIdentification1 reqAcceptanceIdentification,SimpleIdentificationInformation reqTransactionIdentification,MessageIdentification1 reqDeltaReportReference,Count1 reqAcceptedAmendmentNumber )
    {
        AcceptanceIdentification = reqAcceptanceIdentification;
        TransactionIdentification = reqTransactionIdentification;
        DeltaReportReference = reqDeltaReportReference;
        AcceptedAmendmentNumber = reqAcceptedAmendmentNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_j0IVw9E8Ed-BzquC8wXy7w_1561211944")]
    [DisplayName("Acceptance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptncId")]
    #endif
    [IsoXmlTag("AccptncId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 AcceptanceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 AcceptanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 AcceptanceIdentification { get; init; } 
    #else
    public MessageIdentification1 AcceptanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_j0IVxNE8Ed-BzquC8wXy7w_1561211914")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #else
    public SimpleIdentificationInformation TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the identification of the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_j0IVxdE8Ed-BzquC8wXy7w_1561212005")]
    [DisplayName("Submitter Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitrTxRef")]
    #endif
    [IsoXmlTag("SubmitrTxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; } 
    #else
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the identification of the delta report that contained the amendment.
    /// </summary>
    [IsoId("_j0IVxtE8Ed-BzquC8wXy7w_1561211883")]
    [DisplayName("Delta Report Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DltaRptRef")]
    #endif
    [IsoXmlTag("DltaRptRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 DeltaReportReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 DeltaReportReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 DeltaReportReference { get; init; } 
    #else
    public MessageIdentification1 DeltaReportReference { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence number of the accepted baseline amendment.
    /// </summary>
    [IsoId("_j0IVx9E8Ed-BzquC8wXy7w_1561211975")]
    [DisplayName("Accepted Amendment Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptdAmdmntNb")]
    #endif
    [IsoXmlTag("AccptdAmdmntNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Count1 AcceptedAmendmentNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Count1 AcceptedAmendmentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Count1 AcceptedAmendmentNumber { get; init; } 
    #else
    public Count1 AcceptedAmendmentNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AmendmentAcceptanceV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AmendmentAcceptanceV02.

