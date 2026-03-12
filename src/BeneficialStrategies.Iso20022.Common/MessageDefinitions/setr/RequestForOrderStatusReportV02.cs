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



namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.018.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RequestForOrderStatusReport is sent by an instructing party, eg, an investment manager or its authorised representative, to the executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party.
/// This message requests the status of one or several order instruction or order cancellation messages.
/// Usage
/// The RequestForOrderStatusReport message is used to request the status of:
/// - one or several order messages,
/// - one or several cancellation messages,
/// - one or several individual orders within a bulk or multiple order message.
/// If the RequestForOrderStatusReport message is used to request the status of several messages, then the instructing party will receive several reply messages from the executing party, ie, several OrderInstructionStatusReport messages and/or OrderCancellationStatusReport messages. The number of reply messages will match the number of references stated in the RequestForOrderStatusReport message.
/// The RequestForOrderStatusReport message may not be used to request the status of an investment account, a transfer or the status of a financial instrument.
/// </summary>
[Description(@"Scope|The RequestForOrderStatusReport is sent by an instructing party, eg, an investment manager or its authorised representative, to the executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party.|This message requests the status of one or several order instruction or order cancellation messages.|Usage|The RequestForOrderStatusReport message is used to request the status of:|- one or several order messages,|- one or several cancellation messages,|- one or several individual orders within a bulk or multiple order message.|If the RequestForOrderStatusReport message is used to request the status of several messages, then the instructing party will receive several reply messages from the executing party, ie, several OrderInstructionStatusReport messages and/or OrderCancellationStatusReport messages. The number of reply messages will match the number of references stated in the RequestForOrderStatusReport message.|The RequestForOrderStatusReport message may not be used to request the status of an investment account, a transfer or the status of a financial instrument.")]
[IsoId("_wWrFyNE7Ed-BzquC8wXy7w_-1373686594")]
[DisplayName("Request For Order Status Report V")]
public partial record RequestForOrderStatusReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.018.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.018.001.02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.018.001.02";
    
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
    /// Information to identify the order(s) for which the status is requested.
    /// </summary>
    [IsoId("_wWrFydE7Ed-BzquC8wXy7w_93958643")]
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public required MessageAndBusinessReference2 RequestDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since RequestForOrderStatusReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForOrderStatusReportV02.

