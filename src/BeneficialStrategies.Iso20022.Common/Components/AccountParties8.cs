// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party related to an investment account.
/// </summary>
[IsoId("_Pa5soRRPEeOKWo1NF21OVw")]
[DisplayName("Account Parties")]
public record AccountParties8
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_Py2SmRRPEeOKWo1NF21OVw")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_PzADkRRPEeOKWo1NF21OVw")]
    [DisplayName("Principal Account Party")]
    [IsoXmlTag("PrncplAcctPty")]
    public AccountParties3Choice_? PrincipalAccountParty { get; init; }

    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_PzADkxRPEeOKWo1NF21OVw")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    public ValueList<InvestmentAccountOwnershipInformation8> SecondaryOwner { get; init; } = [];

    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_PzADlRRPEeOKWo1NF21OVw")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public ValueList<InvestmentAccountOwnershipInformation8> Beneficiary { get; init; } = [];

    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_PzADlxRPEeOKWo1NF21OVw")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    public ValueList<InvestmentAccountOwnershipInformation8> PowerOfAttorney { get; init; } = [];

    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_PzADmRRPEeOKWo1NF21OVw")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    public ValueList<InvestmentAccountOwnershipInformation8> LegalGuardian { get; init; } = [];

    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_PzADmxRPEeOKWo1NF21OVw")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    public InvestmentAccountOwnershipInformation8? SuccessorOnDeath { get; init; }

    /// <summary>
    /// Entity that has been appointed by a legal authorithy to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_PzADnRRPEeOKWo1NF21OVw")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public ValueList<InvestmentAccountOwnershipInformation8> Administrator { get; init; } = [];

    /// <summary>
    /// An other type of party.
    /// </summary>
    [IsoId("_PzADoxRPEeOKWo1NF21OVw")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public ValueList<ExtendedParty5> OtherParty { get; init; } = [];

    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_PzADnxRPEeOKWo1NF21OVw")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation8> Granter { get; init; } = [];

    /// <summary>
    /// Settler role in the hedge funds industry.
    /// </summary>
    [IsoId("_PzADoRRPEeOKWo1NF21OVw")]
    [DisplayName("Settler")]
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation8> Settler { get; init; } = [];
}
