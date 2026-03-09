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
/// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
/// </summary>
[IsoId("_n3oMMRrcEeOVR9VN6fAMUg")]
[DisplayName("Adjustment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Adjustment7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Adjustment7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Adjustment7( AdjustmentType1Choice_ reqType,AmountOrPercentage2Choice_ reqAmountOrPercentage,AdjustmentDirection1Code reqDirection )
    {
        Type = reqType;
        AmountOrPercentage = reqAmountOrPercentage;
        Direction = reqDirection;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of adjustment.
    /// </summary>
    [IsoId("_oP6wYRrcEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdjustmentType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdjustmentType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdjustmentType1Choice_ Type { get; init; } 
    #else
    public AdjustmentType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the monetary amount or rate of the adjustment.
    /// </summary>
    [IsoId("_oP6wZRrcEeOVR9VN6fAMUg")]
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
    
    /// <summary>
    /// Specifies whether the adjustment must be subtracted or added to the total amount.
    /// </summary>
    [IsoId("_oP6wYxrcEeOVR9VN6fAMUg")]
    [DisplayName("Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Drctn")]
    #endif
    [IsoXmlTag("Drctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdjustmentDirection1Code Direction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdjustmentDirection1Code Direction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdjustmentDirection1Code Direction { get; init; } 
    #else
    public AdjustmentDirection1Code Direction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
