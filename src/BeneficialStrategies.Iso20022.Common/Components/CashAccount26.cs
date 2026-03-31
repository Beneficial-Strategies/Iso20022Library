// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_aVnNARczEeK5g-3oYI0_9Q")]
[DisplayName("Cash Account")]
public record CashAccount26
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_ar93iRczEeK5g-3oYI0_9Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentificationAndName3 Identification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_ar93jRczEeK5g-3oYI0_9Q")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification2Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_ar93kRczEeK5g-3oYI0_9Q")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; }

    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_ar93lRczEeK5g-3oYI0_9Q")]
    [DisplayName("Account Servicer Branch")]
    [IsoXmlTag("AcctSvcrBrnch")]
    public BranchData? AccountServicerBranch { get; init; }

    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, ISA.
    /// </summary>
    [IsoId("_698SoBdKEeK5g-3oYI0_9Q")]
    [DisplayName("Investment Account Type")]
    [IsoXmlTag("InvstmtAcctTp")]
    public InvestmentAccountType1Choice_? InvestmentAccountType { get; init; }

    /// <summary>
    /// Other identification such as national registration identification number, passport number.
    /// </summary>
    [IsoId("_xpDeUBczEeK5g-3oYI0_9Q")]
    [DisplayName("Account Owner Other Identification")]
    [IsoXmlTag("AcctOwnrOthrId")]
    public ValueList<GenericIdentification46> AccountOwnerOtherIdentification { get; init; } = [];
}
