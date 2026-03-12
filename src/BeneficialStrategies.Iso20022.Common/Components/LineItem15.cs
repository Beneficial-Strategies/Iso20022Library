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
[IsoId("_MQGoMTckEeSaC-PiOaz_KQ")]
[DisplayName("Line Item")]
public partial record LineItem15
{
    #nullable enable
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_MnUOQzckEeSaC-PiOaz_KQ")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    
    /// <summary>
    /// Specifies whether this current invoice is the last submission against the purchase order referenced.
    /// </summary>
    [IsoId("_MnUORTckEeSaC-PiOaz_KQ")]
    [DisplayName("Final Submission")]
    [IsoXmlTag("FnlSubmissn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator FinalSubmission { get; init; } 
    
    /// <summary>
    /// Goods which are the subject of the invoice.
    /// </summary>
    [IsoId("_MnUORzckEeSaC-PiOaz_KQ")]
    [DisplayName("Commercial Line Items")]
    [IsoXmlTag("ComrclLineItms")]
    public ValueList<LineItemDetails14> CommercialLineItems { get; init; } = new ValueList<LineItemDetails14>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _MnUORzckEeSaC-PiOaz_KQ
    
    /// <summary>
    /// Specifies the total amount of all line items (incl. their adjustments).
    /// </summary>
    [IsoId("_MnUOSTckEeSaC-PiOaz_KQ")]
    [DisplayName("Line Items Total Amount")]
    [IsoXmlTag("LineItmsTtlAmt")]
    public required CurrencyAndAmount LineItemsTotalAmount { get; init; } 
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_MnUOSzckEeSaC-PiOaz_KQ")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment6? Adjustment { get; init; } 
    
    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_MnUOTTckEeSaC-PiOaz_KQ")]
    [DisplayName("Freight Charges")]
    [IsoXmlTag("FrghtChrgs")]
    public Charge25? FreightCharges { get; init; } 
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_MnUOTzckEeSaC-PiOaz_KQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax22? Tax { get; init; } 
    
    /// <summary>
    /// Total net amount of a trade transaction. Total amount resulting from the gross amount plus freight charges, tax and plus/minus Adjustments.
    /// </summary>
    [IsoId("_MnUOUTckEeSaC-PiOaz_KQ")]
    [DisplayName("Total Net Amount")]
    [IsoXmlTag("TtlNetAmt")]
    public required CurrencyAndAmount TotalNetAmount { get; init; } 
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_MnUOUzckEeSaC-PiOaz_KQ")]
    [DisplayName("Buyer Defined Information")]
    [IsoXmlTag("BuyrDfndInf")]
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_MnUOVTckEeSaC-PiOaz_KQ")]
    [DisplayName("Seller Defined Information")]
    [IsoXmlTag("SellrDfndInf")]
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_MnUOVzckEeSaC-PiOaz_KQ")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms4? Incoterms { get; init; } 
    
    
    #nullable disable
    
}
