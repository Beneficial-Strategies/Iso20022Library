// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of the trade transaction.
/// </summary>
[IsoId("_S-xcR9p-Ed-ak6NoX_4Aeg_946629114")]
[DisplayName("Transaction Details")]
public record TransactionDetails2
{
    /// <summary>
    /// Unique identification assigned to a trade once it is received or matched by an executing system.
    /// </summary>
    [IsoId("_S-6mMNp-Ed-ak6NoX_4Aeg_1406541847")]
    [DisplayName("Trade Reference")]
    [IsoXmlTag("TradRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text TradeReference { get; init; }
}
