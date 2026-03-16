// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account on which a securities entry is made.
/// </summary>
[IsoId("_0mLLh4jyEeONZKAAW4pOaQ")]
[DisplayName("Safekeeping Account")]
public record SafekeepingAccount5
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_0mLLiojyEeONZKAAW4pOaQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_0mLLi4jyEeONZKAAW4pOaQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification100 AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_0mLLiYjyEeONZKAAW4pOaQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification100 AccountServicer { get; init; }

    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_7khGcKCHEeOEyO7fCl8lLA")]
    [DisplayName("Beneficial Owner")]
    [IsoXmlTag("BnfclOwnr")]
    public ValueList<BeneficialOwner2> BeneficialOwner { get; init; } = [];

    /// <summary>
    /// Report on the net position of a financial instrument, on the account, for a certain date.
    /// </summary>
    [IsoId("_0mLLjYjyEeONZKAAW4pOaQ")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public ValueList<AggregateHoldingBalance1> BalanceForAccount { get; init; } = [];

    /// <summary>
    /// Agent of the financial instrument, for example, the transfer agent.
    /// </summary>
    [IsoId("_ylQ_gYj5EeONZKAAW4pOaQ")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public Intermediary28? Agent { get; init; }

    /// <summary>
    /// Holdings of level 1.
    /// </summary>
    [IsoId("_0mLLjIjyEeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl1")]
    public ValueList<AccountSubLevel1> AccountSubLevel1 { get; init; } = [];

    /// <summary>
    /// Difference in holdings between the safekeeping account and the sub-accounts of level 1.
    /// </summary>
    [IsoId("_7YCN0aCAEeOEyO7fCl8lLA")]
    [DisplayName("Account Sub Level 1 Difference")]
    [IsoXmlTag("AcctSubLvl1Diff")]
    public ValueList<AggregateHoldingBalance2> AccountSubLevel1Difference { get; init; } = [];
}
