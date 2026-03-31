// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_ATj_RTUDEe2tRf29bleifQ")]
[DisplayName("Party Identification")]
public record PartyIdentification269
{
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_ArjogTUDEe2tRf29bleifQ")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required PersonName2 NameAndAddress { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_ArjogzUDEe2tRf29bleifQ")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_ArjohTUDEe2tRf29bleifQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification198Choice_? Identification { get; init; }

    /// <summary>
    /// Identification of the shareholder in the company share register.
    /// </summary>
    [IsoId("_ArjohzUDEe2tRf29bleifQ")]
    [DisplayName("Company Register Shareholder Identification")]
    [IsoXmlTag("CpnyRegrShrhldrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CompanyRegisterShareholderIdentification { get; init; }

    /// <summary>
    /// Country in which the company is incorporated or legally registered.
    /// </summary>
    [IsoId("_LunGQDUDEe2tRf29bleifQ")]
    [DisplayName("Country Of Incorporation")]
    [IsoXmlTag("CtryOfIncorprtn")]
    public CountryCode? CountryOfIncorporation { get; init; }
}
