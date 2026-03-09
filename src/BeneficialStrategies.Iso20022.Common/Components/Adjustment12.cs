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
/// Describes each adjustment made to the original price.
/// </summary>
[IsoId("_MMRkATaqEeyjpIf0r_Ojqw")]
[DisplayName("Adjustment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Adjustment12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Adjustment12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Adjustment12( ImpliedCurrencyAndAmount reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the adjusted amount (for example, discounts).
    /// </summary>
    [IsoId("_MRpMMTaqEeyjpIf0r_Ojqw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount Amount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// A code to indicate the tax amount is credit or debit
    /// </summary>
    [IsoId("_8CXhMTapEeyjpIf0r_Ojqw")]
    [DisplayName("Credit Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbt")]
    #endif
    [IsoXmlTag("CdtDbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebit3Code? CreditDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebit3Code? CreditDebit { get; init; } 
    #else
    public CreditDebit3Code? CreditDebit { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the adjustment.
    /// </summary>
    [IsoId("_MRpMNTaqEeyjpIf0r_Ojqw")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reason { get; init; } 
    #else
    public System.String? Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
