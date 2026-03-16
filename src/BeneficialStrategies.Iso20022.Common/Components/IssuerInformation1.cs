// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
[IsoId("_QRLNk9p-Ed-ak6NoX_4Aeg_291424432")]
[DisplayName("Issuer Information")]
public record IssuerInformation1
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_QRLNlNp-Ed-ak6NoX_4Aeg_1651772804")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification9Choice_ Identification { get; init; }

    /// <summary>
    /// Address for the Universal Resource Locator (URL), eg, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_QRLNldp-Ed-ak6NoX_4Aeg_586029588")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }
}
