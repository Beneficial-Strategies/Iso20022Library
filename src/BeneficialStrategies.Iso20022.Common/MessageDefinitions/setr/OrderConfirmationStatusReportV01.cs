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


namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.057.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the OrderConfirmationStatusReport message to the executing party, for example, a transfer agent, to report the status of an order confirmation or an order confirmation amendment.
/// Usage
/// The OrderConfirmationStatusReport message is used to report on the status of one or more individual:
/// - subscription confirmations,
/// - subscription confirmation amendments,
/// - redemption confirmations,
/// - redemption confirmation amendments,
/// - switch order confirmations,
/// - switch order confirmation amendments.
/// One of the following statuses can be reported:
/// - confirmation rejected, or,
/// - amendment rejected, or,
/// - sent to next party, or,
/// - communication problem with next party, or,
/// - confirmation accepted, or,
/// - confirmation received.
/// It is likely that the OrderConfirmationStatusReport is only sent by the order instructing party to the order executing party to reject an order confirmation or to reject an order confirmation amendment, although if an intermediary party is used, the statuses sent to next party and communication problem with next party are also likely be used. The statuses confirmation accepted and confirmation received would only be used in the event the order executing party sends a RequestForOrderConfirmationStatusReport message and one of the other statuses does not apply.
/// If the status being reported is either confirmation rejected or amendment rejected, then a reason for the rejection must be given.
/// The individual order confirmation or confirmation amendment for which the status is given is identified with its order reference. The message identification of the message in which the individual order confirmation or confirmation amendment was conveyed may also be quoted in RelatedReference, but this is not recommended.
/// </summary>
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the OrderConfirmationStatusReport message to the executing party, for example, a transfer agent, to report the status of an order confirmation or an order confirmation amendment.|Usage|The OrderConfirmationStatusReport message is used to report on the status of one or more individual:|- subscription confirmations,|- subscription confirmation amendments,|- redemption confirmations,|- redemption confirmation amendments,|- switch order confirmations,|- switch order confirmation amendments.|One of the following statuses can be reported:|- confirmation rejected, or,|- amendment rejected, or,|- sent to next party, or,|- communication problem with next party, or,|- confirmation accepted, or,|- confirmation received.|It is likely that the OrderConfirmationStatusReport is only sent by the order instructing party to the order executing party to reject an order confirmation or to reject an order confirmation amendment, although if an intermediary party is used, the statuses sent to next party and communication problem with next party are also likely be used. The statuses confirmation accepted and confirmation received would only be used in the event the order executing party sends a RequestForOrderConfirmationStatusReport message and one of the other statuses does not apply.|If the status being reported is either confirmation rejected or amendment rejected, then a reason for the rejection must be given.|The individual order confirmation or confirmation amendment for which the status is given is identified with its order reference. The message identification of the message in which the individual order confirmation or confirmation amendment was conveyed may also be quoted in RelatedReference, but this is not recommended.")]
[IsoId("_hzzSMNE7Ed-BzquC8wXy7w_-354500985")]
[DisplayName("Order Confirmation Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrderConfirmationStatusReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.057.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "OrdrConfStsRptV01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.057.001.01";
    
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
    /// Constructs a OrderConfirmationStatusReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OrderConfirmationStatusReportV01( MessageIdentification1 reqMessageIdentification,IndividualOrderConfirmationStatusAndReason1 reqIndividualOrderConfirmationDetailsReport )
    {
        MessageIdentification = reqMessageIdentification;
        IndividualOrderConfirmationDetailsReport = reqIndividualOrderConfirmationDetailsReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_hzzSMdE7Ed-BzquC8wXy7w_1729546836")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_hzzSMtE7Ed-BzquC8wXy7w_-1840795261")]
    [DisplayName("Other Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRef")]
    #endif
    [IsoXmlTag("OthrRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<AdditionalReference3> OtherReference { get; init; } = new ValueList<AdditionalReference3>(){};
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_hzzSM9E7Ed-BzquC8wXy7w_1545429452")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<AdditionalReference3> RelatedReference { get; init; } = new ValueList<AdditionalReference3>(){};
    
    /// <summary>
    /// Status report details of an individual order confirmation.
    /// </summary>
    [IsoId("_hzzSNNE7Ed-BzquC8wXy7w_1394750346")]
    [DisplayName("Individual Order Confirmation Details Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvOrdrConfDtlsRpt")]
    #endif
    [IsoXmlTag("IndvOrdrConfDtlsRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IndividualOrderConfirmationStatusAndReason1 IndividualOrderConfirmationDetailsReport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IndividualOrderConfirmationStatusAndReason1 IndividualOrderConfirmationDetailsReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualOrderConfirmationStatusAndReason1 IndividualOrderConfirmationDetailsReport { get; init; } 
    #else
    public IndividualOrderConfirmationStatusAndReason1 IndividualOrderConfirmationDetailsReport { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_hzzSNdE7Ed-BzquC8wXy7w_1567010081")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since OrderConfirmationStatusReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to OrderConfirmationStatusReportV01.

