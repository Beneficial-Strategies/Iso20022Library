// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
[IsoId("_RbOl4dp-Ed-ak6NoX_4Aeg_153355944")]
[DisplayName("Comparison Result")]
public record ComparisonResult2
{
    /// <summary>
    /// Sequence number assigned to the element.
    /// </summary>
    [IsoId("_RbOl4tp-Ed-ak6NoX_4Aeg_153356284")]
    [DisplayName("Element Sequence Number")]
    [IsoXmlTag("ElmtSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ElementSequenceNumber { get; init; }

    /// <summary>
    /// Specifies from the root of the message the complete path of the element.
    /// </summary>
    [IsoId("_RbOl49p-Ed-ak6NoX_4Aeg_153355976")]
    [DisplayName("Element Path")]
    [IsoXmlTag("ElmtPth")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text ElementPath { get; init; }

    /// <summary>
    /// Name of the element.
    /// </summary>
    [IsoId("_RbOl5Np-Ed-ak6NoX_4Aeg_153356222")]
    [DisplayName("Element Name")]
    [IsoXmlTag("ElmtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ElementName { get; init; }

    /// <summary>
    /// Replacement of an existing content by a different one.
    /// </summary>
    [IsoId("_RbOl5dp-Ed-ak6NoX_4Aeg_153356746")]
    [DisplayName("Replacement")]
    [IsoXmlTag("Rplcmnt")]
    public required Replacement2 Replacement { get; init; }

    /// <summary>
    /// Deletion of the current element.
    /// </summary>
    [IsoId("_RbOl5tp-Ed-ak6NoX_4Aeg_153356346")]
    [DisplayName("Deletion")]
    [IsoXmlTag("Deltn")]
    public required Deletion2 Deletion { get; init; }

    /// <summary>
    /// Addition of a new element.
    /// </summary>
    [IsoId("_RbOl59p-Ed-ak6NoX_4Aeg_153356686")]
    [DisplayName("Addition")]
    [IsoXmlTag("Addtn")]
    public required Addition2 Addition { get; init; }
}
