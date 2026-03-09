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
/// Distance between a start and a return car rental period.
/// </summary>
[IsoId("_M0xaMF_pEee-csPAW1txwQ")]
[DisplayName("Distance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Distance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unit of measure used to compute the distance.
    /// </summary>
    [IsoId("_cqOP8F_pEee-csPAW1txwQ")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure10Code? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure10Code? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure10Code? UnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Odometer reading at start of rental (at the time of vehicle check-out). 
    /// </summary>
    [IsoId("_B81x4F_qEee-csPAW1txwQ")]
    [DisplayName("Odometer Start")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OdmtrStart")]
    #endif
    [IsoXmlTag("OdmtrStart")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? OdometerStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OdometerStart { get; init; } 
    #else
    public System.String? OdometerStart { get; set; } 
    #endif
    
    /// <summary>
    /// Odometer reading at return of rental (at the time of vehicle check-in). 
    /// </summary>
    [IsoId("_KHAW8F_qEee-csPAW1txwQ")]
    [DisplayName("Odometer Return")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OdmtrRtr")]
    #endif
    [IsoXmlTag("OdmtrRtr")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? OdometerReturn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OdometerReturn { get; init; } 
    #else
    public System.String? OdometerReturn { get; set; } 
    #endif
    
    /// <summary>
    /// Total distance expressed in unit of measure.
    /// </summary>
    [IsoId("_PvfCYF_qEee-csPAW1txwQ")]
    [DisplayName("Total Distance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlDstnc")]
    #endif
    [IsoXmlTag("TtlDstnc")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? TotalDistance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TotalDistance { get; init; } 
    #else
    public System.String? TotalDistance { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum free miles or kilometres for the car rental period.
    /// </summary>
    [IsoId("_XtVCsF_qEee-csPAW1txwQ")]
    [DisplayName("Free Distance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FreeDstnc")]
    #endif
    [IsoXmlTag("FreeDstnc")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? FreeDistance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FreeDistance { get; init; } 
    #else
    public System.String? FreeDistance { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the rate in relation to a specific distance. 
    /// </summary>
    [IsoId("_WT2uwPS2Eeife6veM7daYw")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? Rate { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? Rate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
