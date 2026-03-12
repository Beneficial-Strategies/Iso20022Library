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
[IsoId("_05Z9QQvZEeKzJ69IWwzB9Q")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_1Et1YQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_1Et1ZQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability1? Traceability { get; init; } 
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_1Et1aQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification32? DataSetInitiator { get; init; } 
    
    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_1Et1bQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals2> TransactionTotals { get; init; } = new ValueList<TransactionTotals2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _1Et1bQvZEeKzJ69IWwzB9Q
    
    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_1Et1cQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData2? CommonData { get; init; } 
    
    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_lpQ7sC8SEeKW5usMQLtzqw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction1Choice_> Transaction { get; init; } = new ValueList<CardPaymentDataSetTransaction1Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _lpQ7sC8SEeKW5usMQLtzqw
    
    
    #nullable disable
    
}
