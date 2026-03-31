// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details of the package
/// </summary>
[IsoId("_vJ2p4_clEeiW-auGnDPZIw")]
[DisplayName("Shipping Package")]
public record ShippingPackage1
{
    /// <summary>
    /// Contains the identification number for the packages being shipped and is also used for pickup number.
    /// </summary>
    [IsoId("_B3DI0fcmEeiW-auGnDPZIw")]
    [DisplayName("Tracking Number")]
    [IsoXmlTag("TrckgNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? TrackingNumber { get; init; }

    /// <summary>
    /// Supplier or provider of the delivery services.
    /// </summary>
    [IsoId("_vJ2p5PclEeiW-auGnDPZIw")]
    [DisplayName("Supplier")]
    [IsoXmlTag("Spplr")]
    public PartyIdentification209? Supplier { get; init; }

    /// <summary>
    /// Contains the time the package is picked up.
    /// </summary>
    [IsoId("_blS9wPcoEeiW-auGnDPZIw")]
    [DisplayName("Pickup Time")]
    [IsoXmlTag("PckpTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? PickupTime { get; init; }

    /// <summary>
    /// Delivery information.
    /// </summary>
    [IsoId("_0q63APcrEeiW-auGnDPZIw")]
    [DisplayName("Delivery")]
    [IsoXmlTag("Dlvry")]
    public DeliveryInformation3? Delivery { get; init; }

    /// <summary>
    /// Weight details.
    /// </summary>
    [IsoId("_pvaywPcrEeiW-auGnDPZIw")]
    [DisplayName("Weight")]
    [IsoXmlTag("Wght")]
    public UnitOfMeasure1? Weight { get; init; }

    /// <summary>
    /// Contains the product details.
    /// </summary>
    [IsoId("_knVpMPcsEeiW-auGnDPZIw")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public ValueList<Product7> Product { get; init; } = [];

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_pA2AEvcsEeiW-auGnDPZIw")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Amount of insurance.
    /// </summary>
    [IsoId("_pA2AE_csEeiW-auGnDPZIw")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }
}
