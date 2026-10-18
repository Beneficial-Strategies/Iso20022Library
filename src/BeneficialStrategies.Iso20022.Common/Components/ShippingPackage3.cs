// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Shipping Package3.
/// </summary>
[IsoId("_g4wRUXTtEe6h-4AZRg9sVg")]
[DisplayName("Shipping Package3")]
public record ShippingPackage3
{
    /// <summary>
    /// Delivery Address.
    /// </summary>
    [DisplayName("Delivery Address")]
    [IsoXmlTag("DlvryAdr")]
    public Address2? DeliveryAddress { get; init; }

    /// <summary>
    /// Delivery Contact.
    /// </summary>
    [DisplayName("Delivery Contact")]
    [IsoXmlTag("DlvryCtct")]
    public ContactPersonal1? DeliveryContact { get; init; }

    /// <summary>
    /// Delivery Date.
    /// </summary>
    [DisplayName("Delivery Date")]
    [IsoXmlTag("DlvryDt")]
    public ISODate? DeliveryDate { get; init; }

    /// <summary>
    /// Delivery Instructions.
    /// </summary>
    [DisplayName("Delivery Instructions")]
    [IsoXmlTag("DlvryInstrs")]
    public Max350Text? DeliveryInstructions { get; init; }

    /// <summary>
    /// Delivery Note Number.
    /// </summary>
    [DisplayName("Delivery Note Number")]
    [IsoXmlTag("DlvryNoteNb")]
    public Max35Text? DeliveryNoteNumber { get; init; }

    /// <summary>
    /// Delivery Time.
    /// </summary>
    [DisplayName("Delivery Time")]
    [IsoXmlTag("DlvryTm")]
    public ISOTime? DeliveryTime { get; init; }

    /// <summary>
    /// Insurance.
    /// </summary>
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public TrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Insurance Amount.
    /// </summary>
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Number Of Units.
    /// </summary>
    [DisplayName("Number Of Units")]
    [IsoXmlTag("NbOfUnits")]
    public DecimalNumber? NumberOfUnits { get; init; }

    /// <summary>
    /// Other Weight Unit.
    /// </summary>
    [DisplayName("Other Weight Unit")]
    [IsoXmlTag("OthrWghtUnit")]
    public Max35Text? OtherWeightUnit { get; init; }

    /// <summary>
    /// Pickup Date.
    /// </summary>
    [DisplayName("Pickup Date")]
    [IsoXmlTag("PckpDt")]
    public ISODate? PickupDate { get; init; }

    /// <summary>
    /// Pickup Time.
    /// </summary>
    [DisplayName("Pickup Time")]
    [IsoXmlTag("PckpTm")]
    public ISOTime? PickupTime { get; init; }

    /// <summary>
    /// Product.
    /// </summary>
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public ValueList<Product8> Product { get; init; } = [];

    /// <summary>
    /// Supplier Address.
    /// </summary>
    [DisplayName("Supplier Address")]
    [IsoXmlTag("SpplrAdr")]
    public Address2? SupplierAddress { get; init; }

    /// <summary>
    /// Supplier Contact.
    /// </summary>
    [DisplayName("Supplier Contact")]
    [IsoXmlTag("SpplrCtct")]
    public ContactBusiness1? SupplierContact { get; init; }

    /// <summary>
    /// Supplier Identification.
    /// </summary>
    [DisplayName("Supplier Identification")]
    [IsoXmlTag("SpplrId")]
    public PartyIdentification285? SupplierIdentification { get; init; }

    /// <summary>
    /// Supplier Instructions.
    /// </summary>
    [DisplayName("Supplier Instructions")]
    [IsoXmlTag("SpplrInstrs")]
    public Max350Text? SupplierInstructions { get; init; }

    /// <summary>
    /// Supplier Name.
    /// </summary>
    [DisplayName("Supplier Name")]
    [IsoXmlTag("SpplrNm")]
    public Max70Text? SupplierName { get; init; }

    /// <summary>
    /// Tracking Number.
    /// </summary>
    [DisplayName("Tracking Number")]
    [IsoXmlTag("TrckgNb")]
    public Max70Text? TrackingNumber { get; init; }

    /// <summary>
    /// Weight Unit.
    /// </summary>
    [DisplayName("Weight Unit")]
    [IsoXmlTag("WghtUnit")]
    public UnitOfMeasure1Code? WeightUnit { get; init; }
}
