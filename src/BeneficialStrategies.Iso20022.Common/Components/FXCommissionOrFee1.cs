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
/// Specifies the foreign exchange commissions and fees amounts.
/// </summary>
[IsoId("_Tv5YAANyEe2-vqzwMUAewg")]
[DisplayName("FX Commission Or Fee")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FXCommissionOrFee1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FXCommissionOrFee1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FXCommissionOrFee1( FXAmountType1Choice_ reqType,AmountOrRate4Choice_ reqAmountOrRate )
    {
        Type = reqType;
        AmountOrRate = reqAmountOrRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of the commission or fee.
    /// </summary>
    [IsoId("_e4y_EANyEe2-vqzwMUAewg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FXAmountType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FXAmountType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FXAmountType1Choice_ Type { get; init; } 
    #else
    public FXAmountType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Amount or rate of the commissions and fees.
    /// </summary>
    [IsoId("_oLLJYANyEe2-vqzwMUAewg")]
    [DisplayName("Amount Or Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtOrRate")]
    #endif
    [IsoXmlTag("AmtOrRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountOrRate4Choice_ AmountOrRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountOrRate4Choice_ AmountOrRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrRate4Choice_ AmountOrRate { get; init; } 
    #else
    public AmountOrRate4Choice_ AmountOrRate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the amount or rate value is positive or negative.
    /// Usage: when absent, it means that amount value is 0 or positive.
    /// </summary>
    [IsoId("_pC8e4ANyEe2-vqzwMUAewg")]
    [DisplayName("Sign")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgn")]
    #endif
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPlusOrMinusIndicator? Sign { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Sign { get; init; } 
    #else
    public System.String? Sign { get; set; } 
    #endif
    
    
    #nullable disable
    
}
