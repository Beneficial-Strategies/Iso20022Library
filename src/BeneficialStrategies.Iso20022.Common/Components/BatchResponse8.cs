// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the batch response message.
/// </summary>
[IsoId("_VUaHEbZbEfCUZfsQO4rYeA")]
[DisplayName("Batch Response8")]
public record BatchResponse8
{
    /// <summary>
    /// Sale System identification of the batch in an unambiguous way.
    /// </summary>
    [IsoId("_VVUGBbZbEfCUZfsQO4rYeA")]
    [DisplayName("Sale Batch Identification")]
    [IsoXmlTag("SaleBtchId")]
    public TransactionIdentifier1? SaleBatchIdentification { get; init; }

    /// <summary>
    /// POI identification of the batch in an unambiguous way.
    /// </summary>
    [IsoId("_VVUGC7ZbEfCUZfsQO4rYeA")]
    [DisplayName("POI Batch Identification")]
    [IsoXmlTag("POIBtchId")]
    public TransactionIdentifier1? POIBatchIdentification { get; init; }

    /// <summary>
    /// Performed transaction content.
    /// </summary>
    [IsoId("_VVUGEbZbEfCUZfsQO4rYeA")]
    [DisplayName("Performed Transaction")]
    [IsoXmlTag("PrfrmdTx")]
    public ValueList<PerformedTransaction8> PerformedTransaction { get; init; } = [];
}
