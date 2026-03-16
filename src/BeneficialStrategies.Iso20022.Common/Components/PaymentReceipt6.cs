// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Receipt6.
/// </summary>
[IsoId("_PPvBIJEFEe6Un9Rms6YuCg")]
[DisplayName("Payment Receipt6")]
public partial record PaymentReceipt6
{
    #nullable enable

    /// <summary>
    /// Document Qualifier.
    /// </summary>
    [DisplayName("Document Qualifier")]
    [IsoXmlTag("DocQlfr")]
    public required DocumentType7Code DocumentQualifier { get; init; } 

    /// <summary>
    /// Integrated Print Flag.
    /// </summary>
    [DisplayName("Integrated Print Flag")]
    [IsoXmlTag("IntgrtdPrtFlg")]
    public IsoTrueFalseIndicator? IntegratedPrintFlag { get; init; } 

    /// <summary>
    /// Output Content.
    /// </summary>
    [DisplayName("Output Content")]
    [IsoXmlTag("OutptCntt")]
    public required ActionMessage11 OutputContent { get; init; } 

    /// <summary>
    /// Required Signature Flag.
    /// </summary>
    [DisplayName("Required Signature Flag")]
    [IsoXmlTag("ReqrdSgntrFlg")]
    public IsoTrueFalseIndicator? RequiredSignatureFlag { get; init; } 

    
    #nullable disable
    
}
