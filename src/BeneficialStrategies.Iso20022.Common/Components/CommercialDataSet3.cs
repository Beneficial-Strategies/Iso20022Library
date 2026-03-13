// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Goods or services that are part of a commercial trade agreement.
/// </summary>
[IsoId("_Spw1k9p-Ed-ak6NoX_4Aeg_720183247")]
[DisplayName("Commercial Data Set")]
public partial record CommercialDataSet3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the commercial data set.
    /// </summary>
    [IsoId("_Spw1lNp-Ed-ak6NoX_4Aeg_720183672")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the identification of the underlying commercial document.
    /// </summary>
    [IsoId("_Spw1ldp-Ed-ak6NoX_4Aeg_720183588")]
    [DisplayName("Commercial Document Reference")]
    [IsoXmlTag("ComrclDocRef")]
    public required InvoiceIdentification1 CommercialDocumentReference { get; init; } 
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Spw1ltp-Ed-ak6NoX_4Aeg_720184042")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification26 Buyer { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Spw1l9p-Ed-ak6NoX_4Aeg_720184073")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification26 Seller { get; init; } 
    
    /// <summary>
    /// Party to be invoiced for the purchase.
    /// </summary>
    [IsoId("_Spw1mNp-Ed-ak6NoX_4Aeg_720183981")]
    [DisplayName("Bill To")]
    [IsoXmlTag("BllTo")]
    public PartyIdentification26? BillTo { get; init; } 
    
    /// <summary>
    /// Information about the goods and/or services of the underlying transaction.
    /// </summary>
    [IsoId("_Spw1mdp-Ed-ak6NoX_4Aeg_720183528")]
    [DisplayName("Goods")]
    [IsoXmlTag("Goods")]
    public ValueList<LineItem9> Goods { get; init; } = [];
    // ID for the above is _Spw1mdp-Ed-ak6NoX_4Aeg_720183528
    
    /// <summary>
    /// Specifies the payment terms by means of a code and a limit in time.
    /// </summary>
    [IsoId("_Sp5_gNp-Ed-ak6NoX_4Aeg_720184134")]
    [DisplayName("Payment Terms")]
    [IsoXmlTag("PmtTerms")]
    public ValueList<PaymentTerms1> PaymentTerms { get; init; } = [];
    // ID for the above is _Sp5_gNp-Ed-ak6NoX_4Aeg_720184134
    
    /// <summary>
    /// Specifies how the transaction should be settled.
    /// </summary>
    [IsoId("_Sp5_gdp-Ed-ak6NoX_4Aeg_720184165")]
    [DisplayName("Settlement Terms")]
    [IsoXmlTag("SttlmTerms")]
    public required SettlementTerms2 SettlementTerms { get; init; } 
    
    
    #nullable disable
    
}
