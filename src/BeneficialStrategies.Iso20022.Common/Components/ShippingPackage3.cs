// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Shipping Package3.
/// </summary>
[IsoId("_g4wRUXTtEe6h-4AZRg9sVg")]
[DisplayName("Shipping Package3")]
public partial record ShippingPackage3
{
    #nullable enable

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
    public IsoISODate? DeliveryDate { get; init; } 

    /// <summary>
    /// Delivery Instructions.
    /// </summary>
    [DisplayName("Delivery Instructions")]
    [IsoXmlTag("DlvryInstrs")]
    public IsoMax350Text? DeliveryInstructions { get; init; } 

    /// <summary>
    /// Delivery Note Number.
    /// </summary>
    [DisplayName("Delivery Note Number")]
    [IsoXmlTag("DlvryNoteNb")]
    public IsoMax35Text? DeliveryNoteNumber { get; init; } 

    /// <summary>
    /// Delivery Time.
    /// </summary>
    [DisplayName("Delivery Time")]
    [IsoXmlTag("DlvryTm")]
    public IsoISOTime? DeliveryTime { get; init; } 

    /// <summary>
    /// Insurance.
    /// </summary>
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; } 

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
    public IsoDecimalNumber? NumberOfUnits { get; init; } 

    /// <summary>
    /// Other Weight Unit.
    /// </summary>
    [DisplayName("Other Weight Unit")]
    [IsoXmlTag("OthrWghtUnit")]
    public IsoMax35Text? OtherWeightUnit { get; init; } 

    /// <summary>
    /// Pickup Date.
    /// </summary>
    [DisplayName("Pickup Date")]
    [IsoXmlTag("PckpDt")]
    public IsoISODate? PickupDate { get; init; } 

    /// <summary>
    /// Pickup Time.
    /// </summary>
    [DisplayName("Pickup Time")]
    [IsoXmlTag("PckpTm")]
    public IsoISOTime? PickupTime { get; init; } 

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
    public IsoMax350Text? SupplierInstructions { get; init; } 

    /// <summary>
    /// Supplier Name.
    /// </summary>
    [DisplayName("Supplier Name")]
    [IsoXmlTag("SpplrNm")]
    public IsoMax70Text? SupplierName { get; init; } 

    /// <summary>
    /// Tracking Number.
    /// </summary>
    [DisplayName("Tracking Number")]
    [IsoXmlTag("TrckgNb")]
    public IsoMax70Text? TrackingNumber { get; init; } 

    /// <summary>
    /// Weight Unit.
    /// </summary>
    [DisplayName("Weight Unit")]
    [IsoXmlTag("WghtUnit")]
    public UnitOfMeasure1Code? WeightUnit { get; init; } 

    
    #nullable disable
    
}
