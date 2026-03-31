// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device Print Request6.
/// </summary>
[IsoId("_4ozh4ZCTEe6zroekBXoFoQ")]
[DisplayName("Device Print Request6")]
public record DevicePrintRequest6
{
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

    /// <summary>
    /// Response Mode.
    /// </summary>
    [DisplayName("Response Mode")]
    [IsoXmlTag("RspnMd")]
    public required ResponseMode2Code ResponseMode { get; init; }
}
