// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intra-balance type used to specify pairs of from/to balances.
/// </summary>
[IsoId("_8fdtgeE8EeWHlNkrP2xqHA")]
[DisplayName("Intra Balance Type")]
public partial record IntraBalanceType2
{
    #nullable enable
    
    /// <summary>
    /// Balance from which the amount of money is moved.
    /// </summary>
    [IsoId("_8oixA-E8EeWHlNkrP2xqHA")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public CashSubBalanceTypeAndQuantityBreakdown2? BalanceFrom { get; init; } 
    
    /// <summary>
    /// Balance to which the amount of money is moved.
    /// </summary>
    [IsoId("_8oixC-E8EeWHlNkrP2xqHA")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public CashSubBalanceTypeAndQuantityBreakdown2? BalanceTo { get; init; } 
    
    
    #nullable disable
    
}
