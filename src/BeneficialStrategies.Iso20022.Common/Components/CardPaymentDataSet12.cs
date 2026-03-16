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
[IsoId("_FNaCgWmaEeSQ1udc47rf0A")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet12
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_FbHuYWmaEeSQ1udc47rf0A")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification1 DataSetIdentification { get; init; }

    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_FbHuY2maEeSQ1udc47rf0A")]
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType1 DataSetResult { get; init; }

    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_FbHuZWmaEeSQ1udc47rf0A")]
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; }

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_FbHuZ2maEeSQ1udc47rf0A")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification53? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_FbHuaWmaEeSQ1udc47rf0A")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals3> TransactionTotals { get; init; } = [];

    // ID for the above is _FbHuaWmaEeSQ1udc47rf0A

    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_FbHua2maEeSQ1udc47rf0A")]
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public CardPaymentDataSet11? RejectedTransaction { get; init; }
}
