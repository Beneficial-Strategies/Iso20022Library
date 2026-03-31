// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a party&apos;s account.
/// </summary>
[IsoId("_kz0oJZQ_EemqYPWMBuVawg")]
[DisplayName("Account Parties")]
public record AccountParties17
{
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_lHKa45Q_EemqYPWMBuVawg")]
    [DisplayName("Principal Account Party")]
    [IsoXmlTag("PrncplAcctPty")]
    public required AccountParties12Choice_ PrincipalAccountParty { get; init; }

    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_lHKa5ZQ_EemqYPWMBuVawg")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    public ValueList<InvestmentAccountOwnershipInformation16> SecondaryOwner { get; init; } = [];

    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_lHKa55Q_EemqYPWMBuVawg")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public ValueList<InvestmentAccountOwnershipInformation16> Beneficiary { get; init; } = [];

    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_lHKa6ZQ_EemqYPWMBuVawg")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    public ValueList<InvestmentAccountOwnershipInformation16> PowerOfAttorney { get; init; } = [];

    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_lHKa65Q_EemqYPWMBuVawg")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    public ValueList<InvestmentAccountOwnershipInformation16> LegalGuardian { get; init; } = [];

    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_lHKa7ZQ_EemqYPWMBuVawg")]
    [DisplayName("Custodian For Minor")]
    [IsoXmlTag("CtdnForMnr")]
    public ValueList<InvestmentAccountOwnershipInformation16> CustodianForMinor { get; init; } = [];

    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_lHKa75Q_EemqYPWMBuVawg")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    public ValueList<InvestmentAccountOwnershipInformation16> SuccessorOnDeath { get; init; } = [];

    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_lHKa8ZQ_EemqYPWMBuVawg")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public ValueList<InvestmentAccountOwnershipInformation16> Administrator { get; init; } = [];

    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_lHKa85Q_EemqYPWMBuVawg")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public ValueList<ExtendedParty14> OtherParty { get; init; } = [];

    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_lHKa9ZQ_EemqYPWMBuVawg")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    public ValueList<InvestmentAccountOwnershipInformation16> Granter { get; init; } = [];

    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    [IsoId("_lHKa95Q_EemqYPWMBuVawg")]
    [DisplayName("Settlor")]
    [IsoXmlTag("Sttlr")]
    public ValueList<InvestmentAccountOwnershipInformation16> Settlor { get; init; } = [];

    /// <summary>
    /// Party that makes, or participates in the making of, decisions that affect the whole, or a substantial part, of the business of a customer of a reporting entity or that has the capacity to affect significantly the financial standing of a customer of a reporting entity. Typically, this is a controlling person of a corporate (ownership type CORP).
    /// </summary>
    [IsoId("_lHKa-ZQ_EemqYPWMBuVawg")]
    [DisplayName("Senior Managing Official")]
    [IsoXmlTag("SnrMggOffcl")]
    public ValueList<InvestmentAccountOwnershipInformation16> SeniorManagingOfficial { get; init; } =
        [];

    /// <summary>
    /// Person appointed under the trust instrument to direct or restrain the trustees in relation to their administration of the trust. Typically, this is a controlling person of a trust (ownership type TRUS) or other non-individual organisation (ownership type ONIS).
    /// </summary>
    [IsoId("_lHKa-5Q_EemqYPWMBuVawg")]
    [DisplayName("Protector")]
    [IsoXmlTag("Prtctr")]
    public ValueList<InvestmentAccountOwnershipInformation16> Protector { get; init; } = [];

    /// <summary>
    /// Party that registers its name with the issuer and the name used for the registration.
    /// </summary>
    [IsoId("_lHKa_ZQ_EemqYPWMBuVawg")]
    [DisplayName("Registered Shareholder Name")]
    [IsoXmlTag("RegdShrhldrNm")]
    public RegisteredShareholderName1Choice_? RegisteredShareholderName { get; init; }
}
