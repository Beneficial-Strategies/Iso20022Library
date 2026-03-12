// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Print Request message.
/// </summary>
[IsoId("_3nMJkQ0qEeqUVL7sB4m7NA")]
[DisplayName("Device Print Request")]
public partial record DevicePrintRequest2
{
    #nullable enable
    
    /// <summary>
    /// Qualifies the type of document.
    /// </summary>
    [IsoId("_3yAScQ0qEeqUVL7sB4m7NA")]
    [DisplayName("Document Qualifier")]
    [IsoXmlTag("DocQlfr")]
    public required DocumentType7Code DocumentQualifier { get; init; } 
    
    /// <summary>
    /// Type of awaited response (none, immediate, after printing, after sound).
    /// </summary>
    [IsoId("_3yAScw0qEeqUVL7sB4m7NA")]
    [DisplayName("Response Mode")]
    [IsoXmlTag("RspnMd")]
    public required ResponseMode1Code ResponseMode { get; init; } 
    
    /// <summary>
    /// Flag that the print is integrated to other prints.
    /// </summary>
    [IsoId("_3yASdQ0qEeqUVL7sB4m7NA")]
    [DisplayName("Integrated Print Flag")]
    [IsoXmlTag("IntgrtdPrtFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? IntegratedPrintFlag { get; init; } 
    
    /// <summary>
    /// Flag to require a physical signature by the Customer.
    /// </summary>
    [IsoId("_3yASdw0qEeqUVL7sB4m7NA")]
    [DisplayName("Required Signature Flag")]
    [IsoXmlTag("ReqrdSgntrFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequiredSignatureFlag { get; init; } 
    
    /// <summary>
    /// Content of the message to print.
    /// </summary>
    [IsoId("_3yASeQ0qEeqUVL7sB4m7NA")]
    [DisplayName("Output Content")]
    [IsoXmlTag("OutptCntt")]
    public required ActionMessage7 OutputContent { get; init; } 
    
    
    #nullable disable
    
}
