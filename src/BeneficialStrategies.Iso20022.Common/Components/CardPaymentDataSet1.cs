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
[IsoId("_TDm_yAEcEeCQm6a_G2yO_w_158061117")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_TDm_yQEcEeCQm6a_G2yO_w_345387769")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_TDm_ygEcEeCQm6a_G2yO_w_449079350")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability1? Traceability { get; init; } 
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_TDm_ywEcEeCQm6a_G2yO_w_-548944295")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification32? DataSetInitiator { get; init; } 
    
    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_TDm_zAEcEeCQm6a_G2yO_w_-133329418")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals1> TransactionTotals { get; init; } = [];
    // ID for the above is _TDm_zAEcEeCQm6a_G2yO_w_-133329418
    
    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_TDm_zQEcEeCQm6a_G2yO_w_1682366920")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData1? CommonData { get; init; } 
    
    /// <summary>
    /// Set of transaction to capture.
    /// </summary>
    [IsoId("_TDm_zgEcEeCQm6a_G2yO_w_-7296977")]
    [DisplayName("Transaction To Capture")]
    [IsoXmlTag("TxToCaptr")]
    public CardPaymentDataSetTransaction1? TransactionToCapture { get; init; } 
    
    
    #nullable disable
    
}
