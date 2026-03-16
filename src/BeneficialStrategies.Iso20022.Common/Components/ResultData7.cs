// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the processing.
/// </summary>
[IsoId("_ms_0QahNEeuOaMA1YOy5YQ")]
[DisplayName("Result Data")]
public record ResultData7
{
    /// <summary>
    /// Generic result of the processing.
    /// ISO 8583 bit 39
    /// </summary>
    [IsoId("_myQuwahNEeuOaMA1YOy5YQ")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Response8Code? Result { get; init; }

    /// <summary>
    /// Other type of result of the processing.
    /// </summary>
    [IsoId("_myQuw6hNEeuOaMA1YOy5YQ")]
    [DisplayName("Other Result")]
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherResult { get; init; }

    /// <summary>
    /// Detailed results of the processing, conforming to ISO 8583 Response codes list.  This code list is maintained by the ISO 8583/MA (maintenance agency).
    /// </summary>
    [IsoId("_myQuxahNEeuOaMA1YOy5YQ")]
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    public required ISO8583ResponseCode ResultDetails { get; init; }

    /// <summary>
    /// Other result details of the processing.
    /// </summary>
    [IsoId("_myQux6hNEeuOaMA1YOy5YQ")]
    [DisplayName("Other Result Details")]
    [IsoXmlTag("OthrRsltDtls")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherResultDetails { get; init; }

    /// <summary>
    /// Issuer permits reuse of temporary secure stored card data.
    /// </summary>
    [IsoId("_1LCyMKhNEeuOaMA1YOy5YQ")]
    [DisplayName("Temporary Secure Card Data Reuse Permitted")]
    [IsoXmlTag("TempScrCardDataReusePrtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TemporarySecureCardDataReusePermitted { get; init; }

    /// <summary>
    /// Additional result information to be conveyed.
    /// </summary>
    [IsoId("_myQuyahNEeuOaMA1YOy5YQ")]
    [DisplayName("Additional Result Information")]
    [IsoXmlTag("AddtlRsltInf")]
    public ValueList<AdditionalData1> AdditionalResultInformation { get; init; } = [];
}
