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
/// The OriginalAmountDetails contains all amount information in the acceptor currency code necessary to manage currency conversion in the cardholder currency code.
/// </summary>
[IsoId("_H_Dk4K_TEeaepNKtQMrGAQ")]
[DisplayName("Original Amount Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalAmountDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Actual amount to be converted.
    /// </summary>
    [IsoId("_eQjRAK_TEeaepNKtQMrGAQ")]
    [DisplayName("Actual Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlAmt")]
    #endif
    [IsoXmlTag("ActlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? ActualAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? ActualAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? ActualAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum amount for conversion (in case of range of amounts).
    /// </summary>
    [IsoId("_nGuAcK_TEeaepNKtQMrGAQ")]
    [DisplayName("Minimum Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinAmt")]
    #endif
    [IsoXmlTag("MinAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MinimumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MinimumAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MinimumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount for conversion (in case of range of amounts).
    /// </summary>
    [IsoId("_uH150K_TEeaepNKtQMrGAQ")]
    [DisplayName("Maximum Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAmt")]
    #endif
    [IsoXmlTag("MaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MaximumAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
