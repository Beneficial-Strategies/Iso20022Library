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
[IsoId("_NXCxMTqFEemJ3KLLPeYl6g")]
[DisplayName("Intra Balance Type")]
public partial record IntraBalanceType3
{
    #nullable enable
    
    /// <summary>
    /// Balance from which the amount of money is moved.
    /// </summary>
    [IsoId("_NhoQkzqFEemJ3KLLPeYl6g")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public CashSubBalanceTypeAndQuantityBreakdown3? BalanceFrom { get; init; } 
    
    /// <summary>
    /// Balance to which the amount of money is moved.
    /// </summary>
    [IsoId("_NhoQmzqFEemJ3KLLPeYl6g")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public CashSubBalanceTypeAndQuantityBreakdown3? BalanceTo { get; init; } 
    
    
    #nullable disable
    
}
