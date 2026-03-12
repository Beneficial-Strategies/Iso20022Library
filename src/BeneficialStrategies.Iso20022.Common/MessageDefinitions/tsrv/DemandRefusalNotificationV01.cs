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
/// This record is an implementation of the tsrv.016.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DemandRefusalNotification message is sent to the beneficiary or presenter by the party obligated on the undertaking and to whom a demand for payment has been made, either directly or via one or more advising parties. It notifies the beneficiary or presenter that the demand has been refused.
/// </summary>
[Description(@"The DemandRefusalNotification message is sent to the beneficiary or presenter by the party obligated on the undertaking and to whom a demand for payment has been made, either directly or via one or more advising parties. It notifies the beneficiary or presenter that the demand has been refused.")]
[IsoId("_9iijAHltEeG7BsjMvd1mEw_2131850524")]
[DisplayName("Demand Refusal Notification V")]
public partial record DemandRefusalNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.016.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DmndRfslNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.016.001.01";
    
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
    /// Details of the demand refusal notification.
    /// </summary>
    [IsoId("_9iijAXltEeG7BsjMvd1mEw_1591105840")]
    [DisplayName("Demand Refusal Notification Details")]
    [IsoXmlTag("DmndRfslNtfctnDtls")]
    public DemandRefusal1? DemandRefusalNotificationDetails { get; init; } 
    
    /// <summary>
    /// Digital signature of the notification.
    /// </summary>
    [IsoId("_9iijAnltEeG7BsjMvd1mEw_-509775412")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since DemandRefusalNotificationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DemandRefusalNotificationV01.

