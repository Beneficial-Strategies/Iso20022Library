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



namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.032.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAICSD1 message extends ISO corporate action Instruction Cancellation Request (CAIC) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCAICSD1 message extends ISO corporate action Instruction Cancellation Request (CAIC) message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_b8UwkL5OEeexmbB7KsjCwA")]
[DisplayName("DTCCCAICSD 1 V")]
public partial record DTCCCAICSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.032.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAICSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.032.001.01";
    
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
    /// Supplementary data extending corporate action instruction cancellation request message with corporate action reorganisation elements not covered in the standard message.
    /// </summary>
    [IsoId("_fcQ_wMYxEeesocHIuVGr7g")]
    [DisplayName("Reorganisation Instruction Cancellation Details")]
    [IsoXmlTag("ReorgInstrCxlDtls")]
    [MinLength(0)]
    [MaxLength(12)]
    public ValueList<ReorganisationInstructionDetailsSD3> ReorganisationInstructionCancellationDetails { get; init; } = new ValueList<ReorganisationInstructionDetailsSD3>(){};
    
    
    #nullable disable
    
}


// Since DTCCCAICSD1V01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCAICSD1V01.

