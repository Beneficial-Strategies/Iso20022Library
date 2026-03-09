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
/// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
/// </summary>
[IsoId("_5Pm5wRreEeOVR9VN6fAMUg")]
[DisplayName("Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Tax23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Tax23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Tax23( TaxType2Choice_ reqType,AmountOrPercentage2Choice_ reqAmountOrPercentage )
    {
        Type = reqType;
        AmountOrPercentage = reqAmountOrPercentage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of tax.
    /// </summary>
    [IsoId("_qZsY8BrfEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxType2Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxType2Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxType2Choice_ Type { get; init; } 
    #else
    public TaxType2Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the tax as an amount or percentage.
    /// </summary>
    [IsoId("_DQNcABrfEeOVR9VN6fAMUg")]
    [DisplayName("Amount Or Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtOrPctg")]
    #endif
    [IsoXmlTag("AmtOrPctg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    #else
    public AmountOrPercentage2Choice_ AmountOrPercentage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
