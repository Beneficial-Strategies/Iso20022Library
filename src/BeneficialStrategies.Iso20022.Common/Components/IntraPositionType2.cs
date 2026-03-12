// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intra-position type used to specify pairs of from/to balances.
/// </summary>
[IsoId("_Vno_MeWYEeWvh8HbDeFFMA")]
[DisplayName("Intra Position Type")]
public partial record IntraPositionType2
{
    #nullable enable
    
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_VzY8M-WYEeWvh8HbDeFFMA")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3? BalanceFrom { get; init; } 
    
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_VzY8O-WYEeWvh8HbDeFFMA")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3? BalanceTo { get; init; } 
    
    
    #nullable disable
    
}
