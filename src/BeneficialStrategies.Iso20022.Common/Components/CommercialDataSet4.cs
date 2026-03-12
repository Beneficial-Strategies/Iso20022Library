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
[IsoId("_kPbooRVZEeOCqpkCrPgk4g")]
[DisplayName("Commercial Data Set")]
public partial record CommercialDataSet4
{
    #nullable enable
    
    /// <summary>
    /// Identifies the commercial data set.
    /// </summary>
    [IsoId("_kp9BcRVZEeOCqpkCrPgk4g")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the identification of the underlying commercial document.
    /// </summary>
    [IsoId("_kp9BcxVZEeOCqpkCrPgk4g")]
    [DisplayName("Commercial Document Reference")]
    [IsoXmlTag("ComrclDocRef")]
    public required InvoiceIdentification1 CommercialDocumentReference { get; init; } 
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_kp9BdRVZEeOCqpkCrPgk4g")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification26 Buyer { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_kp9BdxVZEeOCqpkCrPgk4g")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification26 Seller { get; init; } 
    
    /// <summary>
    /// Party to be invoiced for the purchase.
    /// </summary>
    [IsoId("_kp9BeRVZEeOCqpkCrPgk4g")]
    [DisplayName("Bill To")]
    [IsoXmlTag("BllTo")]
    public PartyIdentification26? BillTo { get; init; } 
    
    /// <summary>
    /// Information about the goods and/or services of the underlying transaction.
    /// </summary>
    [IsoId("_kp9BexVZEeOCqpkCrPgk4g")]
    [DisplayName("Goods")]
    [IsoXmlTag("Goods")]
    public ValueList<LineItem12> Goods { get; init; } = new ValueList<LineItem12>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _kp9BexVZEeOCqpkCrPgk4g
    
    /// <summary>
    /// Specifies the payment terms by means of a code and a limit in time.
    /// </summary>
    [IsoId("_kp9BfRVZEeOCqpkCrPgk4g")]
    [DisplayName("Payment Terms")]
    [IsoXmlTag("PmtTerms")]
    public ValueList<PaymentTerms4> PaymentTerms { get; init; } = new ValueList<PaymentTerms4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _kp9BfRVZEeOCqpkCrPgk4g
    
    /// <summary>
    /// Specifies how the transaction should be settled.
    /// </summary>
    [IsoId("_kp9BfxVZEeOCqpkCrPgk4g")]
    [DisplayName("Settlement Terms")]
    [IsoXmlTag("SttlmTerms")]
    public required SettlementTerms3 SettlementTerms { get; init; } 
    
    
    #nullable disable
    
}
