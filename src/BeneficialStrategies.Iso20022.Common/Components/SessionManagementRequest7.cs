// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Session Management Request7.
/// </summary>
[IsoId("_qohUcZL4Ee6GkefOR4Wjuw")]
[DisplayName("Session Management Request7")]
public record SessionManagementRequest7
{
    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Diagnosis Request.
    /// </summary>
    [DisplayName("Diagnosis Request")]
    [IsoXmlTag("DgnssReq")]
    public DiagnosisRequest1? DiagnosisRequest { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment80 Environment { get; init; }

    /// <summary>
    /// Login Request.
    /// </summary>
    [DisplayName("Login Request")]
    [IsoXmlTag("LgnReq")]
    public LoginRequest6? LoginRequest { get; init; }

    /// <summary>
    /// Logout Request.
    /// </summary>
    [DisplayName("Logout Request")]
    [IsoXmlTag("LgtReq")]
    public LogoutRequest1? LogoutRequest { get; init; }

    /// <summary>
    /// Service Content.
    /// </summary>
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService4Code ServiceContent { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
