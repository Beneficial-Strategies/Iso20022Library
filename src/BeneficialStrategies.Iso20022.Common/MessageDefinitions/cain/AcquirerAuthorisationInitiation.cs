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



namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcquirerAuthorisationInitiation message is sent by an acquirer or an agent to an issuer or an agent, to request, advice or notify the approval of a card transaction.
/// </summary>
[Description(@"The AcquirerAuthorisationInitiation message is sent by an acquirer or an agent to an issuer or an agent, to request, advice or notify the approval of a card transaction.")]
[IsoId("_Kdha0Hq9EeSqmf43GdBXXQ")]
[DisplayName("Acquirer Authorisation Initiation")]
public partial record AcquirerAuthorisationInitiation : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.001.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcqrrAuthstnInitn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.001.001.01";
    
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
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_pyxmcHq9EeSqmf43GdBXXQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header17 Header { get; init; } 
    
    /// <summary>
    /// Information related to the authorisation initiation.
    /// </summary>
    [IsoId("_XShM8HrhEeSlsoBd7x4P6A")]
    [DisplayName("Authorisation Initiation")]
    [IsoXmlTag("AuthstnInitn")]
    public required AcquirerAuthorisationInitiation1 AuthorisationInitiation { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds patially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_R0omUHtBEeSTS7uHCe8FPQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since AcquirerAuthorisationInitiationDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcquirerAuthorisationInitiation.

