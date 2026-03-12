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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.034.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The InvoiceTaxReport message is sent by tax responsible to tax authority. Tax authorities require corporates to report their sales based value added tax (VAT). This message is targeted to this reporting based on information in sales invoices and card transactions.
/// </summary>
[Description(@"The InvoiceTaxReport message is sent by tax responsible to tax authority. Tax authorities require corporates to report their sales based value added tax (VAT). This message is targeted to this reporting based on information in sales invoices and card transactions.")]
[IsoId("_B5eQoFmrEeOQYsoJizpkVw")]
[DisplayName("Invoice Tax Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceTaxReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.034.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcTaxRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.034.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvoiceTaxReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvoiceTaxReportV01( TaxReportHeader1 reqInvoiceTaxReportHeader,TaxReport1 reqTaxReport )
    {
        InvoiceTaxReportHeader = reqInvoiceTaxReportHeader;
        TaxReport = reqTaxReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines message level identification, number of individual tax reports and tax authority.
    /// </summary>
    [IsoId("_riLtAGn0Eea5EcY2TpG1mw")]
    [DisplayName("Invoice Tax Report Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcTaxRptHdr")]
    #endif
    [IsoXmlTag("InvcTaxRptHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxReportHeader1 InvoiceTaxReportHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxReportHeader1 InvoiceTaxReportHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReportHeader1 InvoiceTaxReportHeader { get; init; } 
    #else
    public TaxReportHeader1 InvoiceTaxReportHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Contains all needed party details for tax agency (sender of the TaxReport) and tax authority (receiver of the TaxReport) and the details of the reported sales transaction and calculated tax related that specific business transaction.
    /// </summary>
    [IsoId("_DiX4YFm8EeOQYsoJizpkVw")]
    [DisplayName("Tax Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRpt")]
    #endif
    [IsoXmlTag("TaxRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxReport1 TaxReport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxReport1 TaxReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReport1 TaxReport { get; init; } 
    #else
    public TaxReport1 TaxReport { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_YqO7oEjvEeaOe8w0NJ11wQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since InvoiceTaxReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoiceTaxReportV01.

