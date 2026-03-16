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
[IsoId("_AnqMMS5MEeunNvJlR_vCbg")]
[DisplayName("Session Management Request")]
public record SessionManagementRequest4
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_A1SYgS5MEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_A1SYgy5MEeunNvJlR_vCbg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_A1SYhS5MEeunNvJlR_vCbg")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService4Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Login Request message.
    /// </summary>
    [IsoId("_A1SYhy5MEeunNvJlR_vCbg")]
    [DisplayName("Login Request")]
    [IsoXmlTag("LgnReq")]
    public LoginRequest3? LoginRequest { get; init; }

    /// <summary>
    /// Content of the Logout Request message.
    /// </summary>
    [IsoId("_A1SYiS5MEeunNvJlR_vCbg")]
    [DisplayName("Logout Request")]
    [IsoXmlTag("LgtReq")]
    public LogoutRequest1? LogoutRequest { get; init; }

    /// <summary>
    /// Content of the Diagnosis Request message.
    /// </summary>
    [IsoId("_A1SYiy5MEeunNvJlR_vCbg")]
    [DisplayName("Diagnosis Request")]
    [IsoXmlTag("DgnssReq")]
    public DiagnosisRequest1? DiagnosisRequest { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_A1SYjS5MEeunNvJlR_vCbg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
