// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details an individuation of the classification type of the financial instrument.
/// </summary>
[IsoId("_NHRMYX5xEeasY4u9QTizPQ")]
[DisplayName("Securities Instrument Classification")]
public record SecuritiesInstrumentClassification2
{
    /// <summary>
    /// Identifier of the financial instrument classification type code.
    /// </summary>
    [IsoId("_NP5j8X5xEeasY4u9QTizPQ")]
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public required IsoCFIOct2015Identifier Identifier { get; init; }

    /// <summary>
    /// Modification status for the record compared to the previous report.
    /// </summary>
    [IsoId("_NP5j835xEeasY4u9QTizPQ")]
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    public Modification1Code? Modification { get; init; }

    /// <summary>
    /// Details the validity of the specific record.
    /// Usage:
    /// Within MiFIR, the FromDate is populated while the instrument is valid. From Date To Date is only populated when the record is being invalidated.
    /// </summary>
    [IsoId("_NP5j9X5xEeasY4u9QTizPQ")]
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public required Period4Choice_ ValidityPeriod { get; init; }

    /// <summary>
    /// Date when this record was last modified.
    /// </summary>
    [IsoId("_NP5j935xEeasY4u9QTizPQ")]
    [DisplayName("Last Updated")]
    [IsoXmlTag("LastUpdtd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LastUpdated { get; init; }
}
