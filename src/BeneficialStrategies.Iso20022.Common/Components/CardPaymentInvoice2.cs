// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed invoice data.
/// </summary>
[IsoId("_Az1NUcNPEeWGDrnsYu2p6g")]
[DisplayName("Card Payment Invoice")]
public partial record CardPaymentInvoice2
{
    #nullable enable
    
    /// <summary>
    /// General data relevant to the main body of the invoice such as date of issue, currency code and identification number.
    /// </summary>
    [IsoId("_BGbZMcNPEeWGDrnsYu2p6g")]
    [DisplayName("Invoice Header")]
    [IsoXmlTag("InvcHdr")]
    public required InvoiceHeader2 InvoiceHeader { get; init; } 
    
    /// <summary>
    /// Contractual details related to the agreement between parties.
    /// </summary>
    [IsoId("_BGbZM8NPEeWGDrnsYu2p6g")]
    [DisplayName("Trade Agreement")]
    [IsoXmlTag("TradAgrmt")]
    public required TradeAgreement13 TradeAgreement { get; init; } 
    
    /// <summary>
    /// Supply chain shipping arrangements for delivery of invoiced products and/or services.
    /// </summary>
    [IsoId("_BGbZNcNPEeWGDrnsYu2p6g")]
    [DisplayName("Trade Delivery")]
    [IsoXmlTag("TradDlvry")]
    public required TradeDelivery2 TradeDelivery { get; init; } 
    
    /// <summary>
    /// Unit of information showing the related provision of products and/or services and monetary summations reported as a discrete line items.
    /// </summary>
    [IsoId("_BGbZN8NPEeWGDrnsYu2p6g")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public LineItem16? LineItem { get; init; } 
    
    
    #nullable disable
    
}
