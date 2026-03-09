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
/// Preferred withdrawal transaction chosen by the the customer.
/// </summary>
[IsoId("_keiqMYq3EeSIDtZ76p6McQ")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount to dispense.
    /// </summary>
    [IsoId("_igfzsIq4EeSIDtZ76p6McQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? Amount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency.
    /// </summary>
    [IsoId("_nDhS8Iq4EeSIDtZ76p6McQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// True if a receipt has to be printed by the ATM for the customer.
    /// </summary>
    [IsoId("_kq6SVYq3EeSIDtZ76p6McQ")]
    [DisplayName("Receipt Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RctFlg")]
    #endif
    [IsoXmlTag("RctFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReceiptFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReceiptFlag { get; init; } 
    #else
    public System.String? ReceiptFlag { get; set; } 
    #endif
    
    /// <summary>
    /// True if a balance has to be printed by the ATM on the customer receipt.
    /// </summary>
    [IsoId("_D1jJUIq4EeSIDtZ76p6McQ")]
    [DisplayName("Balance Print Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalPrtFlg")]
    #endif
    [IsoXmlTag("BalPrtFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? BalancePrintFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BalancePrintFlag { get; init; } 
    #else
    public System.String? BalancePrintFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Media mix algorithm, the identification of the algorithm is an agreement between the ATM and the ATM manager.
    /// </summary>
    [IsoId("_kq6SUYq3EeSIDtZ76p6McQ")]
    [DisplayName("Mix Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MixTp")]
    #endif
    [IsoXmlTag("MixTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MixType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MixType { get; init; } 
    #else
    public System.String? MixType { get; set; } 
    #endif
    
    /// <summary>
    /// Media mix to select.
    /// </summary>
    [IsoId("_kq6SU4q3EeSIDtZ76p6McQ")]
    [DisplayName("Mix")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mix")]
    #endif
    [IsoXmlTag("Mix")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMMediaMix2? Mix { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMMediaMix2? Mix { get; init; } 
    #else
    public ATMMediaMix2? Mix { get; set; } 
    #endif
    
    
    #nullable disable
    
}
