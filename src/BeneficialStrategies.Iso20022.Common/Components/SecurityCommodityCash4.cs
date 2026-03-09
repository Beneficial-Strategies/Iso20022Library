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
[IsoId("_A1bcjcK3EeuFNp8LZAnorg")]
[DisplayName("Security Commodity Cash")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityCommodityCash4
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
    [IsoId("_A2yHY8K3EeuFNp8LZAnorg")]
    [DisplayName("Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scty")]
    #endif
    [IsoXmlTag("Scty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Security48? Security { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Security48? Security { get; init; } 
    #else
    public Security48? Security { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to commodities being subject to the transaction.
    /// </summary>
    [IsoId("_A2yHZcK3EeuFNp8LZAnorg")]
    [DisplayName("Commodity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmmdty")]
    #endif
    [IsoXmlTag("Cmmdty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commodity42? Commodity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commodity42? Commodity { get; init; } 
    #else
    public Commodity42? Commodity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_A2yHZ8K3EeuFNp8LZAnorg")]
    [DisplayName("Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Csh")]
    #endif
    [IsoXmlTag("Csh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashCompare3? Cash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashCompare3? Cash { get; init; } 
    #else
    public CashCompare3? Cash { get; set; } 
    #endif
    
    
    #nullable disable
    
}
