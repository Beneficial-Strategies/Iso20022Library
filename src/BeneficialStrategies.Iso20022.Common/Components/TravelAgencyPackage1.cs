// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information about the travel package, excluding specific itinerary data.
/// </summary>
[IsoId("_VWwMQ_PYEeihCvvpsmGI2w")]
[DisplayName("Travel Agency Package")]
public record TravelAgencyPackage1
{
    /// <summary>
    /// Reservation number or identifier.
    /// </summary>
    [IsoId("_VWwMTPPYEeihCvvpsmGI2w")]
    [DisplayName("Reservation Number")]
    [IsoXmlTag("RsvatnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReservationNumber { get; init; }

    /// <summary>
    /// Describes the type of travel offering provided by the travel agency or partner.
    /// </summary>
    [IsoId("_VW4vFPPYEeihCvvpsmGI2w")]
    [DisplayName("Travel Package Type")]
    [IsoXmlTag("TrvlPackgTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? TravelPackageType { get; init; }

    /// <summary>
    /// Number of people included in the travel arrangements.
    /// </summary>
    [IsoId("_VW4vFvPYEeihCvvpsmGI2w")]
    [DisplayName("Number In Party")]
    [IsoXmlTag("NbInPty")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? NumberInParty { get; init; }

    /// <summary>
    /// Contains Customer Reference Values provided for this transaction and used for various reference processing at the customer site. These values represent information most prevalently provided by travel agencies for transactions booked against a lodged account or central travel account.
    /// </summary>
    [IsoId("_VWwMRfPYEeihCvvpsmGI2w")]
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    public CustomerReference1? CustomerReference { get; init; }

    /// <summary>
    /// Indicates the source of enhanced data that is matched to the transaction.
    /// </summary>
    [IsoId("_VWwMS_PYEeihCvvpsmGI2w")]
    [DisplayName("Data Source")]
    [IsoXmlTag("DataSrc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DataSource { get; init; }

    /// <summary>
    /// Contains a customer invoice number for a rail sale to a corporate account.
    /// </summary>
    [IsoId("_VW4vF_PYEeihCvvpsmGI2w")]
    [DisplayName("Delivery Order Number")]
    [IsoXmlTag("DlvryOrdrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DeliveryOrderNumber { get; init; }

    /// <summary>
    /// Contains a slip number from the credit card slip.
    /// </summary>
    [IsoId("_VWwMRvPYEeihCvvpsmGI2w")]
    [DisplayName("Credit Card Slip Number")]
    [IsoXmlTag("CdtCardSlipNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditCardSlipNumber { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_VW4vEPPYEeihCvvpsmGI2w")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Cost of the insurance purchased.
    /// </summary>
    [IsoId("_VWwMTfPYEeihCvvpsmGI2w")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Travel agency fee amount.
    /// </summary>
    [IsoId("_VW4vEvPYEeihCvvpsmGI2w")]
    [DisplayName("Fee")]
    [IsoXmlTag("Fee")]
    public ImpliedCurrencyAndAmount? Fee { get; init; }
}
