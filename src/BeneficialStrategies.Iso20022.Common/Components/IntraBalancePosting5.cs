// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the transactions in the report.
/// </summary>
[IsoId("_ZMt4zTneEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Posting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalancePosting5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraBalancePosting5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraBalancePosting5( CashSubBalanceTypeAndQuantityBreakdown3 reqBalanceFrom )
    {
        BalanceFrom = reqBalanceFrom;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Balance from which the amount of money is moved.
    /// </summary>
    [IsoId("_ZXSw4TneEem7JZMuWtwtsg")]
    [DisplayName("Balance From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalFr")]
    #endif
    [IsoXmlTag("BalFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #else
    public CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the individual intrabalance movement transaction.
    /// </summary>
    [IsoId("_ZXSw6TneEem7JZMuWtwtsg")]
    [DisplayName("Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mvmnt")]
    #endif
    [IsoXmlTag("Mvmnt")]
    public ValueList<IntraBalancePosting6> Movement { get; init; } = new ValueList<IntraBalancePosting6>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _ZXSw6TneEem7JZMuWtwtsg
    
    
    #nullable disable
    
}
