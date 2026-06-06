// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details of the package.
/// </summary>
[IsoId("_tGSrEUiCEfCMZJtj4J7UGQ")]
[DisplayName("Shipping Package4")]
public record ShippingPackage4
{
    /// <summary>
    /// Contains the identification number for the packages being shipped and is also used for pickup number. 
    /// </summary>
    [IsoId("_tIpbgUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Tracking Number")]
    [IsoXmlTag("TrckgNb")]
    public IsoMax70Text? TrackingNumber { get; init; }

    /// <summary>
    /// Name of the supplier
    /// </summary>
    [IsoId("_tIpbg0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Name")]
    [IsoXmlTag("SpplrNm")]
    public IsoMax70Text? SupplierName { get; init; }

    /// <summary>
    /// Identification of the supplier.
    /// </summary>
    [IsoId("_pqQpFUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Identification")]
    [IsoXmlTag("SpplrId")]
    public IsoMax35Text? SupplierIdentification { get; init; }

    /// <summary>
    /// Business name of the supplier.
    /// </summary>
    [IsoId("_pqQpFkiCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Business Name")]
    [IsoXmlTag("SpplrBizNm")]
    public IsoMax35Text? SupplierBusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the supplier.
    /// </summary>
    [IsoId("_pqQpF0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Legal Corporate Name")]
    [IsoXmlTag("SpplrLglCorpNm")]
    public IsoMax99Text? SupplierLegalCorporateName { get; init; }

    /// <summary>
    /// Address of the supplier.
    /// </summary>
    [IsoId("_tIpbh0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Address")]
    [IsoXmlTag("SpplrAdr")]
    public Address4? SupplierAddress { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of the supplier data.
    /// </summary>
    [IsoId("_pqQpGUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Local Data")]
    [IsoXmlTag("SpplrLclData")]
    public ValueList<LocalData20> SupplierLocalData { get; init; } = [];

    /// <summary>
    /// Contact information related to the supplier.
    /// </summary>
    [IsoId("_tIpbiUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Contact")]
    [IsoXmlTag("SpplrCtct")]
    public ContactBusiness2? SupplierContact { get; init; }

    /// <summary>
    /// Supplier special instructions. 
    /// </summary>
    [IsoId("_tIpbi0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Instructions")]
    [IsoXmlTag("SpplrInstrs")]
    public IsoMax350Text? SupplierInstructions { get; init; }

    /// <summary>
    /// Contains the date the package is picked up.
    /// </summary>
    [IsoId("_tIpbjUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Pickup Date")]
    [IsoXmlTag("PckpDt")]
    public IsoISODate? PickupDate { get; init; }

    /// <summary>
    /// Contains the time the package is picked up.
    /// </summary>
    [IsoId("_tIpbj0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Pickup Time")]
    [IsoXmlTag("PckpTm")]
    public IsoISOTime? PickupTime { get; init; }

    /// <summary>
    /// Contains the number identifying an individual delivery note. 
    /// </summary>
    [IsoId("_tIpbkUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Note Number")]
    [IsoXmlTag("DlvryNoteNb")]
    public IsoMax35Text? DeliveryNoteNumber { get; init; }

    /// <summary>
    /// Delivery address.
    /// </summary>
    [IsoId("_tIpbk0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Address")]
    [IsoXmlTag("DlvryAdr")]
    public Address4? DeliveryAddress { get; init; }

    /// <summary>
    /// Contact for delivery.
    /// </summary>
    [IsoId("_tIpblUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Contact")]
    [IsoXmlTag("DlvryCtct")]
    public ContactPersonal1? DeliveryContact { get; init; }

    /// <summary>
    /// Special delivery instructions. 
    /// </summary>
    [IsoId("_tIpbl0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Instructions")]
    [IsoXmlTag("DlvryInstrs")]
    public IsoMax350Text? DeliveryInstructions { get; init; }

    /// <summary>
    /// Contains the package delivery date.
    /// </summary>
    [IsoId("_tIpbmUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Date")]
    [IsoXmlTag("DlvryDt")]
    public IsoISODate? DeliveryDate { get; init; }

    /// <summary>
    /// Contains the package delivery time.
    /// </summary>
    [IsoId("_tIpbm0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Time")]
    [IsoXmlTag("DlvryTm")]
    public IsoISOTime? DeliveryTime { get; init; }

    /// <summary>
    /// Unit of measure of the item being shipped.
    /// </summary>
    [IsoId("_tIpbnUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Weight Unit")]
    [IsoXmlTag("WghtUnit")]
    public UnitOfMeasure1Code? WeightUnit { get; init; }

    /// <summary>
    /// Other unit of measure the item being shipped .
    /// </summary>
    [IsoId("_tIpbn0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Other Weight Unit")]
    [IsoXmlTag("OthrWghtUnit")]
    public IsoMax35Text? OtherWeightUnit { get; init; }

    /// <summary>
    /// Number of units.
    /// </summary>
    [IsoId("_tIpboUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Number Of Units")]
    [IsoXmlTag("NbOfUnits")]
    public IsoDecimalNumber? NumberOfUnits { get; init; }

    /// <summary>
    /// Contains the product details.
    /// </summary>
    [IsoId("_tIpbo0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public ValueList<Product8> Product { get; init; } = [];

    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_tIpbpUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Amount of insurance.
    /// </summary>
    [IsoId("_tIpbp0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }
}
