// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation Response9.
/// </summary>
[IsoId("_TEb3sZL7Ee6GkefOR4Wjuw")]
[DisplayName("Reconciliation Response9")]
public record ReconciliationResponse9
{
    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment80 Environment { get; init; }

    /// <summary>
    /// Reconciliation Response Data.
    /// </summary>
    [DisplayName("Reconciliation Response Data")]
    [IsoXmlTag("RcncltnRspnData")]
    public required ReconciliationResponseData1 ReconciliationResponseData { get; init; }

    /// <summary>
    /// Response.
    /// </summary>
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
