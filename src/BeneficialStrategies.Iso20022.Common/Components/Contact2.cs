// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a contact person.
/// </summary>
[IsoId("_DZOUkVyuEeeve7Je9cXtkQ")]
[DisplayName("Contact")]
public record Contact2
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_DkrWoVyuEeeve7Je9cXtkQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Home phone number of contact.
    /// </summary>
    [IsoId("_gNEyB45UEeeiH8xEoW101w")]
    [DisplayName("Home Phone Number")]
    [IsoXmlTag("HomePhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? HomePhoneNumber { get; init; }

    /// <summary>
    /// Business phone number of contact.
    /// </summary>
    [IsoId("_gNEyCI5UEeeiH8xEoW101w")]
    [DisplayName("Business Phone Number")]
    [IsoXmlTag("BizPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? BusinessPhoneNumber { get; init; }

    /// <summary>
    /// Mobile phone number of contact.
    /// </summary>
    [IsoId("_gNEyCY5UEeeiH8xEoW101w")]
    [DisplayName("Mobile Phone Number")]
    [IsoXmlTag("MobPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? MobilePhoneNumber { get; init; }

    /// <summary>
    /// Other phone number of contact.
    /// </summary>
    [IsoId("_gNEyCo5UEeeiH8xEoW101w")]
    [DisplayName("Other Phone Number")]
    [IsoXmlTag("OthrPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? OtherPhoneNumber { get; init; }

    /// <summary>
    /// Personal email address of contact.
    /// </summary>
    [IsoId("_gNEyC45UEeeiH8xEoW101w")]
    [DisplayName("Personal Email Address")]
    [IsoXmlTag("PrsnlEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? PersonalEmailAddress { get; init; }

    /// <summary>
    /// Business email address of contact.
    /// </summary>
    [IsoId("_gNEyDI5UEeeiH8xEoW101w")]
    [DisplayName("Business Email Address")]
    [IsoXmlTag("BizEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? BusinessEmailAddress { get; init; }

    /// <summary>
    /// Other email address of contact.
    /// </summary>
    [IsoId("_gNEyDY5UEeeiH8xEoW101w")]
    [DisplayName("Other Email Address")]
    [IsoXmlTag("OthrEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? OtherEmailAddress { get; init; }

    /// <summary>
    /// Collection of information that identifies a home FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_DkrWo1yuEeeve7Je9cXtkQ")]
    [DisplayName("Home Fax Number")]
    [IsoXmlTag("HomeFaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? HomeFaxNumber { get; init; }

    /// <summary>
    /// Collection of information that identifies a home FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_wAu4AI5UEeeiH8xEoW101w")]
    [DisplayName("Business Fax Number")]
    [IsoXmlTag("BizFaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? BusinessFaxNumber { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_DkrWqVyuEeeve7Je9cXtkQ")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }

    /// <summary>
    /// Language of the contact.
    /// </summary>
    [IsoId("_Jvq5QFyuEeeve7Je9cXtkQ")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISO2ALanguageCode? Language { get; init; }
}
