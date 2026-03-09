// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed invoice data.
/// </summary>
[IsoId("_Az1NUcNPEeWGDrnsYu2p6g")]
[DisplayName("Card Payment Invoice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentInvoice2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentInvoice2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentInvoice2( InvoiceHeader2 reqInvoiceHeader,TradeAgreement13 reqTradeAgreement,TradeDelivery2 reqTradeDelivery )
    {
        InvoiceHeader = reqInvoiceHeader;
        TradeAgreement = reqTradeAgreement;
        TradeDelivery = reqTradeDelivery;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// General data relevant to the main body of the invoice such as date of issue, currency code and identification number.
    /// </summary>
    [IsoId("_BGbZMcNPEeWGDrnsYu2p6g")]
    [DisplayName("Invoice Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcHdr")]
    #endif
    [IsoXmlTag("InvcHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvoiceHeader2 InvoiceHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvoiceHeader2 InvoiceHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvoiceHeader2 InvoiceHeader { get; init; } 
    #else
    public InvoiceHeader2 InvoiceHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Contractual details related to the agreement between parties.
    /// </summary>
    [IsoId("_BGbZM8NPEeWGDrnsYu2p6g")]
    [DisplayName("Trade Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradAgrmt")]
    #endif
    [IsoXmlTag("TradAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeAgreement13 TradeAgreement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeAgreement13 TradeAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeAgreement13 TradeAgreement { get; init; } 
    #else
    public TradeAgreement13 TradeAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Supply chain shipping arrangements for delivery of invoiced products and/or services.
    /// </summary>
    [IsoId("_BGbZNcNPEeWGDrnsYu2p6g")]
    [DisplayName("Trade Delivery")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDlvry")]
    #endif
    [IsoXmlTag("TradDlvry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeDelivery2 TradeDelivery { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeDelivery2 TradeDelivery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDelivery2 TradeDelivery { get; init; } 
    #else
    public TradeDelivery2 TradeDelivery { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of information showing the related provision of products and/or services and monetary summations reported as a discrete line items.
    /// </summary>
    [IsoId("_BGbZN8NPEeWGDrnsYu2p6g")]
    [DisplayName("Line Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItm")]
    #endif
    [IsoXmlTag("LineItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItem16? LineItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItem16? LineItem { get; init; } 
    #else
    public LineItem16? LineItem { get; set; } 
    #endif
    
    
    #nullable disable
    
}
