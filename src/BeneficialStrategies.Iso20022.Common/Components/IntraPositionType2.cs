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
/// Intra-position type used to specify pairs of from/to balances.
/// </summary>
[IsoId("_Vno_MeWYEeWvh8HbDeFFMA")]
[DisplayName("Intra Position Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraPositionType2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_VzY8M-WYEeWvh8HbDeFFMA")]
    [DisplayName("Balance From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalFr")]
    #endif
    [IsoXmlTag("BalFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3? BalanceFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3? BalanceFrom { get; init; } 
    #else
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3? BalanceFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_VzY8O-WYEeWvh8HbDeFFMA")]
    [DisplayName("Balance To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTo")]
    #endif
    [IsoXmlTag("BalTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3? BalanceTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3? BalanceTo { get; init; } 
    #else
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3? BalanceTo { get; set; } 
    #endif
    
    
    #nullable disable
    
}
