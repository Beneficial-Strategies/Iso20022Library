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
[IsoId("_l2yNwZF_EeukDPgU2BMkjQ")]
[DisplayName("Shipping Package")]
public record ShippingPackage2
{
    /// <summary>
    /// Contains the identification number for the packages being shipped and is also used for pickup number.
    /// </summary>
    [IsoId("_l8yIEZF_EeukDPgU2BMkjQ")]
    [DisplayName("Tracking Number")]
    [IsoXmlTag("TrckgNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? TrackingNumber { get; init; }

    /// <summary>
    /// Supplier or provider of the delivery services.
    /// </summary>
    [IsoId("_l8yIE5F_EeukDPgU2BMkjQ")]
    [DisplayName("Supplier")]
    [IsoXmlTag("Spplr")]
    public PartyIdentification260? Supplier { get; init; }

    /// <summary>
    /// Contains the date the package is picked up.
    /// </summary>
    [IsoId("_7Ip_kCbSEeyhZIgCcGlTyA")]
    [DisplayName("Pickup Date")]
    [IsoXmlTag("PckpDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PickupDate { get; init; }

    /// <summary>
    /// Contains the time the package is picked up.
    /// </summary>
    [IsoId("_l8yIFZF_EeukDPgU2BMkjQ")]
    [DisplayName("Pickup Time")]
    [IsoXmlTag("PckpTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? PickupTime { get; init; }

    /// <summary>
    /// Delivery information.
    /// </summary>
    [IsoId("_l8yIF5F_EeukDPgU2BMkjQ")]
    [DisplayName("Delivery")]
    [IsoXmlTag("Dlvry")]
    public DeliveryInformation4? Delivery { get; init; }

    /// <summary>
    /// Weight details.
    /// </summary>
    [IsoId("_l8yIGZF_EeukDPgU2BMkjQ")]
    [DisplayName("Weight")]
    [IsoXmlTag("Wght")]
    public UnitOfMeasure2? Weight { get; init; }

    /// <summary>
    /// Contains the product details.
    /// </summary>
    [IsoId("_l8yIG5F_EeukDPgU2BMkjQ")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public ValueList<Product7> Product { get; init; } = [];

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_l8yIHZF_EeukDPgU2BMkjQ")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Amount of insurance.
    /// </summary>
    [IsoId("_l8yIH5F_EeukDPgU2BMkjQ")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }
}
