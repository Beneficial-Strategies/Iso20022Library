// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Invoice3.
/// </summary>
[IsoId("_5qsCYXNXEe6Y1uOeeiF_Eg")]
[DisplayName("Invoice3")]
public record Invoice3
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Buyer Additional Information.
    /// </summary>
    [DisplayName("Buyer Additional Information")]
    [IsoXmlTag("BuyrAddtlInf")]
    public IsoMax1000Text? BuyerAdditionalInformation { get; init; }

    /// <summary>
    /// Buyer Address.
    /// </summary>
    [DisplayName("Buyer Address")]
    [IsoXmlTag("BuyrAdr")]
    public Address2? BuyerAddress { get; init; }

    /// <summary>
    /// Buyer Contact.
    /// </summary>
    [DisplayName("Buyer Contact")]
    [IsoXmlTag("BuyrCtct")]
    public ContactBusiness1? BuyerContact { get; init; }

    /// <summary>
    /// Buyer Identification.
    /// </summary>
    [DisplayName("Buyer Identification")]
    [IsoXmlTag("BuyrId")]
    public PartyIdentification285? BuyerIdentification { get; init; }

    /// <summary>
    /// Buyer Name.
    /// </summary>
    [DisplayName("Buyer Name")]
    [IsoXmlTag("BuyrNm")]
    public IsoMax70Text? BuyerName { get; init; }

    /// <summary>
    /// Buyer Tax Registration Identification.
    /// </summary>
    [DisplayName("Buyer Tax Registration Identification")]
    [IsoXmlTag("BuyrTaxRegnId")]
    public IsoMax70Text? BuyerTaxRegistrationIdentification { get; init; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Freight Amount.
    /// </summary>
    [DisplayName("Freight Amount")]
    [IsoXmlTag("FrghtAmt")]
    public ImpliedCurrencyAndAmount? FreightAmount { get; init; }

    /// <summary>
    /// Line Item.
    /// </summary>
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<InvoiceLineItem3> LineItem { get; init; } = [];

    /// <summary>
    /// Number.
    /// </summary>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public IsoMax70Text? Number { get; init; }

    /// <summary>
    /// Seller Additional Information.
    /// </summary>
    [DisplayName("Seller Additional Information")]
    [IsoXmlTag("SellrAddtlInf")]
    public IsoMax1000Text? SellerAdditionalInformation { get; init; }

    /// <summary>
    /// Seller Address.
    /// </summary>
    [DisplayName("Seller Address")]
    [IsoXmlTag("SellrAdr")]
    public Address2? SellerAddress { get; init; }

    /// <summary>
    /// Seller Contact.
    /// </summary>
    [DisplayName("Seller Contact")]
    [IsoXmlTag("SellrCtct")]
    public ContactBusiness1? SellerContact { get; init; }

    /// <summary>
    /// Seller Identification.
    /// </summary>
    [DisplayName("Seller Identification")]
    [IsoXmlTag("SellrId")]
    public PartyIdentification285? SellerIdentification { get; init; }

    /// <summary>
    /// Seller Name.
    /// </summary>
    [DisplayName("Seller Name")]
    [IsoXmlTag("SellrNm")]
    public IsoMax70Text? SellerName { get; init; }

    /// <summary>
    /// Seller Tax Registration Identification.
    /// </summary>
    [DisplayName("Seller Tax Registration Identification")]
    [IsoXmlTag("SellrTaxRegnId")]
    public IsoMax70Text? SellerTaxRegistrationIdentification { get; init; }

    /// <summary>
    /// Summary Commodity Identification.
    /// </summary>
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Tax Reclaim Method.
    /// </summary>
    [DisplayName("Tax Reclaim Method")]
    [IsoXmlTag("TaxRclmMtd")]
    public TaxReclaimMethod1Code? TaxReclaimMethod { get; init; }

    /// <summary>
    /// Tax Total.
    /// </summary>
    [DisplayName("Tax Total")]
    [IsoXmlTag("TaxTtl")]
    public ValueList<Tax41> TaxTotal { get; init; } = [];
}
