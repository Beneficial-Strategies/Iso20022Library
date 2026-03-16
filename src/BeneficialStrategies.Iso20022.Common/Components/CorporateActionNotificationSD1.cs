// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer security identification reference information.
/// </summary>
[IsoId("_1Tg-ADL3EeKU9IrkkToqcw_-2108418056")]
[DisplayName("Corporate Action Notification SD")]
public record CorporateActionNotificationSD1
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1Tg-ATL3EeKU9IrkkToqcw_1641834561")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Internal security identification as provided by the customer for the given security on the security of interest (SOI) import file.
    /// </summary>
    [IsoId("_1Tg-AjL3EeKU9IrkkToqcw_-48041887")]
    [DisplayName("Customer Internal Security Identification")]
    [IsoXmlTag("CstmrIntlSctyId")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? CustomerInternalSecurityIdentification { get; init; }

    /// <summary>
    /// Security identifier that is used to match the customer&apos;s SOI (Security of Interest) to the GCA VS Security Cross Reference.
    /// </summary>
    [IsoId("_1Tg-AzL3EeKU9IrkkToqcw_-1925537148")]
    [DisplayName("Security Of Interest Matching Security")]
    [IsoXmlTag("SctyOfIntrstMtchgScty")]
    public SecurityIdentification15? SecurityOfInterestMatchingSecurity { get; init; }
}
