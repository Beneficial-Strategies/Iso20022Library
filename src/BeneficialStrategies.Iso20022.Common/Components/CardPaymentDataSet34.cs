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
[IsoId("_sB2BoXJPEe299ZbWCkdR_w")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet34
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_sIT2AXJPEe299ZbWCkdR_w")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_sIT2A3JPEe299ZbWCkdR_w")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability8? Traceability { get; init; } 
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_sIT2BXJPEe299ZbWCkdR_w")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification176? DataSetInitiator { get; init; } 
    
    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_sIT2B3JPEe299ZbWCkdR_w")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = new ValueList<TransactionTotals12>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _sIT2B3JPEe299ZbWCkdR_w
    
    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_sIT2CXJPEe299ZbWCkdR_w")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData12? CommonData { get; init; } 
    
    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_sIT2C3JPEe299ZbWCkdR_w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction11Choice_> Transaction { get; init; } = new ValueList<CardPaymentDataSetTransaction11Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _sIT2C3JPEe299ZbWCkdR_w
    
    
    #nullable disable
    
}
