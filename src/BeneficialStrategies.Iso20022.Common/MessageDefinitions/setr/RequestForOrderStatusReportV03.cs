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
/// This record is an implementation of the setr.018.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the RequestForOrderStatusReport to the executing party, for example, a transfer agent, to request the status of one or more order instruction or order cancellation request messages.
/// Usage
/// The RequestForOrderStatusReport message is used to request the status of:
/// - one or several individual order instructions, or,
/// - one or several order messages, or
/// - one or several individual order cancellation requests, or,
/// - one or several order cancellation request messages.
/// The response to a RequestForOrderStatusReport message is the OrderInstructionStatusReport message or OrderCancellationStatusReport message.
/// If the RequestForOrderStatusReport message is used to request the status of several individual order instructions or one or more order instruction messages, then the instructing party may receive several OrderInstructionStatusReport messages from the executing party.
/// If the RequestForOrderStatusReport message is used to request the status of several individual order cancellation requests or one or more order cancellation messages, then the instructing party may receive several OrderCancellationStatusReport messages from the executing party.
/// When the RequestForOrderStatusReport is used to request the status of one or more individual orders or order cancellations, each individual order is identified with its order reference. The investment account and/or financial instrument related to the order can also be identified. The message identification of the message in which the individual order was conveyed may also be quoted in PreviousReference.
/// When the RequestForOrderStatusReport is used to request the status of an order message or an order cancellations request message, then the message identification of the order or cancellation message is identified in PreviousReference.
/// The RequestForOrderStatusReport message may not be used to request the status of an investment account, a transfer or the status of a financial instrument.
/// </summary>
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the RequestForOrderStatusReport to the executing party, for example, a transfer agent, to request the status of one or more order instruction or order cancellation request messages.|Usage|The RequestForOrderStatusReport message is used to request the status of:|- one or several individual order instructions, or,|- one or several order messages, or|- one or several individual order cancellation requests, or,|- one or several order cancellation request messages.|The response to a RequestForOrderStatusReport message is the OrderInstructionStatusReport message or OrderCancellationStatusReport message.|If the RequestForOrderStatusReport message is used to request the status of several individual order instructions or one or more order instruction messages, then the instructing party may receive several OrderInstructionStatusReport messages from the executing party.|If the RequestForOrderStatusReport message is used to request the status of several individual order cancellation requests or one or more order cancellation messages, then the instructing party may receive several OrderCancellationStatusReport messages from the executing party.|When the RequestForOrderStatusReport is used to request the status of one or more individual orders or order cancellations, each individual order is identified with its order reference. The investment account and/or financial instrument related to the order can also be identified. The message identification of the message in which the individual order was conveyed may also be quoted in PreviousReference.|When the RequestForOrderStatusReport is used to request the status of an order message or an order cancellations request message, then the message identification of the order or cancellation message is identified in PreviousReference.|The RequestForOrderStatusReport message may not be used to request the status of an investment account, a transfer or the status of a financial instrument.")]
[IsoId("_wy_OWNE7Ed-BzquC8wXy7w_1331513670")]
[DisplayName("Request For Order Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestForOrderStatusReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.018.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForOrdrStsRptV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.018.001.03";
    
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
    /// Constructs a RequestForOrderStatusReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestForOrderStatusReportV03( MessageIdentification1 reqMessageIdentification,MessageAndBusinessReference4 reqRequestDetails )
    {
        MessageIdentification = reqMessageIdentification;
        RequestDetails = reqRequestDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_wy_OWdE7Ed-BzquC8wXy7w_390506052")]
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
    /// Information to identify the order(s) for which the status is requested.
    /// </summary>
    [IsoId("_wy_OWtE7Ed-BzquC8wXy7w_1331513937")]
    [DisplayName("Request Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqDtls")]
    #endif
    [IsoXmlTag("ReqDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageAndBusinessReference4 RequestDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageAndBusinessReference4 RequestDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageAndBusinessReference4 RequestDetails { get; init; } 
    #else
    public MessageAndBusinessReference4 RequestDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_wy_OW9E7Ed-BzquC8wXy7w_-800406650")]
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


// Since RequestForOrderStatusReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForOrderStatusReportV03.

