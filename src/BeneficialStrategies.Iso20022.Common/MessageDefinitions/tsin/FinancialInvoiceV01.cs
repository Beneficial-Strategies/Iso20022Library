// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// This record is an implementation of the tsin.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInvoice message is used to support the provision of financial and related services where there is a requirement to exchange invoice information.
/// Usage
/// While the prime function of the FinancialInvoice message is as a request from the seller to the buyer for payment, the FinancialInvoice message can also serve to evidence an invoice in support of a financial service such as invoice factoring, letters of credit, and bank payment obligations, to enable Web based services such as electronic bill payment and presentment, and as the basis to transfer invoice information via third parties such as e-invoicing service providers.
/// A consequence of the receipt of an invoice by the buyer is that it acts as a trigger for the use of related messages that are already defined in ISO 20022, notably where the information contained in the Financial Invoice enables payment for the goods or services received, and/or is provided in support of a request for invoice financing. While certain of these related messages, such as the CreditTransfer and PaymentInitiation messages, are shown in the sequence diagram they are out of scope. They are shown only to illustrate a given scenario and to place the invoice in the context of the financial banking processes that might be conducted between different financial institutions.
/// The use of self-billing by the buyer to the seller, where the buyer acts as the invoice issuer or the process of handling an incorrect invoice, is not in scope.
/// </summary>
[Description(@"Scope|The FinancialInvoice message is used to support the provision of financial and related services where there is a requirement to exchange invoice information.|Usage|While the prime function of the FinancialInvoice message is as a request from the seller to the buyer for payment, the FinancialInvoice message can also serve to evidence an invoice in support of a financial service such as invoice factoring, letters of credit, and bank payment obligations, to enable Web based services such as electronic bill payment and presentment, and as the basis to transfer invoice information via third parties such as e-invoicing service providers.|A consequence of the receipt of an invoice by the buyer is that it acts as a trigger for the use of related messages that are already defined in ISO 20022, notably where the information contained in the Financial Invoice enables payment for the goods or services received, and/or is provided in support of a request for invoice financing. While certain of these related messages, such as the CreditTransfer and PaymentInitiation messages, are shown in the sequence diagram they are out of scope. They are shown only to illustrate a given scenario and to place the invoice in the context of the financial banking processes that might be conducted between different financial institutions.|The use of self-billing by the buyer to the seller, where the buyer acts as the invoice issuer or the process of handling an incorrect invoice, is not in scope.")]
[IsoId("_BU_0In1LEeCF8NjrBemJWQ_-1866907401")]
[DisplayName("Financial Invoice V")]
public partial record FinancialInvoiceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.004.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.004.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Collection of data that is exchanged between two or more parties in written, printed or electronic form. It contains general data relevant to the main body of the invoice such as date of issue, currency code and identification number.
    /// </summary>
    [IsoId("_BU_0I31LEeCF8NjrBemJWQ_-1198026434")]
    [DisplayName("Invoice Header")]
    [IsoXmlTag("InvcHdr")]
    public required InvoiceHeader1 InvoiceHeader { get; init; } 
    
    /// <summary>
    /// Commercial information such as terms of commerce, parties, and documentation, related to the trading agreement under which this invoice is issued.
    /// </summary>
    [IsoId("_BU_0JH1LEeCF8NjrBemJWQ_-1506571269")]
    [DisplayName("Trade Agreement")]
    [IsoXmlTag("TradAgrmt")]
    public required TradeAgreement6 TradeAgreement { get; init; } 
    
    /// <summary>
    /// Supply chain shipping arrangements for delivery of invoiced products and/or services.
    /// </summary>
    [IsoId("_BU_0JX1LEeCF8NjrBemJWQ_-1892382855")]
    [DisplayName("Trade Delivery")]
    [IsoXmlTag("TradDlvry")]
    public required TradeDelivery1 TradeDelivery { get; init; } 
    
    /// <summary>
    /// Settlement information that enables the financial reconciliation and payment of this invoice.
    /// </summary>
    [IsoId("_BU_0Jn1LEeCF8NjrBemJWQ_1308887526")]
    [DisplayName("Trade Settlement")]
    [IsoXmlTag("TradSttlm")]
    public required TradeSettlement1 TradeSettlement { get; init; } 
    
    /// <summary>
    /// Unit of information in this invoice showning the related provision of products and/or services and monetary summations reported as a discrete line item.
    /// </summary>
    [IsoId("_BU_0J31LEeCF8NjrBemJWQ_-1744265877")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public LineItem10? LineItem { get; init; } 
    
    
    #nullable disable
    
}


// Since FinancialInvoiceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInvoiceV01.

