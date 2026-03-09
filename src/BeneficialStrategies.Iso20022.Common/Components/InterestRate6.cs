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
/// Information on interest rates related to the transaction.
/// </summary>
[IsoId("_oLE7E8g6Eeu4ecZgAYuz5w")]
[DisplayName("Interest Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestRate6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InterestRate6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InterestRate6( AmountAndDirection53 reqAmount,InterestRate27Choice_ reqInterestRate )
    {
        Amount = reqAmount;
        InterestRate = reqInterestRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_oMi6ocg6Eeu4ecZgAYuz5w")]
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
    [IsoId("_oMi6o8g6Eeu4ecZgAYuz5w")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InterestRate27Choice_ InterestRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InterestRate27Choice_ InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate27Choice_ InterestRate { get; init; } 
    #else
    public InterestRate27Choice_ InterestRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
