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
[IsoId("_GY8mMSCBEeWhHbfCMWc1cw")]
[DisplayName("Account Parties")]
public record AccountParties13
{
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_G1n7JSCBEeWhHbfCMWc1cw")]
    [DisplayName("Principal Account Party")]
    [IsoXmlTag("PrncplAcctPty")]
    public required AccountParties8Choice_ PrincipalAccountParty { get; init; }

    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_G1n7JyCBEeWhHbfCMWc1cw")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    public ValueList<InvestmentAccountOwnershipInformation12> SecondaryOwner { get; init; } = [];

    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_G1n7KSCBEeWhHbfCMWc1cw")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public ValueList<InvestmentAccountOwnershipInformation12> Beneficiary { get; init; } = [];

    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_G1n7KyCBEeWhHbfCMWc1cw")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    public ValueList<InvestmentAccountOwnershipInformation12> PowerOfAttorney { get; init; } = [];

    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_G1n7LSCBEeWhHbfCMWc1cw")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    public ValueList<InvestmentAccountOwnershipInformation12> LegalGuardian { get; init; } = [];

    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_Yo7mYVxmEeW0RaYpOo325g")]
    [DisplayName("Custodian For Minor")]
    [IsoXmlTag("CtdnForMnr")]
    public InvestmentAccountOwnershipInformation12? CustodianForMinor { get; init; }

    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_G1n7LyCBEeWhHbfCMWc1cw")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation12> SuccessorOnDeath { get; init; } = [];

    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_G1n7MSCBEeWhHbfCMWc1cw")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public ValueList<InvestmentAccountOwnershipInformation12> Administrator { get; init; } = [];

    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_G1n7MyCBEeWhHbfCMWc1cw")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public ValueList<ExtendedParty9> OtherParty { get; init; } = [];

    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_G1n7NSCBEeWhHbfCMWc1cw")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation12> Granter { get; init; } = [];

    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    [IsoId("_G1n7NyCBEeWhHbfCMWc1cw")]
    [DisplayName("Settlor")]
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation12> Settlor { get; init; } = [];

    /// <summary>
    /// Party that registers its name with the issuer and the name used for the registration.
    /// </summary>
    [IsoId("_fPhIgDYJEeWxoIK_IhudJg")]
    [DisplayName("Registered Shareholder Name")]
    [IsoXmlTag("RegdShrhldrNm")]
    public RegisteredShareholderName1Choice_? RegisteredShareholderName { get; init; }
}
