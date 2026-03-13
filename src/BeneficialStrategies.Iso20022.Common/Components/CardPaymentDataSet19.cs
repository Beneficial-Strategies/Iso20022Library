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
[IsoId("_68jRcdpoEeearpaEPXv9UA")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet19
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_7Fa5kdpoEeearpaEPXv9UA")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_7Fa5k9poEeearpaEPXv9UA")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability5? Traceability { get; init; } 
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_7Fa5ldpoEeearpaEPXv9UA")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification53? DataSetInitiator { get; init; } 
    
    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_7Fa5l9poEeearpaEPXv9UA")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals7> TransactionTotals { get; init; } = [];
    // ID for the above is _7Fa5l9poEeearpaEPXv9UA
    
    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_7Fa5mdpoEeearpaEPXv9UA")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData7? CommonData { get; init; } 
    
    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_7Fa5m9poEeearpaEPXv9UA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction6Choice_> Transaction { get; init; } = [];
    // ID for the above is _7Fa5m9poEeearpaEPXv9UA
    
    
    #nullable disable
    
}
