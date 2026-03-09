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
/// Indication of the type of assets subject of the transaction.
/// </summary>
[IsoId("_lwUpMa-1EemF0ZVFnxVu4g")]
[DisplayName("Security Commodity Cash")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityCommodityCash1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    [IsoId("_l0q9sa-1EemF0ZVFnxVu4g")]
    [DisplayName("Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scty")]
    #endif
    [IsoXmlTag("Scty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Security17? Security { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Security17? Security { get; init; } 
    #else
    public Security17? Security { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to commodities being subject to the transaction.
    /// </summary>
    [IsoId("_l0q9s6-1EemF0ZVFnxVu4g")]
    [DisplayName("Commodity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmmdty")]
    #endif
    [IsoXmlTag("Cmmdty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commodity21? Commodity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commodity21? Commodity { get; init; } 
    #else
    public Commodity21? Commodity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_pTFlUK-1EemF0ZVFnxVu4g")]
    [DisplayName("Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Csh")]
    #endif
    [IsoXmlTag("Csh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashCompare1? Cash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashCompare1? Cash { get; init; } 
    #else
    public CashCompare1? Cash { get; set; } 
    #endif
    
    
    #nullable disable
    
}
