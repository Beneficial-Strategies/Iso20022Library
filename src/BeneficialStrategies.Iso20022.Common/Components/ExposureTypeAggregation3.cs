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
/// Specifies the valuation details per exposure type aggregation.
/// </summary>
[IsoId("_Ml-goSs9EeySlt9bF77XfA")]
[DisplayName("Exposure Type Aggregation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExposureTypeAggregation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ExposureTypeAggregation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ExposureTypeAggregation3( ExposureType23Choice_ reqExposureType )
    {
        ExposureType = reqExposureType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_M90Y0Ss9EeySlt9bF77XfA")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExposureType23Choice_ ExposureType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExposureType23Choice_ ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType23Choice_ ExposureType { get; init; } 
    #else
    public ExposureType23Choice_ ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the settlement process in which the collateral will be settled.
    /// </summary>
    [IsoId("_M90Y0ys9EeySlt9bF77XfA")]
    [DisplayName("Settlement Process")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPrc")]
    #endif
    [IsoXmlTag("SttlmPrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? SettlementProcess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? SettlementProcess { get; init; } 
    #else
    public GenericIdentification30? SettlementProcess { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    [IsoId("_M90Y1Ss9EeySlt9bF77XfA")]
    [DisplayName("Valuation Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnAmts")]
    #endif
    [IsoXmlTag("ValtnAmts")]
    public ValueList<CollateralAmount16> ValuationAmounts { get; init; } = new ValueList<CollateralAmount16>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _M90Y1Ss9EeySlt9bF77XfA
    
    /// <summary>
    /// The collateral excess/shortage expressed in the percentage of the collateral required.
    /// </summary>
    [IsoId("_M90Y1ys9EeySlt9bF77XfA")]
    [DisplayName("Margin Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnRate")]
    #endif
    [IsoXmlTag("MrgnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? MarginRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MarginRate { get; init; } 
    #else
    public System.Decimal? MarginRate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status after comparing the total collateral required and the total collateral value of all transactions of the same exposure type.
    /// </summary>
    [IsoId("_M90Y2Ss9EeySlt9bF77XfA")]
    [DisplayName("Global Exposure Type Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GblXpsrTpSts")]
    #endif
    [IsoXmlTag("GblXpsrTpSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralStatus1Code? GlobalExposureTypeStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralStatus1Code? GlobalExposureTypeStatus { get; init; } 
    #else
    public CollateralStatus1Code? GlobalExposureTypeStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
