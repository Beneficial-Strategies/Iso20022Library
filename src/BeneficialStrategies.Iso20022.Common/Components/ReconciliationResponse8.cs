// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of financial service to be used with this message of reconciliation. This is only one service : ReconcialiationResponse.
/// </summary>
[IsoId("_cNbJ0XJTEe299ZbWCkdR_w")]
[DisplayName("Reconciliation Response")]
public record ReconciliationResponse8
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_cT8okXJTEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_cT8ok3JTEe299ZbWCkdR_w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Content of the Reconciliation Response message.
    /// </summary>
    [IsoId("_cT8olXJTEe299ZbWCkdR_w")]
    [DisplayName("Reconciliation Response Data")]
    [IsoXmlTag("RcncltnRspnData")]
    public required ReconciliationResponseData1 ReconciliationResponseData { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_cT8ol3JTEe299ZbWCkdR_w")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_cT8omXJTEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
