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
/// This record is an implementation of the cain.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInitiation message is sent by an acquirer or an agent to an issuer to request approval of a card transaction or to inform about the completion of an authorisation. It allows the approved transaction amount to be billed or posted on the cardholder&apos;s account. It can also be sent by an issuer to an acquirer or agent to advise that an authorisation has been successfully completed for the final amount and requests the clearing of the transaction.
/// </summary>
[Description(@"The FinancialInitiation message is sent by an acquirer or an agent to an issuer to request approval of a card transaction or to inform about the completion of an authorisation. It allows the approved transaction amount to be billed or posted on the cardholder's account. It can also be sent by an issuer to an acquirer or agent to advise that an authorisation has been successfully completed for the final amount and requests the clearing of the transaction.")]
[IsoId("_Sii_4YELEeu6D49Gi-ZPwQ")]
[DisplayName("Financial Initiation V")]
public partial record FinancialInitiationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.003.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInitn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.003.001.03";
    
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
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_Sii_44ELEeu6D49Gi-ZPwQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header62 Header { get; init; } 
    
    /// <summary>
    /// Information related to the financial initiation.
    /// </summary>
    [IsoId("_Sii_5YELEeu6D49Gi-ZPwQ")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required FinancialInitiation2 Body { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_Sii_54ELEeu6D49Gi-ZPwQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since FinancialInitiationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInitiationV03.

