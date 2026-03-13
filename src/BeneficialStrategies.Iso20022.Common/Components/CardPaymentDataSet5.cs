// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the captured set of transactions.
/// </summary>
[IsoId("_I4-DAQvaEeKzJ69IWwzB9Q")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet5
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_JD-ZIQvaEeKzJ69IWwzB9Q")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_JD-ZJQvaEeKzJ69IWwzB9Q")]
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType1 DataSetResult { get; init; } 
    
    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_JD-ZKQvaEeKzJ69IWwzB9Q")]
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; } 
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_JD-ZLQvaEeKzJ69IWwzB9Q")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification32? DataSetInitiator { get; init; } 
    
    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_JD-ZMQvaEeKzJ69IWwzB9Q")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals2> TransactionTotals { get; init; } = [];
    // ID for the above is _JD-ZMQvaEeKzJ69IWwzB9Q
    
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_JD-ZNQvaEeKzJ69IWwzB9Q")]
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public CardPaymentDataSet6? RejectedTransaction { get; init; } 
    
    
    #nullable disable
    
}
