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
/// Indicates one of the constraints of a range of business values.
/// </summary>
[IsoId("_Q7yQ0dp-Ed-ak6NoX_4Aeg_528848853")]
[DisplayName("Term")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Term1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Term1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Term1( Operator1Code reqOperator,RateOrAbsoluteValue1Choice_ reqValue )
    {
        Operator = reqOperator;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the relationship between a variable and a fixed value.
    /// </summary>
    [IsoId("_Q7yQ0tp-Ed-ak6NoX_4Aeg_-1511433825")]
    [DisplayName("Operator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oprtr")]
    #endif
    [IsoXmlTag("Oprtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Operator1Code Operator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Operator1Code Operator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Operator1Code Operator { get; init; } 
    #else
    public Operator1Code Operator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the value.
    /// </summary>
    [IsoId("_Q7yQ09p-Ed-ak6NoX_4Aeg_1365947131")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RateOrAbsoluteValue1Choice_ Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RateOrAbsoluteValue1Choice_ Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateOrAbsoluteValue1Choice_ Value { get; init; } 
    #else
    public RateOrAbsoluteValue1Choice_ Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
