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
[IsoId("_QM2HONp-Ed-ak6NoX_4Aeg_-1220331346")]
[DisplayName("Organisation")]
public record Organisation7
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QM2HOdp-Ed-ak6NoX_4Aeg_-1334170412")]
    [DisplayName("Full Legal Name")]
    [IsoXmlTag("FullLglNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text FullLegalName { get; init; }

    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another.
    /// </summary>
    [IsoId("_QM2HOtp-Ed-ak6NoX_4Aeg_1963724531")]
    [DisplayName("Trading Name")]
    [IsoXmlTag("TradgNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? TradingName { get; init; }

    /// <summary>
    /// Country in which the organisation has its business activity.
    /// </summary>
    [IsoId("_QM_4MNp-Ed-ak6NoX_4Aeg_966652178")]
    [DisplayName("Country Of Operation")]
    [IsoXmlTag("CtryOfOpr")]
    public required CountryCode CountryOfOperation { get; init; }

    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_QM_4Mdp-Ed-ak6NoX_4Aeg_-30420175")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RegistrationDate { get; init; }

    /// <summary>
    /// Is an operational address, for example, of a shared services center.
    /// </summary>
    [IsoId("_QM_4Mtp-Ed-ak6NoX_4Aeg_-1205611200")]
    [DisplayName("Operational Address")]
    [IsoXmlTag("OprlAdr")]
    public PostalAddress6? OperationalAddress { get; init; }

    /// <summary>
    /// Is the address where the business activity is taking place.
    /// </summary>
    [IsoId("_QM_4M9p-Ed-ak6NoX_4Aeg_2092283743")]
    [DisplayName("Business Address")]
    [IsoXmlTag("BizAdr")]
    public PostalAddress6? BusinessAddress { get; init; }

    /// <summary>
    /// Is the address where the entity resides and is registered. More generically, it is the home address (Residential address).
    /// </summary>
    [IsoId("_QM_4NNp-Ed-ak6NoX_4Aeg_1095211390")]
    [DisplayName("Legal Address")]
    [IsoXmlTag("LglAdr")]
    public required PostalAddress6 LegalAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous way of identifying an organisation.
    /// </summary>
    [IsoId("_QM_4Ndp-Ed-ak6NoX_4Aeg_-1262530733")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification6 OrganisationIdentification { get; init; }

    /// <summary>
    /// Person in the customer&apos;s organisation who can be contacted by the account servicer.
    /// </summary>
    [IsoId("_QM_4Ntp-Ed-ak6NoX_4Aeg_2035364210")]
    [DisplayName("Representative Officer")]
    [IsoXmlTag("RprtvOffcr")]
    public PartyIdentification40? RepresentativeOfficer { get; init; }

    /// <summary>
    /// Identification of the person responsible of the treasury department within an organisation.
    /// </summary>
    [IsoId("_QM_4N9p-Ed-ak6NoX_4Aeg_1038291857")]
    [DisplayName("Treasury Manager")]
    [IsoXmlTag("TrsrMgr")]
    public PartyIdentification40? TreasuryManager { get; init; }

    /// <summary>
    /// Is the main mandate holder that will delegate some authority to other individuals (mandate holders) to perform some specific bank operations on the account.
    /// </summary>
    [IsoId("_QM_4ONp-Ed-ak6NoX_4Aeg_41219504")]
    [DisplayName("Main Mandate Holder")]
    [IsoXmlTag("MainMndtHldr")]
    public PartyIdentification40? MainMandateHolder { get; init; }

    /// <summary>
    /// Potential sender of a message related to the life cyle of an account.
    /// </summary>
    [IsoId("_QM_4Odp-Ed-ak6NoX_4Aeg_-878814148")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification40? Sender { get; init; }
}
