// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification and a version.|Also provides reference to a baseline amendment number.
/// </summary>
[IsoId("_RJWLtNp-Ed-ak6NoX_4Aeg_-481192802")]
[DisplayName("Document Identification")]
public record DocumentIdentification6
{
    /// <summary>
    /// Identification of a set of data.
    /// </summary>
    [IsoId("_RJWLtdp-Ed-ak6NoX_4Aeg_-449794434")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Unambiguous identification of the version of a set of data. Example: Version 1.
    /// </summary>
    [IsoId("_RJWLttp-Ed-ak6NoX_4Aeg_-449794157")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Version { get; init; }

    /// <summary>
    /// Number that is assigned sequentially by the TSU to a baseline amendment.
    /// </summary>
    [IsoId("_RJWLt9p-Ed-ak6NoX_4Aeg_-449794140")]
    [DisplayName("Amendment Sequence Number")]
    [IsoXmlTag("AmdmntSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? AmendmentSequenceNumber { get; init; }
}
