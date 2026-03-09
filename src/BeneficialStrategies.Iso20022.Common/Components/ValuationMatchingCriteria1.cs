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
/// Compares information related to both sides of a contract valuation.
/// </summary>
[IsoId("_L1MIEExTEeywvc16MwOPfw")]
[DisplayName("Valuation Matching Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ValuationMatchingCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the contract values are matching or not.
    /// </summary>
    [IsoId("_ZiXpwExTEeywvc16MwOPfw")]
    [DisplayName("Contract Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctVal")]
    #endif
    [IsoXmlTag("CtrctVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAmountAndDirection3? ContractValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAmountAndDirection3? ContractValue { get; init; } 
    #else
    public CompareAmountAndDirection3? ContractValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the valuation methods are matching or not.
    /// </summary>
    [IsoId("_POV_wExUEeywvc16MwOPfw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareValuationType1? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareValuationType1? Type { get; init; } 
    #else
    public CompareValuationType1? Type { get; set; } 
    #endif
    
    
    #nullable disable
    
}
