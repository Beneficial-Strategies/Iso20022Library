// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information which describes the organisation.
/// </summary>
[IsoId("_B8VHuW49EeiU9cctagi5ow")]
[DisplayName("Organisation")]
public record Organisation33
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_CFttMW49EeiU9cctagi5ow")]
    [DisplayName("Full Legal Name")]
    [IsoXmlTag("FullLglNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text FullLegalName { get; init; }

    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another.
    /// </summary>
    [IsoId("_CFttM249EeiU9cctagi5ow")]
    [DisplayName("Trading Name")]
    [IsoXmlTag("TradgNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? TradingName { get; init; }

    /// <summary>
    /// Country in which the organisation has its business activity.
    /// </summary>
    [IsoId("_CFttNW49EeiU9cctagi5ow")]
    [DisplayName("Country Of Operation")]
    [IsoXmlTag("CtryOfOpr")]
    public required CountryCode CountryOfOperation { get; init; }

    /// <summary>
    /// Date at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_CFttN249EeiU9cctagi5ow")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; }

    /// <summary>
    /// Specifies an operational address, for example, of a shared services centre.
    /// </summary>
    [IsoId("_CFttOW49EeiU9cctagi5ow")]
    [DisplayName("Operational Address")]
    [IsoXmlTag("OprlAdr")]
    public PostalAddress24? OperationalAddress { get; init; }

    /// <summary>
    /// Specifies the address where the business activity is taking place.
    /// </summary>
    [IsoId("_CFttO249EeiU9cctagi5ow")]
    [DisplayName("Business Address")]
    [IsoXmlTag("BizAdr")]
    public PostalAddress24? BusinessAddress { get; init; }

    /// <summary>
    /// Specifies the address where the entity resides and is registered. More generically, it is the home address (Residential address).
    /// </summary>
    [IsoId("_CFttPW49EeiU9cctagi5ow")]
    [DisplayName("Legal Address")]
    [IsoXmlTag("LglAdr")]
    public required PostalAddress24 LegalAddress { get; init; }

    /// <summary>
    /// Address where invoices must be sent.
    /// </summary>
    [IsoId("_CFttP249EeiU9cctagi5ow")]
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public PostalAddress24? BillingAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous way of identifying an organisation.
    /// </summary>
    [IsoId("_CFttQW49EeiU9cctagi5ow")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification29 OrganisationIdentification { get; init; }

    /// <summary>
    /// Person in the customer&apos;s organisation who can be contacted by the account servicer in relation to the account(s) identified in this instruction.
    /// </summary>
    [IsoId("_CFttQ249EeiU9cctagi5ow")]
    [DisplayName("Representative Officer")]
    [IsoXmlTag("RprtvOffcr")]
    public PartyIdentification137? RepresentativeOfficer { get; init; }

    /// <summary>
    /// Person responsible of the treasury department within the customer’s organisation.
    /// </summary>
    [IsoId("_CFttRW49EeiU9cctagi5ow")]
    [DisplayName("Treasury Manager")]
    [IsoXmlTag("TrsrMgr")]
    public PartyIdentification137? TreasuryManager { get; init; }

    /// <summary>
    /// Person that has the mandate to delegate authority, to assign mandates to other individuals (mandate holders) to perform specific bank operations on the account.
    /// </summary>
    [IsoId("_CFttR249EeiU9cctagi5ow")]
    [DisplayName("Main Mandate Holder")]
    [IsoXmlTag("MainMndtHldr")]
    public PartyIdentification137? MainMandateHolder { get; init; }

    /// <summary>
    /// Person that may be the potential sender of a message related to the life cycle of the account.
    /// </summary>
    [IsoId("_CFttSW49EeiU9cctagi5ow")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification137? Sender { get; init; }

    /// <summary>
    /// Person that is officially and legally mandated to represent the organisation. Depending on legislation, the legal representative(s) might for instance be assigned by the Board, identified in the by-laws of the organisation, be publicly announced in the official journal of a country, etc.
    /// </summary>
    [IsoId("_CFttS249EeiU9cctagi5ow")]
    [DisplayName("Legal Representative")]
    [IsoXmlTag("LglRprtv")]
    public PartyIdentification137? LegalRepresentative { get; init; }
}
