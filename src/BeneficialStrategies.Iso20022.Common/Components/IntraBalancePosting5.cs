// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the transactions in the report.
/// </summary>
[IsoId("_ZMt4zTneEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Posting")]
public record IntraBalancePosting5
{
    /// <summary>
    /// Balance from which the amount of money is moved.
    /// </summary>
    [IsoId("_ZXSw4TneEem7JZMuWtwtsg")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; }

    /// <summary>
    /// Further details on the individual intrabalance movement transaction.
    /// </summary>
    [IsoId("_ZXSw6TneEem7JZMuWtwtsg")]
    [DisplayName("Movement")]
    [IsoXmlTag("Mvmnt")]
    public ValueList<IntraBalancePosting6> Movement { get; init; } = [];
    // ID for the above is _ZXSw6TneEem7JZMuWtwtsg
}
