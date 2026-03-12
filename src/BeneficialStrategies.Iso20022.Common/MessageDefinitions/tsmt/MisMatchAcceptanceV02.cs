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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MisMatchAcceptanceV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MisMatchAcceptanceV02( MessageIdentification1 reqAcceptanceIdentification,SimpleIdentificationInformation reqTransactionIdentification,MessageIdentification1 reqDataSetMatchReportReference )
    {
        AcceptanceIdentification = reqAcceptanceIdentification;
        TransactionIdentification = reqTransactionIdentification;
        DataSetMatchReportReference = reqDataSetMatchReportReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_rmuIWdE8Ed-BzquC8wXy7w_-505566937")]
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
    [IsoId("_rmuIWtE8Ed-BzquC8wXy7w_-505567246")]
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
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_rm35UNE8Ed-BzquC8wXy7w_-505567275")]
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
    /// Reference to the identification of the report that contained the difference.
    /// </summary>
    [IsoId("_rm35UdE8Ed-BzquC8wXy7w_-505567215")]
    [DisplayName("Data Set Match Report Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetMtchRptRef")]
    #endif
    [IsoXmlTag("DataSetMtchRptRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 DataSetMatchReportReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 DataSetMatchReportReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 DataSetMatchReportReference { get; init; } 
    #else
    public MessageIdentification1 DataSetMatchReportReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MisMatchAcceptanceV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MisMatchAcceptanceV02.

