// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the reconciliation.
/// </summary>
[IsoId("_GHeMwE93EeePXdaAO32Uew")]
[DisplayName("Reconciliation Initiation")]
public record ReconciliationInitiation1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_R71LoE93EeePXdaAO32Uew")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment3 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_yP53sMyaEeiqqJhU2tqK8A")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context9? Context { get; init; }

    /// <summary>
    /// Data pertaining to the reconciliation transaction.
    /// </summary>
    [IsoId("_uPJ3UE93EeePXdaAO32Uew")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction94 Transaction { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_cQi0gdXxEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_Vwk_EaK6EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
