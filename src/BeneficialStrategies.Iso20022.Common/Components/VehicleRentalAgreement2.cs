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
/// Agreement (contract) related to a vehicle rental service.
/// </summary>
[IsoId("_wcJ5EayeEeuupt0UCH5uiw")]
[DisplayName("Vehicle Rental Agreement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VehicleRentalAgreement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the original vehicle rental agreement, invoice or contract number.
    /// </summary>
    [IsoId("_wgUnYayeEeuupt0UCH5uiw")]
    [DisplayName("Agreement Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtNb")]
    #endif
    [IsoXmlTag("AgrmtNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AgreementNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AgreementNumber { get; init; } 
    #else
    public System.String? AgreementNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that an adjustment was made to a vehicle rental charge (for example, additional charges added). 
    /// </summary>
    [IsoId("_wgUnY6yeEeuupt0UCH5uiw")]
    [DisplayName("Adjusted Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstdInd")]
    #endif
    [IsoXmlTag("AdjstdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AdjustedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdjustedIndicator { get; init; } 
    #else
    public System.String? AdjustedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the vehicle rental location. 
    /// </summary>
    [IsoId("_wgUnZayeEeuupt0UCH5uiw")]
    [DisplayName("Rental Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntlLctn")]
    #endif
    [IsoXmlTag("RntlLctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address2? RentalLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address2? RentalLocation { get; init; } 
    #else
    public Address2? RentalLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Used when different than rental location
    /// </summary>
    [IsoId("_wgUnZ6yeEeuupt0UCH5uiw")]
    [DisplayName("Pickup Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PckpLctn")]
    #endif
    [IsoXmlTag("PckpLctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address2? PickupLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address2? PickupLocation { get; init; } 
    #else
    public Address2? PickupLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Date the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup date.
    /// </summary>
    [IsoId("_wgUnaayeEeuupt0UCH5uiw")]
    [DisplayName("Check Out Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckOutDt")]
    #endif
    [IsoXmlTag("ChckOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CheckOutDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CheckOutDate { get; init; } 
    #else
    public System.DateOnly? CheckOutDate { get; set; } 
    #endif
    
    /// <summary>
    /// Time the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup time.
    /// </summary>
    [IsoId("_wgUna6yeEeuupt0UCH5uiw")]
    [DisplayName("Check Out Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckOutTm")]
    #endif
    [IsoXmlTag("ChckOutTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? CheckOutTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? CheckOutTime { get; init; } 
    #else
    public System.TimeOnly? CheckOutTime { get; set; } 
    #endif
    
    /// <summary>
    /// Location to which vehicle was returned.
    /// </summary>
    [IsoId("_wgUnbayeEeuupt0UCH5uiw")]
    [DisplayName("Return Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrLctn")]
    #endif
    [IsoXmlTag("RtrLctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address2? ReturnLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address2? ReturnLocation { get; init; } 
    #else
    public Address2? ReturnLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_wgUnb6yeEeuupt0UCH5uiw")]
    [DisplayName("Check In Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckInDt")]
    #endif
    [IsoXmlTag("ChckInDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CheckInDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CheckInDate { get; init; } 
    #else
    public System.DateOnly? CheckInDate { get; set; } 
    #endif
    
    /// <summary>
    /// Time when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_wgUncayeEeuupt0UCH5uiw")]
    [DisplayName("Check In Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckInTm")]
    #endif
    [IsoXmlTag("ChckInTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? CheckInTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? CheckInTime { get; init; } 
    #else
    public System.TimeOnly? CheckInTime { get; set; } 
    #endif
    
    /// <summary>
    /// Duration of rental in days.
    /// </summary>
    [IsoId("_wgUnc6yeEeuupt0UCH5uiw")]
    [DisplayName("Duration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Drtn")]
    #endif
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? Duration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Duration { get; init; } 
    #else
    public System.String? Duration { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details of the vehicle classification.
    /// </summary>
    [IsoId("_wgUndayeEeuupt0UCH5uiw")]
    [DisplayName("Vehicle Class Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclClssDtls")]
    #endif
    [IsoXmlTag("VhclClssDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Vehicle4? VehicleClassDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vehicle4? VehicleClassDetails { get; init; } 
    #else
    public Vehicle4? VehicleClassDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Distance travelled during vehicle rental.
    /// </summary>
    [IsoId("_wgUnd6yeEeuupt0UCH5uiw")]
    [DisplayName("Travel Distance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrvlDstnc")]
    #endif
    [IsoXmlTag("TrvlDstnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Distance1? TravelDistance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Distance1? TravelDistance { get; init; } 
    #else
    public Distance1? TravelDistance { get; set; } 
    #endif
    
    /// <summary>
    /// Vehicle rental rate.
    /// </summary>
    [IsoId("_wgUneayeEeuupt0UCH5uiw")]
    [DisplayName("Rental Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntlRate")]
    #endif
    [IsoXmlTag("RntlRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RentalRate1? RentalRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RentalRate1? RentalRate { get; init; } 
    #else
    public RentalRate1? RentalRate { get; set; } 
    #endif
    
    /// <summary>
    /// Vehicle rental details.
    /// </summary>
    [IsoId("_wgUne6yeEeuupt0UCH5uiw")]
    [DisplayName("Rental Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntlDtls")]
    #endif
    [IsoXmlTag("RntlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RentalDetails2? RentalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RentalDetails2? RentalDetails { get; init; } 
    #else
    public RentalDetails2? RentalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Registration number of vehicle.
    /// </summary>
    [IsoId("_wgUnfayeEeuupt0UCH5uiw")]
    [DisplayName("Vehicle Registration Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclRegnNb")]
    #endif
    [IsoXmlTag("VhclRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? VehicleRegistrationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VehicleRegistrationNumber { get; init; } 
    #else
    public System.String? VehicleRegistrationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_wgUnf6yeEeuupt0UCH5uiw")]
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
    /// Contains the details of additional amount for a specific vehicle rental service type. 
    /// </summary>
    [IsoId("_wgUngayeEeuupt0UCH5uiw")]
    [DisplayName("Additional Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAmt")]
    #endif
    [IsoXmlTag("AddtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount18? AdditionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount18? AdditionalAmount { get; init; } 
    #else
    public Amount18? AdditionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_wgUng6yeEeuupt0UCH5uiw")]
    [DisplayName("Estimated Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdTax")]
    #endif
    [IsoXmlTag("EstmtdTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax39? EstimatedTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax39? EstimatedTax { get; init; } 
    #else
    public Tax39? EstimatedTax { get; set; } 
    #endif
    
    /// <summary>
    /// Discount applied to the vehicle rental.
    /// </summary>
    [IsoId("_wgUnhayeEeuupt0UCH5uiw")]
    [DisplayName("Discount Programme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntPrgrmm")]
    #endif
    [IsoXmlTag("DscntPrgrmm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Discount3? DiscountProgramme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Discount3? DiscountProgramme { get; init; } 
    #else
    public Discount3? DiscountProgramme { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty programme details.
    /// </summary>
    [IsoId("_wgUnh6yeEeuupt0UCH5uiw")]
    [DisplayName("Loyalty Programme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyPrgrmm")]
    #endif
    [IsoXmlTag("LltyPrgrmm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyProgramme3? LoyaltyProgramme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyProgramme3? LoyaltyProgramme { get; init; } 
    #else
    public LoyaltyProgramme3? LoyaltyProgramme { get; set; } 
    #endif
    
    
    #nullable disable
    
}
