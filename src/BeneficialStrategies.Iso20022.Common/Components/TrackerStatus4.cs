// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the transaction status to be updated in the tracker.
/// </summary>
[IsoId("_cQn51wSrEeusZ4O-nsxv_w")]
[DisplayName("Tracker Status")]
public record TrackerStatus4
{
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_cRFz4QSrEeusZ4O-nsxv_w")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ExternalPaymentTransactionStatus1Code Status { get; init; }

    /// <summary>
    /// Date for the status.
    /// </summary>
    [IsoId("_cRFz4wSrEeusZ4O-nsxv_w")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public DateAndDateTime2Choice_? Date { get; init; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_cRFz5QSrEeusZ4O-nsxv_w")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public ValueList<PaymentStatusReason1> StatusReason { get; init; } = [];

    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    [IsoId("_cRFz5wSrEeusZ4O-nsxv_w")]
    [DisplayName("Reject Return Reason")]
    [IsoXmlTag("RjctRtrRsn")]
    public ValueList<PaymentRejectReturnReason1> RejectReturnReason { get; init; } = [];

    /// <summary>
    /// Specifies whether the amount information matches the tracker record reference data or not.
    /// </summary>
    [IsoId("_c8NNcASrEeusZ4O-nsxv_w")]
    [DisplayName("Amount Inconsistency")]
    [IsoXmlTag("AmtIncnsstncy")]
    public AmountConsistencyType1Code? AmountInconsistency { get; init; }
}
