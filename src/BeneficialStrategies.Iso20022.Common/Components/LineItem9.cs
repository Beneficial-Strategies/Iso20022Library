// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Commercial details of a trade transaction between a buyer and a seller.
/// </summary>
[IsoId("_SrsvS9p-Ed-ak6NoX_4Aeg_-1149974341")]
[DisplayName("Line Item")]
public partial record LineItem9
{
    #nullable enable
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_SrsvTNp-Ed-ak6NoX_4Aeg_-1149973732")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    
    /// <summary>
    /// Specifies whether this current invoice is the last submission against the purchase order referenced.
    /// </summary>
    [IsoId("_SrsvTdp-Ed-ak6NoX_4Aeg_-121761224")]
    [DisplayName("Final Submission")]
    [IsoXmlTag("FnlSubmissn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator FinalSubmission { get; init; } 
    
    /// <summary>
    /// Goods which are the subject of the invoice.
    /// </summary>
    [IsoId("_SrsvTtp-Ed-ak6NoX_4Aeg_-1149973794")]
    [DisplayName("Commercial Line Items")]
    [IsoXmlTag("ComrclLineItms")]
    public ValueList<LineItemDetails9> CommercialLineItems { get; init; } = [];
    // ID for the above is _SrsvTtp-Ed-ak6NoX_4Aeg_-1149973794
    
    /// <summary>
    /// Specifies the total amount of all line items (incl. their adjustments).
    /// </summary>
    [IsoId("_SrsvT9p-Ed-ak6NoX_4Aeg_-1149974310")]
    [DisplayName("Line Items Total Amount")]
    [IsoXmlTag("LineItmsTtlAmt")]
    public required CurrencyAndAmount LineItemsTotalAmount { get; init; } 
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_SrsvUNp-Ed-ak6NoX_4Aeg_-1149973702")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms2? Incoterms { get; init; } 
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_Sr15MNp-Ed-ak6NoX_4Aeg_-1149973824")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment4? Adjustment { get; init; } 
    
    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_Sr15Mdp-Ed-ak6NoX_4Aeg_-1149974103")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge13? FreightCharges { get; init; } 
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_Sr15Mtp-Ed-ak6NoX_4Aeg_-1149974185")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax12? Tax { get; init; } 
    
    /// <summary>
    /// Total net amount of a trade transaction. Total amount resulting from the gross amount plus freight charges, tax and plus/minus Adjustments.
    /// </summary>
    [IsoId("_Sr15M9p-Ed-ak6NoX_4Aeg_-1149974279")]
    [DisplayName("Total Net Amount")]
    [IsoXmlTag("TtlNetAmt")]
    public required CurrencyAndAmount TotalNetAmount { get; init; } 
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_Sr15NNp-Ed-ak6NoX_4Aeg_-1149973362")]
    [DisplayName("Buyer Defined Information")]
    [IsoXmlTag("BuyrDfndInf")]
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_Sr15Ndp-Ed-ak6NoX_4Aeg_-1149973393")]
    [DisplayName("Seller Defined Information")]
    [IsoXmlTag("SellrDfndInf")]
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    
    
    #nullable disable
    
}
