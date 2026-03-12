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



namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.019.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingStatusReport message is exchanged between parties that have an interest in the referenced undertaking transaction. It notifies the recipient of the status of the transaction, such as acceptance or rejection, withdrawal, or non-conformation. The sender may add additional information, as appropriate.
/// </summary>
[Description(@"The UndertakingStatusReport message is exchanged between parties that have an interest in the referenced undertaking transaction. It notifies the recipient of the status of the transaction, such as acceptance or rejection, withdrawal, or non-conformation. The sender may add additional information, as appropriate.")]
[IsoId("_9h8tJXltEeG7BsjMvd1mEw_-329334493")]
[DisplayName("Undertaking Status Report V")]
public partial record UndertakingStatusReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.019.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgStsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.019.001.01";
    
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
    /// Details of the undertaking status report.
    /// </summary>
    [IsoId("_9h8tJnltEeG7BsjMvd1mEw_-1217857261")]
    [DisplayName("Undertaking Status Report Details")]
    [IsoXmlTag("UdrtkgStsRptDtls")]
    public required UndertakingStatusAdvice1 UndertakingStatusReportDetails { get; init; } 
    
    /// <summary>
    /// Digital signature of the report.
    /// </summary>
    [IsoId("_9h8tJ3ltEeG7BsjMvd1mEw_1390197264")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since UndertakingStatusReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingStatusReportV01.

