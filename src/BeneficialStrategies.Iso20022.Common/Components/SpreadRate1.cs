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
/// Margin over or under an index that determines the repurchase rate expressed as a rate or an amount.
/// </summary>
[IsoId("_Q-niYtp-Ed-ak6NoX_4Aeg_-1715964179")]
[DisplayName("Spread Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SpreadRate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SpreadRate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SpreadRate1( System.String reqSign,AmountOrRate1Choice_ reqRateOrAmount )
    {
        Sign = reqSign;
        RateOrAmount = reqRateOrAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the sign of the rate.
    /// </summary>
    [IsoId("_Q-niY9p-Ed-ak6NoX_4Aeg_1222158444")]
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
    
    /// <summary>
    /// Specifies if the spreadf is expressed as an amount or a rate.
    /// </summary>
    [IsoId("_Q-niZNp-Ed-ak6NoX_4Aeg_88699368")]
    [DisplayName("Rate Or Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateOrAmt")]
    #endif
    [IsoXmlTag("RateOrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountOrRate1Choice_ RateOrAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountOrRate1Choice_ RateOrAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrRate1Choice_ RateOrAmount { get; init; } 
    #else
    public AmountOrRate1Choice_ RateOrAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
