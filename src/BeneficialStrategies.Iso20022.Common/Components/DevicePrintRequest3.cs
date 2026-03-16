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
[IsoId("_IyqbgS8MEeu125Ip9zFcsQ")]
[DisplayName("Device Print Request")]
public record DevicePrintRequest3
{
    /// <summary>
    /// Qualifies the type of document.
    /// </summary>
    [IsoId("_JDQcQS8MEeu125Ip9zFcsQ")]
    [DisplayName("Document Qualifier")]
    [IsoXmlTag("DocQlfr")]
    public required DocumentType7Code DocumentQualifier { get; init; }

    /// <summary>
    /// Type of awaited response (none, immediate, after printing, after sound).
    /// </summary>
    [IsoId("_JDQcQy8MEeu125Ip9zFcsQ")]
    [DisplayName("Response Mode")]
    [IsoXmlTag("RspnMd")]
    public required ResponseMode2Code ResponseMode { get; init; }

    /// <summary>
    /// Flag that the print is integrated to other prints.
    /// </summary>
    [IsoId("_JDQcRS8MEeu125Ip9zFcsQ")]
    [DisplayName("Integrated Print Flag")]
    [IsoXmlTag("IntgrtdPrtFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? IntegratedPrintFlag { get; init; }

    /// <summary>
    /// Flag to require a physical signature by the Customer.
    /// </summary>
    [IsoId("_JDQcRy8MEeu125Ip9zFcsQ")]
    [DisplayName("Required Signature Flag")]
    [IsoXmlTag("ReqrdSgntrFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequiredSignatureFlag { get; init; }

    /// <summary>
    /// Content of the message to print.
    /// </summary>
    [IsoId("_JDQcSS8MEeu125Ip9zFcsQ")]
    [DisplayName("Output Content")]
    [IsoXmlTag("OutptCntt")]
    public required ActionMessage8 OutputContent { get; init; }
}
