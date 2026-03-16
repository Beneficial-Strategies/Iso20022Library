// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding linkage details.
/// </summary>
[IsoId("_pm0bkb5XEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Cancellation SD")]
public record CorporateActionCancellationSD3
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_p4rAkL5XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a related corporate action event.
    /// </summary>
    [IsoId("_p4rAkr5XEeexmbB7KsjCwA")]
    [DisplayName("Linked Corporate Action Identification")]
    [IsoXmlTag("LkdCorpActnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text LinkedCorporateActionIdentification { get; init; }

    /// <summary>
    /// Indicates the reason why two or more events are related.
    /// </summary>
    [IsoId("_p4rAoL5XEeexmbB7KsjCwA")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public required DTCCLinkType1Code LinkageType { get; init; }

    /// <summary>
    /// Events can be linked together. This date represents the date on which the link was established.
    /// </summary>
    [IsoId("_p4rAqL5XEeexmbB7KsjCwA")]
    [DisplayName("Link Added Date")]
    [IsoXmlTag("LkAddedDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate LinkAddedDate { get; init; }

    /// <summary>
    /// Events can be linked together. This date represents the date on which the link was modified.
    /// </summary>
    [IsoId("_p4rAsL5XEeexmbB7KsjCwA")]
    [DisplayName("Link Modified Date")]
    [IsoXmlTag("LkModfdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LinkModifiedDate { get; init; }
}
