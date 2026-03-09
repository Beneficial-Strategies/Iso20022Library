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
/// Contains the details of the package
/// </summary>
[IsoId("_l2yNwZF_EeukDPgU2BMkjQ")]
[DisplayName("Shipping Package")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShippingPackage2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the identification number for the packages being shipped and is also used for pickup number. 
    /// </summary>
    [IsoId("_l8yIEZF_EeukDPgU2BMkjQ")]
    [DisplayName("Tracking Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckgNb")]
    #endif
    [IsoXmlTag("TrckgNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? TrackingNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TrackingNumber { get; init; } 
    #else
    public System.String? TrackingNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Supplier or provider of the delivery services.
    /// </summary>
    [IsoId("_l8yIE5F_EeukDPgU2BMkjQ")]
    [DisplayName("Supplier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Spplr")]
    #endif
    [IsoXmlTag("Spplr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification260? Supplier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification260? Supplier { get; init; } 
    #else
    public PartyIdentification260? Supplier { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the date the package is picked up.
    /// </summary>
    [IsoId("_7Ip_kCbSEeyhZIgCcGlTyA")]
    [DisplayName("Pickup Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PckpDt")]
    #endif
    [IsoXmlTag("PckpDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? PickupDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? PickupDate { get; init; } 
    #else
    public System.DateOnly? PickupDate { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the time the package is picked up.
    /// </summary>
    [IsoId("_l8yIFZF_EeukDPgU2BMkjQ")]
    [DisplayName("Pickup Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PckpTm")]
    #endif
    [IsoXmlTag("PckpTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? PickupTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? PickupTime { get; init; } 
    #else
    public System.TimeOnly? PickupTime { get; set; } 
    #endif
    
    /// <summary>
    /// Delivery information. 
    /// </summary>
    [IsoId("_l8yIF5F_EeukDPgU2BMkjQ")]
    [DisplayName("Delivery")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dlvry")]
    #endif
    [IsoXmlTag("Dlvry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryInformation4? Delivery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryInformation4? Delivery { get; init; } 
    #else
    public DeliveryInformation4? Delivery { get; set; } 
    #endif
    
    /// <summary>
    /// Weight details.
    /// </summary>
    [IsoId("_l8yIGZF_EeukDPgU2BMkjQ")]
    [DisplayName("Weight")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wght")]
    #endif
    [IsoXmlTag("Wght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure2? Weight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure2? Weight { get; init; } 
    #else
    public UnitOfMeasure2? Weight { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the product details.
    /// </summary>
    [IsoId("_l8yIG5F_EeukDPgU2BMkjQ")]
    [DisplayName("Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pdct")]
    #endif
    [IsoXmlTag("Pdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Product7? Product { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product7? Product { get; init; } 
    #else
    public Product7? Product { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_l8yIHZF_EeukDPgU2BMkjQ")]
    [DisplayName("Insurance Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncInd")]
    #endif
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InsuranceIndicator { get; init; } 
    #else
    public System.String? InsuranceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of insurance.
    /// </summary>
    [IsoId("_l8yIH5F_EeukDPgU2BMkjQ")]
    [DisplayName("Insurance Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncAmt")]
    #endif
    [IsoXmlTag("InsrncAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
