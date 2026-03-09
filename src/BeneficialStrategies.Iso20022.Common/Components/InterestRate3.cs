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
/// Choice between a fixed rate and a floating rate.
/// </summary>
[IsoId("_g9tac6x2Eem81-uIvTF5rQ")]
[DisplayName("Interest Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestRate3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InterestRate3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InterestRate3( AmountAndDirection53 reqAmount,InterestRate20Choice_ reqInterestRate )
    {
        Amount = reqAmount;
        InterestRate = reqInterestRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_hBu-wax2Eem81-uIvTF5rQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection53 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection53 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection53 Amount { get; init; } 
    #else
    public AmountAndDirection53 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Information on interest rates related to the transaction.
    /// </summary>
    [IsoId("_hBu-w6x2Eem81-uIvTF5rQ")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InterestRate20Choice_ InterestRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InterestRate20Choice_ InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate20Choice_ InterestRate { get; init; } 
    #else
    public InterestRate20Choice_ InterestRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
