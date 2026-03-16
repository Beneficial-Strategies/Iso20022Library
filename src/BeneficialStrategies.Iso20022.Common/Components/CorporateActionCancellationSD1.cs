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
[IsoId("_1cdeoTL3EeKU9IrkkToqcw_-445567817")]
[DisplayName("Corporate Action Cancellation SD")]
public record CorporateActionCancellationSD1
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1cdeojL3EeKU9IrkkToqcw_-559406883")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a related corporate action event.
    /// </summary>
    [IsoId("_1cdeozL3EeKU9IrkkToqcw_-51875322")]
    [DisplayName("Linked Corporate Action Identification")]
    [IsoXmlTag("LkdCorpActnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text LinkedCorporateActionIdentification { get; init; }

    /// <summary>
    /// Indicates the reason why two or more events are related.
    /// </summary>
    [IsoId("_1cdepDL3EeKU9IrkkToqcw_-1442640170")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public required DTCCLinkType1Code LinkageType { get; init; }

    /// <summary>
    /// Events can be linked together. This date represents the date on which the link was established.
    /// </summary>
    [IsoId("_1cdepTL3EeKU9IrkkToqcw_858182420")]
    [DisplayName("Link Added Date")]
    [IsoXmlTag("LkAddedDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate LinkAddedDate { get; init; }

    /// <summary>
    /// Events can be linked together. This date represents the date on which the link was modified.
    /// </summary>
    [IsoId("_1cnPoDL3EeKU9IrkkToqcw_1855254773")]
    [DisplayName("Link Modified Date")]
    [IsoXmlTag("LkModfdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LinkModifiedDate { get; init; }
}
