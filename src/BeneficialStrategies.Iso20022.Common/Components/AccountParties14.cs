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
[IsoId("_M3J_wSCBEeWhHbfCMWc1cw")]
[DisplayName("Account Parties")]
public record AccountParties14
{
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_NTyRZyCBEeWhHbfCMWc1cw")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_NTyRaSCBEeWhHbfCMWc1cw")]
    [DisplayName("Principal Account Party")]
    [IsoXmlTag("PrncplAcctPty")]
    public AccountParties9Choice_? PrincipalAccountParty { get; init; }

    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_NTyRayCBEeWhHbfCMWc1cw")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    public InvestmentAccountOwnershipInformation13? SecondaryOwner { get; init; }

    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_NTyRbSCBEeWhHbfCMWc1cw")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public InvestmentAccountOwnershipInformation13? Beneficiary { get; init; }

    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_NTyRbyCBEeWhHbfCMWc1cw")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    public InvestmentAccountOwnershipInformation13? PowerOfAttorney { get; init; }

    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_NTyRcSCBEeWhHbfCMWc1cw")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    public InvestmentAccountOwnershipInformation13? LegalGuardian { get; init; }

    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_b2UvcVxmEeW0RaYpOo325g")]
    [DisplayName("Custodian For Minor")]
    [IsoXmlTag("CtdnForMnr")]
    public InvestmentAccountOwnershipInformation13? CustodianForMinor { get; init; }

    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_NTyRcyCBEeWhHbfCMWc1cw")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    public InvestmentAccountOwnershipInformation13? SuccessorOnDeath { get; init; }

    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_NTyRdSCBEeWhHbfCMWc1cw")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public InvestmentAccountOwnershipInformation13? Administrator { get; init; }

    /// <summary>
    /// An other type of party.
    /// </summary>
    [IsoId("_NTyRdyCBEeWhHbfCMWc1cw")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public ExtendedParty10? OtherParty { get; init; }

    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_NTyReSCBEeWhHbfCMWc1cw")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    public InvestmentAccountOwnershipInformation13? Granter { get; init; }

    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    [IsoId("_NTyReyCBEeWhHbfCMWc1cw")]
    [DisplayName("Settlor")]
    [IsoXmlTag("Sttlr")]
    public InvestmentAccountOwnershipInformation13? Settlor { get; init; }

    /// <summary>
    /// Party for which shares are to be registered.
    /// </summary>
    [IsoId("_tKPW8TYJEeWxoIK_IhudJg")]
    [DisplayName("Registered Shareholder Name")]
    [IsoXmlTag("RegdShrhldrNm")]
    public RegisteredShareholderName1Choice_? RegisteredShareholderName { get; init; }
}
