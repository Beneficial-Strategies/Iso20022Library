// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of admin service to be used with this message.
/// </summary>
[IsoId("_d0BVIbYCEfCUZfsQO4rYeA")]
[DisplayName("Session Management Response9")]
public record SessionManagementResponse9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_d077JbYCEfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_d077K7YCEfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    /// <summary>
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_d077MbYCEfCUZfsQO4rYeA")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService5Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Login Response message.
    /// </summary>
    [IsoId("_d077N7YCEfCUZfsQO4rYeA")]
    [DisplayName("Login Response")]
    [IsoXmlTag("LgnRspn")]
    public LoginResponse8? LoginResponse { get; init; }

    /// <summary>
    /// Content of the Diagnosis Response message.
    /// </summary>
    [IsoId("_d077PbYCEfCUZfsQO4rYeA")]
    [DisplayName("Diagnosis Response")]
    [IsoXmlTag("DgnssRspn")]
    public DiagnosisResponse8? DiagnosisResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_d077Q7YCEfCUZfsQO4rYeA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_d077SbYCEfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
