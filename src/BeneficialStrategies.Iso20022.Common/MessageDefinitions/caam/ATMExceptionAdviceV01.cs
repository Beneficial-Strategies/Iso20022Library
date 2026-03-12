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



namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// This record is an implementation of the caam.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMExceptionAdvice message is sent by an ATM to an acquirer or its agent to inform of that an exception occurred outside a service.
/// </summary>
[Description(@"The ATMExceptionAdvice message is sent by an ATM to an acquirer or its agent to inform of that an exception occurred outside a service.")]
[IsoId("_i58PwK5CEeWCgYcWSNgX5g")]
[DisplayName("ATM Exception Advice V")]
public partial record ATMExceptionAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.011.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMXcptnAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.011.001.01";
    
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
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_uFaCoK5CEeWCgYcWSNgX5g")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header32 Header { get; init; } 
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_MJAZIK5DEeWCgYcWSNgX5g")]
    [DisplayName("Protected ATM Exception Advice")]
    [IsoXmlTag("PrtctdATMXcptnAdvc")]
    public ContentInformationType10? ProtectedATMExceptionAdvice { get; init; } 
    
    /// <summary>
    /// Information related to exceptions occurring on the ATM.
    /// </summary>
    [IsoId("_4n370K5CEeWCgYcWSNgX5g")]
    [DisplayName("ATM Exception Advice")]
    [IsoXmlTag("ATMXcptnAdvc")]
    public ATMExceptionAdvice1? ATMExceptionAdvice { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_PYXwwK5GEeWCgYcWSNgX5g")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since ATMExceptionAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMExceptionAdviceV01.

