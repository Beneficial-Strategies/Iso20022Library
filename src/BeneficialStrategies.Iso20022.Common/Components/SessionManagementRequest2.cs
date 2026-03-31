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
[IsoId("_C8Um8YYBEemxIqbaFEE8-w")]
[DisplayName("Session Management Request")]
public record SessionManagementRequest2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_DG2b8YYBEemxIqbaFEE8-w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment73 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_DG2b84YBEemxIqbaFEE8-w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext27 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_DG2b9YYBEemxIqbaFEE8-w")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService4Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Login Request message.
    /// </summary>
    [IsoId("_DG2b94YBEemxIqbaFEE8-w")]
    [DisplayName("Login Request")]
    [IsoXmlTag("LgnReq")]
    public LoginRequest1? LoginRequest { get; init; }

    /// <summary>
    /// Content of the Logout Request message.
    /// </summary>
    [IsoId("_DG2b-YYBEemxIqbaFEE8-w")]
    [DisplayName("Logout Request")]
    [IsoXmlTag("LgtReq")]
    public LogoutRequest1? LogoutRequest { get; init; }

    /// <summary>
    /// Content of the Diagnosis Request message.
    /// </summary>
    [IsoId("_DG2b-4YBEemxIqbaFEE8-w")]
    [DisplayName("Diagnosis Request")]
    [IsoXmlTag("DgnssReq")]
    public DiagnosisRequest1? DiagnosisRequest { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_DG2b_YYBEemxIqbaFEE8-w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
