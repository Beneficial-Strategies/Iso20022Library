// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Location information.
/// </summary>
[IsoId("_EBsPBPNCEei4qfiLgRIZBA")]
[DisplayName("Location")]
public record Location3
{
    /// <summary>
    /// Contains the location code.
    /// </summary>
    [IsoId("_8CLxkP5UEeirBKKww67A3w")]
    [DisplayName("Location Code")]
    [IsoXmlTag("LctnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LocationCode { get; init; }

    /// <summary>
    /// Name (label) of the location.
    /// </summary>
    [IsoId("_EBsPBvNCEei4qfiLgRIZBA")]
    [DisplayName("Location Name")]
    [IsoXmlTag("LctnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LocationName { get; init; }

    /// <summary>
    /// Specific explanation of the location or directions.
    /// </summary>
    [IsoId("_EBsPBfNCEei4qfiLgRIZBA")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Description { get; init; }

    /// <summary>
    /// Contains the address details.
    /// </summary>
    [IsoId("_EBsPB_NCEei4qfiLgRIZBA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; }

    /// <summary>
    /// Local time zone.
    /// </summary>
    [IsoId("_gqYoEPcDEeiW-auGnDPZIw")]
    [DisplayName("Local Time Zone")]
    [IsoXmlTag("LclTmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? LocalTimeZone { get; init; }

    /// <summary>
    /// Local currency.
    /// </summary>
    [IsoId("_-KR0kPcDEeiW-auGnDPZIw")]
    [DisplayName("Local Currency")]
    [IsoXmlTag("LclCcy")]
    public ISO3NumericCurrencyCode? LocalCurrency { get; init; }
}
