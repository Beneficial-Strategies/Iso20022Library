// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification and a version.
/// </summary>
[IsoId("_RJNBwdp-Ed-ak6NoX_4Aeg_-1127047102")]
[DisplayName("Document Identification")]
public record DocumentIdentification3
{
    /// <summary>
    /// Identification of a set of data.
    /// </summary>
    [IsoId("_RJNBwtp-Ed-ak6NoX_4Aeg_-841680229")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Unambiguous identification of the version of a set of data. Example: Version 1.
    /// </summary>
    [IsoId("_RJNBw9p-Ed-ak6NoX_4Aeg_-841680211")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Version { get; init; }
}
