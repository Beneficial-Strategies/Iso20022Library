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
/// This record is an implementation of the setr.017.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The OrderCancellationStatusReport is sent by an executing party, eg, a transfer agent, to the instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.
/// The message gives the status of an order cancellation instruction message that was previously sent by the instructing party.
/// Usage
/// The OrderCancellationStatusReport message is used to report the status of an order cancellation instruction message that was previously sent by the instructing party. The message can be used to report one of the following:
/// - the cancellation is accepted for further processing, or
/// - the cancellation is rejected, or
/// - the order has been cancelled.
/// When the cancellation is rejected, the reason for the rejection must be specified.
/// </summary>
[Description(@"Scope|The OrderCancellationStatusReport is sent by an executing party, eg, a transfer agent, to the instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.|The message gives the status of an order cancellation instruction message that was previously sent by the instructing party.|Usage|The OrderCancellationStatusReport message is used to report the status of an order cancellation instruction message that was previously sent by the instructing party. The message can be used to report one of the following:|- the cancellation is accepted for further processing, or|- the cancellation is rejected, or|- the order has been cancelled.|When the cancellation is rejected, the reason for the rejection must be specified.")]
[IsoId("_gilh-NE7Ed-BzquC8wXy7w_-1859459709")]
[DisplayName("Order Cancellation Status Report V")]
public partial record OrderCancellationStatusReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.017.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.017.001.02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.017.001.02";
    
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
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_gilh-dE7Ed-BzquC8wXy7w_339506897")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<AdditionalReference3> RelatedReference { get; init; } = new ValueList<AdditionalReference3>(){};
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_gilh-tE7Ed-BzquC8wXy7w_-1972675840")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<AdditionalReference3> OtherReference { get; init; } = new ValueList<AdditionalReference3>(){};
    
    /// <summary>
    /// Status report details of a bulk or multiple or switch order cancellation instruction that was previously received.
    /// </summary>
    [IsoId("_gilh-9E7Ed-BzquC8wXy7w_1147588729")]
    [DisplayName("Cancellation Status Report")]
    [IsoXmlTag("CxlStsRpt")]
    public required OrderStatusAndReason4 CancellationStatusReport { get; init; } 
    
    
    #nullable disable
    
}


// Since OrderCancellationStatusReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to OrderCancellationStatusReportV02.

