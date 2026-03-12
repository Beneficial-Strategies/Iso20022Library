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
/// This record is an implementation of the tsmt.015.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The DeltaReport message is sent by the matching application to the parties involved in the request of a baseline amendment.
/// The message is used to list the differences between the established and the newly proposed baseline.
/// Usage
/// The DeltaReport message can be sent by the matching application to
/// - the parties involved in the amendment of a baseline that has been established in the push-through mode. In the outlined scenario the message is sent to the requester of the amendment to acknowledge the receipt of the request and to list the differences between the established and the newly proposed baseline and to the counterparty to list the differences between the established and the newly proposed baseline and to request the acceptance or rejection of the amendment request,
/// or
/// - the party that has requested the amendment of a baseline established in the lodge mode. In the outlined scenario the message is used to confirm the changes to the baseline and to list the differences between the amended baseline and the baseline established earlier.
/// </summary>
[Description(@"Scope|The DeltaReport message is sent by the matching application to the parties involved in the request of a baseline amendment.|The message is used to list the differences between the established and the newly proposed baseline.|Usage|The DeltaReport message can be sent by the matching application to|- the parties involved in the amendment of a baseline that has been established in the push-through mode. In the outlined scenario the message is sent to the requester of the amendment to acknowledge the receipt of the request and to list the differences between the established and the newly proposed baseline and to the counterparty to list the differences between the established and the newly proposed baseline and to request the acceptance or rejection of the amendment request,|or|- the party that has requested the amendment of a baseline established in the lodge mode. In the outlined scenario the message is used to confirm the changes to the baseline and to list the differences between the amended baseline and the baseline established earlier.")]
[IsoId("_nsFeyNE8Ed-BzquC8wXy7w_1762924909")]
[DisplayName("Delta Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeltaReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.015.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DltaRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.015.001.03";
    
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
    /// Constructs a DeltaReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeltaReportV03( MessageIdentification1 reqReportIdentification,SimpleIdentificationInformation reqTransactionIdentification,DocumentIdentification3 reqEstablishedBaselineIdentification,TransactionStatus4 reqTransactionStatus,Count1 reqAmendmentNumber,PartyIdentification26 reqBuyer,PartyIdentification26 reqSeller,BICIdentification1 reqBuyerBank,BICIdentification1 reqSellerBank,DocumentIdentification1 reqSubmitterProposedBaselineReference,ComparisonResult2 reqUpdatedElement )
    {
        ReportIdentification = reqReportIdentification;
        TransactionIdentification = reqTransactionIdentification;
        EstablishedBaselineIdentification = reqEstablishedBaselineIdentification;
        TransactionStatus = reqTransactionStatus;
        AmendmentNumber = reqAmendmentNumber;
        Buyer = reqBuyer;
        Seller = reqSeller;
        BuyerBank = reqBuyerBank;
        SellerBank = reqSellerBank;
        SubmitterProposedBaselineReference = reqSubmitterProposedBaselineReference;
        UpdatedElement = reqUpdatedElement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_nsPPwNE8Ed-BzquC8wXy7w_1762925372")]
    [DisplayName("Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptId")]
    #endif
    [IsoXmlTag("RptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 ReportIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 ReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 ReportIdentification { get; init; } 
    #else
    public MessageIdentification1 ReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_nsPPwdE8Ed-BzquC8wXy7w_1762924912")]
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
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_nsPPwtE8Ed-BzquC8wXy7w_1762925433")]
    [DisplayName("Established Baseline Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstblishdBaselnId")]
    #endif
    [IsoXmlTag("EstblishdBaselnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #else
    public DocumentIdentification3 EstablishedBaselineIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_nsPPw9E8Ed-BzquC8wXy7w_1762925188")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus4 TransactionStatus { get; init; } 
    #else
    public TransactionStatus4 TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence number of the proposed baseline amendment.
    /// </summary>
    [IsoId("_nsPPxNE8Ed-BzquC8wXy7w_1762925826")]
    [DisplayName("Amendment Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntNb")]
    #endif
    [IsoXmlTag("AmdmntNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Count1 AmendmentNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Count1 AmendmentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Count1 AmendmentNumber { get; init; } 
    #else
    public Count1 AmendmentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_nsPPxdE8Ed-BzquC8wXy7w_1762925311")]
    [DisplayName("User Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrTxRef")]
    #endif
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_nsPPxtE8Ed-BzquC8wXy7w_1762925464")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Buyer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Buyer { get; init; } 
    #else
    public PartyIdentification26 Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_nsPPx9E8Ed-BzquC8wXy7w_1762925711")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Seller { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Seller { get; init; } 
    #else
    public PartyIdentification26 Seller { get; set; } 
    #endif
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_nsYZsNE8Ed-BzquC8wXy7w_1762925280")]
    [DisplayName("Buyer Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrBk")]
    #endif
    [IsoXmlTag("BuyrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 BuyerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 BuyerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 BuyerBank { get; init; } 
    #else
    public BICIdentification1 BuyerBank { get; set; } 
    #endif
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_nsYZsdE8Ed-BzquC8wXy7w_1762925221")]
    [DisplayName("Seller Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrBk")]
    #endif
    [IsoXmlTag("SellrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 SellerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 SellerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 SellerBank { get; init; } 
    #else
    public BICIdentification1 SellerBank { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the identification of the baseline included in the amendment request.
    /// </summary>
    [IsoId("_nsYZstE8Ed-BzquC8wXy7w_1762925795")]
    [DisplayName("Submitter Proposed Baseline Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitrPropsdBaselnRef")]
    #endif
    [IsoXmlTag("SubmitrPropsdBaselnRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification1 SubmitterProposedBaselineReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification1 SubmitterProposedBaselineReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification1 SubmitterProposedBaselineReference { get; init; } 
    #else
    public DocumentIdentification1 SubmitterProposedBaselineReference { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed comparison between the currently established baseline elements and the proposed ones.
    /// </summary>
    [IsoId("_nsYZs9E8Ed-BzquC8wXy7w_1762925773")]
    [DisplayName("Updated Element")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdtdElmt")]
    #endif
    [IsoXmlTag("UpdtdElmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ComparisonResult2 UpdatedElement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ComparisonResult2 UpdatedElement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparisonResult2 UpdatedElement { get; init; } 
    #else
    public ComparisonResult2 UpdatedElement { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_nsYZtNE8Ed-BzquC8wXy7w_1762925341")]
    [DisplayName("Request For Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqForActn")]
    #endif
    [IsoXmlTag("ReqForActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingActivity2? RequestForAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingActivity2? RequestForAction { get; init; } 
    #else
    public PendingActivity2? RequestForAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DeltaReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DeltaReportV03.

