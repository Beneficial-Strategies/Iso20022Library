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
/// This record is an implementation of the tsmt.020.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MisMatchAcceptance message is sent by the party requested to accept or reject data set mis-matches to the matching application.
/// This message is used to accept mis-matches between data sets and the related baseline.
/// Usage
/// The MisMatchAcceptance message can be sent by the party requested to accept or reject data set mis-matches to inform that it accepts the data sets.
/// The message can be sent in response to a DataSetMatchReport message conveying mis-matches.
/// The information about the acceptance of the mis-matched data sets will be forwarded by the matching application to the submitter of the data sets by a MisMatchAcceptanceNotification message.
/// The rejection of mis-matched data sets can be achieved by sending a MisMatchRejection message.
/// </summary>
[Description(@"Scope|The MisMatchAcceptance message is sent by the party requested to accept or reject data set mis-matches to the matching application.|This message is used to accept mis-matches between data sets and the related baseline.|Usage|The MisMatchAcceptance message can be sent by the party requested to accept or reject data set mis-matches to inform that it accepts the data sets.|The message can be sent in response to a DataSetMatchReport message conveying mis-matches.|The information about the acceptance of the mis-matched data sets will be forwarded by the matching application to the submitter of the data sets by a MisMatchAcceptanceNotification message.|The rejection of mis-matched data sets can be achieved by sending a MisMatchRejection message.")]
[IsoId("_rmuIWNE8Ed-BzquC8wXy7w_-505567278")]
[DisplayName("Mis Match Acceptance V")]
public partial record MisMatchAcceptanceV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.020.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MisMtchAccptnc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.020.001.02";
    
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
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_rmuIWdE8Ed-BzquC8wXy7w_-505566937")]
    [DisplayName("Acceptance Identification")]
    [IsoXmlTag("AccptncId")]
    public required MessageIdentification1 AcceptanceIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_rmuIWtE8Ed-BzquC8wXy7w_-505567246")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_rm35UNE8Ed-BzquC8wXy7w_-505567275")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; } 
    
    /// <summary>
    /// Reference to the identification of the report that contained the difference.
    /// </summary>
    [IsoId("_rm35UdE8Ed-BzquC8wXy7w_-505567215")]
    [DisplayName("Data Set Match Report Reference")]
    [IsoXmlTag("DataSetMtchRptRef")]
    public required MessageIdentification1 DataSetMatchReportReference { get; init; } 
    
    
    #nullable disable
    
}


// Since MisMatchAcceptanceV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MisMatchAcceptanceV02.

