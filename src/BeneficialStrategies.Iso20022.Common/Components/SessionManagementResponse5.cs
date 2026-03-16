// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of admin service to be used with this message.
/// </summary>
[IsoId("_Hh0iUU6sEeyGi9JAv6wq7Q")]
[DisplayName("Session Management Response")]
public record SessionManagementResponse5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Hn4uEU6sEeyGi9JAv6wq7Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_Hn4uE06sEeyGi9JAv6wq7Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext29 Context { get; init; }

    /// <summary>
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_Hn4uFU6sEeyGi9JAv6wq7Q")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService5Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Login Response message.
    /// </summary>
    [IsoId("_Hn4uF06sEeyGi9JAv6wq7Q")]
    [DisplayName("Login Response")]
    [IsoXmlTag("LgnRspn")]
    public LoginResponse4? LoginResponse { get; init; }

    /// <summary>
    /// Content of the Diagnosis Response message.
    /// </summary>
    [IsoId("_Hn4uGU6sEeyGi9JAv6wq7Q")]
    [DisplayName("Diagnosis Response")]
    [IsoXmlTag("DgnssRspn")]
    public DiagnosisResponse4? DiagnosisResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_Hn4uG06sEeyGi9JAv6wq7Q")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_Hn4uHU6sEeyGi9JAv6wq7Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
