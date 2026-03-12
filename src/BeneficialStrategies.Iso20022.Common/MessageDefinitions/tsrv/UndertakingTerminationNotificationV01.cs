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



namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingTerminationNotification message is sent to the applicant by the party that issued the undertaking to give notification of the termination or cancelation of the referenced undertaking.
/// </summary>
[Description(@"The UndertakingTerminationNotification message is sent to the applicant by the party that issued the undertaking to give notification of the termination or cancelation of the referenced undertaking.")]
[IsoId("_9gdfZXltEeG7BsjMvd1mEw_-1901363318")]
[DisplayName("Undertaking Termination Notification V")]
public partial record UndertakingTerminationNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.012.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgTermntnNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.012.001.01";
    
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
    /// Details of the termination notification.
    /// </summary>
    [IsoId("_9gdfZnltEeG7BsjMvd1mEw_-908071833")]
    [DisplayName("Undertaking Termination Notification Details")]
    [IsoXmlTag("UdrtkgTermntnNtfctnDtls")]
    public required UndertakingTerminationNotice1 UndertakingTerminationNotificationDetails { get; init; } 
    
    /// <summary>
    /// Digital signature of the notification.
    /// </summary>
    [IsoId("_9gdfZ3ltEeG7BsjMvd1mEw_-1175318209")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since UndertakingTerminationNotificationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingTerminationNotificationV01.

