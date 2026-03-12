// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of transactions to capture, sharing common characteristics.
/// </summary>
[IsoId("_MHomAdekEeiJyp_aycJaTw")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet22
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_MSLpIdekEeiJyp_aycJaTw")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_MSLpI9ekEeiJyp_aycJaTw")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability5? Traceability { get; init; } 
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_MSLpJdekEeiJyp_aycJaTw")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification53? DataSetInitiator { get; init; } 
    
    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_MSLpJ9ekEeiJyp_aycJaTw")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals7> TransactionTotals { get; init; } = new ValueList<TransactionTotals7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _MSLpJ9ekEeiJyp_aycJaTw
    
    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_MSLpKdekEeiJyp_aycJaTw")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData8? CommonData { get; init; } 
    
    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_MSLpK9ekEeiJyp_aycJaTw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction7Choice_> Transaction { get; init; } = new ValueList<CardPaymentDataSetTransaction7Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _MSLpK9ekEeiJyp_aycJaTw
    
    
    #nullable disable
    
}
