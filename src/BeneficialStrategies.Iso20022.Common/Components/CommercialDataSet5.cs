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
[IsoId("_L6FU0TckEeSaC-PiOaz_KQ")]
[DisplayName("Commercial Data Set")]
public partial record CommercialDataSet5
{
    #nullable enable
    
    /// <summary>
    /// Identifies the commercial data set.
    /// </summary>
    [IsoId("_MQGoITckEeSaC-PiOaz_KQ")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the identification of the underlying commercial document.
    /// </summary>
    [IsoId("_MQGoIzckEeSaC-PiOaz_KQ")]
    [DisplayName("Commercial Document Reference")]
    [IsoXmlTag("ComrclDocRef")]
    public required InvoiceIdentification1 CommercialDocumentReference { get; init; } 
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_MQGoJTckEeSaC-PiOaz_KQ")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification26 Buyer { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_MQGoJzckEeSaC-PiOaz_KQ")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification26 Seller { get; init; } 
    
    /// <summary>
    /// Party to be invoiced for the purchase.
    /// </summary>
    [IsoId("_MQGoKTckEeSaC-PiOaz_KQ")]
    [DisplayName("Bill To")]
    [IsoXmlTag("BllTo")]
    public PartyIdentification26? BillTo { get; init; } 
    
    /// <summary>
    /// Information about the goods and/or services of the underlying transaction.
    /// </summary>
    [IsoId("_MQGoKzckEeSaC-PiOaz_KQ")]
    [DisplayName("Goods")]
    [IsoXmlTag("Goods")]
    public ValueList<LineItem15> Goods { get; init; } = new ValueList<LineItem15>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _MQGoKzckEeSaC-PiOaz_KQ
    
    /// <summary>
    /// Specifies the payment terms by means of a code and a limit in time.
    /// </summary>
    [IsoId("_MQGoLTckEeSaC-PiOaz_KQ")]
    [DisplayName("Payment Terms")]
    [IsoXmlTag("PmtTerms")]
    public ValueList<PaymentTerms4> PaymentTerms { get; init; } = new ValueList<PaymentTerms4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _MQGoLTckEeSaC-PiOaz_KQ
    
    /// <summary>
    /// Specifies how the transaction should be settled.
    /// </summary>
    [IsoId("_MQGoLzckEeSaC-PiOaz_KQ")]
    [DisplayName("Settlement Terms")]
    [IsoXmlTag("SttlmTerms")]
    public required SettlementTerms3 SettlementTerms { get; init; } 
    
    
    #nullable disable
    
}
