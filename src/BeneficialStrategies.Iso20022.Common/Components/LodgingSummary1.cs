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
/// Data pertaining to a lodging transaction. 
/// </summary>
[IsoId("_npqEIPb_EeiW-auGnDPZIw")]
[DisplayName("Lodging Summary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LodgingSummary1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the lodging company&apos;s invoice or billing ID reference number, referred to as a folio number. 
    /// </summary>
    [IsoId("_4mIMUfb_EeiW-auGnDPZIw")]
    [DisplayName("Folio Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FolioNb")]
    #endif
    [IsoXmlTag("FolioNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FolioNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FolioNumber { get; init; } 
    #else
    public System.String? FolioNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the lodging property. 
    /// </summary>
    [IsoId("_npqEIvb_EeiW-auGnDPZIw")]
    [DisplayName("Property")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prprty")]
    #endif
    [IsoXmlTag("Prprty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LodgingProperty1? Property { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LodgingProperty1? Property { get; init; } 
    #else
    public LodgingProperty1? Property { get; set; } 
    #endif
    
    /// <summary>
    /// Contains customer details.
    /// </summary>
    [IsoId("_npqEJPb_EeiW-auGnDPZIw")]
    [DisplayName("Customer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cstmr")]
    #endif
    [IsoXmlTag("Cstmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Customer5? Customer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Customer5? Customer { get; init; } 
    #else
    public Customer5? Customer { get; set; } 
    #endif
    
    /// <summary>
    /// Number of rooms within the reservation. 
    /// </summary>
    [IsoId("_LIyYwPcMEeiW-auGnDPZIw")]
    [DisplayName("Number Of Rooms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfRooms")]
    #endif
    [IsoXmlTag("NbOfRooms")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? NumberOfRooms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfRooms { get; init; } 
    #else
    public System.String? NumberOfRooms { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the room details. 
    /// </summary>
    [IsoId("_npqEI_b_EeiW-auGnDPZIw")]
    [DisplayName("Room")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Room")]
    #endif
    [IsoXmlTag("Room")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LodgingRoom1? Room { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LodgingRoom1? Room { get; init; } 
    #else
    public LodgingRoom1? Room { get; set; } 
    #endif
    
    /// <summary>
    /// Duration of stay in days.
    /// </summary>
    [IsoId("_zIKFxPcVEeiW-auGnDPZIw")]
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
    /// Lodging transaction details.
    /// </summary>
    [IsoId("_npqEIfb_EeiW-auGnDPZIw")]
    [DisplayName("Arrival")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Arrvl")]
    #endif
    [IsoXmlTag("Arrvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DepartureOrArrival2? Arrival { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DepartureOrArrival2? Arrival { get; init; } 
    #else
    public DepartureOrArrival2? Arrival { get; set; } 
    #endif
    
    /// <summary>
    /// Contains departure details. 
    /// </summary>
    [IsoId("_CbURUPcXEeiW-auGnDPZIw")]
    [DisplayName("Departure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dprture")]
    #endif
    [IsoXmlTag("Dprture")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DepartureOrArrival1? Departure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DepartureOrArrival1? Departure { get; init; } 
    #else
    public DepartureOrArrival1? Departure { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee; property was not actually rented. 
    /// </summary>
    [IsoId("_fKVag_cXEeiW-auGnDPZIw")]
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
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_zIKFxfcVEeiW-auGnDPZIw")]
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
    [IsoId("_-Xv4wPcXEeiW-auGnDPZIw")]
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
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_fKVahfcXEeiW-auGnDPZIw")]
    [DisplayName("Total Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTax")]
    #endif
    [IsoXmlTag("TtlTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax33? TotalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax33? TotalTax { get; init; } 
    #else
    public Tax33? TotalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the total amount of lodging expenses.
    /// </summary>
    [IsoId("_GYQLgPcYEeiW-auGnDPZIw")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Contains Authorised amount details.
    /// </summary>
    [IsoId("_fKVahPcXEeiW-auGnDPZIw")]
    [DisplayName("Authorised Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrsdAmt")]
    #endif
    [IsoXmlTag("AuthrsdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthorisedAmount1? AuthorisedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisedAmount1? AuthorisedAmount { get; init; } 
    #else
    public AuthorisedAmount1? AuthorisedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_zIKFxvcVEeiW-auGnDPZIw")]
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
    /// Loyalty programme details. 
    /// </summary>
    [IsoId("_zIKFx_cVEeiW-auGnDPZIw")]
    [DisplayName("Loyalty Programme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyPrgrmm")]
    #endif
    [IsoXmlTag("LltyPrgrmm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    #else
    public LoyaltyProgramme2? LoyaltyProgramme { get; set; } 
    #endif
    
    /// <summary>
    /// Additional user-defined data pertaining to the lodging. 
    /// </summary>
    [IsoId("_zIKFyPcVEeiW-auGnDPZIw")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
