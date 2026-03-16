// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Safekeeping Account17.
/// </summary>
[IsoId("_wukNFVx7Ee6fgZt44_IqFA")]
[DisplayName("Safekeeping Account17")]
public record SafekeepingAccount17
{
    /// <summary>
    /// Account Servicer.
    /// </summary>
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification195Choice_ AccountServicer { get; init; }

    /// <summary>
    /// Account Sub Level.
    /// </summary>
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl")]
    public AccountSubLevel24? AccountSubLevel { get; init; }

    /// <summary>
    /// Safekeeping Account.
    /// </summary>
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required IsoMax35Text SafekeepingAccount { get; init; }

    /// <summary>
    /// Shareholding Balance On Client Account.
    /// </summary>
    [DisplayName("Shareholding Balance On Client Account")]
    [IsoXmlTag("ShrhldgBalOnClntAcct")]
    public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnClientAccount { get; init; }

    /// <summary>
    /// Shareholding Balance On Own Account.
    /// </summary>
    [DisplayName("Shareholding Balance On Own Account")]
    [IsoXmlTag("ShrhldgBalOnOwnAcct")]
    public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnOwnAccount { get; init; }

    /// <summary>
    /// Total Shareholding Balance.
    /// </summary>
    [DisplayName("Total Shareholding Balance")]
    [IsoXmlTag("TtlShrhldgBal")]
    public required FinancialInstrumentQuantity18Choice_ TotalShareholdingBalance { get; init; }
}
