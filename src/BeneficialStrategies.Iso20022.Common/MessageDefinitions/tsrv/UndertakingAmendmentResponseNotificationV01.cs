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
/// This record is an implementation of the tsrv.009.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingAmendmentResponseNotification message is sent by the advising party to the party that issued the undertaking, either directly or via one or more other parties, to notify the recipient of the acceptance or rejection by the beneficiary of the amendment. On receipt of this message or the UndertakingAmendmentResponse message, the issuer may also send the UndertakingAmendmentResponseNotification to the applicant.
/// </summary>
[Description(@"The UndertakingAmendmentResponseNotification message is sent by the advising party to the party that issued the undertaking, either directly or via one or more other parties, to notify the recipient of the acceptance or rejection by the beneficiary of the amendment. On receipt of this message or the UndertakingAmendmentResponse message, the issuer may also send the UndertakingAmendmentResponseNotification to the applicant.")]
[IsoId("_9iPoEnltEeG7BsjMvd1mEw_-78549695")]
[DisplayName("Undertaking Amendment Response Notification V")]
public partial record UndertakingAmendmentResponseNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.009.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAmdmntRspnNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.009.001.01";
    
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
    /// Details related to the proposed amendment response notification.
    /// </summary>
    [IsoId("_9iPoE3ltEeG7BsjMvd1mEw_-1088327263")]
    [DisplayName("Undertaking Amendment Response Notification Details")]
    [IsoXmlTag("UdrtkgAmdmntRspnNtfctnDtls")]
    public required Amendment9 UndertakingAmendmentResponseNotificationDetails { get; init; } 
    
    /// <summary>
    /// Additional information reported by the beneficiary.
    /// </summary>
    [IsoId("_Xldnk387EeGx884K2iQOLg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public IsoMax2000Text? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Digital signature of the response notification.
    /// </summary>
    [IsoId("_9iPoFHltEeG7BsjMvd1mEw_1375957956")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since UndertakingAmendmentResponseNotificationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingAmendmentResponseNotificationV01.

