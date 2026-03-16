// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of financial service to be used with this message of Reconciliation. This is only one service : ReconcialiationResponse.
/// </summary>
[IsoId("_MTmrYS5LEeunNvJlR_vCbg")]
[DisplayName("Reconciliation Response")]
public record ReconciliationResponse5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_MiATwS5LEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_MiATwy5LEeunNvJlR_vCbg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Content of the Reconciliation Response message.
    /// </summary>
    [IsoId("_MiATxS5LEeunNvJlR_vCbg")]
    [DisplayName("Reconciliation Response Data")]
    [IsoXmlTag("RcncltnRspnData")]
    public required ReconciliationResponseData1 ReconciliationResponseData { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_MiATxy5LEeunNvJlR_vCbg")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_MiATyS5LEeunNvJlR_vCbg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
