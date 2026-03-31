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
[IsoId("_M2on0VICEey4xOoMoOPSJQ")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet31
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_M9jIIVICEey4xOoMoOPSJQ")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; }

    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [IsoId("_M9jII1ICEey4xOoMoOPSJQ")]
    [DisplayName("Data Set Result")]
    [IsoXmlTag("DataSetRslt")]
    public required ResponseType10 DataSetResult { get; init; }

    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_M9jIJVICEey4xOoMoOPSJQ")]
    [DisplayName("Remove Data Set")]
    [IsoXmlTag("RmvDataSet")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; }

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_M9jIJ1ICEey4xOoMoOPSJQ")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification176? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [IsoId("_M9jIKVICEey4xOoMoOPSJQ")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];

    // ID for the above is _M9jIKVICEey4xOoMoOPSJQ

    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [IsoId("_M9jIK1ICEey4xOoMoOPSJQ")]
    [DisplayName("Rejected Transaction")]
    [IsoXmlTag("RjctdTx")]
    public ValueList<CardPaymentDataSet30> RejectedTransaction { get; init; } = [];

    /// <summary>
    /// Transaction in the batch, whose capture has been suspended.
    /// </summary>
    [IsoId("_M9jILVICEey4xOoMoOPSJQ")]
    [DisplayName("Suspended Transaction")]
    [IsoXmlTag("SspdTx")]
    public ValueList<CardPaymentDataSet30> SuspendedTransaction { get; init; } = [];

    /// <summary>
    /// Transaction in the batch, whose capture has been approved after suspension.
    /// </summary>
    [IsoId("_M9jIL1ICEey4xOoMoOPSJQ")]
    [DisplayName("Resumed Approval")]
    [IsoXmlTag("RsmdApprvl")]
    public ValueList<CardPaymentDataSet30> ResumedApproval { get; init; } = [];

    /// <summary>
    /// Transaction in the batch, whose capture has been rejected after suspension.
    /// </summary>
    [IsoId("_M9jIMVICEey4xOoMoOPSJQ")]
    [DisplayName("Resumed Rejection")]
    [IsoXmlTag("RsmdRjctn")]
    public ValueList<CardPaymentDataSet30> ResumedRejection { get; init; } = [];
}
