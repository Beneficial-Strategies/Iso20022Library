// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the non financial request.
/// </summary>
[IsoId("_YkhCEXJWEe299ZbWCkdR_w")]
[DisplayName("Non Financial Request Component")]
public record NonFinancialRequestComponent3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Yq-2cXJWEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_Yq-2c3JWEe299ZbWCkdR_w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Aim of the non financial request.
    /// </summary>
    [IsoId("_Yq-2dXJWEe299ZbWCkdR_w")]
    [DisplayName("Non Financial Request Content")]
    [IsoXmlTag("NonFinReqCntt")]
    public required NonFinancialRequestContentComponent3 NonFinancialRequestContent { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_Yq-2d3JWEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
