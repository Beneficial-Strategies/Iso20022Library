// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the fulfilment of a retrieval.
/// </summary>
[IsoId("_w0G-EeFIEeeRS5LRvWPKMw")]
[DisplayName("Retrieval Fulfilment Initiation")]
public record RetrievalFulfilmentInitiation1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_w_27EeFIEeeRS5LRvWPKMw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment13 Environment { get; init; }

    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_w_27E-FIEeeRS5LRvWPKMw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context4 Context { get; init; }

    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    [IsoId("_Qr2TkPF4EeiGNursv3uE_g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction89? Transaction { get; init; }

    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    [IsoId("_w_27FeFIEeeRS5LRvWPKMw")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public OriginalTransaction1? OriginalTransaction { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_w_27IeFIEeeRS5LRvWPKMw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_w_27I-FIEeeRS5LRvWPKMw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
