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
[IsoId("_wA70wb5WEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Rate SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRateSD9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_wRTMAb5WEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Applicable to structured securities where there is a set schedule of principal and interest payments for the life of the issue. A portion of the scheduled interest payment will not be paid at the time of distribution.
    /// </summary>
    [IsoId("_wRTMA75WEeexmbB7KsjCwA")]
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
    /// American or Global Depository Receipt(s) per ordinary share(s) ratio.
    /// </summary>
    [IsoId("_wRTMC75WEeexmbB7KsjCwA")]
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
