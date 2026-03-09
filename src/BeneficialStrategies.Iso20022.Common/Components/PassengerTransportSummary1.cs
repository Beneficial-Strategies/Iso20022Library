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
/// Passenger ticket summary information for the cardholder. 
/// </summary>
[IsoId("_YkXBm_PhEeihCvvpsmGI2w")]
[DisplayName("Passenger Transport Summary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PassengerTransportSummary1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification number of the document.
    /// </summary>
    [IsoId("_OysdwfPiEeihCvvpsmGI2w")]
    [DisplayName("Document Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocNb")]
    #endif
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DocumentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DocumentNumber { get; init; } 
    #else
    public System.String? DocumentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reservation number or identifier. 
    /// </summary>
    [IsoId("_YkXopvPhEeihCvvpsmGI2w")]
    [DisplayName("Reservation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsvatn")]
    #endif
    [IsoXmlTag("Rsvatn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReservationDetails3? Reservation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationDetails3? Reservation { get; init; } 
    #else
    public ReservationDetails3? Reservation { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a code provided to a travel agent by a company to authorise ticket issuance. 
    /// </summary>
    [IsoId("_YkXoo_PhEeihCvvpsmGI2w")]
    [DisplayName("Travel Authorisation Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrvlAuthstnCd")]
    #endif
    [IsoXmlTag("TrvlAuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? TravelAuthorisationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TravelAuthorisationCode { get; init; } 
    #else
    public System.String? TravelAuthorisationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the issuing ticket agent. 
    /// </summary>
    [IsoId("_YkXoqPPhEeihCvvpsmGI2w")]
    [DisplayName("Ticket Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TcktIssr")]
    #endif
    [IsoXmlTag("TcktIssr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TicketIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TicketIssuer { get; init; } 
    #else
    public System.String? TicketIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the ticket is open or restricted.
    /// </summary>
    [IsoId("_v7m4AfPlEeihCvvpsmGI2w")]
    [DisplayName("Open Ticket Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpnTcktInd")]
    #endif
    [IsoXmlTag("OpnTcktInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? OpenTicketIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OpenTicketIndicator { get; init; } 
    #else
    public System.String? OpenTicketIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Contains Customer Reference Values provided for this transaction and used for various reference processing at the customer site. These values represent information most prevalently provided by travel agencies for transactions booked against a lodged account or central travel account.
    /// </summary>
    [IsoId("_YkXooPPhEeihCvvpsmGI2w")]
    [DisplayName("Customer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrRef")]
    #endif
    [IsoXmlTag("CstmrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerReference1? CustomerReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerReference1? CustomerReference { get; init; } 
    #else
    public CustomerReference1? CustomerReference { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details of the passenger.
    /// </summary>
    [IsoId("_YkXopPPhEeihCvvpsmGI2w")]
    [DisplayName("Passenger")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pssngr")]
    #endif
    [IsoXmlTag("Pssngr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Customer5? Passenger { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Customer5? Passenger { get; init; } 
    #else
    public Customer5? Passenger { get; set; } 
    #endif
    
    /// <summary>
    /// Contains departure location, date and time. 
    /// </summary>
    [IsoId("_YkXoofPhEeihCvvpsmGI2w")]
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
    /// Duration of the trip in days.
    /// </summary>
    [IsoId("_YkXopfPhEeihCvvpsmGI2w")]
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
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_YkXoovPhEeihCvvpsmGI2w")]
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
    /// Total amount.
    /// </summary>
    [IsoId("_YkXoqfPhEeihCvvpsmGI2w")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountDetails1? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountDetails1? TotalAmount { get; init; } 
    #else
    public AmountDetails1? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_tPq8kvPtEeihCvvpsmGI2w")]
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
    [IsoId("_tPq8k_PtEeihCvvpsmGI2w")]
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
    /// Additional user-defined data pertaining to the transportation.
    /// </summary>
    [IsoId("_YkXop_PhEeihCvvpsmGI2w")]
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
