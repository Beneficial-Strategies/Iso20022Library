// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding underlying security details.
/// </summary>
[IsoId("_dqeI4b5YEeexmbB7KsjCwA")]
[DisplayName("Financial Instrument Attributes SD")]
public record FinancialInstrumentAttributesSD17
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_d7RlAb5YEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Represents the &apos;original&apos; security identifier of the event. It is used in the scenarios like &quot;partial call&quot; where there are 2 events. The first event distributes into the Contra CUSIP, a temporary security; and on the second event that temporary security becomes the underlying security of the event. This element is used in the second event to point to the original CUSIP.
    /// </summary>
    [IsoId("_d7RlA75YEeexmbB7KsjCwA")]
    [DisplayName("Originating Security Identification")]
    [IsoXmlTag("OrgtgSctyId")]
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; }
}
