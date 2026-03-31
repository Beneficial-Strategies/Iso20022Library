// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification and a version together with the identification of the submitter of the document.
/// </summary>
[IsoId("_RJDQxtp-Ed-ak6NoX_4Aeg_632201605")]
[DisplayName("Document Identification")]
public record DocumentIdentification1
{
    /// <summary>
    /// Identification of a set of data.
    /// </summary>
    [IsoId("_RJDQx9p-Ed-ak6NoX_4Aeg_1045013628")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Unambiguous identification of the version of a set of data. Example: Version 1.
    /// </summary>
    [IsoId("_RJDQyNp-Ed-ak6NoX_4Aeg_1045013940")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Version { get; init; }

    /// <summary>
    /// Uniquely identifies the financial institution which has submitted the set of data by using a BIC.
    /// </summary>
    [IsoId("_RJNBwNp-Ed-ak6NoX_4Aeg_-237333531")]
    [DisplayName("Submitter")]
    [IsoXmlTag("Submitr")]
    public required BICIdentification1 Submitter { get; init; }
}
