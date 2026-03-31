// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the reconciliation type
/// </summary>
[DataContract]
[Serializable]
[IsoId("_E0Tvl8yyEeiqqJhU2tqK8A")]
[Description(@"Contains the reconciliation type")]
[Derivations(typeof(ReconciliationMessageType1Code), typeof(ReconciliationMessageType2Code))]
public enum ReconciliationMessageTypeCode
{
    /// <summary>
    /// Batch Transfer Response
    /// Encoded/decoded by serializers as &quot;BATR&quot;.
    /// </summary>
    [EnumMember(Value = "BATR")]
    [IsoId("_E0TvmMyyEeiqqJhU2tqK8A")]
    [Description(@"Batch Transfer Response")]
    BatchTransferResponse,

    /// <summary>
    /// Card Management Response
    /// Encoded/decoded by serializers as &quot;CAMR&quot;.
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_E0TvmcyyEeiqqJhU2tqK8A")]
    [Description(@"Card Management Response")]
    CardManagementResponse,

    /// <summary>
    /// Batch Transfer Initiation
    /// Encoded/decoded by serializers as &quot;BATI&quot;.
    /// </summary>
    [EnumMember(Value = "BATI")]
    [IsoId("_E0TvncyyEeiqqJhU2tqK8A")]
    [Description(@"Batch Transfer Initiation")]
    BatchTransferInitiation,

    /// <summary>
    /// Card Management Initiation
    /// Encoded/decoded by serializers as &quot;CAMI&quot;.
    /// </summary>
    [EnumMember(Value = "CAMI")]
    [IsoId("_E0Tvm8yyEeiqqJhU2tqK8A")]
    [Description(@"Card Management Initiation")]
    CardManagementInitiation,

    /// <summary>
    /// Amendment
    /// Encoded/decoded by serializers as &quot;AMDT&quot;.
    /// </summary>
    [EnumMember(Value = "AMDT")]
    [IsoId("_hBsMYM5UEeiEmaZryQQ14Q")]
    [Description(@"Amendment")]
    Amendment,

    /// <summary>
    /// Authorisation Initiation
    /// Encoded/decoded by serializers as &quot;ATHI&quot;.
    /// </summary>
    [EnumMember(Value = "ATHI")]
    [IsoId("_zETdQM5UEeiEmaZryQQ14Q")]
    [Description(@"Authorisation Initiation")]
    AuthorisationInitiation,

    /// <summary>
    /// Authorisation Response
    /// Encoded/decoded by serializers as &quot;ATHR&quot;.
    /// </summary>
    [EnumMember(Value = "ATHR")]
    [IsoId("_4DPccM5UEeiEmaZryQQ14Q")]
    [Description(@"Authorisation Response")]
    AuthorisationResponse,

    /// <summary>
    /// Batch Management Initiation
    /// Encoded/decoded by serializers as &quot;BAMI&quot;.
    /// </summary>
    [EnumMember(Value = "BAMI")]
    [IsoId("_Ik87QM5VEeiEmaZryQQ14Q")]
    [Description(@"Batch Management Initiation")]
    BatchManagementInitiation,

    /// <summary>
    /// Batch Management Response
    /// Encoded/decoded by serializers as &quot;BAMR&quot;.
    /// </summary>
    [EnumMember(Value = "BAMR")]
    [IsoId("_IvFHoM5VEeiEmaZryQQ14Q")]
    [Description(@"Batch Management Response")]
    BatchManagementResponse,

    /// <summary>
    /// Chargeback Initiation
    /// Encoded/decoded by serializers as &quot;CGBI&quot;.
    /// </summary>
    [EnumMember(Value = "CGBI")]
    [IsoId("_r5PvUM5VEeiEmaZryQQ14Q")]
    [Description(@"Chargeback Initiation")]
    ChargebackInitiation,

    /// <summary>
    /// Chargeback Response
    /// Encoded/decoded by serializers as &quot;CGBR&quot;.
    /// </summary>
    [EnumMember(Value = "CGBR")]
    [IsoId("_vcl6QM5VEeiEmaZryQQ14Q")]
    [Description(@"Chargeback Response")]
    ChargebackResponse,

    /// <summary>
    /// Error
    /// Encoded/decoded by serializers as &quot;EROR&quot;.
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_2v5IwM5VEeiEmaZryQQ14Q")]
    [Description(@"Error")]
    Error,

    /// <summary>
    /// Fee Collection Initiation
    /// Encoded/decoded by serializers as &quot;FECI&quot;.
    /// </summary>
    [EnumMember(Value = "FECI")]
    [IsoId("_26Rz0M5VEeiEmaZryQQ14Q")]
    [Description(@"Fee Collection Initiation")]
    FeeCollectionInitiation,

    /// <summary>
    /// Fee Collection Response
    /// Encoded/decoded by serializers as &quot;FECR&quot;.
    /// </summary>
    [EnumMember(Value = "FECR")]
    [IsoId("_6j4-0M5VEeiEmaZryQQ14Q")]
    [Description(@"Fee Collection Response")]
    FeeCollectionResponse,

    /// <summary>
    /// File Action Initiation
    /// Encoded/decoded by serializers as &quot;FIAI&quot;.
    /// </summary>
    [EnumMember(Value = "FIAI")]
    [IsoId("_Au5vkM5WEeiEmaZryQQ14Q")]
    [Description(@"File Action Initiation")]
    FileActionInitiation,

    /// <summary>
    /// File Action Response
    /// Encoded/decoded by serializers as &quot;FIAR&quot;.
    /// </summary>
    [EnumMember(Value = "FIAR")]
    [IsoId("_A0VpMM5WEeiEmaZryQQ14Q")]
    [Description(@"File Action Response")]
    FileActionResponse,

    /// <summary>
    /// Inquiry Initiation
    /// Encoded/decoded by serializers as &quot;INQI&quot;.
    /// </summary>
    [EnumMember(Value = "INQI")]
    [IsoId("_GwcbQM5WEeiEmaZryQQ14Q")]
    [Description(@"Inquiry Initiation")]
    InquiryInitiation,

    /// <summary>
    /// Inquiry Response
    /// Encoded/decoded by serializers as &quot;INQR&quot;.
    /// </summary>
    [EnumMember(Value = "INQR")]
    [IsoId("_GzV-QM5WEeiEmaZryQQ14Q")]
    [Description(@"Inquiry Response")]
    InquiryResponse,

    /// <summary>
    /// Fraud Reporting Initiation
    /// Encoded/decoded by serializers as &quot;FRRI&quot;.
    /// </summary>
    [EnumMember(Value = "FRRI")]
    [IsoId("_G8470M5WEeiEmaZryQQ14Q")]
    [Description(@"Fraud Reporting Initiation")]
    FraudReportingInitiation,

    /// <summary>
    /// Fraud Reporting Response
    /// Encoded/decoded by serializers as &quot;FRRR&quot;.
    /// </summary>
    [EnumMember(Value = "FRRR")]
    [IsoId("_IzKg8M5WEeiEmaZryQQ14Q")]
    [Description(@"Fraud Reporting Response")]
    FraudReportingResponse,

    /// <summary>
    /// Fraud Disposition Initiation
    /// Encoded/decoded by serializers as &quot;FRDI&quot;.
    /// </summary>
    [EnumMember(Value = "FRDI")]
    [IsoId("_I9x1gM5WEeiEmaZryQQ14Q")]
    [Description(@"Fraud Disposition Initiation")]
    FraudDispositionInitiation,

    /// <summary>
    /// Fraud Disposition Response
    /// Encoded/decoded by serializers as &quot;FRDR&quot;.
    /// </summary>
    [EnumMember(Value = "FRDR")]
    [IsoId("_Jn6XoM5WEeiEmaZryQQ14Q")]
    [Description(@"Fraud Disposition Response")]
    FraudDispositionResponse,

    /// <summary>
    /// Financial Initiation
    /// Encoded/decoded by serializers as &quot;FINI&quot;.
    /// </summary>
    [EnumMember(Value = "FINI")]
    [IsoId("_Juqf4M5WEeiEmaZryQQ14Q")]
    [Description(@"Financial Initiation")]
    FinancialInitiation,

    /// <summary>
    /// Financial Response
    /// Encoded/decoded by serializers as &quot;FINR&quot;.
    /// </summary>
    [EnumMember(Value = "FINR")]
    [IsoId("_J6J-MM5WEeiEmaZryQQ14Q")]
    [Description(@"Financial Response")]
    FinancialResponse,

    /// <summary>
    /// Key Exchange Initiation
    /// Encoded/decoded by serializers as &quot;KYEI&quot;.
    /// </summary>
    [EnumMember(Value = "KYEI")]
    [IsoId("_sZHFsM5WEeiEmaZryQQ14Q")]
    [Description(@"Key Exchange Initiation")]
    KeyExchangeInitiation,

    /// <summary>
    /// Key Exchange Response
    /// Encoded/decoded by serializers as &quot;KYER&quot;.
    /// </summary>
    [EnumMember(Value = "KYER")]
    [IsoId("_sb7wMM5WEeiEmaZryQQ14Q")]
    [Description(@"Key Exchange Response")]
    KeyExchangeResponse,

    /// <summary>
    /// Verification Initiation.
    /// Encoded/decoded by serializers as &quot;VERI&quot;.
    /// </summary>
    [EnumMember(Value = "VERI")]
    [IsoId("_5Sd9wM5WEeiEmaZryQQ14Q")]
    [Description(@"Verification Initiation.")]
    VerificationInitiation,

    /// <summary>
    /// Verification Response
    /// Encoded/decoded by serializers as &quot;VERR&quot;.
    /// </summary>
    [EnumMember(Value = "VERR")]
    [IsoId("_5Sek0M5WEeiEmaZryQQ14Q")]
    [Description(@"Verification Response")]
    VerificationResponse,

    /// <summary>
    /// Settlement Reporting Initiation
    /// Encoded/decoded by serializers as &quot;SERI&quot;.
    /// </summary>
    [EnumMember(Value = "SERI")]
    [IsoId("_5St1YM5WEeiEmaZryQQ14Q")]
    [Description(@"Settlement Reporting Initiation")]
    SettlementReportingInitiation,

    /// <summary>
    /// Settlement Reporting Response
    /// Encoded/decoded by serializers as &quot;SERR&quot;.
    /// </summary>
    [EnumMember(Value = "SERR")]
    [IsoId("_5Vy-kM5WEeiEmaZryQQ14Q")]
    [Description(@"Settlement Reporting Response")]
    SettlementReportingResponse,

    /// <summary>
    /// Reversal Initiation
    /// Encoded/decoded by serializers as &quot;REVI&quot;.
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_5VzloM5WEeiEmaZryQQ14Q")]
    [Description(@"Reversal Initiation")]
    ReversalInitiation,

    /// <summary>
    /// Reversal Response
    /// Encoded/decoded by serializers as &quot;REVR&quot;.
    /// </summary>
    [EnumMember(Value = "REVR")]
    [IsoId("_5YftQM5WEeiEmaZryQQ14Q")]
    [Description(@"Reversal Response")]
    ReversalResponse,

    /// <summary>
    /// Retrieval Response
    /// Encoded/decoded by serializers as &quot;RTRI&quot;.
    /// </summary>
    [EnumMember(Value = "RTRI")]
    [IsoId("_5YftQc5WEeiEmaZryQQ14Q")]
    [Description(@"Retrieval Response")]
    RetrievalResponse,

    /// <summary>
    /// Retrieval Request
    /// Encoded/decoded by serializers as &quot;RTRR&quot;.
    /// </summary>
    [EnumMember(Value = "RTRR")]
    [IsoId("_5a6vIM5WEeiEmaZryQQ14Q")]
    [Description(@"Retrieval Request")]
    RetrievalRequest,

    /// <summary>
    /// Retrieval Fulfilment Initiation
    /// Encoded/decoded by serializers as &quot;RTFI&quot;.
    /// </summary>
    [EnumMember(Value = "RTFI")]
    [IsoId("_5a7WMM5WEeiEmaZryQQ14Q")]
    [Description(@"Retrieval Fulfilment Initiation")]
    RetrievalFulfilmentInitiation,

    /// <summary>
    /// Retrieval Fulfilment Response
    /// Encoded/decoded by serializers as &quot;RTFR&quot;.
    /// </summary>
    [EnumMember(Value = "RTFR")]
    [IsoId("_5d81AM5WEeiEmaZryQQ14Q")]
    [Description(@"Retrieval Fulfilment Response")]
    RetrievalFulfilmentResponse,

    /// <summary>
    /// Reconciliation Initiation
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_5gS-YM5WEeiEmaZryQQ14Q")]
    [Description(@"Reconciliation Initiation")]
    ReconciliationInitiation,

    /// <summary>
    /// Reconciliation Response
    /// Encoded/decoded by serializers as &quot;RECR&quot;.
    /// </summary>
    [EnumMember(Value = "RECR")]
    [IsoId("_5inSkM5WEeiEmaZryQQ14Q")]
    [Description(@"Reconciliation Response")]
    ReconciliationResponse,

    /// <summary>
    /// Network Management Initiation.
    /// Encoded/decoded by serializers as &quot;NWMI&quot;.
    /// </summary>
    [EnumMember(Value = "NWMI")]
    [IsoId("_5in5oM5WEeiEmaZryQQ14Q")]
    [Description(@"Network Management Initiation.")]
    NetworkManagementInitiation,

    /// <summary>
    /// Network Management Response
    /// Encoded/decoded by serializers as &quot;NWMR&quot;.
    /// </summary>
    [EnumMember(Value = "NWMR")]
    [IsoId("_5k_4MM5WEeiEmaZryQQ14Q")]
    [Description(@"Network Management Response")]
    NetworkManagementResponse,

    /// <summary>
    /// Addendum initiation
    /// Encoded/decoded by serializers as &quot;ADDI&quot;.
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_PnU-wBqSEeqH1IQNpbVpEw")]
    [Description(@"Addendum initiation")]
    AddendumInitiation,

    /// <summary>
    /// Addendum response
    /// Encoded/decoded by serializers as &quot;ADDR&quot;.
    /// </summary>
    [EnumMember(Value = "ADDR")]
    [IsoId("_eQKQYBqSEeqH1IQNpbVpEw")]
    [Description(@"Addendum response")]
    AddendumResponse,

    /// <summary>
    /// Retrieval Initiation Message
    /// Encoded/decoded by serializers as &quot;RTVI&quot;.
    /// </summary>
    [EnumMember(Value = "RTVI")]
    [IsoId("_k7ul0C3iEeyg-aG5nXcnfg")]
    [Description(@"Retrieval Initiation Message")]
    RetrievalInitiation,
}
