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
[IsoId("_8_5WYa5vEfCUHaCK5HWOhg")]
[DisplayName("Party Identification341")]
public record PartyIdentification341
{
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_9GWjsa5vEfCUHaCK5HWOhg")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required PersonName2 NameAndAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account.
    /// </summary>
    [IsoId("_Nj238K5wEfCUHaCK5HWOhg")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_9GWjs65vEfCUHaCK5HWOhg")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_9GWjta5vEfCUHaCK5HWOhg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification198Choice? Identification { get; init; }

    /// <summary>
    /// Identification of the shareholder in the company share register.
    /// </summary>
    [IsoId("_9GWjt65vEfCUHaCK5HWOhg")]
    [DisplayName("Company Register Shareholder Identification")]
    [IsoXmlTag("CpnyRegrShrhldrId")]
    public IsoMax35Text? CompanyRegisterShareholderIdentification { get; init; }

    /// <summary>
    /// Country in which the company is incorporated or legally registered.
    /// </summary>
    [IsoId("_9GWjua5vEfCUHaCK5HWOhg")]
    [DisplayName("Country Of Incorporation")]
    [IsoXmlTag("CtryOfIncorprtn")]
    public CountryCode? CountryOfIncorporation { get; init; }
}
