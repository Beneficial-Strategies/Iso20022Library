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



namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.
/// The message gives the status of a complete message or of one or more specific instructions within the message.
/// Usage
/// The MeetingInstructionStatus message is used for four purposes.
/// First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, ie, whether the request message is rejected or accepted.
/// Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.
/// Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, ie, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.
/// The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).
/// Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.
/// </summary>
[Description(@"Scope|The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.|The message gives the status of a complete message or of one or more specific instructions within the message.|Usage|The MeetingInstructionStatus message is used for four purposes.|First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, ie, whether the request message is rejected or accepted.|Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.|Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, ie, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.|The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).|Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.")]
[IsoId("_Tpw2YNEwEd-BzquC8wXy7w_322491691")]
[DisplayName("Meeting Instruction Status V")]
public partial record MeetingInstructionStatusV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrSts";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.006.001.02";
    
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
    /// Identifies the meeting instruction status message.
    /// </summary>
    [IsoId("_Tpw2YdEwEd-BzquC8wXy7w_322491753")]
    [DisplayName("Meeting Instruction Status Identification")]
    [IsoXmlTag("MtgInstrStsId")]
    public required MessageIdentification1 MeetingInstructionStatusIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the meeting instruction message for which the status is provided.
    /// </summary>
    [IsoId("_Tpw2YtEwEd-BzquC8wXy7w_2026535768")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public required MessageIdentification InstructionIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the meeting instruction cancellation request message for which the status is provided.
    /// </summary>
    [IsoId("_Tpw2Y9EwEd-BzquC8wXy7w_-1459248718")]
    [DisplayName("Instruction Cancellation Identification")]
    [IsoXmlTag("InstrCxlId")]
    public required MessageIdentification InstructionCancellationIdentification { get; init; } 
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_Tpw2ZNEwEd-BzquC8wXy7w_322491723")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference3 MeetingReference { get; init; } 
    
    /// <summary>
    /// Party reporting the status.
    /// </summary>
    [IsoId("_Tpw2ZdEwEd-BzquC8wXy7w_322491769")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required PartyIdentification9Choice_ ReportingParty { get; init; } 
    
    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_Tpw2ZtEwEd-BzquC8wXy7w_322491740")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification3 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Status applying to the instruction request received. The instruction is identified by the InstructionIdentification.
    /// </summary>
    [IsoId("_Tp6nYNEwEd-BzquC8wXy7w_-1918238262")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionStatus1Choice_ InstructionStatus { get; init; } 
    
    /// <summary>
    /// Status applying to the instruction cancellation request received. The instruction cancellation is identified by the InstructionCancellationIdentification.
    /// </summary>
    [IsoId("_Tp6nYdEwEd-BzquC8wXy7w_-1891306191")]
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public required CancellationStatus1Choice_ CancellationStatus { get; init; } 
    
    
    #nullable disable
    
}


// Since MeetingInstructionStatusV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionStatusV02.

