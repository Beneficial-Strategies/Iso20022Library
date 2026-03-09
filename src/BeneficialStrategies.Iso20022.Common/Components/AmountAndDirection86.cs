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
/// Cash posting where the currency is implied by the context.
/// </summary>
[IsoId("_dilJ8FG0EeeqtLmveSCYmA")]
[DisplayName("Amount And Direction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountAndDirection86
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountAndDirection86 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountAndDirection86( ImpliedCurrencyAndAmount reqAmount,System.String reqSign )
    {
        Amount = reqAmount;
        Sign = reqSign;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_F436cFHEEeeqtLmveSCYmA")]
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
    /// Indicates that the amount value is positive or negative.
    /// </summary>
    [IsoId("_IXnNwFHEEeeqtLmveSCYmA")]
    [DisplayName("Sign")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgn")]
    #endif
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPlusOrMinusIndicator Sign { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Sign { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Sign { get; init; } 
    #else
    public System.String Sign { get; set; } 
    #endif
    
    
    #nullable disable
    
}
