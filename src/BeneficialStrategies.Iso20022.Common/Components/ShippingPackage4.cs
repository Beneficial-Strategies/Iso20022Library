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
    [IsoId("_tIpbgUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Tracking Number")]
    [IsoXmlTag("TrckgNb")]
    public IsoMax70Text? TrackingNumber { get; init; }

    [IsoId("_tIpbg0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Name")]
    [IsoXmlTag("SpplrNm")]
    public IsoMax70Text? SupplierName { get; init; }

    [IsoId("_pqQpFUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Identification")]
    [IsoXmlTag("SpplrId")]
    public IsoMax35Text? SupplierIdentification { get; init; }

    [IsoId("_pqQpFkiCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Business Name")]
    [IsoXmlTag("SpplrBizNm")]
    public IsoMax35Text? SupplierBusinessName { get; init; }

    [IsoId("_pqQpF0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Legal Corporate Name")]
    [IsoXmlTag("SpplrLglCorpNm")]
    public IsoMax99Text? SupplierLegalCorporateName { get; init; }

    [IsoId("_tIpbh0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Address")]
    [IsoXmlTag("SpplrAdr")]
    public Address4? SupplierAddress { get; init; }

    [IsoId("_pqQpGUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Local Data")]
    [IsoXmlTag("SpplrLclData")]
    public ValueList<LocalData20> SupplierLocalData { get; init; } = [];

    [IsoId("_tIpbiUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Contact")]
    [IsoXmlTag("SpplrCtct")]
    public ContactBusiness2? SupplierContact { get; init; }

    [IsoId("_tIpbi0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Supplier Instructions")]
    [IsoXmlTag("SpplrInstrs")]
    public IsoMax350Text? SupplierInstructions { get; init; }

    [IsoId("_tIpbjUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Pickup Date")]
    [IsoXmlTag("PckpDt")]
    public IsoISODate? PickupDate { get; init; }

    [IsoId("_tIpbj0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Pickup Time")]
    [IsoXmlTag("PckpTm")]
    public IsoISOTime? PickupTime { get; init; }

    [IsoId("_tIpbkUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Note Number")]
    [IsoXmlTag("DlvryNoteNb")]
    public IsoMax35Text? DeliveryNoteNumber { get; init; }

    [IsoId("_tIpbk0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Address")]
    [IsoXmlTag("DlvryAdr")]
    public Address4? DeliveryAddress { get; init; }

    [IsoId("_tIpblUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Contact")]
    [IsoXmlTag("DlvryCtct")]
    public ContactPersonal1? DeliveryContact { get; init; }

    [IsoId("_tIpbl0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Instructions")]
    [IsoXmlTag("DlvryInstrs")]
    public IsoMax350Text? DeliveryInstructions { get; init; }

    [IsoId("_tIpbmUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Date")]
    [IsoXmlTag("DlvryDt")]
    public IsoISODate? DeliveryDate { get; init; }

    [IsoId("_tIpbm0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Delivery Time")]
    [IsoXmlTag("DlvryTm")]
    public IsoISOTime? DeliveryTime { get; init; }

    [IsoId("_tIpbnUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Weight Unit")]
    [IsoXmlTag("WghtUnit")]
    public UnitOfMeasure1Code? WeightUnit { get; init; }

    [IsoId("_tIpbn0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Other Weight Unit")]
    [IsoXmlTag("OthrWghtUnit")]
    public IsoMax35Text? OtherWeightUnit { get; init; }

    [IsoId("_tIpboUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Number Of Units")]
    [IsoXmlTag("NbOfUnits")]
    public IsoDecimalNumber? NumberOfUnits { get; init; }

    [IsoId("_tIpbo0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public ValueList<Product8> Product { get; init; } = [];

    [IsoId("_tIpbpUiCEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    [IsoId("_tIpbp0iCEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }
}
