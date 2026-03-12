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
[IsoId("_YJ1FgDD0EeO9waS4ina8CA")]
[DisplayName("Card Payment Invoice")]
public partial record CardPaymentInvoice1
{
    #nullable enable
    
    /// <summary>
    /// General data relevant to the main body of the invoice such as date of issue, currency code and identification number.
    /// </summary>
    [IsoId("_ozV1cDD0EeO9waS4ina8CA")]
    [DisplayName("Invoice Header")]
    [IsoXmlTag("InvcHdr")]
    public required InvoiceHeader1 InvoiceHeader { get; init; } 
    
    /// <summary>
    /// Contractual details related to the agreement between parties.
    /// </summary>
    [IsoId("_ubYcADD0EeO9waS4ina8CA")]
    [DisplayName("Trade Agreement")]
    [IsoXmlTag("TradAgrmt")]
    public required TradeAgreement6 TradeAgreement { get; init; } 
    
    /// <summary>
    /// Supply chain shipping arrangements for delivery of invoiced products and/or services.
    /// </summary>
    [IsoId("_ymbgIDD0EeO9waS4ina8CA")]
    [DisplayName("Trade Delivery")]
    [IsoXmlTag("TradDlvry")]
    public required TradeDelivery1 TradeDelivery { get; init; } 
    
    /// <summary>
    /// Unit of information showing the related provision of products and/or services and monetary summations reported as a discrete line items.
    /// </summary>
    [IsoId("_3mI7YDD0EeO9waS4ina8CA")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public LineItem10? LineItem { get; init; } 
    
    
    #nullable disable
    
}
