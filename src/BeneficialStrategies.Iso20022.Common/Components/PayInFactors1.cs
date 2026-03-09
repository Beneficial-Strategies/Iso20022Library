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
/// Factors used in the calculation of the pay in schedule.
/// </summary>
[IsoId("_S3PXsAEcEeCQm6a_G2yO_w_-1038379529")]
[DisplayName("Pay In Factors")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PayInFactors1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PayInFactors1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PayInFactors1( ActiveCurrencyAndAmount reqAggregateShortPositionLimit )
    {
        AggregateShortPositionLimit = reqAggregateShortPositionLimit;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Maximum allowed sum of short positions in all currencies, converted to base currency, during settlement.
    /// </summary>
    [IsoId("_S3PXsQEcEeCQm6a_G2yO_w_-1671491994")]
    [DisplayName("Aggregate Short Position Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AggtShrtPosLmt")]
    #endif
    [IsoXmlTag("AggtShrtPosLmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount AggregateShortPositionLimit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount AggregateShortPositionLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount AggregateShortPositionLimit { get; init; } 
    #else
    public ActiveCurrencyAndAmount AggregateShortPositionLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Currency specific pay-in factors.
    /// </summary>
    [IsoId("_S3PXsgEcEeCQm6a_G2yO_w_1288597221")]
    [DisplayName("Currency Factors")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyFctrs")]
    #endif
    [IsoXmlTag("CcyFctrs")]
    public ValueList<CurrencyFactors1> CurrencyFactors { get; init; } = new ValueList<CurrencyFactors1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _S3PXsgEcEeCQm6a_G2yO_w_1288597221
    
    
    #nullable disable
    
}
