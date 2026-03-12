// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of the trade transaction.
/// </summary>
[IsoId("_S-xcR9p-Ed-ak6NoX_4Aeg_946629114")]
[DisplayName("Transaction Details")]
public partial record TransactionDetails2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned to a trade once it is received or matched by an executing system.
    /// </summary>
    [IsoId("_S-6mMNp-Ed-ak6NoX_4Aeg_1406541847")]
    [DisplayName("Trade Reference")]
    [IsoXmlTag("TradRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text TradeReference { get; init; } 
    
    
    #nullable disable
    
}
