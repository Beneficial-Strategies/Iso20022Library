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
[IsoId("_ja7hEb5XEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Notification SD")]
public record CorporateActionNotificationSD10
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_jrS4Ub5XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Internal security identification as provided by the customer for the given security on the security of interest (SOI) import file.
    /// </summary>
    [IsoId("_jrS4U75XEeexmbB7KsjCwA")]
    [DisplayName("Customer Internal Security Identification")]
    [IsoXmlTag("CstmrIntlSctyId")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? CustomerInternalSecurityIdentification { get; init; }

    /// <summary>
    /// Security identifier that is used to match the customer&apos;s SOI (Security of Interest) to the GCA VS Security Cross Reference.
    /// </summary>
    [IsoId("_jrS4W75XEeexmbB7KsjCwA")]
    [DisplayName("Security Of Interest Matching Security")]
    [IsoXmlTag("SctyOfIntrstMtchgScty")]
    public SecurityIdentification20? SecurityOfInterestMatchingSecurity { get; init; }
}
