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
[IsoId("_YzZoAQuEEeqYM5yH99IYQw")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet23
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_Y9_HYQuEEeqYM5yH99IYQw")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_Y9_HYwuEEeqYM5yH99IYQw")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability8? Traceability { get; init; } 
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_Y9_ucQuEEeqYM5yH99IYQw")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification176? DataSetInitiator { get; init; } 
    
    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_Y9_ucwuEEeqYM5yH99IYQw")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals7> TransactionTotals { get; init; } = new ValueList<TransactionTotals7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Y9_ucwuEEeqYM5yH99IYQw
    
    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_Y9_udQuEEeqYM5yH99IYQw")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData9? CommonData { get; init; } 
    
    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_Y9_udwuEEeqYM5yH99IYQw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction8Choice_> Transaction { get; init; } = new ValueList<CardPaymentDataSetTransaction8Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Y9_udwuEEeqYM5yH99IYQw
    
    
    #nullable disable
    
}
