// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Print Request message.
/// </summary>
[IsoId("__-8okbZeEfCUZfsQO4rYeA")]
[DisplayName("Device Print Request7")]
public record DevicePrintRequest7
{
    /// <summary>
    /// Qualifies the type of document.
    /// </summary>
    [IsoId("___2nhbZeEfCUZfsQO4rYeA")]
    [DisplayName("Document Qualifier")]
    [IsoXmlTag("DocQlfr")]
    public required DocumentType7Code DocumentQualifier { get; init; }

    /// <summary>
    /// Type of awaited response (none, immediate, after printing, after sound).
    /// </summary>
    [IsoId("___2ni7ZeEfCUZfsQO4rYeA")]
    [DisplayName("Response Mode")]
    [IsoXmlTag("RspnMd")]
    public required ResponseMode2Code ResponseMode { get; init; }

    /// <summary>
    /// Flag that the print is integrated to other prints.
    /// </summary>
    [IsoId("___2nkbZeEfCUZfsQO4rYeA")]
    [DisplayName("Integrated Print Flag")]
    [IsoXmlTag("IntgrtdPrtFlg")]
    public IsoTrueFalseIndicator? IntegratedPrintFlag { get; init; }

    /// <summary>
    /// Flag to require a physical signature by the Customer.
    /// </summary>
    [IsoId("___2nl7ZeEfCUZfsQO4rYeA")]
    [DisplayName("Required Signature Flag")]
    [IsoXmlTag("ReqrdSgntrFlg")]
    public IsoTrueFalseIndicator? RequiredSignatureFlag { get; init; }

    /// <summary>
    /// Content of the message to print.
    /// </summary>
    [IsoId("___2nnbZeEfCUZfsQO4rYeA")]
    [DisplayName("Output Content")]
    [IsoXmlTag("OutptCntt")]
    public required ActionMessage12 OutputContent { get; init; }
}
