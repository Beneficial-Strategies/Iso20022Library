// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of session management service to be used with this message.
/// </summary>
[IsoId("_flbWgXJKEe299ZbWCkdR_w")]
[DisplayName("Session Management Request")]
public record SessionManagementRequest6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_ftHS4XJKEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_ftHS43JKEe299ZbWCkdR_w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_ftHS5XJKEe299ZbWCkdR_w")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService4Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Login Request message.
    /// </summary>
    [IsoId("_ftHS53JKEe299ZbWCkdR_w")]
    [DisplayName("Login Request")]
    [IsoXmlTag("LgnReq")]
    public LoginRequest5? LoginRequest { get; init; }

    /// <summary>
    /// Content of the Logout Request message.
    /// </summary>
    [IsoId("_ftHS6XJKEe299ZbWCkdR_w")]
    [DisplayName("Logout Request")]
    [IsoXmlTag("LgtReq")]
    public LogoutRequest1? LogoutRequest { get; init; }

    /// <summary>
    /// Content of the Diagnosis Request message.
    /// </summary>
    [IsoId("_ftHS63JKEe299ZbWCkdR_w")]
    [DisplayName("Diagnosis Request")]
    [IsoXmlTag("DgnssReq")]
    public DiagnosisRequest1? DiagnosisRequest { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_ftHS7XJKEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
