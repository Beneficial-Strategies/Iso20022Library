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
/// Attributes of non-financial instrument of type foreign exchange as underlying.
/// </summary>
[IsoId("_8LPcAXvyEeanCNPcMT7sSg")]
[DisplayName("Derivative Foreign Exchange")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativeForeignExchange3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of the underlying currency.
    /// </summary>
    [IsoId("_8UQ1IXvyEeanCNPcMT7sSg")]
    [DisplayName("FX Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxTp")]
    #endif
    [IsoXmlTag("FxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetFXSubProductType1Code? FXType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetFXSubProductType1Code? FXType { get; init; } 
    #else
    public AssetFXSubProductType1Code? FXType { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying currency 2 of the currency pair (the currency 1 will be populated in the notional currency).
    /// </summary>
    [IsoId("_8UQ1I3vyEeanCNPcMT7sSg")]
    [DisplayName("Other Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrNtnlCcy")]
    #endif
    [IsoXmlTag("OthrNtnlCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? OtherNotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? OtherNotionalCurrency { get; init; } 
    #else
    public string? OtherNotionalCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
