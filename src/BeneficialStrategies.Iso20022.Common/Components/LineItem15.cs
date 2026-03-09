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
/// Commercial details of a trade transaction between a buyer and a seller.
/// </summary>
[IsoId("_MQGoMTckEeSaC-PiOaz_KQ")]
[DisplayName("Line Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItem15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LineItem15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LineItem15( DocumentIdentification7 reqPurchaseOrderReference,System.String reqFinalSubmission,CurrencyAndAmount reqLineItemsTotalAmount,CurrencyAndAmount reqTotalNetAmount )
    {
        PurchaseOrderReference = reqPurchaseOrderReference;
        FinalSubmission = reqFinalSubmission;
        LineItemsTotalAmount = reqLineItemsTotalAmount;
        TotalNetAmount = reqTotalNetAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_MnUOQzckEeSaC-PiOaz_KQ")]
    [DisplayName("Purchase Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsOrdrRef")]
    #endif
    [IsoXmlTag("PurchsOrdrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #else
    public DocumentIdentification7 PurchaseOrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether this current invoice is the last submission against the purchase order referenced.
    /// </summary>
    [IsoId("_MnUORTckEeSaC-PiOaz_KQ")]
    [DisplayName("Final Submission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlSubmissn")]
    #endif
    [IsoXmlTag("FnlSubmissn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator FinalSubmission { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FinalSubmission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FinalSubmission { get; init; } 
    #else
    public System.String FinalSubmission { get; set; } 
    #endif
    
    /// <summary>
    /// Goods which are the subject of the invoice.
    /// </summary>
    [IsoId("_MnUORzckEeSaC-PiOaz_KQ")]
    [DisplayName("Commercial Line Items")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComrclLineItms")]
    #endif
    [IsoXmlTag("ComrclLineItms")]
    public ValueList<LineItemDetails14> CommercialLineItems { get; init; } = new ValueList<LineItemDetails14>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _MnUORzckEeSaC-PiOaz_KQ
    
    /// <summary>
    /// Specifies the total amount of all line items (incl. their adjustments).
    /// </summary>
    [IsoId("_MnUOSTckEeSaC-PiOaz_KQ")]
    [DisplayName("Line Items Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItmsTtlAmt")]
    #endif
    [IsoXmlTag("LineItmsTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount LineItemsTotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount LineItemsTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount LineItemsTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount LineItemsTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_MnUOSzckEeSaC-PiOaz_KQ")]
    [DisplayName("Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adjstmnt")]
    #endif
    [IsoXmlTag("Adjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment6? Adjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment6? Adjustment { get; init; } 
    #else
    public Adjustment6? Adjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_MnUOTTckEeSaC-PiOaz_KQ")]
    [DisplayName("Freight Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrghtChrgs")]
    #endif
    [IsoXmlTag("FrghtChrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge25? FreightCharges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge25? FreightCharges { get; init; } 
    #else
    public Charge25? FreightCharges { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_MnUOTzckEeSaC-PiOaz_KQ")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax22? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax22? Tax { get; init; } 
    #else
    public Tax22? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Total net amount of a trade transaction. Total amount resulting from the gross amount plus freight charges, tax and plus/minus Adjustments.
    /// </summary>
    [IsoId("_MnUOUTckEeSaC-PiOaz_KQ")]
    [DisplayName("Total Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNetAmt")]
    #endif
    [IsoXmlTag("TtlNetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount TotalNetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount TotalNetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount TotalNetAmount { get; init; } 
    #else
    public CurrencyAndAmount TotalNetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_MnUOUzckEeSaC-PiOaz_KQ")]
    [DisplayName("Buyer Defined Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrDfndInf")]
    #endif
    [IsoXmlTag("BuyrDfndInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    #else
    public UserDefinedInformation1? BuyerDefinedInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_MnUOVTckEeSaC-PiOaz_KQ")]
    [DisplayName("Seller Defined Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrDfndInf")]
    #endif
    [IsoXmlTag("SellrDfndInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    #else
    public UserDefinedInformation1? SellerDefinedInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_MnUOVzckEeSaC-PiOaz_KQ")]
    [DisplayName("Incoterms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incotrms")]
    #endif
    [IsoXmlTag("Incotrms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Incoterms4? Incoterms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Incoterms4? Incoterms { get; init; } 
    #else
    public Incoterms4? Incoterms { get; set; } 
    #endif
    
    
    #nullable disable
    
}
