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
[IsoId("_mp9DWZQ_EemqYPWMBuVawg")]
[DisplayName("Account Parties")]
public record AccountParties18
{
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_m9viBZQ_EemqYPWMBuVawg")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_m9viB5Q_EemqYPWMBuVawg")]
    [DisplayName("Principal Account Party")]
    [IsoXmlTag("PrncplAcctPty")]
    public AccountParties13Choice_? PrincipalAccountParty { get; init; }

    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_m9viCZQ_EemqYPWMBuVawg")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    public ValueList<InvestmentAccountOwnershipInformation17> SecondaryOwner { get; init; } = [];

    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_m9viC5Q_EemqYPWMBuVawg")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public ValueList<InvestmentAccountOwnershipInformation17> Beneficiary { get; init; } = [];

    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_m9viDZQ_EemqYPWMBuVawg")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    public ValueList<InvestmentAccountOwnershipInformation17> PowerOfAttorney { get; init; } = [];

    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_m9viD5Q_EemqYPWMBuVawg")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    public ValueList<InvestmentAccountOwnershipInformation17> LegalGuardian { get; init; } = [];

    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_m9viEZQ_EemqYPWMBuVawg")]
    [DisplayName("Custodian For Minor")]
    [IsoXmlTag("CtdnForMnr")]
    public ValueList<InvestmentAccountOwnershipInformation17> CustodianForMinor { get; init; } = [];

    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_m9viE5Q_EemqYPWMBuVawg")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    public ValueList<InvestmentAccountOwnershipInformation17> SuccessorOnDeath { get; init; } = [];

    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_m9viFZQ_EemqYPWMBuVawg")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public ValueList<InvestmentAccountOwnershipInformation17> Administrator { get; init; } = [];

    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_m9viF5Q_EemqYPWMBuVawg")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public ValueList<ExtendedParty15> OtherParty { get; init; } = [];

    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_m9viGZQ_EemqYPWMBuVawg")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    public ValueList<InvestmentAccountOwnershipInformation17> Granter { get; init; } = [];

    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    [IsoId("_m9viG5Q_EemqYPWMBuVawg")]
    [DisplayName("Settlor")]
    [IsoXmlTag("Sttlr")]
    public ValueList<InvestmentAccountOwnershipInformation17> Settlor { get; init; } = [];

    /// <summary>
    /// Party that makes, or participates in the making of, decisions that affect the whole, or a substantial part, of the business of a customer of a reporting entity or that has the capacity to affect significantly the financial standing of a customer of a reporting entity. Typically, this is a controlling person of a corporate (ownership type CORP).
    /// </summary>
    [IsoId("_m9viHZQ_EemqYPWMBuVawg")]
    [DisplayName("Senior Managing Official")]
    [IsoXmlTag("SnrMggOffcl")]
    public ValueList<InvestmentAccountOwnershipInformation17> SeniorManagingOfficial { get; init; } =
        [];

    /// <summary>
    /// Person appointed under the trust instrument to direct or restrain the trustees in relation to their administration of the trust. Typically, this is a controlling person of a trust (ownership type TRUS) or other non-individual organisation (ownership type ONIS).
    /// </summary>
    [IsoId("_m9viH5Q_EemqYPWMBuVawg")]
    [DisplayName("Protector")]
    [IsoXmlTag("Prtctr")]
    public ValueList<InvestmentAccountOwnershipInformation17> Protector { get; init; } = [];

    /// <summary>
    /// Party for which shares are to be registered.
    /// </summary>
    [IsoId("_m9viIZQ_EemqYPWMBuVawg")]
    [DisplayName("Registered Shareholder Name")]
    [IsoXmlTag("RegdShrhldrNm")]
    public RegisteredShareholderName1Choice_? RegisteredShareholderName { get; init; }
}
