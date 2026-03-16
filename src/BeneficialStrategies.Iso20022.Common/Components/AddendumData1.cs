// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Component contains data structures applicable to certain merchant verticals that require industry-specific data within transaction messages.
/// </summary>
[IsoId("_DnFa09kkEeiKYdl5SlduIA")]
[DisplayName("Addendum Data")]
public record AddendumData1
{
    /// <summary>
    /// Specifies the type of identifier present in the message.
    /// </summary>
    [IsoId("_7-q0oPJNEeiJn9rM2Znz2w")]
    [DisplayName("Purchase Identifier Type")]
    [IsoXmlTag("PurchsIdrTp")]
    public PurchaseIdentifierType1Code? PurchaseIdentifierType { get; init; }

    /// <summary>
    /// Used when Purchase Identifier Type is Other National or Other Private.
    /// </summary>
    [IsoId("_r448gPJQEeiJn9rM2Znz2w")]
    [DisplayName("Other Purchase Identifier Type")]
    [IsoXmlTag("OthrPurchsIdrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherPurchaseIdentifierType { get; init; }

    /// <summary>
    /// Contains a value identifying Invoice Data or Purchase Request Data.
    /// </summary>
    [IsoId("_7K0OcPJQEeiJn9rM2Znz2w")]
    [DisplayName("Purchase Identifier")]
    [IsoXmlTag("PurchsIdr")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public IsoMax99Text? PurchaseIdentifier { get; init; }

    /// <summary>
    /// Contains additional card acceptor data.
    /// </summary>
    [IsoId("_bbBTgPJeEeiJn9rM2Znz2w")]
    [DisplayName("Additional Acceptor Data")]
    [IsoXmlTag("AddtlAccptrData")]
    public AdditionalAcceptorData1? AdditionalAcceptorData { get; init; }

    /// <summary>
    /// Information about the customer.
    /// </summary>
    [IsoId("_z39NYPJnEeiJn9rM2Znz2w")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public Customer4? Customer { get; init; }

    /// <summary>
    /// Details of good and services included in the sale.
    /// </summary>
    [IsoId("_vGEREPJ6EeiJn9rM2Znz2w")]
    [DisplayName("Sale")]
    [IsoXmlTag("Sale")]
    public Sale1? Sale { get; init; }

    /// <summary>
    /// Fleet data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_oQcUYPjNEeiM7KpzmLtmTQ")]
    [DisplayName("Fleet")]
    [IsoXmlTag("Fleet")]
    public FleetData2? Fleet { get; init; }

    /// <summary>
    /// Invoice data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_M5uigfNJEei4qfiLgRIZBA")]
    [DisplayName("Invoice")]
    [IsoXmlTag("Invc")]
    public Invoice1? Invoice { get; init; }

    /// <summary>
    /// Component supports corporate transactions for travel agency, airline, or railway transactions. Acquirers may submit multiple occurrences of this component. Each occurrence provides detailed travel agency fee data associated with a travel agency, airline, or railway transaction.
    /// </summary>
    [IsoId("_dZBKwfPeEeihCvvpsmGI2w")]
    [DisplayName("Travel Agency")]
    [IsoXmlTag("TrvlAgcy")]
    public TravelAgency2? TravelAgency { get; init; }

    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder.
    /// </summary>
    [IsoId("_a2_UQPQdEeihCvvpsmGI2w")]
    [DisplayName("Passenger Transport")]
    [IsoXmlTag("PssngrTrnsprt")]
    public PassengerTransport1? PassengerTransport { get; init; }

    /// <summary>
    /// Component provides detailed vehicle rental information. One occurrence of this component provides rental agreement data reporting for a single vehicle rental transaction.
    /// </summary>
    [IsoId("_W9dLwvJNEeiJn9rM2Znz2w")]
    [DisplayName("Vehicle Rental")]
    [IsoXmlTag("VhclRntl")]
    public VehicleRentalService1? VehicleRental { get; init; }

    /// <summary>
    /// Component provides detailed information about lodging accommodations and related expenses for the cardholder. Acquirers can submit multiple occurrences of this component for each lodging transaction, to provide details of one or more folios.
    /// </summary>
    [IsoId("_W9dLw_JNEeiJn9rM2Znz2w")]
    [DisplayName("Lodging")]
    [IsoXmlTag("Ldgg")]
    public Lodging2? Lodging { get; init; }

    /// <summary>
    /// Shipping or Courier Service detail component provides detailed information regarding delivery or courier services.
    /// </summary>
    [IsoId("_ZZD9cPctEeiW-auGnDPZIw")]
    [DisplayName("Shipping Data")]
    [IsoXmlTag("ShppgData")]
    public ShippingData1? ShippingData { get; init; }

    /// <summary>
    /// Telecommunication services component is designed to carry telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information.
    /// </summary>
    [IsoId("_iX6coPfOEei89sMSHxl1ew")]
    [DisplayName("Telecommunication Services")]
    [IsoXmlTag("TelecomSvcs")]
    public TelecomServices1? TelecommunicationServices { get; init; }

    /// <summary>
    /// Temporary Services component provides detailed information regarding the billing for services rendered on a temporary or contract basis. The component provides information such as the employee job performed, timekeeping, and billing rates.
    /// </summary>
    [IsoId("_bfPSoPfkEei89sMSHxl1ew")]
    [DisplayName("Temporary Services")]
    [IsoXmlTag("TempSvcs")]
    public TemporaryServices1? TemporaryServices { get; init; }

    /// <summary>
    /// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
    /// </summary>
    [IsoId("_tVn5gPlREeilft0P2fSiEQ")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public Instalment3? Instalment { get; init; }

    /// <summary>
    /// Contains additional data for the addendum.
    /// </summary>
    [IsoId("_jeXOgP75Eeic54G0fOJNMg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
