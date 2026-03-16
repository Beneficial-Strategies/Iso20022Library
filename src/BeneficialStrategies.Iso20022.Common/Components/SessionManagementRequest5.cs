// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of Session management service to be used with this message.
/// </summary>
[IsoId("_gAxp4U6_EeyGi9JAv6wq7Q")]
[DisplayName("Session Management Request")]
public record SessionManagementRequest5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_gIATQU6_EeyGi9JAv6wq7Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_gIATQ06_EeyGi9JAv6wq7Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext29 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_gIATRU6_EeyGi9JAv6wq7Q")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService4Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Login Request message.
    /// </summary>
    [IsoId("_gIATR06_EeyGi9JAv6wq7Q")]
    [DisplayName("Login Request")]
    [IsoXmlTag("LgnReq")]
    public LoginRequest4? LoginRequest { get; init; }

    /// <summary>
    /// Content of the Logout Request message.
    /// </summary>
    [IsoId("_gIATSU6_EeyGi9JAv6wq7Q")]
    [DisplayName("Logout Request")]
    [IsoXmlTag("LgtReq")]
    public LogoutRequest1? LogoutRequest { get; init; }

    /// <summary>
    /// Content of the Diagnosis Request message.
    /// </summary>
    [IsoId("_gIATS06_EeyGi9JAv6wq7Q")]
    [DisplayName("Diagnosis Request")]
    [IsoXmlTag("DgnssReq")]
    public DiagnosisRequest1? DiagnosisRequest { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_gIATTU6_EeyGi9JAv6wq7Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
