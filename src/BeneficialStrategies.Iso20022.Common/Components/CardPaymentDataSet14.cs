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
[IsoId("_4LejsY3VEeWjkqXgn_0Imw")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet14
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_4XaG4Y3VEeWjkqXgn_0Imw")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; }

    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_4XaG443VEeWjkqXgn_0Imw")]
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType5 DataSetResult { get; init; }

    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_4XaG5Y3VEeWjkqXgn_0Imw")]
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; }

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_4XaG543VEeWjkqXgn_0Imw")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification53? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_4XaG6Y3VEeWjkqXgn_0Imw")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals7> TransactionTotals { get; init; } = [];

    // ID for the above is _4XaG6Y3VEeWjkqXgn_0Imw

    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_4XaG643VEeWjkqXgn_0Imw")]
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public CardPaymentDataSet15? RejectedTransaction { get; init; }
}
