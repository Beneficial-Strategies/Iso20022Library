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
/// Invoice related to a vehicle rental service.
/// </summary>
[IsoId("_cYeOxvTZEeife6veM7daYw")]
[DisplayName("Vehicle Rental Invoice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VehicleRentalInvoice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates that the cardholder failed to pick up the vehicle and was therefore charged a no-show fee; vehicle was not actually rented. 
    /// </summary>
    [IsoId("_cYeO1fTZEeife6veM7daYw")]
    [DisplayName("No Show Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoShowInd")]
    #endif
    [IsoXmlTag("NoShowInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? NoShowIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NoShowIndicator { get; init; } 
    #else
    public System.String? NoShowIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that an adjustment was made to a vehicle rental charge (for example, additional charges added). 
    /// </summary>
    [IsoId("_cYeO2PTZEeife6veM7daYw")]
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
    /// Location to which vehicle was returned.
    /// </summary>
    [IsoId("_cYeO0_TZEeife6veM7daYw")]
    [DisplayName("Return Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrLctn")]
    #endif
    [IsoXmlTag("RtrLctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address1? ReturnLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address1? ReturnLocation { get; init; } 
    #else
    public Address1? ReturnLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Date the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup date.
    /// </summary>
    [IsoId("_cYeOyPTZEeife6veM7daYw")]
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
    [IsoId("_cYeOzPTZEeife6veM7daYw")]
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
    /// Date when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_cYeO0vTZEeife6veM7daYw")]
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
    [IsoId("_cYeOx_TZEeife6veM7daYw")]
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
    [IsoId("_cYeO2fTZEeife6veM7daYw")]
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
    /// Contains the details of the vehicle class invoiced to the renter regardless of the class of vehicle actually provided. 
    /// </summary>
    [IsoId("_cYeO1vTZEeife6veM7daYw")]
    [DisplayName("Vehicle Class Invoiced")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclClssInvcd")]
    #endif
    [IsoXmlTag("VhclClssInvcd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Vehicle4? VehicleClassInvoiced { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vehicle4? VehicleClassInvoiced { get; init; } 
    #else
    public Vehicle4? VehicleClassInvoiced { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details of the vehicle class of the vehicle actually provided to the renter at the time of vehicle pick-up. This may be an upgrade class of vehicle, above that invoiced to the renter. 
    /// </summary>
    [IsoId("_cYeO1PTZEeife6veM7daYw")]
    [DisplayName("Vehicle Class Provided")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclClssPrvdd")]
    #endif
    [IsoXmlTag("VhclClssPrvdd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Vehicle4? VehicleClassProvided { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vehicle4? VehicleClassProvided { get; init; } 
    #else
    public Vehicle4? VehicleClassProvided { get; set; } 
    #endif
    
    /// <summary>
    /// Distance travelled during vehicle rental.
    /// </summary>
    [IsoId("_cYeOz_TZEeife6veM7daYw")]
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
    /// Vehicle rental charge.
    /// </summary>
    [IsoId("_cYeOzvTZEeife6veM7daYw")]
    [DisplayName("Rental Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntlChrg")]
    #endif
    [IsoXmlTag("RntlChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RentalRate1? RentalCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RentalRate1? RentalCharge { get; init; } 
    #else
    public RentalRate1? RentalCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_v-ZlEfTcEeife6veM7daYw")]
    [DisplayName("Summary Commodity Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SummryCmmdtyId")]
    #endif
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SummaryCommodityIdentification { get; init; } 
    #else
    public System.String? SummaryCommodityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_cYeO0fTZEeife6veM7daYw")]
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
    [IsoId("_cYeOyfTZEeife6veM7daYw")]
    [DisplayName("Additional Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAmt")]
    #endif
    [IsoXmlTag("AddtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount9? AdditionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount9? AdditionalAmount { get; init; } 
    #else
    public Amount9? AdditionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_cYeO2vTZEeife6veM7daYw")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax33? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax33? Tax { get; init; } 
    #else
    public Tax33? Tax { get; set; } 
    #endif
    
    
    #nullable disable
    
}
