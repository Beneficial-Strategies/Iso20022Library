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
[IsoId("_9nv3AVV2Eea1MPROA61PoQ")]
[DisplayName("Safekeeping Account")]
public record SafekeepingAccount7
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_-A4vwVV2Eea1MPROA61PoQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_-A4vw1V2Eea1MPROA61PoQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification100 AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_-A4vxVV2Eea1MPROA61PoQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification100 AccountServicer { get; init; }

    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_-A4vx1V2Eea1MPROA61PoQ")]
    [DisplayName("Beneficial Owner")]
    [IsoXmlTag("BnfclOwnr")]
    public ValueList<BeneficialOwner2> BeneficialOwner { get; init; } = [];

    /// <summary>
    /// Report on the net position of a financial instrument on the account, for a certain date. The agent, for example, a trade intermediary, may also be specified.
    /// </summary>
    [IsoId("_GbAcYVV3Eea1MPROA61PoQ")]
    [DisplayName("Balance Details")]
    [IsoXmlTag("BalDtls")]
    public ValueList<AggregateHoldingBalance3> BalanceDetails { get; init; } = [];

    /// <summary>
    /// Holdings of level 1.
    /// </summary>
    [IsoId("_-A4vzVV2Eea1MPROA61PoQ")]
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl1")]
    public ValueList<AccountSubLevel11> AccountSubLevel1 { get; init; } = [];

    /// <summary>
    /// Difference in holdings between the safekeeping account and the sub-accounts of level 1.
    /// </summary>
    [IsoId("_-A4vz1V2Eea1MPROA61PoQ")]
    [DisplayName("Account Sub Level 1 Difference")]
    [IsoXmlTag("AcctSubLvl1Diff")]
    public ValueList<AggregateHoldingBalance2> AccountSubLevel1Difference { get; init; } = [];
}
