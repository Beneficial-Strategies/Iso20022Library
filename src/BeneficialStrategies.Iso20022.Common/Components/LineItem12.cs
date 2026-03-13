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
[IsoId("_SW4OUTAWEeOKib24wnHaFg")]
[DisplayName("Line Item")]
public partial record LineItem12
{
    #nullable enable
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_SxvlYzAWEeOKib24wnHaFg")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    
    /// <summary>
    /// Specifies whether this current invoice is the last submission against the purchase order referenced.
    /// </summary>
    [IsoId("_SxvlZTAWEeOKib24wnHaFg")]
    [DisplayName("Final Submission")]
    [IsoXmlTag("FnlSubmissn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator FinalSubmission { get; init; } 
    
    /// <summary>
    /// Goods which are the subject of the invoice.
    /// </summary>
    [IsoId("_SxvlZzAWEeOKib24wnHaFg")]
    [DisplayName("Commercial Line Items")]
    [IsoXmlTag("ComrclLineItms")]
    public ValueList<LineItemDetails11> CommercialLineItems { get; init; } = [];
    // ID for the above is _SxvlZzAWEeOKib24wnHaFg
    
    /// <summary>
    /// Specifies the total amount of all line items (incl. their adjustments).
    /// </summary>
    [IsoId("_SxvlaTAWEeOKib24wnHaFg")]
    [DisplayName("Line Items Total Amount")]
    [IsoXmlTag("LineItmsTtlAmt")]
    public required CurrencyAndAmount LineItemsTotalAmount { get; init; } 
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_SxvlbTAWEeOKib24wnHaFg")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment6? Adjustment { get; init; } 
    
    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_SxvlbzAWEeOKib24wnHaFg")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge25? FreightCharges { get; init; } 
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_SxvlcTAWEeOKib24wnHaFg")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax22? Tax { get; init; } 
    
    /// <summary>
    /// Total net amount of a trade transaction. Total amount resulting from the gross amount plus freight charges, tax and plus/minus Adjustments.
    /// </summary>
    [IsoId("_SxvlczAWEeOKib24wnHaFg")]
    [DisplayName("Total Net Amount")]
    [IsoXmlTag("TtlNetAmt")]
    public required CurrencyAndAmount TotalNetAmount { get; init; } 
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_SxvldTAWEeOKib24wnHaFg")]
    [DisplayName("Buyer Defined Information")]
    [IsoXmlTag("BuyrDfndInf")]
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_SxvldzAWEeOKib24wnHaFg")]
    [DisplayName("Seller Defined Information")]
    [IsoXmlTag("SellrDfndInf")]
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_SxvlazAWEeOKib24wnHaFg")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms4? Incoterms { get; init; } 
    
    
    #nullable disable
    
}
