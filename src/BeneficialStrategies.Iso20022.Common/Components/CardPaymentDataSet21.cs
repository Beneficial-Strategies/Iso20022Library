// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the captured set of transactions.
/// </summary>
[IsoId("_mZP3gdtPEee9e6xduATmQg")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet21
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_mimAwdtPEee9e6xduATmQg")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; }

    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_mimAw9tPEee9e6xduATmQg")]
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType5 DataSetResult { get; init; }

    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_mimAxdtPEee9e6xduATmQg")]
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; }

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_mimAx9tPEee9e6xduATmQg")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification53? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_mimAydtPEee9e6xduATmQg")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals7> TransactionTotals { get; init; } = [];

    // ID for the above is _mimAydtPEee9e6xduATmQg

    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_mimAy9tPEee9e6xduATmQg")]
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public ValueList<CardPaymentDataSet20> RejectedTransaction { get; init; } = [];
}
