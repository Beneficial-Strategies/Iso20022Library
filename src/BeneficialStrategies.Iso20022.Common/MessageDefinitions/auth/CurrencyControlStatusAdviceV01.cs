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



namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.027.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CurrencyControlStatusAdvice message is sent by either the reporting party (respectively the registration agent or the registration agent (respectively the reporting party) to provide a status advice on a previously sent currency control message.
/// 
/// Usage: 
/// The message may be sent in response to requests on the registration of the currency control contract, supporting document or on the payment regulatory information notification.
/// </summary>
[Description(@"The CurrencyControlStatusAdvice message is sent by either the reporting party (respectively the registration agent or the registration agent (respectively the reporting party) to provide a status advice on a previously sent currency control message.||Usage: |The message may be sent in response to requests on the registration of the currency control contract, supporting document or on the payment regulatory information notification.")]
[IsoId("_9ek38NnOEeS--7IJLPC9lw")]
[DisplayName("Currency Control Status Advice V")]
public partial record CurrencyControlStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.027.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CcyCtrlStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.027.001.01";
    
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
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_TDEesdnQEeS--7IJLPC9lw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required CurrencyControlHeader2 GroupHeader { get; init; } 
    
    /// <summary>
    /// Provides the group status for the global message.
    /// </summary>
    [IsoId("_OWKlteFaEeSvv6t4Ka7B7A")]
    [DisplayName("Group Status")]
    [IsoXmlTag("GrpSts")]
    public required CurrencyControlGroupStatus1 GroupStatus { get; init; } 
    
    /// <summary>
    /// Provides the status of the package in the message, which may contain the individual records.
    /// </summary>
    [IsoId("_lQl6EOFaEeSvv6t4Ka7B7A")]
    [DisplayName("Package Status")]
    [IsoXmlTag("PackgSts")]
    public CurrencyControlPackageStatus1? PackageStatus { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2c1oodnQEeS--7IJLPC9lw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since CurrencyControlStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CurrencyControlStatusAdviceV01.

