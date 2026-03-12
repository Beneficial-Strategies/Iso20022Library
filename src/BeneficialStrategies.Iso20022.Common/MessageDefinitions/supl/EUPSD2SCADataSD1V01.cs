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
/// This record is an implementation of the supl.035.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Extends the ATICA message set to address the requirement of the European Banking Authority (EBA) related to the Regulatory Technical Standard (RTS) on Strong Customer Authentication (SCA) imposed by the EU regulation.
/// </summary>
[Description(@"Extends the ATICA message set to address the requirement of the European Banking Authority (EBA) related to the Regulatory Technical Standard (RTS) on Strong Customer Authentication (SCA) imposed by the EU regulation.")]
[IsoId("_g7hKgAMdEeujMs2LsB3mMw")]
[DisplayName("EUPSD 2 SCA Data SD 1 V")]
public partial record EUPSD2SCADataSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.035.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "EUPSD2SCADataSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.035.001.01";
    
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
    /// EU PSD2 Strong Consumer Authentication data.
    /// </summary>
    [IsoId("_dWMeEAMnEeubkNI1IXQTVQ")]
    [DisplayName("Strong Customer Authentication")]
    [IsoXmlTag("StrngCstmrAuthntcn")]
    public required StrongCustomerAuthentication1 StrongCustomerAuthentication { get; init; } 
    
    
    #nullable disable
    
}


// Since EUPSD2SCADataSD1V01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to EUPSD2SCADataSD1V01.

