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
/// This record is an implementation of the tsmt.010.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BaselineMatchReport message is sent by the matching application to the parties involved in the establishment of a transaction.
/// The message is used to inform about either the successful establishment of a transaction (baseline) or the mis-matches found between two baseline initiation messages.
/// Usage
/// The BaselineMatchReport message can be sent by the matching application to
/// - the parties involved in the establishment of a transaction in the push-through mode, that is the senders of InitialBaselineSubmission and BaselineReSubmission messages including the instruction push-through. In the outlined scenario the message is used to inform either about the successful establishment of a transaction in the matching application or about mis-matches found between two baseline initiation messages,or
/// - the party establishing a transaction in the lodge mode, that is the sender of an InitialBaselineSubmission message including the instruction lodge. In the outlined scenario the message is used to inform about the successful establishment of a transaction in the matching application.
/// </summary>
[Description(@"Scope|The BaselineMatchReport message is sent by the matching application to the parties involved in the establishment of a transaction.|The message is used to inform about either the successful establishment of a transaction (baseline) or the mis-matches found between two baseline initiation messages.|Usage|The BaselineMatchReport message can be sent by the matching application to|- the parties involved in the establishment of a transaction in the push-through mode, that is the senders of InitialBaselineSubmission and BaselineReSubmission messages including the instruction push-through. In the outlined scenario the message is used to inform either about the successful establishment of a transaction in the matching application or about mis-matches found between two baseline initiation messages,or|- the party establishing a transaction in the lodge mode, that is the sender of an InitialBaselineSubmission message including the instruction lodge. In the outlined scenario the message is used to inform about the successful establishment of a transaction in the matching application.")]
[IsoId("_lhzYiNE8Ed-BzquC8wXy7w_-1930237011")]
[DisplayName("Baseline Match Report V")]
public partial record BaselineMatchReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.010.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BaselnMtchRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03";
    
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
    /// Identifies the report.
    /// </summary>
    [IsoId("_lh9JgNE8Ed-BzquC8wXy7w_-1930236671")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required MessageIdentification1 ReportIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_lh9JgdE8Ed-BzquC8wXy7w_-1930237000")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_lh9JgtE8Ed-BzquC8wXy7w_-1930236517")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_lh9Jg9E8Ed-BzquC8wXy7w_-1930236979")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_lh9JhNE8Ed-BzquC8wXy7w_-1930236548")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_lh9JhdE8Ed-BzquC8wXy7w_-1930236093")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification26 Buyer { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_lh9JhtE8Ed-BzquC8wXy7w_-1930236208")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification26 Seller { get; init; } 
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_lh9Jh9E8Ed-BzquC8wXy7w_-1930236154")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; } 
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_liGTcNE8Ed-BzquC8wXy7w_-1930236123")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; } 
    
    /// <summary>
    /// Specifies the number of matching trials for a baseline.
    /// </summary>
    [IsoId("_liGTcdE8Ed-BzquC8wXy7w_-1930236609")]
    [DisplayName("Baseline Establishment Trials")]
    [IsoXmlTag("BaselnEstblishmtTrils")]
    public required Limit1 BaselineEstablishmentTrials { get; init; } 
    
    /// <summary>
    /// Identifies the two baselines compared in this report.
    /// </summary>
    [IsoId("_liGTctE8Ed-BzquC8wXy7w_-1930236239")]
    [DisplayName("Compared Document Reference")]
    [IsoXmlTag("CmpardDocRef")]
    [MinLength(2)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification4> ComparedDocumentReference { get; init; } = new ValueList<DocumentIdentification4>(){};
    
    /// <summary>
    /// Description of the differences between the two proposed baselines.
    /// </summary>
    [IsoId("_liGTc9E8Ed-BzquC8wXy7w_-1930236947")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public required MisMatchReport3 Report { get; init; } 
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_liGTdNE8Ed-BzquC8wXy7w_-1930236640")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; } 
    
    
    #nullable disable
    
}


// Since BaselineMatchReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BaselineMatchReportV03.

