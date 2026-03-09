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
/// Performance factors of the investment fund / fund class.
/// </summary>
[IsoId("_TTfIAtp-Ed-ak6NoX_4Aeg_1116778698")]
[DisplayName("Performance Factors")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PerformanceFactors1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the NAV before all corporate events of the valuation date, divided by the value of the NAV after the corporate event.
    /// </summary>
    [IsoId("_TTfIA9p-Ed-ak6NoX_4Aeg_-359866902")]
    [DisplayName("Corporate Action Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnFctr")]
    #endif
    [IsoXmlTag("CorpActnFctr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? CorporateActionFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? CorporateActionFactor { get; init; } 
    #else
    public System.UInt64? CorporateActionFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the NAV before a corporate event, divided by the value of the NAV after the corporate event, accumulated for a number of corporate events over the defined period of time.
    /// </summary>
    [IsoId("_TTfIBNp-Ed-ak6NoX_4Aeg_-358021142")]
    [DisplayName("Cumulative Corporate Action Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmltvCorpActnFctr")]
    #endif
    [IsoXmlTag("CmltvCorpActnFctr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? CumulativeCorporateActionFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? CumulativeCorporateActionFactor { get; init; } 
    #else
    public System.UInt64? CumulativeCorporateActionFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Period of time for the calculation of the cumulative corporate action factor.
    /// </summary>
    [IsoId("_TTfIBdp-Ed-ak6NoX_4Aeg_-1211048401")]
    [DisplayName("Accumulation Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcmltnPrd")]
    #endif
    [IsoXmlTag("AcmltnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriodDetails? AccumulationPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriodDetails? AccumulationPeriod { get; init; } 
    #else
    public DatePeriodDetails? AccumulationPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Normal performance value of the NAV.
    /// </summary>
    [IsoId("_TTfIBtp-Ed-ak6NoX_4Aeg_-357097187")]
    [DisplayName("Normal Performance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrmlPrfrmnc")]
    #endif
    [IsoXmlTag("NrmlPrfrmnc")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? NormalPerformance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NormalPerformance { get; init; } 
    #else
    public System.UInt64? NormalPerformance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
