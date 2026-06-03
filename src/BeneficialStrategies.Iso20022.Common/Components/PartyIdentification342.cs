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
[IsoId("_WGr0oa5wEfCUHaCK5HWOhg")]
[DisplayName("Party Identification342")]
public record PartyIdentification342
{
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_WM4jQa5wEfCUHaCK5HWOhg")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required PersonName3 NameAndAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account.
    /// </summary>
    [IsoId("_YJARsa5wEfCUHaCK5HWOhg")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_WM4jQ65wEfCUHaCK5HWOhg")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Natural person local identification and type.
    /// </summary>
    [IsoId("_WM4jRa5wEfCUHaCK5HWOhg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public NaturalPersonIdentification1? Identification { get; init; }

    /// <summary>
    /// Nationality of the person.
    /// </summary>
    [IsoId("_WM4jR65wEfCUHaCK5HWOhg")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public CountryCode? Nationality { get; init; }

    /// <summary>
    /// Date on which and place at which a born person is born.
    /// </summary>
    [IsoId("_WM4jSa5wEfCUHaCK5HWOhg")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; }

    /// <summary>
    /// Identification of the shareholder in the company share register.
    /// </summary>
    [IsoId("_WM4jS65wEfCUHaCK5HWOhg")]
    [DisplayName("Company Register Shareholder Identification")]
    [IsoXmlTag("CpnyRegrShrhldrId")]
    public IsoMax35Text? CompanyRegisterShareholderIdentification { get; init; }
}
