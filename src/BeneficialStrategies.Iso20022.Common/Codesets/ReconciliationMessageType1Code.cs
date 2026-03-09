// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the reconciliation message type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CjGTwC7PEemIy6A-26wnAg")]
[Description(@"Contains the reconciliation message type.")]
[DerivedFrom(typeof(ReconciliationMessageTypeCode))]
public enum ReconciliationMessageType1Code
{
    /// <summary>
    /// Batch Transfer Response
    /// Encoded/decoded by serializers as &quot;BATR&quot;.
    /// </summary>
    [EnumMember(Value = "BATR")]
    [IsoId("_IGu7cS7PEemIy6A-26wnAg")]
    [Description(@"Batch Transfer Response")]
    BatchTransferResponse = ReconciliationMessageTypeCode.BatchTransferResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card Management Initiation
    /// Encoded/decoded by serializers as &quot;CAMI&quot;.
    /// </summary>
    [EnumMember(Value = "CAMI")]
    [IsoId("_IXD2cS7PEemIy6A-26wnAg")]
    [Description(@"Card Management Initiation")]
    CardManagementInitiation = ReconciliationMessageTypeCode.CardManagementInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card Management Response
    /// Encoded/decoded by serializers as &quot;CAMR&quot;.
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_IagMAS7PEemIy6A-26wnAg")]
    [Description(@"Card Management Response")]
    CardManagementResponse = ReconciliationMessageTypeCode.CardManagementResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Chargeback Initiation
    /// Encoded/decoded by serializers as &quot;CGBI&quot;.
    /// </summary>
    [EnumMember(Value = "CGBI")]
    [IsoId("_Id-WwS7PEemIy6A-26wnAg")]
    [Description(@"Chargeback Initiation")]
    ChargebackInitiation = ReconciliationMessageTypeCode.ChargebackInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Chargeback Response
    /// Encoded/decoded by serializers as &quot;CGBR&quot;.
    /// </summary>
    [EnumMember(Value = "CGBR")]
    [IsoId("_IhZeMS7PEemIy6A-26wnAg")]
    [Description(@"Chargeback Response")]
    ChargebackResponse = ReconciliationMessageTypeCode.ChargebackResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Error
    /// Encoded/decoded by serializers as &quot;EROR&quot;.
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_Ik3o8S7PEemIy6A-26wnAg")]
    [Description(@"Error")]
    Error = ReconciliationMessageTypeCode.Error, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee Collection Initiation
    /// Encoded/decoded by serializers as &quot;FECI&quot;.
    /// </summary>
    [EnumMember(Value = "FECI")]
    [IsoId("_IowDYS7PEemIy6A-26wnAg")]
    [Description(@"Fee Collection Initiation")]
    FeeCollectionInitiation = ReconciliationMessageTypeCode.FeeCollectionInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee Collection Response
    /// Encoded/decoded by serializers as &quot;FECR&quot;.
    /// </summary>
    [EnumMember(Value = "FECR")]
    [IsoId("_IsQDUS7PEemIy6A-26wnAg")]
    [Description(@"Fee Collection Response")]
    FeeCollectionResponse = ReconciliationMessageTypeCode.FeeCollectionResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// File Action Initiation
    /// Encoded/decoded by serializers as &quot;FIAI&quot;.
    /// </summary>
    [EnumMember(Value = "FIAI")]
    [IsoId("_IvwDQS7PEemIy6A-26wnAg")]
    [Description(@"File Action Initiation")]
    FileActionInitiation = ReconciliationMessageTypeCode.FileActionInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// File Action Response
    /// Encoded/decoded by serializers as &quot;FIAR&quot;.
    /// </summary>
    [EnumMember(Value = "FIAR")]
    [IsoId("_IzfTwS7PEemIy6A-26wnAg")]
    [Description(@"File Action Response")]
    FileActionResponse = ReconciliationMessageTypeCode.FileActionResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial Response
    /// Encoded/decoded by serializers as &quot;FINR&quot;.
    /// </summary>
    [EnumMember(Value = "FINR")]
    [IsoId("_I9QTwS7PEemIy6A-26wnAg")]
    [Description(@"Financial Response")]
    FinancialResponse = ReconciliationMessageTypeCode.FinancialResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial Initiation
    /// Encoded/decoded by serializers as &quot;FINI&quot;.
    /// </summary>
    [EnumMember(Value = "FINI")]
    [IsoId("_JOZuIS7PEemIy6A-26wnAg")]
    [Description(@"Financial Initiation")]
    FinancialInitiation = ReconciliationMessageTypeCode.FinancialInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fraud Disposition Initiation
    /// Encoded/decoded by serializers as &quot;FRDI&quot;.
    /// </summary>
    [EnumMember(Value = "FRDI")]
    [IsoId("_JeeKcS7PEemIy6A-26wnAg")]
    [Description(@"Fraud Disposition Initiation")]
    FraudDispositionInitiation = ReconciliationMessageTypeCode.FraudDispositionInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fraud Disposition Response
    /// Encoded/decoded by serializers as &quot;FRDR&quot;.
    /// </summary>
    [EnumMember(Value = "FRDR")]
    [IsoId("_JkbogS7PEemIy6A-26wnAg")]
    [Description(@"Fraud Disposition Response")]
    FraudDispositionResponse = ReconciliationMessageTypeCode.FraudDispositionResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fraud Reporting Initiation
    /// Encoded/decoded by serializers as &quot;FRRI&quot;.
    /// </summary>
    [EnumMember(Value = "FRRI")]
    [IsoId("_Jn-EsS7PEemIy6A-26wnAg")]
    [Description(@"Fraud Reporting Initiation")]
    FraudReportingInitiation = ReconciliationMessageTypeCode.FraudReportingInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fraud Reporting Response
    /// Encoded/decoded by serializers as &quot;FRRR&quot;.
    /// </summary>
    [EnumMember(Value = "FRRR")]
    [IsoId("_Jrw_kS7PEemIy6A-26wnAg")]
    [Description(@"Fraud Reporting Response")]
    FraudReportingResponse = ReconciliationMessageTypeCode.FraudReportingResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Inquiry Initiation
    /// Encoded/decoded by serializers as &quot;INQI&quot;.
    /// </summary>
    [EnumMember(Value = "INQI")]
    [IsoId("_JvV4AS7PEemIy6A-26wnAg")]
    [Description(@"Inquiry Initiation")]
    InquiryInitiation = ReconciliationMessageTypeCode.InquiryInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Inquiry Response
    /// Encoded/decoded by serializers as &quot;INQR&quot;.
    /// </summary>
    [EnumMember(Value = "INQR")]
    [IsoId("_Jy3tIS7PEemIy6A-26wnAg")]
    [Description(@"Inquiry Response")]
    InquiryResponse = ReconciliationMessageTypeCode.InquiryResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key Exchange Initiation
    /// Encoded/decoded by serializers as &quot;KYEI&quot;.
    /// </summary>
    [EnumMember(Value = "KYEI")]
    [IsoId("_J9dMgS7PEemIy6A-26wnAg")]
    [Description(@"Key Exchange Initiation")]
    KeyExchangeInitiation = ReconciliationMessageTypeCode.KeyExchangeInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key Exchange Response
    /// Encoded/decoded by serializers as &quot;KYER&quot;.
    /// </summary>
    [EnumMember(Value = "KYER")]
    [IsoId("_KBTKsS7PEemIy6A-26wnAg")]
    [Description(@"Key Exchange Response")]
    KeyExchangeResponse = ReconciliationMessageTypeCode.KeyExchangeResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Network Management Initiation.
    /// Encoded/decoded by serializers as &quot;NWMI&quot;.
    /// </summary>
    [EnumMember(Value = "NWMI")]
    [IsoId("_KEzKoS7PEemIy6A-26wnAg")]
    [Description(@"Network Management Initiation.")]
    NetworkManagementInitiation = ReconciliationMessageTypeCode.NetworkManagementInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Network Management Response
    /// Encoded/decoded by serializers as &quot;NWMR&quot;.
    /// </summary>
    [EnumMember(Value = "NWMR")]
    [IsoId("_KKgxES7PEemIy6A-26wnAg")]
    [Description(@"Network Management Response")]
    NetworkManagementResponse = ReconciliationMessageTypeCode.NetworkManagementResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reconciliation Initiation
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_KOB_IS7PEemIy6A-26wnAg")]
    [Description(@"Reconciliation Initiation")]
    ReconciliationInitiation = ReconciliationMessageTypeCode.ReconciliationInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reconciliation Response
    /// Encoded/decoded by serializers as &quot;RECR&quot;.
    /// </summary>
    [EnumMember(Value = "RECR")]
    [IsoId("_KRoswS7PEemIy6A-26wnAg")]
    [Description(@"Reconciliation Response")]
    ReconciliationResponse = ReconciliationMessageTypeCode.ReconciliationResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Retrieval Fulfilment Initiation
    /// Encoded/decoded by serializers as &quot;RTFI&quot;.
    /// </summary>
    [EnumMember(Value = "RTFI")]
    [IsoId("_KZKRES7PEemIy6A-26wnAg")]
    [Description(@"Retrieval Fulfilment Initiation")]
    RetrievalFulfilmentInitiation = ReconciliationMessageTypeCode.RetrievalFulfilmentInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Retrieval Fulfilment Response
    /// Encoded/decoded by serializers as &quot;RTFR&quot;.
    /// </summary>
    [EnumMember(Value = "RTFR")]
    [IsoId("_Kcyz4S7PEemIy6A-26wnAg")]
    [Description(@"Retrieval Fulfilment Response")]
    RetrievalFulfilmentResponse = ReconciliationMessageTypeCode.RetrievalFulfilmentResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Retrieval Request
    /// Encoded/decoded by serializers as &quot;RTRR&quot;.
    /// </summary>
    [EnumMember(Value = "RTRR")]
    [IsoId("_KgUpAS7PEemIy6A-26wnAg")]
    [Description(@"Retrieval Request")]
    RetrievalRequest = ReconciliationMessageTypeCode.RetrievalRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Retrieval Response
    /// Encoded/decoded by serializers as &quot;RTRI&quot;.
    /// </summary>
    [EnumMember(Value = "RTRI")]
    [IsoId("_Kjw-kS7PEemIy6A-26wnAg")]
    [Description(@"Retrieval Response")]
    RetrievalResponse = ReconciliationMessageTypeCode.RetrievalResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal Initiation
    /// Encoded/decoded by serializers as &quot;REVI&quot;.
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_KnPJUS7PEemIy6A-26wnAg")]
    [Description(@"Reversal Initiation")]
    ReversalInitiation = ReconciliationMessageTypeCode.ReversalInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal Response
    /// Encoded/decoded by serializers as &quot;REVR&quot;.
    /// </summary>
    [EnumMember(Value = "REVR")]
    [IsoId("_KrDSUS7PEemIy6A-26wnAg")]
    [Description(@"Reversal Response")]
    ReversalResponse = ReconciliationMessageTypeCode.ReversalResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement Reporting Initiation
    /// Encoded/decoded by serializers as &quot;SERI&quot;.
    /// </summary>
    [EnumMember(Value = "SERI")]
    [IsoId("_KujSQS7PEemIy6A-26wnAg")]
    [Description(@"Settlement Reporting Initiation")]
    SettlementReportingInitiation = ReconciliationMessageTypeCode.SettlementReportingInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement Reporting Response
    /// Encoded/decoded by serializers as &quot;SERR&quot;.
    /// </summary>
    [EnumMember(Value = "SERR")]
    [IsoId("_Kx_AwS7PEemIy6A-26wnAg")]
    [Description(@"Settlement Reporting Response")]
    SettlementReportingResponse = ReconciliationMessageTypeCode.SettlementReportingResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification Initiation.
    /// Encoded/decoded by serializers as &quot;VERI&quot;.
    /// </summary>
    [EnumMember(Value = "VERI")]
    [IsoId("_K1dLgS7PEemIy6A-26wnAg")]
    [Description(@"Verification Initiation.")]
    VerificationInitiation = ReconciliationMessageTypeCode.VerificationInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification Response
    /// Encoded/decoded by serializers as &quot;VERR&quot;.
    /// </summary>
    [EnumMember(Value = "VERR")]
    [IsoId("_LGM9QS7PEemIy6A-26wnAg")]
    [Description(@"Verification Response")]
    VerificationResponse = ReconciliationMessageTypeCode.VerificationResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amendment
    /// Encoded/decoded by serializers as &quot;AMDT&quot;.
    /// </summary>
    [EnumMember(Value = "AMDT")]
    [IsoId("_HQVeoRqSEeqH1IQNpbVpEw")]
    [Description(@"Amendment")]
    Amendment = ReconciliationMessageTypeCode.Amendment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authorisation Initiation
    /// Encoded/decoded by serializers as &quot;ATHI&quot;.
    /// </summary>
    [EnumMember(Value = "ATHI")]
    [IsoId("_HXxjYRqSEeqH1IQNpbVpEw")]
    [Description(@"Authorisation Initiation")]
    AuthorisationInitiation = ReconciliationMessageTypeCode.AuthorisationInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authorisation Response
    /// Encoded/decoded by serializers as &quot;ATHR&quot;.
    /// </summary>
    [EnumMember(Value = "ATHR")]
    [IsoId("_HiovkRqSEeqH1IQNpbVpEw")]
    [Description(@"Authorisation Response")]
    AuthorisationResponse = ReconciliationMessageTypeCode.AuthorisationResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Batch Management Initiation
    /// Encoded/decoded by serializers as &quot;BAMI&quot;.
    /// </summary>
    [EnumMember(Value = "BAMI")]
    [IsoId("_HxN-IRqSEeqH1IQNpbVpEw")]
    [Description(@"Batch Management Initiation")]
    BatchManagementInitiation = ReconciliationMessageTypeCode.BatchManagementInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Batch Management Response
    /// Encoded/decoded by serializers as &quot;BAMR&quot;.
    /// </summary>
    [EnumMember(Value = "BAMR")]
    [IsoId("_H-T-8RqSEeqH1IQNpbVpEw")]
    [Description(@"Batch Management Response")]
    BatchManagementResponse = ReconciliationMessageTypeCode.BatchManagementResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Batch Transfer Initiation
    /// Encoded/decoded by serializers as &quot;BATI&quot;.
    /// </summary>
    [EnumMember(Value = "BATI")]
    [IsoId("_IJeGERqSEeqH1IQNpbVpEw")]
    [Description(@"Batch Transfer Initiation")]
    BatchTransferInitiation = ReconciliationMessageTypeCode.BatchTransferInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Addendum initiation
    /// Encoded/decoded by serializers as &quot;ADDI&quot;.
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_mkVGARqSEeqH1IQNpbVpEw")]
    [Description(@"Addendum initiation")]
    AddendumInitiation = ReconciliationMessageTypeCode.AddendumInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Addendum response
    /// Encoded/decoded by serializers as &quot;ADDR&quot;.
    /// </summary>
    [EnumMember(Value = "ADDR")]
    [IsoId("_mtZicRqSEeqH1IQNpbVpEw")]
    [Description(@"Addendum response")]
    AddendumResponse = ReconciliationMessageTypeCode.AddendumResponse, // same ordinal as derivation source for type conversions
    
}
