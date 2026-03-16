// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the reconciliation message type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ek0aUSB4Eey8XKHwKquEQw")]
[Description(@"Contains the reconciliation message type.")]
[DerivedFrom(typeof(ReconciliationMessageTypeCode))]
public enum ReconciliationMessageType2Code
{
    /// <summary>
    /// Batch Transfer Response
    /// Encoded/decoded by serializers as &quot;BATR&quot;.
    /// </summary>
    [EnumMember(Value = "BATR")]
    [IsoId("_ErhfQSB4Eey8XKHwKquEQw")]
    [Description(@"Batch Transfer Response")]
    BatchTransferResponse = ReconciliationMessageTypeCode.BatchTransferResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card Management Initiation
    /// Encoded/decoded by serializers as &quot;CAMI&quot;.
    /// </summary>
    [EnumMember(Value = "CAMI")]
    [IsoId("_ErhfQyB4Eey8XKHwKquEQw")]
    [Description(@"Card Management Initiation")]
    CardManagementInitiation = ReconciliationMessageTypeCode.CardManagementInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card Management Response
    /// Encoded/decoded by serializers as &quot;CAMR&quot;.
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_ErhfRSB4Eey8XKHwKquEQw")]
    [Description(@"Card Management Response")]
    CardManagementResponse = ReconciliationMessageTypeCode.CardManagementResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Chargeback Initiation
    /// Encoded/decoded by serializers as &quot;CGBI&quot;.
    /// </summary>
    [EnumMember(Value = "CGBI")]
    [IsoId("_ErhfRyB4Eey8XKHwKquEQw")]
    [Description(@"Chargeback Initiation")]
    ChargebackInitiation = ReconciliationMessageTypeCode.ChargebackInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Chargeback Response
    /// Encoded/decoded by serializers as &quot;CGBR&quot;.
    /// </summary>
    [EnumMember(Value = "CGBR")]
    [IsoId("_ErhfSSB4Eey8XKHwKquEQw")]
    [Description(@"Chargeback Response")]
    ChargebackResponse = ReconciliationMessageTypeCode.ChargebackResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Error
    /// Encoded/decoded by serializers as &quot;EROR&quot;.
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_ErhfSyB4Eey8XKHwKquEQw")]
    [Description(@"Error")]
    Error = ReconciliationMessageTypeCode.Error, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee Collection Initiation
    /// Encoded/decoded by serializers as &quot;FECI&quot;.
    /// </summary>
    [EnumMember(Value = "FECI")]
    [IsoId("_ErhfTSB4Eey8XKHwKquEQw")]
    [Description(@"Fee Collection Initiation")]
    FeeCollectionInitiation = ReconciliationMessageTypeCode.FeeCollectionInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee Collection Response
    /// Encoded/decoded by serializers as &quot;FECR&quot;.
    /// </summary>
    [EnumMember(Value = "FECR")]
    [IsoId("_ErhfTyB4Eey8XKHwKquEQw")]
    [Description(@"Fee Collection Response")]
    FeeCollectionResponse = ReconciliationMessageTypeCode.FeeCollectionResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File Action Initiation
    /// Encoded/decoded by serializers as &quot;FIAI&quot;.
    /// </summary>
    [EnumMember(Value = "FIAI")]
    [IsoId("_ErhfUSB4Eey8XKHwKquEQw")]
    [Description(@"File Action Initiation")]
    FileActionInitiation = ReconciliationMessageTypeCode.FileActionInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File Action Response
    /// Encoded/decoded by serializers as &quot;FIAR&quot;.
    /// </summary>
    [EnumMember(Value = "FIAR")]
    [IsoId("_ErhfUyB4Eey8XKHwKquEQw")]
    [Description(@"File Action Response")]
    FileActionResponse = ReconciliationMessageTypeCode.FileActionResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial Response
    /// Encoded/decoded by serializers as &quot;FINR&quot;.
    /// </summary>
    [EnumMember(Value = "FINR")]
    [IsoId("_ErhfVSB4Eey8XKHwKquEQw")]
    [Description(@"Financial Response")]
    FinancialResponse = ReconciliationMessageTypeCode.FinancialResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial Initiation
    /// Encoded/decoded by serializers as &quot;FINI&quot;.
    /// </summary>
    [EnumMember(Value = "FINI")]
    [IsoId("_ErhfVyB4Eey8XKHwKquEQw")]
    [Description(@"Financial Initiation")]
    FinancialInitiation = ReconciliationMessageTypeCode.FinancialInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraud Disposition Initiation
    /// Encoded/decoded by serializers as &quot;FRDI&quot;.
    /// </summary>
    [EnumMember(Value = "FRDI")]
    [IsoId("_ErhfWSB4Eey8XKHwKquEQw")]
    [Description(@"Fraud Disposition Initiation")]
    FraudDispositionInitiation = ReconciliationMessageTypeCode.FraudDispositionInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraud Disposition Response
    /// Encoded/decoded by serializers as &quot;FRDR&quot;.
    /// </summary>
    [EnumMember(Value = "FRDR")]
    [IsoId("_ErhfWyB4Eey8XKHwKquEQw")]
    [Description(@"Fraud Disposition Response")]
    FraudDispositionResponse = ReconciliationMessageTypeCode.FraudDispositionResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraud Reporting Initiation
    /// Encoded/decoded by serializers as &quot;FRRI&quot;.
    /// </summary>
    [EnumMember(Value = "FRRI")]
    [IsoId("_ErhfXSB4Eey8XKHwKquEQw")]
    [Description(@"Fraud Reporting Initiation")]
    FraudReportingInitiation = ReconciliationMessageTypeCode.FraudReportingInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraud Reporting Response
    /// Encoded/decoded by serializers as &quot;FRRR&quot;.
    /// </summary>
    [EnumMember(Value = "FRRR")]
    [IsoId("_ErhfXyB4Eey8XKHwKquEQw")]
    [Description(@"Fraud Reporting Response")]
    FraudReportingResponse = ReconciliationMessageTypeCode.FraudReportingResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inquiry Initiation
    /// Encoded/decoded by serializers as &quot;INQI&quot;.
    /// </summary>
    [EnumMember(Value = "INQI")]
    [IsoId("_ErhfYSB4Eey8XKHwKquEQw")]
    [Description(@"Inquiry Initiation")]
    InquiryInitiation = ReconciliationMessageTypeCode.InquiryInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inquiry Response
    /// Encoded/decoded by serializers as &quot;INQR&quot;.
    /// </summary>
    [EnumMember(Value = "INQR")]
    [IsoId("_ErhfYyB4Eey8XKHwKquEQw")]
    [Description(@"Inquiry Response")]
    InquiryResponse = ReconciliationMessageTypeCode.InquiryResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key Exchange Initiation
    /// Encoded/decoded by serializers as &quot;KYEI&quot;.
    /// </summary>
    [EnumMember(Value = "KYEI")]
    [IsoId("_ErhfZSB4Eey8XKHwKquEQw")]
    [Description(@"Key Exchange Initiation")]
    KeyExchangeInitiation = ReconciliationMessageTypeCode.KeyExchangeInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key Exchange Response
    /// Encoded/decoded by serializers as &quot;KYER&quot;.
    /// </summary>
    [EnumMember(Value = "KYER")]
    [IsoId("_ErhfZyB4Eey8XKHwKquEQw")]
    [Description(@"Key Exchange Response")]
    KeyExchangeResponse = ReconciliationMessageTypeCode.KeyExchangeResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Network Management Initiation.
    /// Encoded/decoded by serializers as &quot;NWMI&quot;.
    /// </summary>
    [EnumMember(Value = "NWMI")]
    [IsoId("_ErhfaSB4Eey8XKHwKquEQw")]
    [Description(@"Network Management Initiation.")]
    NetworkManagementInitiation = ReconciliationMessageTypeCode.NetworkManagementInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Network Management Response
    /// Encoded/decoded by serializers as &quot;NWMR&quot;.
    /// </summary>
    [EnumMember(Value = "NWMR")]
    [IsoId("_ErhfayB4Eey8XKHwKquEQw")]
    [Description(@"Network Management Response")]
    NetworkManagementResponse = ReconciliationMessageTypeCode.NetworkManagementResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reconciliation Initiation
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_ErhfbSB4Eey8XKHwKquEQw")]
    [Description(@"Reconciliation Initiation")]
    ReconciliationInitiation = ReconciliationMessageTypeCode.ReconciliationInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reconciliation Response
    /// Encoded/decoded by serializers as &quot;RECR&quot;.
    /// </summary>
    [EnumMember(Value = "RECR")]
    [IsoId("_ErhfbyB4Eey8XKHwKquEQw")]
    [Description(@"Reconciliation Response")]
    ReconciliationResponse = ReconciliationMessageTypeCode.ReconciliationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Retrieval Fulfilment Initiation
    /// Encoded/decoded by serializers as &quot;RTFI&quot;.
    /// </summary>
    [EnumMember(Value = "RTFI")]
    [IsoId("_ErhfcSB4Eey8XKHwKquEQw")]
    [Description(@"Retrieval Fulfilment Initiation")]
    RetrievalFulfilmentInitiation = ReconciliationMessageTypeCode.RetrievalFulfilmentInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Retrieval Fulfilment Response
    /// Encoded/decoded by serializers as &quot;RTFR&quot;.
    /// </summary>
    [EnumMember(Value = "RTFR")]
    [IsoId("_ErhfcyB4Eey8XKHwKquEQw")]
    [Description(@"Retrieval Fulfilment Response")]
    RetrievalFulfilmentResponse = ReconciliationMessageTypeCode.RetrievalFulfilmentResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Retrieval Response
    /// Encoded/decoded by serializers as &quot;RTRI&quot;.
    /// </summary>
    [EnumMember(Value = "RTRI")]
    [IsoId("_ErhfdyB4Eey8XKHwKquEQw")]
    [Description(@"Retrieval Response")]
    RetrievalResponse = ReconciliationMessageTypeCode.RetrievalResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reversal Initiation
    /// Encoded/decoded by serializers as &quot;REVI&quot;.
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_ErhfeSB4Eey8XKHwKquEQw")]
    [Description(@"Reversal Initiation")]
    ReversalInitiation = ReconciliationMessageTypeCode.ReversalInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reversal Response
    /// Encoded/decoded by serializers as &quot;REVR&quot;.
    /// </summary>
    [EnumMember(Value = "REVR")]
    [IsoId("_EriGUSB4Eey8XKHwKquEQw")]
    [Description(@"Reversal Response")]
    ReversalResponse = ReconciliationMessageTypeCode.ReversalResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement Reporting Initiation
    /// Encoded/decoded by serializers as &quot;SERI&quot;.
    /// </summary>
    [EnumMember(Value = "SERI")]
    [IsoId("_EriGUyB4Eey8XKHwKquEQw")]
    [Description(@"Settlement Reporting Initiation")]
    SettlementReportingInitiation = ReconciliationMessageTypeCode.SettlementReportingInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement Reporting Response
    /// Encoded/decoded by serializers as &quot;SERR&quot;.
    /// </summary>
    [EnumMember(Value = "SERR")]
    [IsoId("_EriGVSB4Eey8XKHwKquEQw")]
    [Description(@"Settlement Reporting Response")]
    SettlementReportingResponse = ReconciliationMessageTypeCode.SettlementReportingResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification Initiation.
    /// Encoded/decoded by serializers as &quot;VERI&quot;.
    /// </summary>
    [EnumMember(Value = "VERI")]
    [IsoId("_EriGVyB4Eey8XKHwKquEQw")]
    [Description(@"Verification Initiation.")]
    VerificationInitiation = ReconciliationMessageTypeCode.VerificationInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification Response
    /// Encoded/decoded by serializers as &quot;VERR&quot;.
    /// </summary>
    [EnumMember(Value = "VERR")]
    [IsoId("_EriGWSB4Eey8XKHwKquEQw")]
    [Description(@"Verification Response")]
    VerificationResponse = ReconciliationMessageTypeCode.VerificationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amendment
    /// Encoded/decoded by serializers as &quot;AMDT&quot;.
    /// </summary>
    [EnumMember(Value = "AMDT")]
    [IsoId("_EriGWyB4Eey8XKHwKquEQw")]
    [Description(@"Amendment")]
    Amendment = ReconciliationMessageTypeCode.Amendment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authorisation Initiation
    /// Encoded/decoded by serializers as &quot;ATHI&quot;.
    /// </summary>
    [EnumMember(Value = "ATHI")]
    [IsoId("_EriGXSB4Eey8XKHwKquEQw")]
    [Description(@"Authorisation Initiation")]
    AuthorisationInitiation = ReconciliationMessageTypeCode.AuthorisationInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authorisation Response
    /// Encoded/decoded by serializers as &quot;ATHR&quot;.
    /// </summary>
    [EnumMember(Value = "ATHR")]
    [IsoId("_EriGXyB4Eey8XKHwKquEQw")]
    [Description(@"Authorisation Response")]
    AuthorisationResponse = ReconciliationMessageTypeCode.AuthorisationResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Batch Management Initiation
    /// Encoded/decoded by serializers as &quot;BAMI&quot;.
    /// </summary>
    [EnumMember(Value = "BAMI")]
    [IsoId("_EriGYSB4Eey8XKHwKquEQw")]
    [Description(@"Batch Management Initiation")]
    BatchManagementInitiation = ReconciliationMessageTypeCode.BatchManagementInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Batch Management Response
    /// Encoded/decoded by serializers as &quot;BAMR&quot;.
    /// </summary>
    [EnumMember(Value = "BAMR")]
    [IsoId("_EriGYyB4Eey8XKHwKquEQw")]
    [Description(@"Batch Management Response")]
    BatchManagementResponse = ReconciliationMessageTypeCode.BatchManagementResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Batch Transfer Initiation
    /// Encoded/decoded by serializers as &quot;BATI&quot;.
    /// </summary>
    [EnumMember(Value = "BATI")]
    [IsoId("_EriGZSB4Eey8XKHwKquEQw")]
    [Description(@"Batch Transfer Initiation")]
    BatchTransferInitiation = ReconciliationMessageTypeCode.BatchTransferInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Addendum initiation
    /// Encoded/decoded by serializers as &quot;ADDI&quot;.
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_EriGZyB4Eey8XKHwKquEQw")]
    [Description(@"Addendum initiation")]
    AddendumInitiation = ReconciliationMessageTypeCode.AddendumInitiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Addendum response
    /// Encoded/decoded by serializers as &quot;ADDR&quot;.
    /// </summary>
    [EnumMember(Value = "ADDR")]
    [IsoId("_EriGaSB4Eey8XKHwKquEQw")]
    [Description(@"Addendum response")]
    AddendumResponse = ReconciliationMessageTypeCode.AddendumResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Retrieval Initiation Message
    /// Encoded/decoded by serializers as &quot;RTVI&quot;.
    /// </summary>
    [EnumMember(Value = "RTVI")]
    [IsoId("_vgp9IS3iEeyg-aG5nXcnfg")]
    [Description(@"Retrieval Initiation Message")]
    RetrievalInitiation = ReconciliationMessageTypeCode.RetrievalInitiation, // same ordinal as derivation source for type conversions
}
