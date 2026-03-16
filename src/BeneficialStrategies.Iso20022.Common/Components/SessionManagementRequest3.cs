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
[IsoId("_BkhG0Q1WEeqjM-rxn3HuXQ")]
[DisplayName("Session Management Request")]
public record SessionManagementRequest3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_BwEPgQ1WEeqjM-rxn3HuXQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment75 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_BwEPgw1WEeqjM-rxn3HuXQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_BwEPhQ1WEeqjM-rxn3HuXQ")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService4Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Login Request message.
    /// </summary>
    [IsoId("_BwEPhw1WEeqjM-rxn3HuXQ")]
    [DisplayName("Login Request")]
    [IsoXmlTag("LgnReq")]
    public LoginRequest2? LoginRequest { get; init; }

    /// <summary>
    /// Content of the Logout Request message.
    /// </summary>
    [IsoId("_BwEPiQ1WEeqjM-rxn3HuXQ")]
    [DisplayName("Logout Request")]
    [IsoXmlTag("LgtReq")]
    public LogoutRequest1? LogoutRequest { get; init; }

    /// <summary>
    /// Content of the Diagnosis Request message.
    /// </summary>
    [IsoId("_BwEPiw1WEeqjM-rxn3HuXQ")]
    [DisplayName("Diagnosis Request")]
    [IsoXmlTag("DgnssReq")]
    public DiagnosisRequest1? DiagnosisRequest { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_BwEPjQ1WEeqjM-rxn3HuXQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
