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
[IsoId("_TsjBMW49EeiU9cctagi5ow")]
[DisplayName("Organisation Modification")]
public record OrganisationModification2
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_T4nHEW49EeiU9cctagi5ow")]
    [DisplayName("Full Legal Name")]
    [IsoXmlTag("FullLglNm")]
    public required FullLegalNameModification1 FullLegalName { get; init; }

    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another.
    /// </summary>
    [IsoId("_T4nHE249EeiU9cctagi5ow")]
    [DisplayName("Trading Name")]
    [IsoXmlTag("TradgNm")]
    public TradingNameModification1? TradingName { get; init; }

    /// <summary>
    /// Country in which the organisation has its business activity.
    /// </summary>
    [IsoId("_T4nHFW49EeiU9cctagi5ow")]
    [DisplayName("Country Of Operation")]
    [IsoXmlTag("CtryOfOpr")]
    public required CountryCode CountryOfOperation { get; init; }

    /// <summary>
    /// Date at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_T4nHF249EeiU9cctagi5ow")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; }

    /// <summary>
    /// Specifies an operational address, for example, of a shared services centre.
    /// </summary>
    [IsoId("_T4nHGW49EeiU9cctagi5ow")]
    [DisplayName("Operational Address")]
    [IsoXmlTag("OprlAdr")]
    public AddressModification2? OperationalAddress { get; init; }

    /// <summary>
    /// Specifies the address where the business activity is taking place.
    /// </summary>
    [IsoId("_T4nHG249EeiU9cctagi5ow")]
    [DisplayName("Business Address")]
    [IsoXmlTag("BizAdr")]
    public AddressModification2? BusinessAddress { get; init; }

    /// <summary>
    /// Specifies the address where the entity resides and is registered. More generically, it is the home address (Residential address).
    /// </summary>
    [IsoId("_T4nHHW49EeiU9cctagi5ow")]
    [DisplayName("Legal Address")]
    [IsoXmlTag("LglAdr")]
    public required AddressModification2 LegalAddress { get; init; }

    /// <summary>
    /// Address where invoices must be sent.
    /// </summary>
    [IsoId("_T4nHH249EeiU9cctagi5ow")]
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public AddressModification2? BillingAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous way of identifying an organisation.
    /// </summary>
    [IsoId("_T4nHIW49EeiU9cctagi5ow")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification29 OrganisationIdentification { get; init; }

    /// <summary>
    /// Person in the customer&apos;s organisation who can be contacted by the account servicer in relation to the account(s) identified in this instruction.
    /// </summary>
    [IsoId("_T4nHI249EeiU9cctagi5ow")]
    [DisplayName("Representative Officer")]
    [IsoXmlTag("RprtvOffcr")]
    public ValueList<PartyModification2> RepresentativeOfficer { get; init; } = [];

    /// <summary>
    /// Person responsible of the treasury department within the customer’s organisation.
    /// </summary>
    [IsoId("_T4nHJW49EeiU9cctagi5ow")]
    [DisplayName("Treasury Manager")]
    [IsoXmlTag("TrsrMgr")]
    public PartyModification2? TreasuryManager { get; init; }

    /// <summary>
    /// Person that has the mandate to delegate authority, to assign mandates to other individuals (mandate holders) to perform specific bank operations on the account.
    /// </summary>
    [IsoId("_T4nHJ249EeiU9cctagi5ow")]
    [DisplayName("Main Mandate Holder")]
    [IsoXmlTag("MainMndtHldr")]
    public ValueList<PartyModification2> MainMandateHolder { get; init; } = [];

    /// <summary>
    /// Person that may be the potential sender of a message related to the life cycle of the account.
    /// </summary>
    [IsoId("_T4nHKW49EeiU9cctagi5ow")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public ValueList<PartyModification2> Sender { get; init; } = [];

    /// <summary>
    /// Person that is officially and legally mandated to represent the organisation. Depending on legislation, the legal representative(s) might for instance be assigned by the Board, identified in the by-laws of the organisation, be publicly announced in the official journal of a country, etc.
    /// </summary>
    [IsoId("_T4nHK249EeiU9cctagi5ow")]
    [DisplayName("Legal Representative")]
    [IsoXmlTag("LglRprtv")]
    public ValueList<PartyModification2> LegalRepresentative { get; init; } = [];
}
