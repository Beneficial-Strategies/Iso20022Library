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
[IsoId("_TDd12AEcEeCQm6a_G2yO_w_1905755664")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_TDd12QEcEeCQm6a_G2yO_w_-646086754")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_TDd12gEcEeCQm6a_G2yO_w_1565121438")]
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType1 DataSetResult { get; init; } 
    
    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_TDd12wEcEeCQm6a_G2yO_w_311897814")]
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; } 
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_TDd13AEcEeCQm6a_G2yO_w_315929733")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification32? DataSetInitiator { get; init; } 
    
    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_TDd13QEcEeCQm6a_G2yO_w_-242186047")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals1> TransactionTotals { get; init; } = new ValueList<TransactionTotals1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _TDd13QEcEeCQm6a_G2yO_w_-242186047
    
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_TDd13gEcEeCQm6a_G2yO_w_-154960259")]
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public CardPaymentDataSet3? RejectedTransaction { get; init; } 
    
    
    #nullable disable
    
}
