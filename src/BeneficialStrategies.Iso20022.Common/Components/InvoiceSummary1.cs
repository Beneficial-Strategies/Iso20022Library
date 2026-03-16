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
[IsoId("_IgZ-aPM0Eei4qfiLgRIZBA")]
[DisplayName("Invoice Summary")]
public record InvoiceSummary1
{
    /// <summary>
    /// Contains the invoice number.
    /// </summary>
    [IsoId("_IgZ-bfM0Eei4qfiLgRIZBA")]
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? InvoiceNumber { get; init; }

    /// <summary>
    /// Supplier or the provider of the goods or services.
    /// </summary>
    [IsoId("_IgZ-bvM0Eei4qfiLgRIZBA")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public PartyIdentification206? Seller { get; init; }

    /// <summary>
    /// Buyer or company buying the goods or services.
    /// </summary>
    [IsoId("_IgZ-avM0Eei4qfiLgRIZBA")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public PartyIdentification206? Buyer { get; init; }

    /// <summary>
    /// Effective billing date.
    /// </summary>
    [IsoId("_IgZ-b_M0Eei4qfiLgRIZBA")]
    [DisplayName("Invoice Date")]
    [IsoXmlTag("InvcDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InvoiceDate { get; init; }

    /// <summary>
    /// Contains the date and time the electronic invoice was created.
    /// </summary>
    [IsoId("_IgZ-bPM0Eei4qfiLgRIZBA")]
    [DisplayName("Invoice Creation Date Time")]
    [IsoXmlTag("InvcCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? InvoiceCreationDateTime { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_IgZ-afM0Eei4qfiLgRIZBA")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Contains the freight charges for the entire purchase.
    /// </summary>
    [IsoId("_1RoGQPM8Eei4qfiLgRIZBA")]
    [DisplayName("Freight Amount")]
    [IsoXmlTag("FrghtAmt")]
    public ImpliedCurrencyAndAmount? FreightAmount { get; init; }

    /// <summary>
    /// Contains the total tax amount for the entire purchase.
    /// </summary>
    [IsoId("_5JlPQPM8Eei4qfiLgRIZBA")]
    [DisplayName("Tax Total")]
    [IsoXmlTag("TaxTtl")]
    public ValueList<Tax33> TaxTotal { get; init; } = [];

    /// <summary>
    /// Code that identifies the disposition of the tax reclaim invoice.
    /// </summary>
    [IsoId("_-wAsQPM8Eei4qfiLgRIZBA")]
    [DisplayName("Tax Reclaim Method")]
    [IsoXmlTag("TaxRclmMtd")]
    public TaxReclaimMethod1Code? TaxReclaimMethod { get; init; }

    /// <summary>
    /// Contains additional details.
    /// </summary>
    [IsoId("_C9fZUPM9Eei4qfiLgRIZBA")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
