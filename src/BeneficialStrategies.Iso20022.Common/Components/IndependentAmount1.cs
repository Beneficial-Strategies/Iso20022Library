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
/// Indicates the independent amount and how it was applied in the calculation.
/// </summary>
[IsoId("_UlI9KNp-Ed-ak6NoX_4Aeg_1173631516")]
[DisplayName("Independent Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndependentAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndependentAmount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndependentAmount1( ActiveCurrencyAndAmount reqAmount,IndependentAmountConventionType1Code reqConvention )
    {
        Amount = reqAmount;
        Convention = reqConvention;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the independant amount.
    /// </summary>
    [IsoId("_UlSuINp-Ed-ak6NoX_4Aeg_-2028501598")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Determines how the independent amount was applied in the calculation. 
    /// It is either:
    /// - before threshold, effectively acting as an add on to exposure, 
    /// - after threshold where the amount is an add on to the credit support amount and forms part of the variation margin requirement,
    /// - segregated where it is treated independently of variation margin for segregation purposes.
    /// </summary>
    [IsoId("_UlSuIdp-Ed-ak6NoX_4Aeg_1427405925")]
    [DisplayName("Convention")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cnvntn")]
    #endif
    [IsoXmlTag("Cnvntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IndependentAmountConventionType1Code Convention { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IndependentAmountConventionType1Code Convention { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndependentAmountConventionType1Code Convention { get; init; } 
    #else
    public IndependentAmountConventionType1Code Convention { get; set; } 
    #endif
    
    
    #nullable disable
    
}
