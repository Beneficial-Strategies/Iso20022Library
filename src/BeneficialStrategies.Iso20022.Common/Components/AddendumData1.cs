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
/// Component contains data structures applicable to certain merchant verticals that require industry-specific data within transaction messages. 
/// </summary>
[IsoId("_DnFa09kkEeiKYdl5SlduIA")]
[DisplayName("Addendum Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AddendumData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of identifier present in the message.
    /// </summary>
    [IsoId("_7-q0oPJNEeiJn9rM2Znz2w")]
    [DisplayName("Purchase Identifier Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsIdrTp")]
    #endif
    [IsoXmlTag("PurchsIdrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PurchaseIdentifierType1Code? PurchaseIdentifierType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PurchaseIdentifierType1Code? PurchaseIdentifierType { get; init; } 
    #else
    public PurchaseIdentifierType1Code? PurchaseIdentifierType { get; set; } 
    #endif
    
    /// <summary>
    /// Used when Purchase Identifier Type is Other National or Other Private. 
    /// </summary>
    [IsoId("_r448gPJQEeiJn9rM2Znz2w")]
    [DisplayName("Other Purchase Identifier Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPurchsIdrTp")]
    #endif
    [IsoXmlTag("OthrPurchsIdrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherPurchaseIdentifierType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherPurchaseIdentifierType { get; init; } 
    #else
    public System.String? OtherPurchaseIdentifierType { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a value identifying Invoice Data or Purchase Request Data.
    /// </summary>
    [IsoId("_7K0OcPJQEeiJn9rM2Znz2w")]
    [DisplayName("Purchase Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsIdr")]
    #endif
    [IsoXmlTag("PurchsIdr")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax99Text? PurchaseIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PurchaseIdentifier { get; init; } 
    #else
    public System.String? PurchaseIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional card acceptor data. 
    /// </summary>
    [IsoId("_bbBTgPJeEeiJn9rM2Znz2w")]
    [DisplayName("Additional Acceptor Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAccptrData")]
    #endif
    [IsoXmlTag("AddtlAccptrData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalAcceptorData1? AdditionalAcceptorData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalAcceptorData1? AdditionalAcceptorData { get; init; } 
    #else
    public AdditionalAcceptorData1? AdditionalAcceptorData { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the customer.
    /// </summary>
    [IsoId("_z39NYPJnEeiJn9rM2Znz2w")]
    [DisplayName("Customer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cstmr")]
    #endif
    [IsoXmlTag("Cstmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Customer4? Customer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Customer4? Customer { get; init; } 
    #else
    public Customer4? Customer { get; set; } 
    #endif
    
    /// <summary>
    /// Details of good and services included in the sale.
    /// </summary>
    [IsoId("_vGEREPJ6EeiJn9rM2Znz2w")]
    [DisplayName("Sale")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sale")]
    #endif
    [IsoXmlTag("Sale")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Sale1? Sale { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Sale1? Sale { get; init; } 
    #else
    public Sale1? Sale { get; set; } 
    #endif
    
    /// <summary>
    /// Fleet data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_oQcUYPjNEeiM7KpzmLtmTQ")]
    [DisplayName("Fleet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fleet")]
    #endif
    [IsoXmlTag("Fleet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FleetData2? Fleet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FleetData2? Fleet { get; init; } 
    #else
    public FleetData2? Fleet { get; set; } 
    #endif
    
    /// <summary>
    /// Invoice data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_M5uigfNJEei4qfiLgRIZBA")]
    [DisplayName("Invoice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invc")]
    #endif
    [IsoXmlTag("Invc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Invoice1? Invoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Invoice1? Invoice { get; init; } 
    #else
    public Invoice1? Invoice { get; set; } 
    #endif
    
    /// <summary>
    /// Component supports corporate transactions for travel agency, airline, or railway transactions. Acquirers may submit multiple occurrences of this component. Each occurrence provides detailed travel agency fee data associated with a travel agency, airline, or railway transaction.
    /// </summary>
    [IsoId("_dZBKwfPeEeihCvvpsmGI2w")]
    [DisplayName("Travel Agency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrvlAgcy")]
    #endif
    [IsoXmlTag("TrvlAgcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TravelAgency2? TravelAgency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TravelAgency2? TravelAgency { get; init; } 
    #else
    public TravelAgency2? TravelAgency { get; set; } 
    #endif
    
    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder. 
    /// </summary>
    [IsoId("_a2_UQPQdEeihCvvpsmGI2w")]
    [DisplayName("Passenger Transport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PssngrTrnsprt")]
    #endif
    [IsoXmlTag("PssngrTrnsprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PassengerTransport1? PassengerTransport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PassengerTransport1? PassengerTransport { get; init; } 
    #else
    public PassengerTransport1? PassengerTransport { get; set; } 
    #endif
    
    /// <summary>
    /// Component provides detailed vehicle rental information. One occurrence of this component provides rental agreement data reporting for a single vehicle rental transaction.
    /// </summary>
    [IsoId("_W9dLwvJNEeiJn9rM2Znz2w")]
    [DisplayName("Vehicle Rental")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclRntl")]
    #endif
    [IsoXmlTag("VhclRntl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VehicleRentalService1? VehicleRental { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VehicleRentalService1? VehicleRental { get; init; } 
    #else
    public VehicleRentalService1? VehicleRental { get; set; } 
    #endif
    
    /// <summary>
    /// Component provides detailed information about lodging accommodations and related expenses for the cardholder. Acquirers can submit multiple occurrences of this component for each lodging transaction, to provide details of one or more folios.
    /// </summary>
    [IsoId("_W9dLw_JNEeiJn9rM2Znz2w")]
    [DisplayName("Lodging")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ldgg")]
    #endif
    [IsoXmlTag("Ldgg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Lodging2? Lodging { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Lodging2? Lodging { get; init; } 
    #else
    public Lodging2? Lodging { get; set; } 
    #endif
    
    /// <summary>
    /// Shipping or Courier Service detail component provides detailed information regarding delivery or courier services. 
    /// </summary>
    [IsoId("_ZZD9cPctEeiW-auGnDPZIw")]
    [DisplayName("Shipping Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShppgData")]
    #endif
    [IsoXmlTag("ShppgData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ShippingData1? ShippingData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShippingData1? ShippingData { get; init; } 
    #else
    public ShippingData1? ShippingData { get; set; } 
    #endif
    
    /// <summary>
    /// Telecommunication services component is designed to carry telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information. 
    /// </summary>
    [IsoId("_iX6coPfOEei89sMSHxl1ew")]
    [DisplayName("Telecommunication Services")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TelecomSvcs")]
    #endif
    [IsoXmlTag("TelecomSvcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TelecomServices1? TelecommunicationServices { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TelecomServices1? TelecommunicationServices { get; init; } 
    #else
    public TelecomServices1? TelecommunicationServices { get; set; } 
    #endif
    
    /// <summary>
    /// Temporary Services component provides detailed information regarding the billing for services rendered on a temporary or contract basis. The component provides information such as the employee job performed, timekeeping, and billing rates.
    /// </summary>
    [IsoId("_bfPSoPfkEei89sMSHxl1ew")]
    [DisplayName("Temporary Services")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TempSvcs")]
    #endif
    [IsoXmlTag("TempSvcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TemporaryServices1? TemporaryServices { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TemporaryServices1? TemporaryServices { get; init; } 
    #else
    public TemporaryServices1? TemporaryServices { get; set; } 
    #endif
    
    /// <summary>
    /// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
    /// </summary>
    [IsoId("_tVn5gPlREeilft0P2fSiEQ")]
    [DisplayName("Instalment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instlmt")]
    #endif
    [IsoXmlTag("Instlmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Instalment3? Instalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Instalment3? Instalment { get; init; } 
    #else
    public Instalment3? Instalment { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data for the addendum.
    /// </summary>
    [IsoId("_jeXOgP75Eeic54G0fOJNMg")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
