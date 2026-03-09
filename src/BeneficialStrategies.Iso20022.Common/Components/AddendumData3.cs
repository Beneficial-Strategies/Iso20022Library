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
[IsoId("_-wbMoYv0EeumSPwlS1PkxQ")]
[DisplayName("Addendum Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AddendumData3
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
    [IsoId("_-2QH0Yv0EeumSPwlS1PkxQ")]
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
    [IsoId("_-2QH04v0EeumSPwlS1PkxQ")]
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
    [IsoId("_-2QH1Yv0EeumSPwlS1PkxQ")]
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
    [IsoId("_-2QH14v0EeumSPwlS1PkxQ")]
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
    [IsoId("_-2QH2Yv0EeumSPwlS1PkxQ")]
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
    [IsoId("_-2QH24v0EeumSPwlS1PkxQ")]
    [DisplayName("Sale")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sale")]
    #endif
    [IsoXmlTag("Sale")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Sale2? Sale { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Sale2? Sale { get; init; } 
    #else
    public Sale2? Sale { get; set; } 
    #endif
    
    /// <summary>
    /// Fleet data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_-2QH3Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Fleet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fleet")]
    #endif
    [IsoXmlTag("Fleet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FleetData4? Fleet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FleetData4? Fleet { get; init; } 
    #else
    public FleetData4? Fleet { get; set; } 
    #endif
    
    /// <summary>
    /// Invoice data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_-2QH34v0EeumSPwlS1PkxQ")]
    [DisplayName("Invoice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invc")]
    #endif
    [IsoXmlTag("Invc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Invoice2? Invoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Invoice2? Invoice { get; init; } 
    #else
    public Invoice2? Invoice { get; set; } 
    #endif
    
    /// <summary>
    /// Component supports corporate transactions for travel agency, airline, or railway transactions. Acquirers may submit multiple occurrences of this component. Each occurrence provides detailed travel agency fee data associated with a travel agency, airline, or railway transaction.
    /// </summary>
    [IsoId("_-2QH4Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Travel Agency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrvlAgcy")]
    #endif
    [IsoXmlTag("TrvlAgcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TravelAgency3? TravelAgency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TravelAgency3? TravelAgency { get; init; } 
    #else
    public TravelAgency3? TravelAgency { get; set; } 
    #endif
    
    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder. 
    /// </summary>
    [IsoId("_-2QH44v0EeumSPwlS1PkxQ")]
    [DisplayName("Passenger Transport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PssngrTrnsprt")]
    #endif
    [IsoXmlTag("PssngrTrnsprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PassengerTransport2? PassengerTransport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PassengerTransport2? PassengerTransport { get; init; } 
    #else
    public PassengerTransport2? PassengerTransport { get; set; } 
    #endif
    
    /// <summary>
    /// Component provides detailed vehicle rental information. One occurrence of this component provides rental agreement data reporting for a single vehicle rental transaction.
    /// </summary>
    [IsoId("_-2QH5Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Vehicle Rental")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclRntl")]
    #endif
    [IsoXmlTag("VhclRntl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VehicleRentalService2? VehicleRental { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VehicleRentalService2? VehicleRental { get; init; } 
    #else
    public VehicleRentalService2? VehicleRental { get; set; } 
    #endif
    
    /// <summary>
    /// Component provides detailed information about lodging accommodations and related expenses for the cardholder. Acquirers can submit multiple occurrences of this component for each lodging transaction, to provide details of one or more folios.
    /// </summary>
    [IsoId("_-2QH54v0EeumSPwlS1PkxQ")]
    [DisplayName("Lodging")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ldgg")]
    #endif
    [IsoXmlTag("Ldgg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Lodging3? Lodging { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Lodging3? Lodging { get; init; } 
    #else
    public Lodging3? Lodging { get; set; } 
    #endif
    
    /// <summary>
    /// Shipping or Courier Service detail component provides detailed information regarding delivery or courier services. 
    /// </summary>
    [IsoId("_-2QH6Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Shipping Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShppgData")]
    #endif
    [IsoXmlTag("ShppgData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ShippingData2? ShippingData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShippingData2? ShippingData { get; init; } 
    #else
    public ShippingData2? ShippingData { get; set; } 
    #endif
    
    /// <summary>
    /// Telecommunication services component is designed to carry telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information. 
    /// </summary>
    [IsoId("_-2QH64v0EeumSPwlS1PkxQ")]
    [DisplayName("Telecommunication Services")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TelecomSvcs")]
    #endif
    [IsoXmlTag("TelecomSvcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TelecomServices2? TelecommunicationServices { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TelecomServices2? TelecommunicationServices { get; init; } 
    #else
    public TelecomServices2? TelecommunicationServices { get; set; } 
    #endif
    
    /// <summary>
    /// Temporary Services component provides detailed information regarding the billing for services rendered on a temporary or contract basis. The component provides information such as the employee job performed, timekeeping, and billing rates.
    /// </summary>
    [IsoId("_-2QH7Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Temporary Services")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TempSvcs")]
    #endif
    [IsoXmlTag("TempSvcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TemporaryServices2? TemporaryServices { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TemporaryServices2? TemporaryServices { get; init; } 
    #else
    public TemporaryServices2? TemporaryServices { get; set; } 
    #endif
    
    /// <summary>
    /// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
    /// </summary>
    [IsoId("_-2QH74v0EeumSPwlS1PkxQ")]
    [DisplayName("Instalment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instlmt")]
    #endif
    [IsoXmlTag("Instlmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Instalment4? Instalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Instalment4? Instalment { get; init; } 
    #else
    public Instalment4? Instalment { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data for the addendum.
    /// </summary>
    [IsoId("_-2QH8Yv0EeumSPwlS1PkxQ")]
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
