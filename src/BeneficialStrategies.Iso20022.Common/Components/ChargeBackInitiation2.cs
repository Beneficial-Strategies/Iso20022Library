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
[IsoId("__Ot3UYHREeuwq_rv81SdXw")]
[DisplayName("Charge Back Initiation")]
public record ChargeBackInitiation2
{
    /// <summary>
    /// Environment of the chargeback.
    /// </summary>
    [IsoId("__Tr24YHREeuwq_rv81SdXw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment21 Environment { get; init; }

    /// <summary>
    /// Context of the chargeback transaction.
    /// </summary>
    [IsoId("__Tr244HREeuwq_rv81SdXw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context14? Context { get; init; }

    /// <summary>
    /// Chargeback transaction details.
    /// </summary>
    [IsoId("__Tr25YHREeuwq_rv81SdXw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction154 Transaction { get; init; }

    /// <summary>
    /// Contains details of the transaction to be retrieved.
    /// </summary>
    [IsoId("__Tr254HREeuwq_rv81SdXw")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public required OriginalTransaction2 OriginalTransaction { get; init; }

    /// <summary>
    /// Result of the chargeback verification provided in the chargeback status.
    /// </summary>
    [IsoId("__Tr26YHREeuwq_rv81SdXw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult21? ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("__Tr264HREeuwq_rv81SdXw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("__Tr27YHREeuwq_rv81SdXw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
