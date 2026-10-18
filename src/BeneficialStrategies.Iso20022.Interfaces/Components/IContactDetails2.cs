// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or electronic address used for communication.
/// </summary>
[IsoId("_QJ3rtNp-Ed-ak6NoX_4Aeg_446489744")]
public interface IContactDetails2 : IIsoComponent
{
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_QJ3rtdp-Ed-ak6NoX_4Aeg_-1688546792")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    NamePrefix1Code? NamePrefix { get; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QJ3rttp-Ed-ak6NoX_4Aeg_446489753")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    Max140Text? Name { get; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QJ3rt9p-Ed-ak6NoX_4Aeg_447410116")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    PhoneNumber? PhoneNumber { get; }

    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QJ3ruNp-Ed-ak6NoX_4Aeg_880542111")]
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    PhoneNumber? MobileNumber { get; }

    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_QKBcsNp-Ed-ak6NoX_4Aeg_447410147")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    PhoneNumber? FaxNumber { get; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_QKBcsdp-Ed-ak6NoX_4Aeg_446490084")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    Max2048Text? EmailAddress { get; }

    /// <summary>
    /// Contact details in another form.
    /// </summary>
    [IsoId("_QKBcstp-Ed-ak6NoX_4Aeg_1321060960")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    Max35Text? Other { get; }
}
