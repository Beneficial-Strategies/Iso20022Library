// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the chargeback initiation transaction.
/// </summary>
[IsoId("_qz-mEFDZEee94_dUz-hvgw")]
[DisplayName("Charge Back Initiation")]
public record ChargeBackInitiation1
{
    /// <summary>
    /// Environment of the chargeback.
    /// </summary>
    [IsoId("_1d9cgFDZEee94_dUz-hvgw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment13 Environment { get; init; }

    /// <summary>
    /// Context of the chargeback transaction.
    /// </summary>
    [IsoId("_L5W2EFDbEee94_dUz-hvgw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context7? Context { get; init; }

    /// <summary>
    /// Chargeback transaction details.
    /// </summary>
    [IsoId("_fLIowFDbEee94_dUz-hvgw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction97 Transaction { get; init; }

    /// <summary>
    /// Contains details of the transaction to be retrieved.
    /// </summary>
    [IsoId("_NEDe0fMrEei4qfiLgRIZBA")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public required OriginalTransaction1 OriginalTransaction { get; init; }

    /// <summary>
    /// Result of the chargeback verification provided in the chargeback status.
    /// </summary>
    [IsoId("_0lXgQFDcEee94_dUz-hvgw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult8? ProcessingResult { get; init; }

    /// <summary>
    /// EContains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_PBl8YdXwEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_4W3IgaK4EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
