// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Component contains data structures applicable to certain merchant verticals that require industry-specific data within transaction messages. 
/// </summary>
[IsoId("_-wbMoYv0EeumSPwlS1PkxQ")]
[DisplayName("Addendum Data")]
public partial record AddendumData3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of identifier present in the message.
    /// </summary>
    [IsoId("_-2QH0Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Purchase Identifier Type")]
    [IsoXmlTag("PurchsIdrTp")]
    public PurchaseIdentifierType1Code? PurchaseIdentifierType { get; init; } 
    
    /// <summary>
    /// Used when Purchase Identifier Type is Other National or Other Private. 
    /// </summary>
    [IsoId("_-2QH04v0EeumSPwlS1PkxQ")]
    [DisplayName("Other Purchase Identifier Type")]
    [IsoXmlTag("OthrPurchsIdrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherPurchaseIdentifierType { get; init; } 
    
    /// <summary>
    /// Contains a value identifying Invoice Data or Purchase Request Data.
    /// </summary>
    [IsoId("_-2QH1Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Purchase Identifier")]
    [IsoXmlTag("PurchsIdr")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    public IsoMax99Text? PurchaseIdentifier { get; init; } 
    
    /// <summary>
    /// Contains additional card acceptor data. 
    /// </summary>
    [IsoId("_-2QH14v0EeumSPwlS1PkxQ")]
    [DisplayName("Additional Acceptor Data")]
    [IsoXmlTag("AddtlAccptrData")]
    public AdditionalAcceptorData1? AdditionalAcceptorData { get; init; } 
    
    /// <summary>
    /// Information about the customer.
    /// </summary>
    [IsoId("_-2QH2Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public Customer4? Customer { get; init; } 
    
    /// <summary>
    /// Details of good and services included in the sale.
    /// </summary>
    [IsoId("_-2QH24v0EeumSPwlS1PkxQ")]
    [DisplayName("Sale")]
    [IsoXmlTag("Sale")]
    public Sale2? Sale { get; init; } 
    
    /// <summary>
    /// Fleet data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_-2QH3Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Fleet")]
    [IsoXmlTag("Fleet")]
    public FleetData4? Fleet { get; init; } 
    
    /// <summary>
    /// Invoice data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_-2QH34v0EeumSPwlS1PkxQ")]
    [DisplayName("Invoice")]
    [IsoXmlTag("Invc")]
    public Invoice2? Invoice { get; init; } 
    
    /// <summary>
    /// Component supports corporate transactions for travel agency, airline, or railway transactions. Acquirers may submit multiple occurrences of this component. Each occurrence provides detailed travel agency fee data associated with a travel agency, airline, or railway transaction.
    /// </summary>
    [IsoId("_-2QH4Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Travel Agency")]
    [IsoXmlTag("TrvlAgcy")]
    public TravelAgency3? TravelAgency { get; init; } 
    
    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder. 
    /// </summary>
    [IsoId("_-2QH44v0EeumSPwlS1PkxQ")]
    [DisplayName("Passenger Transport")]
    [IsoXmlTag("PssngrTrnsprt")]
    public PassengerTransport2? PassengerTransport { get; init; } 
    
    /// <summary>
    /// Component provides detailed vehicle rental information. One occurrence of this component provides rental agreement data reporting for a single vehicle rental transaction.
    /// </summary>
    [IsoId("_-2QH5Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Vehicle Rental")]
    [IsoXmlTag("VhclRntl")]
    public VehicleRentalService2? VehicleRental { get; init; } 
    
    /// <summary>
    /// Component provides detailed information about lodging accommodations and related expenses for the cardholder. Acquirers can submit multiple occurrences of this component for each lodging transaction, to provide details of one or more folios.
    /// </summary>
    [IsoId("_-2QH54v0EeumSPwlS1PkxQ")]
    [DisplayName("Lodging")]
    [IsoXmlTag("Ldgg")]
    public Lodging3? Lodging { get; init; } 
    
    /// <summary>
    /// Shipping or Courier Service detail component provides detailed information regarding delivery or courier services. 
    /// </summary>
    [IsoId("_-2QH6Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Shipping Data")]
    [IsoXmlTag("ShppgData")]
    public ShippingData2? ShippingData { get; init; } 
    
    /// <summary>
    /// Telecommunication services component is designed to carry telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information. 
    /// </summary>
    [IsoId("_-2QH64v0EeumSPwlS1PkxQ")]
    [DisplayName("Telecommunication Services")]
    [IsoXmlTag("TelecomSvcs")]
    public TelecomServices2? TelecommunicationServices { get; init; } 
    
    /// <summary>
    /// Temporary Services component provides detailed information regarding the billing for services rendered on a temporary or contract basis. The component provides information such as the employee job performed, timekeeping, and billing rates.
    /// </summary>
    [IsoId("_-2QH7Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Temporary Services")]
    [IsoXmlTag("TempSvcs")]
    public TemporaryServices2? TemporaryServices { get; init; } 
    
    /// <summary>
    /// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
    /// </summary>
    [IsoId("_-2QH74v0EeumSPwlS1PkxQ")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public Instalment4? Instalment { get; init; } 
    
    /// <summary>
    /// Contains additional data for the addendum.
    /// </summary>
    [IsoId("_-2QH8Yv0EeumSPwlS1PkxQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
