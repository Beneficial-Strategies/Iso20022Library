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
/// Provides additional information regarding corporate action details rates and amounts details.
/// </summary>
[IsoId("_1TX0EDL3EeKU9IrkkToqcw_1084559297")]
[DisplayName("Corporate Action Rate SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRateSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionRateSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionRateSD1( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1TX0ETL3EeKU9IrkkToqcw_51606085")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Applicable to structured securities where there is a set schedule of principal and interest payments for the life of the issue. A portion of the scheduled interest payment will not be paid at the time of distribution.
    /// </summary>
    [IsoId("_1TX0EjL3EeKU9IrkkToqcw_-5844361")]
    [DisplayName("Deferred Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfrrdIntrstRate")]
    #endif
    [IsoXmlTag("DfrrdIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? DeferredInterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? DeferredInterestRate { get; init; } 
    #else
    public System.Decimal? DeferredInterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Applicable for structured security issues where there is a set schedule of principal and interest payments for the life of the issue. An interest shortfall occurs when scheduled interest is not paid to the investor as scheduled.
    /// </summary>
    [IsoId("_1TX0EzL3EeKU9IrkkToqcw_1059130676")]
    [DisplayName("Interest Shortfall Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstShrtfllRate")]
    #endif
    [IsoXmlTag("IntrstShrtfllRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? InterestShortfallRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InterestShortfallRate { get; init; } 
    #else
    public System.Decimal? InterestShortfallRate { get; set; } 
    #endif
    
    /// <summary>
    /// Applicable to structured securities where there is a set schedule of principal and interest payments for the life of the issue. This term refers specifically to the principal payment of a mortgage. One or more mortgages within the pool are in default.
    /// </summary>
    [IsoId("_1TX0FDL3EeKU9IrkkToqcw_-1505398481")]
    [DisplayName("Realised Loss Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RealsdLossRate")]
    #endif
    [IsoXmlTag("RealsdLossRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? RealisedLossRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RealisedLossRate { get; init; } 
    #else
    public System.Decimal? RealisedLossRate { get; set; } 
    #endif
    
    /// <summary>
    /// American or Global Depository Receipt(s) per ordinary share(s) ratio.
    /// </summary>
    [IsoId("_1TX0FTL3EeKU9IrkkToqcw_1510806012")]
    [DisplayName("American Or Global Deposit Receipt Ratio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmrcnOrGblDpstRctRatio")]
    #endif
    [IsoXmlTag("AmrcnOrGblDpstRctRatio")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRateSD2? AmericanOrGlobalDepositReceiptRatio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRateSD2? AmericanOrGlobalDepositReceiptRatio { get; init; } 
    #else
    public CorporateActionRateSD2? AmericanOrGlobalDepositReceiptRatio { get; set; } 
    #endif
    
    
    #nullable disable
    
}
