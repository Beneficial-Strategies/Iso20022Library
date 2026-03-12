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
[IsoId("_Z4sT8S4-EeunNvJlR_vCbg")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet26
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_aEKkIS4-EeunNvJlR_vCbg")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_aEKkIy4-EeunNvJlR_vCbg")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability8? Traceability { get; init; } 
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_aEKkJS4-EeunNvJlR_vCbg")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification176? DataSetInitiator { get; init; } 
    
    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_aEKkJy4-EeunNvJlR_vCbg")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = new ValueList<TransactionTotals12>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _aEKkJy4-EeunNvJlR_vCbg
    
    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_aEKkKS4-EeunNvJlR_vCbg")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData10? CommonData { get; init; } 
    
    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_aEKkKy4-EeunNvJlR_vCbg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction9Choice_> Transaction { get; init; } = new ValueList<CardPaymentDataSetTransaction9Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _aEKkKy4-EeunNvJlR_vCbg
    
    
    #nullable disable
    
}
