// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or electronic address used for communication.
/// </summary>
[IsoId("_QKKmpdp-Ed-ak6NoX_4Aeg_-22102184")]
[DisplayName("Communication Address")]
public record CommunicationAddress4
{
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_QKKmptp-Ed-ak6NoX_4Aeg_24996102")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Address for the Universal Resource Locator (URL), eg, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_QKKmp9p-Ed-ak6NoX_4Aeg_25918539")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }
}
