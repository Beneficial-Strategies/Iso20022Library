// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Summary information about the sale
/// </summary>
[IsoId("_BzO2McWkEeuhguwJmlgagQ")]
[DisplayName("Invoice Summary")]
public record InvoiceSummary2
{
    /// <summary>
    /// Contains the invoice number.
    /// </summary>
    [IsoId("_B3u7scWkEeuhguwJmlgagQ")]
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? InvoiceNumber { get; init; }

    /// <summary>
    /// Supplier or the provider of the goods or services.
    /// </summary>
    [IsoId("_B3u7s8WkEeuhguwJmlgagQ")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public PartyIdentification259? Seller { get; init; }

    /// <summary>
    /// Buyer or company buying the goods or services.
    /// </summary>
    [IsoId("_B3u7tcWkEeuhguwJmlgagQ")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public PartyIdentification259? Buyer { get; init; }

    /// <summary>
    /// Effective billing date.
    /// </summary>
    [IsoId("_B3u7t8WkEeuhguwJmlgagQ")]
    [DisplayName("Invoice Date")]
    [IsoXmlTag("InvcDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InvoiceDate { get; init; }

    /// <summary>
    /// Contains the date and time the electronic invoice was created.
    /// </summary>
    [IsoId("_B3u7ucWkEeuhguwJmlgagQ")]
    [DisplayName("Invoice Creation Date Time")]
    [IsoXmlTag("InvcCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? InvoiceCreationDateTime { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_B3u7u8WkEeuhguwJmlgagQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Contains the freight charges for the entire purchase.
    /// </summary>
    [IsoId("_B3u7vcWkEeuhguwJmlgagQ")]
    [DisplayName("Freight Amount")]
    [IsoXmlTag("FrghtAmt")]
    public ImpliedCurrencyAndAmount? FreightAmount { get; init; }

    /// <summary>
    /// Contains the total tax amount for the entire purchase.
    /// </summary>
    [IsoId("_B3u7v8WkEeuhguwJmlgagQ")]
    [DisplayName("Tax Total")]
    [IsoXmlTag("TaxTtl")]
    public Tax39? TaxTotal { get; init; }

    /// <summary>
    /// Code that identifies the disposition of the tax reclaim invoice.
    /// </summary>
    [IsoId("_B3u7wcWkEeuhguwJmlgagQ")]
    [DisplayName("Tax Reclaim Method")]
    [IsoXmlTag("TaxRclmMtd")]
    public TaxReclaimMethod1Code? TaxReclaimMethod { get; init; }

    /// <summary>
    /// Contains additional details.
    /// </summary>
    [IsoId("_B3u7w8WkEeuhguwJmlgagQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
