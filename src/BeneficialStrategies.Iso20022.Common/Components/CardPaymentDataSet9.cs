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
[IsoId("_HKTTsTShEeOnFuyVSIQZKg")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet9
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_HZoJITShEeOnFuyVSIQZKg")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_HZoJIzShEeOnFuyVSIQZKg")]
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType1 DataSetResult { get; init; } 
    
    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_HZoJJTShEeOnFuyVSIQZKg")]
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; } 
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_HZoJJzShEeOnFuyVSIQZKg")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification32? DataSetInitiator { get; init; } 
    
    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_HZoJKTShEeOnFuyVSIQZKg")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals2> TransactionTotals { get; init; } = new ValueList<TransactionTotals2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _HZoJKTShEeOnFuyVSIQZKg
    
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_HZoJKzShEeOnFuyVSIQZKg")]
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public CardPaymentDataSet8? RejectedTransaction { get; init; } 
    
    
    #nullable disable
    
}
