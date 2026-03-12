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
/// This record is an implementation of the cain.027.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ChargeBackInitiation message is sent by an issuer or agent to an acquirer to fully or partially nullify a previous financial transaction; namely when the issuer determines that a customer dispute exists or that an error or violation of rules has been committed. It is also used to nullify a previous chargeback. Chargebacks have a financial impact and should be computed within reconciliation totals.
/// </summary>
[Description(@"The ChargeBackInitiation message is sent by an issuer or agent to an acquirer to fully or partially nullify a previous financial transaction; namely when the issuer determines that a customer dispute exists or that an error or violation of rules has been committed. It is also used to nullify a previous chargeback. Chargebacks have a financial impact and should be computed within reconciliation totals.")]
[IsoId("_52D7IYHSEeuwq_rv81SdXw")]
[DisplayName("Charge Back Initiation V")]
public partial record ChargeBackInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.027.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ChrgBckInitn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.027.001.02";
    
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
    [IsoId("_52D7I4HSEeuwq_rv81SdXw")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header61 Header { get; init; } 
    
    /// <summary>
    /// Information related to the initiation of a chargeback.
    /// ISO 8583:93/2003 bit 25.
    /// </summary>
    [IsoId("_52D7JYHSEeuwq_rv81SdXw")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required ChargeBackInitiation2 Body { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_52D7J4HSEeuwq_rv81SdXw")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since ChargeBackInitiationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ChargeBackInitiationV02.

