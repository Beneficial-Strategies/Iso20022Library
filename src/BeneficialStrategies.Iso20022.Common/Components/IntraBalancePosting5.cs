// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the transactions in the report.
/// </summary>
[IsoId("_ZMt4zTneEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Posting")]
public partial record IntraBalancePosting5
{
    #nullable enable
    
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
    public ValueList<IntraBalancePosting6> Movement { get; init; } = new ValueList<IntraBalancePosting6>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _ZXSw6TneEem7JZMuWtwtsg
    
    
    #nullable disable
    
}
