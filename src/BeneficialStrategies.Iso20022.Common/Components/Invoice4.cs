// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Invoice data pertaining to the payment transaction.
/// </summary>
[IsoId("_gJO2MUhrEfCMZJtj4J7UGQ")]
[DisplayName("Invoice4")]
public record Invoice4
{
    /// <summary>
    /// Contains the invoice number.
    /// </summary>
    [IsoId("_gL9aEUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public IsoMax70Text? Number { get; init; }

    /// <summary>
    /// Effective billing date.
    /// </summary>
    [IsoId("_gL9aE0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Contains the date and time the electronic invoice was created.
    /// </summary>
    [IsoId("_gL9aFUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_gL9aF0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Name of the seller.
    /// </summary>
    [IsoId("_gL9aGUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Seller Name")]
    [IsoXmlTag("SellrNm")]
    public IsoMax105Text? SellerName { get; init; }

    /// <summary>
    /// Identification of the seller.
    /// </summary>
    [IsoId("_b3D5kUhvEfCMZJtj4J7UGQ")]
    [DisplayName("Seller Identification")]
    [IsoXmlTag("SellrId")]
    public IsoMax35Text? SellerIdentification { get; init; }

    /// <summary>
    /// Business name of the seller.
    /// </summary>
    [IsoId("_lzRrEkhvEfCMZJtj4J7UGQ")]
    [DisplayName("Seller Business Name")]
    [IsoXmlTag("SellrBizNm")]
    public IsoMax35Text? SellerBusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the seller.
    /// </summary>
    [IsoId("_lzRrE0hvEfCMZJtj4J7UGQ")]
    [DisplayName("Seller Legal Corporate Name")]
    [IsoXmlTag("SellrLglCorpNm")]
    public IsoMax99Text? SellerLegalCorporateName { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of seller data.
    /// </summary>
    [IsoId("_w_GDQUhvEfCMZJtj4J7UGQ")]
    [DisplayName("Seller Local Data")]
    [IsoXmlTag("SellrLclData")]
    public ValueList<LocalData20> SellerLocalData { get; init; } = [];

    /// <summary>
    /// Address of the seller.
    /// </summary>
    [IsoId("_gL9aHUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Seller Address")]
    [IsoXmlTag("SellrAdr")]
    public Address4? SellerAddress { get; init; }

    /// <summary>
    /// Contact information related to the seller.
    /// </summary>
    [IsoId("_gL_2UUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Seller Contact")]
    [IsoXmlTag("SellrCtct")]
    public ContactBusiness1? SellerContact { get; init; }

    /// <summary>
    /// Identification of the seller recognized by the taxation authority.
    /// </summary>
    [IsoId("_gL_2U0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Seller Tax Registration Identification")]
    [IsoXmlTag("SellrTaxRegnId")]
    public IsoMax70Text? SellerTaxRegistrationIdentification { get; init; }

    /// <summary>
    /// Additional information about the seller.
    /// </summary>
    [IsoId("_gL_2VUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Seller Additional Information")]
    [IsoXmlTag("SellrAddtlInf")]
    public IsoMax1000Text? SellerAdditionalInformation { get; init; }

    /// <summary>
    /// Name of the buyer.
    /// </summary>
    [IsoId("_gL_2V0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Buyer Name")]
    [IsoXmlTag("BuyrNm")]
    public IsoMax105Text? BuyerName { get; init; }

    /// <summary>
    /// Identification of the buyer.
    /// </summary>
    [IsoId("_XUZKNEhwEfCMZJtj4J7UGQ")]
    [DisplayName("Buyer Identification")]
    [IsoXmlTag("BuyrId")]
    public IsoMax35Text? BuyerIdentification { get; init; }

    /// <summary>
    /// Business name of the buyer.
    /// </summary>
    [IsoId("_XUZKNUhwEfCMZJtj4J7UGQ")]
    [DisplayName("Buyer Business Name")]
    [IsoXmlTag("BuyrBizNm")]
    public IsoMax35Text? BuyerBusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the buyer.
    /// </summary>
    [IsoId("_XUZKNkhwEfCMZJtj4J7UGQ")]
    [DisplayName("Buyer Legal Corporate Name")]
    [IsoXmlTag("BuyrLglCorpNm")]
    public IsoMax99Text? BuyerLegalCorporateName { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of buyer data.
    /// </summary>
    [IsoId("_XUZKN0hwEfCMZJtj4J7UGQ")]
    [DisplayName("Buyer Local Data")]
    [IsoXmlTag("BuyrLclData")]
    public ValueList<LocalData20> BuyerLocalData { get; init; } = [];

    /// <summary>
    /// Address of the buyer.
    /// </summary>
    [IsoId("_gL_2W0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Buyer Address")]
    [IsoXmlTag("BuyrAdr")]
    public Address4? BuyerAddress { get; init; }

    /// <summary>
    /// Contact information related to the buyer.
    /// </summary>
    [IsoId("_gL_2XUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Buyer Contact")]
    [IsoXmlTag("BuyrCtct")]
    public ContactBusiness1? BuyerContact { get; init; }

    /// <summary>
    /// Identification of the buyer recognized by the taxation authority.
    /// </summary>
    [IsoId("_gL_2X0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Buyer Tax Registration Identification")]
    [IsoXmlTag("BuyrTaxRegnId")]
    public IsoMax70Text? BuyerTaxRegistrationIdentification { get; init; }

    /// <summary>
    /// Additional information about the buyer.
    /// </summary>
    [IsoId("_gL_2YUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Buyer Additional Information")]
    [IsoXmlTag("BuyrAddtlInf")]
    public IsoMax1000Text? BuyerAdditionalInformation { get; init; }

    /// <summary>
    /// Contains the freight charges for the entire purchase.
    /// </summary>
    [IsoId("_gL_2Y0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Freight Amount")]
    [IsoXmlTag("FrghtAmt")]
    public ImpliedCurrencyAndAmount? FreightAmount { get; init; }

    /// <summary>
    /// Contains the total tax amount for the entire purchase.
    /// </summary>
    [IsoId("_gL_2ZUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Tax Total")]
    [IsoXmlTag("TaxTtl")]
    public ValueList<Tax44> TaxTotal { get; init; } = [];

    /// <summary>
    /// Code that identifies the disposition of the tax reclaim invoice.
    /// </summary>
    [IsoId("_gL_2Z0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Tax Reclaim Method")]
    [IsoXmlTag("TaxRclmMtd")]
    public TaxReclaimMethod1Code? TaxReclaimMethod { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_kjcXskhrEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_kjcXs0hrEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Line item information.
    /// </summary>
    [IsoId("_gL_2a0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<InvoiceLineItem4> LineItem { get; init; } = [];
}
