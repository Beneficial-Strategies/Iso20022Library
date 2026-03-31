// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Batch Response message.
/// </summary>
[IsoId("_3Y34MU0_Eeybj420QgWBkA")]
[DisplayName("Batch Response")]
public record BatchResponse4
{
    /// <summary>
    /// Sale System identification of the bacth in an unambiguous way.
    /// </summary>
    [IsoId("_ZjuikU7uEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Batch Identification")]
    [IsoXmlTag("SaleBtchId")]
    public TransactionIdentifier1? SaleBatchIdentification { get; init; }

    /// <summary>
    /// POI identification of the batch in an unambiguous way.
    /// </summary>
    [IsoId("_xJJ7wU7uEeyGi9JAv6wq7Q")]
    [DisplayName("POI Batch Identification")]
    [IsoXmlTag("POIBtchId")]
    public TransactionIdentifier1? POIBatchIdentification { get; init; }

    /// <summary>
    /// Performed transaction content.
    /// </summary>
    [IsoId("_3fnZYU0_Eeybj420QgWBkA")]
    [DisplayName("Performed Transaction")]
    [IsoXmlTag("PrfrmdTx")]
    public ValueList<PerformedTransaction4> PerformedTransaction { get; init; } = [];
}
