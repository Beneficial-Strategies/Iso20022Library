// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external local instrument code in the format of character string with a maximum length of 35 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ame0gdp-Ed-ak6NoX_4Aeg_-1943783063")]
[Description(@"Specifies the external local instrument code in the format of character string with a maximum length of 35 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalLocalInstrumentCode))]
public enum ExternalLocalInstrument1Code
{
    /// <summary>
    /// Transaction is related to a direct debit instruction authorized under a confirmed electronic mandate.
    /// Encoded/decoded by serializers as &quot;DDMC&quot;.
    /// </summary>
    [EnumMember(Value = "DDMC")]
    [IsoId("_tmA1uPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit instruction authorized under a confirmed electronic mandate.")]
    DirectDebitConfirmedElectronicMandate = ExternalLocalInstrumentCode.DirectDebitConfirmedElectronicMandate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a direct debit instruction authorized under a paper based mandate, supported by paper authorization signed by the debtor.
    /// Encoded/decoded by serializers as &quot;DDMP&quot;.
    /// </summary>
    [EnumMember(Value = "DDMP")]
    [IsoId("_tmA1u_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit instruction authorized under a paper based mandate, supported by paper authorization signed by the debtor.")]
    DirectDebitPaperMandateWithPaperAuthorization = ExternalLocalInstrumentCode.DirectDebitPaperMandateWithPaperAuthorization, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a direct debit instruction authorized under an unconfirmed electronic mandate requiring confirmation by the debtor.
    /// Encoded/decoded by serializers as &quot;DDMU&quot;.
    /// </summary>
    [EnumMember(Value = "DDMU")]
    [IsoId("_tmJ_ovRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit instruction authorized under an unconfirmed electronic mandate requiring confirmation by the debtor.")]
    DirectDebitUnconfirmedElectronicMandate = ExternalLocalInstrumentCode.DirectDebitUnconfirmedElectronicMandate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to an Instant Credit Transfer under the rules of the Centrale Bank van Aruba, based on the EPC SCT Inst scheme, with a specific batch time-out delay.
    /// Encoded/decoded by serializers as &quot;BPA&quot;.
    /// </summary>
    [EnumMember(Value = "BPA")]
    [IsoId("_tmJ_pfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an Instant Credit Transfer under the rules of the Centrale Bank van Aruba, based on the EPC SCT Inst scheme, with a specific batch time-out delay.")]
    BatchPaymentsAruba = ExternalLocalInstrumentCode.BatchPaymentsAruba, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to an Instant Credit Transfer under the rules of the Centrale Bank van Aruba, based on the EPC SCT Inst scheme.
    /// Encoded/decoded by serializers as &quot;IPA&quot;.
    /// </summary>
    [EnumMember(Value = "IPA")]
    [IsoId("_tmJ_qPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an Instant Credit Transfer under the rules of the Centrale Bank van Aruba, based on the EPC SCT Inst scheme.")]
    InstantPaymentsAruba = ExternalLocalInstrumentCode.InstantPaymentsAruba, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to credit transfers
    /// Encoded/decoded by serializers as &quot;TRF&quot;.
    /// </summary>
    [EnumMember(Value = "TRF")]
    [IsoId("_tmJ_q_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to credit transfers")]
    CreditTransfers = ExternalLocalInstrumentCode.CreditTransfers, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a direct debit that is not pre authorised (Einzugsermächtigung). 
    /// Encoded/decoded by serializers as &quot;82&quot;.
    /// </summary>
    [EnumMember(Value = "82")]
    [IsoId("_tmTwovRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is not pre authorised (Einzugsermächtigung). ")]
    NonPreauthorisedDirectDebitAT = ExternalLocalInstrumentCode.NonPreauthorisedDirectDebitAT, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a direct debit that is pre authorised (Abbuchungsauftrag). 
    /// Encoded/decoded by serializers as &quot;83&quot;.
    /// </summary>
    [EnumMember(Value = "83")]
    [IsoId("_tmTwpfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is pre authorised (Abbuchungsauftrag). ")]
    PreauthorisedDirectDebitAT = ExternalLocalInstrumentCode.PreauthorisedDirectDebitAT, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to cash per post.|Transaction to ultimate recipient having no bank account. Primary beneficiary is a postal service provider. Funds are paid out by cash. Additional necessary information for address and delivery options need to be attached.|
    /// Encoded/decoded by serializers as &quot;CPP&quot;.
    /// </summary>
    [EnumMember(Value = "CPP")]
    [IsoId("_tmTwqPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to cash per post.|Transaction to ultimate recipient having no bank account. Primary beneficiary is a postal service provider. Funds are paid out by cash. Additional necessary information for address and delivery options need to be attached.|")]
    CashPerPost = ExternalLocalInstrumentCode.CashPerPost, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to returned credit transfers.
    /// Encoded/decoded by serializers as &quot;RTR&quot;.
    /// </summary>
    [EnumMember(Value = "RTR")]
    [IsoId("_tmTwq_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to returned credit transfers.")]
    ReturnedCreditTransfers = ExternalLocalInstrumentCode.ReturnedCreditTransfers, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to truncated credit transfers.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process..The original instrument rules are retained throughout the life of the instrument.|Transaction triggered by specific marked and populated paper slip.|Reconciliation reference is secured by check digits supporting secure optical recognition. All other remittance information is truncated prior transmission.|
    /// Encoded/decoded by serializers as &quot;GST&quot;.
    /// </summary>
    [EnumMember(Value = "GST")]
    [IsoId("_tmc6kvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to truncated credit transfers.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process..The original instrument rules are retained throughout the life of the instrument.|Transaction triggered by specific marked and populated paper slip.|Reconciliation reference is secured by check digits supporting secure optical recognition. All other remittance information is truncated prior transmission.|")]
    TruncatedCreditTransfers = ExternalLocalInstrumentCode.TruncatedCreditTransfers, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to direct debits.
    /// Encoded/decoded by serializers as &quot;DDT&quot;.
    /// </summary>
    [EnumMember(Value = "DDT")]
    [IsoId("_tmc6lfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to direct debits.")]
    DirectDebits = ExternalLocalInstrumentCode.DirectDebits, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to returned direct debits.
    /// Encoded/decoded by serializers as &quot;RDD&quot;.
    /// </summary>
    [EnumMember(Value = "RDD")]
    [IsoId("_tmc6mPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to returned direct debits.")]
    ReturnedDirectDebits = ExternalLocalInstrumentCode.ReturnedDirectDebits, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to truncated checks.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process..The original instrument rules are retained throughout the life of the instrument.
    /// Encoded/decoded by serializers as &quot;CHN&quot;.
    /// </summary>
    [EnumMember(Value = "CHN")]
    [IsoId("_tmmrkvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to truncated checks.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process..The original instrument rules are retained throughout the life of the instrument.")]
    TruncatedChecks = ExternalLocalInstrumentCode.TruncatedChecks, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to revoked credit transfers
    /// Encoded/decoded by serializers as &quot;STR&quot;.
    /// </summary>
    [EnumMember(Value = "STR")]
    [IsoId("_tmmrlfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked credit transfers")]
    RevokedCreditTransfers = ExternalLocalInstrumentCode.RevokedCreditTransfers, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to revoked direct debits.
    /// Encoded/decoded by serializers as &quot;SDD&quot;.
    /// </summary>
    [EnumMember(Value = "SDD")]
    [IsoId("_tmmrmPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked direct debits.")]
    RevokedDirectDebits = ExternalLocalInstrumentCode.RevokedDirectDebits, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to revoked returned credit transfers
    /// Encoded/decoded by serializers as &quot;SRT&quot;.
    /// </summary>
    [EnumMember(Value = "SRT")]
    [IsoId("_tmmrm_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked returned credit transfers")]
    RevokedReturnedCreditTransfers = ExternalLocalInstrumentCode.RevokedReturnedCreditTransfers, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to revoked returned direct debits.
    /// Encoded/decoded by serializers as &quot;SRD&quot;.
    /// </summary>
    [EnumMember(Value = "SRD")]
    [IsoId("_tmmrnvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked returned direct debits.")]
    RevokedReturnedDirectDebits = ExternalLocalInstrumentCode.RevokedReturnedDirectDebits, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to revoked truncated checks.
    /// Encoded/decoded by serializers as &quot;SCN&quot;.
    /// </summary>
    [EnumMember(Value = "SCN")]
    [IsoId("_tmwckvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked truncated checks.")]
    RevokedTruncatedChecks = ExternalLocalInstrumentCode.RevokedTruncatedChecks, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to revoked truncated credit transfers.
    /// Encoded/decoded by serializers as &quot;SGT&quot;.
    /// </summary>
    [EnumMember(Value = "SGT")]
    [IsoId("_tmwclfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked truncated credit transfers.")]
    RevokedTruncatedCreditTransfers = ExternalLocalInstrumentCode.RevokedTruncatedCreditTransfers, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to card clearing.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_tmwcmPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to card clearing.")]
    CardClearing = ExternalLocalInstrumentCode.CardClearing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a direct debit that is not pre authorised (Einzugsermächtigung). 
    /// Encoded/decoded by serializers as &quot;05&quot;.
    /// </summary>
    [EnumMember(Value = "05")]
    [IsoId("_tm5mgvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is not pre authorised (Einzugsermächtigung). ")]
    NonPreauthorisedDirectDebitDE = ExternalLocalInstrumentCode.NonPreauthorisedDirectDebitDE, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a direct debit that is pre authorised (Abbuchungsauftrag). 
    /// Encoded/decoded by serializers as &quot;04&quot;.
    /// </summary>
    [EnumMember(Value = "04")]
    [IsoId("_tm5mhfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is pre authorised (Abbuchungsauftrag). ")]
    PreauthorisedDirectDebitDE = ExternalLocalInstrumentCode.PreauthorisedDirectDebitDE, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to the German Image-based Cheque Collection Procedure “Imagegestützter Scheckeinzug - ISE”
    /// Encoded/decoded by serializers as &quot;ISE&quot;.
    /// </summary>
    [EnumMember(Value = "ISE")]
    [IsoId("_tm5miPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the German Image-based Cheque Collection Procedure “Imagegestützter Scheckeinzug - ISE”")]
    ImageBasedChequeCollection = ExternalLocalInstrumentCode.ImageBasedChequeCollection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to the German Paperless Cheque Collection procedure “Belegloser Scheckeinzug - BSE”
    /// Encoded/decoded by serializers as &quot;BSE&quot;.
    /// </summary>
    [EnumMember(Value = "BSE")]
    [IsoId("_tm5mi_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the German Paperless Cheque Collection procedure “Belegloser Scheckeinzug - BSE”")]
    PaperlessChequeCollection = ExternalLocalInstrumentCode.PaperlessChequeCollection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a business-to-business direct debit (CSB58).
    /// Encoded/decoded by serializers as &quot;58&quot;.
    /// </summary>
    [EnumMember(Value = "58")]
    [IsoId("_tm5mjvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a business-to-business direct debit (CSB58).")]
    BusinessToBusinessDirectDebit = ExternalLocalInstrumentCode.BusinessToBusinessDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a business-to-customer direct debit (CSB19).
    /// Encoded/decoded by serializers as &quot;19&quot;.
    /// </summary>
    [EnumMember(Value = "19")]
    [IsoId("_tnDXgvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a business-to-customer direct debit (CSB19).")]
    BusinessToCustomerDirectDebit = ExternalLocalInstrumentCode.BusinessToCustomerDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the payment is sent by an authorized third party on behalf of the participant. 
    /// Encoded/decoded by serializers as &quot;ASTI&quot;.
    /// </summary>
    [EnumMember(Value = "ASTI")]
    [IsoId("_tnDXhfRYEeuLhpyIdtJzwg")]
    [Description(@"Indicates that the payment is sent by an authorized third party on behalf of the participant. ")]
    AncillarySystemTransferInitiation = ExternalLocalInstrumentCode.AncillarySystemTransferInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the payment was initiated manually using a GUI (Graphical User Interface).
    /// Encoded/decoded by serializers as &quot;BACP&quot;.
    /// </summary>
    [EnumMember(Value = "BACP")]
    [IsoId("_tnDXiPRYEeuLhpyIdtJzwg")]
    [Description(@"Indicates that the payment was initiated manually using a GUI (Graphical User Interface).")]
    BackupPayment = ExternalLocalInstrumentCode.BackupPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the payment is sent by responsible Central Bank on behalf of the participant in case of contingency.
    /// Encoded/decoded by serializers as &quot;MANP&quot;.
    /// </summary>
    [EnumMember(Value = "MANP")]
    [IsoId("_tnDXi_RYEeuLhpyIdtJzwg")]
    [Description(@"Indicates that the payment is sent by responsible Central Bank on behalf of the participant in case of contingency.")]
    MandatedPayment = ExternalLocalInstrumentCode.MandatedPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the payment is submitted to move  liquidity to the technical account - dedicated to real-time settlement in an external system (for example ancillary system) . The payment is processed in a separate payment queue besides the normal processing.
    /// Encoded/decoded by serializers as &quot;SBTI&quot;.
    /// </summary>
    [EnumMember(Value = "SBTI")]
    [IsoId("_tnNIgvRYEeuLhpyIdtJzwg")]
    [Description(@"Indicates that the payment is submitted to move  liquidity to the technical account - dedicated to real-time settlement in an external system (for example ancillary system) . The payment is processed in a separate payment queue besides the normal processing.")]
    SettlementBankTransferInitiation = ExternalLocalInstrumentCode.SettlementBankTransferInitiation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to an urgent direct debit that is pre authorised (Avis de Prélèvement accéléré).
    /// Encoded/decoded by serializers as &quot;85&quot;.
    /// </summary>
    [EnumMember(Value = "85")]
    [IsoId("_tnNIhfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an urgent direct debit that is pre authorised (Avis de Prélèvement accéléré).")]
    PreauthorisedDirectDebitAccéléréAcceleratedClearing2DayOrdinaireNormalClearing4Day = ExternalLocalInstrumentCode.PreauthorisedDirectDebitAccéléréAcceleratedClearing2DayOrdinaireNormalClearing4Day, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a direct debit that is pre authorised (Avis de Prélèvement).
    /// Encoded/decoded by serializers as &quot;08&quot;.
    /// </summary>
    [EnumMember(Value = "08")]
    [IsoId("_tnNIiPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is pre authorised (Avis de Prélèvement).")]
    PreauthorisedDirectDebitOrdinaireNormalClearing4Day = ExternalLocalInstrumentCode.PreauthorisedDirectDebitOrdinaireNormalClearing4Day, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to an urgent direct debit that is pre authorised (Avis de Prélèvement vérifié).
    /// Encoded/decoded by serializers as &quot;89&quot;.
    /// </summary>
    [EnumMember(Value = "89")]
    [IsoId("_tnNIi_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an urgent direct debit that is pre authorised (Avis de Prélèvement vérifié).")]
    PreauthorisedDirectDebitVérifiéVerifiedClearing = ExternalLocalInstrumentCode.PreauthorisedDirectDebitVérifiéVerifiedClearing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// LCR - Lettre de Change Relevé (Recovered Bill of Exchange) and BOR - Billet à Orde Relevé (Promissory Note)
    /// Encoded/decoded by serializers as &quot;60&quot;.
    /// </summary>
    [EnumMember(Value = "60")]
    [IsoId("_tnNIjvRYEeuLhpyIdtJzwg")]
    [Description(@"LCR - Lettre de Change Relevé (Recovered Bill of Exchange) and BOR - Billet à Orde Relevé (Promissory Note)")]
    RecoveredBillofExchangeorPromissoryNote = ExternalLocalInstrumentCode.RecoveredBillofExchangeorPromissoryNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a non-pre authorised collection (RIBA).
    /// Encoded/decoded by serializers as &quot;RIBA&quot;.
    /// </summary>
    [EnumMember(Value = "RIBA")]
    [IsoId("_tnW5gvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a non-pre authorised collection (RIBA).")]
    NonPreauthorisedDirectDebitRIBA = ExternalLocalInstrumentCode.NonPreauthorisedDirectDebitRIBA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a direct debit that is pre authorised and revocable (RID Ordinario).
    /// Encoded/decoded by serializers as &quot;RIDO&quot;.
    /// </summary>
    [EnumMember(Value = "RIDO")]
    [IsoId("_tnW5hfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is pre authorised and revocable (RID Ordinario).")]
    PreauthorisedRevocableDirectDebit = ExternalLocalInstrumentCode.PreauthorisedRevocableDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to an urgent direct debit that is pre authorised and revocable (RID Veloce).
    /// Encoded/decoded by serializers as &quot;RIDV&quot;.
    /// </summary>
    [EnumMember(Value = "RIDV")]
    [IsoId("_tngDcvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an urgent direct debit that is pre authorised and revocable (RID Veloce).")]
    PreauthorisedRevocableUrgentDirectDebit = ExternalLocalInstrumentCode.PreauthorisedRevocableUrgentDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to payments via internet owned by Currence.
    /// Encoded/decoded by serializers as &quot;IDEAL&quot;.
    /// </summary>
    [EnumMember(Value = "IDEAL")]
    [IsoId("_tngDdfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via internet owned by Currence.")]
    PaymentsViaInternetOwnedByCurrence = ExternalLocalInstrumentCode.PaymentsViaInternetOwnedByCurrence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The transaction is related to a regular  Credit Transfer and will be instantly processed under the Dutch AOS on top of the EPC SCT scheme.
    /// Encoded/decoded by serializers as &quot;INSTNT01&quot;.
    /// </summary>
    [EnumMember(Value = "INSTNT01")]
    [IsoId("_tngDePRYEeuLhpyIdtJzwg")]
    [Description(@"The transaction is related to a regular  Credit Transfer and will be instantly processed under the Dutch AOS on top of the EPC SCT scheme.")]
    InstantCreditTransferNotTimeCritical = ExternalLocalInstrumentCode.InstantCreditTransferNotTimeCritical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The transaction is related to an Instant Credit Transfer under the rules of the Dutch AOS on top of the EPC SCT Inst scheme.
    /// Encoded/decoded by serializers as &quot;INSTTC01&quot;.
    /// </summary>
    [EnumMember(Value = "INSTTC01")]
    [IsoId("_tngDe_RYEeuLhpyIdtJzwg")]
    [Description(@"The transaction is related to an Instant Credit Transfer under the rules of the Dutch AOS on top of the EPC SCT Inst scheme.")]
    InstantCreditTransferTimeCritical = ExternalLocalInstrumentCode.InstantCreditTransferTimeCritical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to payments via internet owned by Currence which uses an Instant Credit Transfer.
    /// Encoded/decoded by serializers as &quot;INSTIDEAL&quot;.
    /// </summary>
    [EnumMember(Value = "INSTIDEAL")]
    [IsoId("_tngDfvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via internet owned by Currence which uses an Instant Credit Transfer.")]
    PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransfer = ExternalLocalInstrumentCode.PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to payments via internet owned by Currence which uses a regular  Credit Transfer and will be instantly processed under the Dutch AOS on top of the EPC SCT scheme.
    /// Encoded/decoded by serializers as &quot;INSTNT01IDEAL&quot;.
    /// </summary>
    [EnumMember(Value = "INSTNT01IDEAL")]
    [IsoId("_tnp0cvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via internet owned by Currence which uses a regular  Credit Transfer and will be instantly processed under the Dutch AOS on top of the EPC SCT scheme.")]
    PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransferNotTimeCritical = ExternalLocalInstrumentCode.PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransferNotTimeCritical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to payments via internet owned by Currence which uses an Instant Credit Transfer under the rules of the Dutch AOS on top of the EPC SCT Inst scheme.
    /// Encoded/decoded by serializers as &quot;INSTTC01IDEAL&quot;.
    /// </summary>
    [EnumMember(Value = "INSTTC01IDEAL")]
    [IsoId("_tnp0dfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via internet owned by Currence which uses an Instant Credit Transfer under the rules of the Dutch AOS on top of the EPC SCT Inst scheme.")]
    PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransferTimeCritical = ExternalLocalInstrumentCode.PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransferTimeCritical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a Domestic payment initiated by PAIN.001
    /// Encoded/decoded by serializers as &quot;NLDO&quot;.
    /// </summary>
    [EnumMember(Value = "NLDO")]
    [IsoId("_tnp0ePRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a Domestic payment initiated by PAIN.001")]
    DutchDomesticBulkPayment = ExternalLocalInstrumentCode.DutchDomesticBulkPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a Domestic payment initiated by PAIN.001
    /// Encoded/decoded by serializers as &quot;NLUP&quot;.
    /// </summary>
    [EnumMember(Value = "NLUP")]
    [IsoId("_tny-YvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a Domestic payment initiated by PAIN.001")]
    DutchUrgentPayment = ExternalLocalInstrumentCode.DutchUrgentPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to payments via a ‘Standaard Digitale Nota’ InvoiceAcceptgiro payment.
    /// Encoded/decoded by serializers as &quot;SDN&quot;.
    /// </summary>
    [EnumMember(Value = "SDN")]
    [IsoId("_tny-ZfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via a ‘Standaard Digitale Nota’ InvoiceAcceptgiro payment.")]
    PaymentsViaStandaardDigitaleNota = ExternalLocalInstrumentCode.PaymentsViaStandaardDigitaleNota, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to payments via Acceptgiro owned by Currence.
    /// Encoded/decoded by serializers as &quot;ACCEPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCEPT")]
    [IsoId("_tn8vYvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via Acceptgiro owned by Currence.")]
    PaymentViaAcceptgiroOwnedByCurrence = ExternalLocalInstrumentCode.PaymentViaAcceptgiroOwnedByCurrence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to an Incident Management Correction procedure based on the DD infrastructure.
    /// Encoded/decoded by serializers as &quot;ICMC&quot;.
    /// </summary>
    [EnumMember(Value = "ICMC")]
    [IsoId("_tn8vZfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an Incident Management Correction procedure based on the DD infrastructure.")]
    IncidentManagementCorrection = ExternalLocalInstrumentCode.IncidentManagementCorrection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to direct debit scheme owned by the NVB.
    /// Encoded/decoded by serializers as &quot;NLGOV&quot;.
    /// </summary>
    [EnumMember(Value = "NLGOV")]
    [IsoId("_tn8vaPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to direct debit scheme owned by the NVB.")]
    DirectDebitInitiatedByTheGovernmentWithSpecialConditions = ExternalLocalInstrumentCode.DirectDebitInitiatedByTheGovernmentWithSpecialConditions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to mass payment beneficiary.|
    /// Encoded/decoded by serializers as &quot;0090&quot;.
    /// </summary>
    [EnumMember(Value = "0090")]
    [IsoId("_tn8va_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to mass payment beneficiary.|")]
    MassPaymentBeneficiary = ExternalLocalInstrumentCode.MassPaymentBeneficiary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to mass payment ours.|
    /// Encoded/decoded by serializers as &quot;0091&quot;.
    /// </summary>
    [EnumMember(Value = "0091")]
    [IsoId("_tn8vbvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to mass payment ours.|")]
    MassPaymentOurs = ExternalLocalInstrumentCode.MassPaymentOurs, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to mass payment shared.|
    /// Encoded/decoded by serializers as &quot;0092&quot;.
    /// </summary>
    [EnumMember(Value = "0092")]
    [IsoId("_toF5UvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to mass payment shared.|")]
    MassPaymentShared = ExternalLocalInstrumentCode.MassPaymentShared, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to standing order.
    /// Encoded/decoded by serializers as &quot;0002&quot;.
    /// </summary>
    [EnumMember(Value = "0002")]
    [IsoId("_toF5VfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to standing order.")]
    StandingOrder = ExternalLocalInstrumentCode.StandingOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to one-off authorisation.
    /// Encoded/decoded by serializers as &quot;0221&quot;.
    /// </summary>
    [EnumMember(Value = "0221")]
    [IsoId("_toF5WPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to one-off authorisation.")]
    OneOffAuthorisation = ExternalLocalInstrumentCode.OneOffAuthorisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to one-off authorisation charities.
    /// Encoded/decoded by serializers as &quot;0224&quot;.
    /// </summary>
    [EnumMember(Value = "0224")]
    [IsoId("_toF5W_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to one-off authorisation charities.")]
    OneOffAuthorisationCharities = ExternalLocalInstrumentCode.OneOffAuthorisationCharities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to one-off authorisation construction industry.
    /// Encoded/decoded by serializers as &quot;0226&quot;.
    /// </summary>
    [EnumMember(Value = "0226")]
    [IsoId("_toPqUvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to one-off authorisation construction industry.")]
    OneOffAuthorisationConstructionIndustry = ExternalLocalInstrumentCode.OneOffAuthorisationConstructionIndustry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to one-off authorisation tuition fees.
    /// Encoded/decoded by serializers as &quot;0225&quot;.
    /// </summary>
    [EnumMember(Value = "0225")]
    [IsoId("_toPqVfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to one-off authorisation tuition fees.")]
    OneOffAuthorisationTuitionFees = ExternalLocalInstrumentCode.OneOffAuthorisationTuitionFees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to standing authorisation companies.
    /// Encoded/decoded by serializers as &quot;0222&quot;.
    /// </summary>
    [EnumMember(Value = "0222")]
    [IsoId("_toPqWPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to standing authorisation companies.")]
    StandingAuthorisationCompanies = ExternalLocalInstrumentCode.StandingAuthorisationCompanies, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to standing authorisation companies without debtor revocation right.
    /// Encoded/decoded by serializers as &quot;0227&quot;.
    /// </summary>
    [EnumMember(Value = "0227")]
    [IsoId("_toZbUvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to standing authorisation companies without debtor revocation right.")]
    StandingAuthorisationCompaniesWithoutDebtorRevocationRight = ExternalLocalInstrumentCode.StandingAuthorisationCompaniesWithoutDebtorRevocationRight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to standing authorisation general.|
    /// Encoded/decoded by serializers as &quot;0220&quot;.
    /// </summary>
    [EnumMember(Value = "0220")]
    [IsoId("_toZbVfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to standing authorisation general.|")]
    StandingAuthorisationGeneral = ExternalLocalInstrumentCode.StandingAuthorisationGeneral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to standing authorisation lotteries.
    /// Encoded/decoded by serializers as &quot;0223&quot;.
    /// </summary>
    [EnumMember(Value = "0223")]
    [IsoId("_toilQvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to standing authorisation lotteries.")]
    StandingAuthorisationLotteries = ExternalLocalInstrumentCode.StandingAuthorisationLotteries, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to converted (bank) payment.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process.The instrument rules change upon conversion.
    /// Encoded/decoded by serializers as &quot;0001&quot;.
    /// </summary>
    [EnumMember(Value = "0001")]
    [IsoId("_toilRfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to converted (bank) payment.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process.The instrument rules change upon conversion.")]
    ConvertedBankPayment = ExternalLocalInstrumentCode.ConvertedBankPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to business payment
    /// Encoded/decoded by serializers as &quot;0000&quot;.
    /// </summary>
    [EnumMember(Value = "0000")]
    [IsoId("_toilSPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to business payment")]
    BusinessPayment = ExternalLocalInstrumentCode.BusinessPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to cross border customer credit transfer.
    /// Encoded/decoded by serializers as &quot;IN&quot;.
    /// </summary>
    [EnumMember(Value = "IN")]
    [IsoId("_tosWQvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to cross border customer credit transfer.")]
    CrossBorderCustomerCreditTransfer = ExternalLocalInstrumentCode.CrossBorderCustomerCreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to overnight clearing.
    /// Encoded/decoded by serializers as &quot;ONCL&quot;.
    /// </summary>
    [EnumMember(Value = "ONCL")]
    [IsoId("_tosWRfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to overnight clearing.")]
    Overnight = ExternalLocalInstrumentCode.Overnight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit transfer contains Extended Remittance Information (ERI) as defined within the applicable scheme.
    /// Encoded/decoded by serializers as &quot;PERI&quot;.
    /// </summary>
    [EnumMember(Value = "PERI")]
    [IsoId("_tosWSPRYEeuLhpyIdtJzwg")]
    [Description(@"Credit transfer contains Extended Remittance Information (ERI) as defined within the applicable scheme.")]
    PaymentWithERI = ExternalLocalInstrumentCode.PaymentWithERI, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to New Zealand High Value Clearing System (HVCS) same day clearing payments.
    /// Encoded/decoded by serializers as &quot;SDCL&quot;.
    /// </summary>
    [EnumMember(Value = "SDCL")]
    [IsoId("_tosWS_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to New Zealand High Value Clearing System (HVCS) same day clearing payments.")]
    SameDayClearedPayments = ExternalLocalInstrumentCode.SameDayClearedPayments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SEPA Core Direct Debit with ‘no refund’ option
    /// Encoded/decoded by serializers as &quot;DDNR&quot;.
    /// </summary>
    [EnumMember(Value = "DDNR")]
    [IsoId("_tosWTvRYEeuLhpyIdtJzwg")]
    [Description(@"SEPA Core Direct Debit with ‘no refund’ option")]
    CoreNoRefund = ExternalLocalInstrumentCode.CoreNoRefund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SEPA Fixed Amount Direct Debit
    /// Encoded/decoded by serializers as &quot;DDFA&quot;.
    /// </summary>
    [EnumMember(Value = "DDFA")]
    [IsoId("_to2HQvRYEeuLhpyIdtJzwg")]
    [Description(@"SEPA Fixed Amount Direct Debit")]
    DirectDebitFixedAmount = ExternalLocalInstrumentCode.DirectDebitFixedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to SEPA direct debit -core.
    /// Encoded/decoded by serializers as &quot;CORE&quot;.
    /// </summary>
    [EnumMember(Value = "CORE")]
    [IsoId("_to2HRfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to SEPA direct debit -core.")]
    SEPADirectDebitCore = ExternalLocalInstrumentCode.SEPADirectDebitCore, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SEPA B2B Direct Debit AMI based on a paper mandate
    /// Encoded/decoded by serializers as &quot;B2BAMIPM&quot;.
    /// </summary>
    [EnumMember(Value = "B2BAMIPM")]
    [IsoId("_to_RMvRYEeuLhpyIdtJzwg")]
    [Description(@"SEPA B2B Direct Debit AMI based on a paper mandate")]
    SEPAB2BDirectDebitAMI = ExternalLocalInstrumentCode.SEPAB2BDirectDebitAMI, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to SEPA business to business direct debit.
    /// Encoded/decoded by serializers as &quot;B2B&quot;.
    /// </summary>
    [EnumMember(Value = "B2B")]
    [IsoId("_to_RNfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to SEPA business to business direct debit.")]
    SEPABusinessToBusinessDirectDebit = ExternalLocalInstrumentCode.SEPABusinessToBusinessDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Optional shorter time cycle (D-1) for SEPA Core Direct Debit AMI based on a paper mandate
    /// Encoded/decoded by serializers as &quot;CR1AMIPM&quot;.
    /// </summary>
    [EnumMember(Value = "CR1AMIPM")]
    [IsoId("_to_ROPRYEeuLhpyIdtJzwg")]
    [Description(@"Optional shorter time cycle (D-1) for SEPA Core Direct Debit AMI based on a paper mandate")]
    SEPACoreD1DirectDebitAMI = ExternalLocalInstrumentCode.SEPACoreD1DirectDebitAMI, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SEPA Core Direct Debit AMI based on a paper mandate
    /// Encoded/decoded by serializers as &quot;CORAMIPM&quot;.
    /// </summary>
    [EnumMember(Value = "CORAMIPM")]
    [IsoId("_to_RO_RYEeuLhpyIdtJzwg")]
    [Description(@"SEPA Core Direct Debit AMI based on a paper mandate")]
    SEPACoreDirectDebitAMI = ExternalLocalInstrumentCode.SEPACoreDirectDebitAMI, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Optional shorter time cycle (D-1) for SEPA Core Direct Debit
    /// Encoded/decoded by serializers as &quot;COR1&quot;.
    /// </summary>
    [EnumMember(Value = "COR1")]
    [IsoId("_to_RPvRYEeuLhpyIdtJzwg")]
    [Description(@"Optional shorter time cycle (D-1) for SEPA Core Direct Debit")]
    SEPADirectDebit1DaySettlement = ExternalLocalInstrumentCode.SEPADirectDebit1DaySettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SEPA Fixed Amount Direct Debit AMI based on a paper mandate
    /// Encoded/decoded by serializers as &quot;FADAMIPM&quot;.
    /// </summary>
    [EnumMember(Value = "FADAMIPM")]
    [IsoId("_tpJCMvRYEeuLhpyIdtJzwg")]
    [Description(@"SEPA Fixed Amount Direct Debit AMI based on a paper mandate")]
    SEPAFADirectDebitAMI = ExternalLocalInstrumentCode.SEPAFADirectDebitAMI, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to the CLSClearedFX service for Eurex.  |Usage: The code is mandatory for all pacs.009 payments to this service.
    /// Encoded/decoded by serializers as &quot;CLSCCPERX&quot;.
    /// </summary>
    [EnumMember(Value = "CLSCCPERX")]
    [IsoId("_tpJCNfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the CLSClearedFX service for Eurex.  |Usage: The code is mandatory for all pacs.009 payments to this service.")]
    CLSClearedFXForEurex = ExternalLocalInstrumentCode.CLSClearedFXForEurex, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to the CLSClearedFX service for London Exchange Clearing House. |Usage: The code is mandatory for all pacs.009 payments to this service.
    /// Encoded/decoded by serializers as &quot;CLSCCPLCH&quot;.
    /// </summary>
    [EnumMember(Value = "CLSCCPLCH")]
    [IsoId("_tpJCOPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the CLSClearedFX service for London Exchange Clearing House. |Usage: The code is mandatory for all pacs.009 payments to this service.")]
    CLSClearedFXForLCH = ExternalLocalInstrumentCode.CLSClearedFXForLCH, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to an Instant Credit Transfer.|Use case example: SEPA Instant Credit Transfer (SCT Inst)
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_tpJCO_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an Instant Credit Transfer.|Use case example: SEPA Instant Credit Transfer (SCT Inst)")]
    InstantCreditTransfer = ExternalLocalInstrumentCode.InstantCreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is authenticated direct debit for domestic use.
    /// Encoded/decoded by serializers as &quot;ADD&quot;.
    /// </summary>
    [EnumMember(Value = "ADD")]
    [IsoId("_tpJCPvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is authenticated direct debit for domestic use.")]
    AuthenticatedDirectDebit = ExternalLocalInstrumentCode.AuthenticatedDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is unauthenticated direct debit for domestic use.
    /// Encoded/decoded by serializers as &quot;UDD&quot;.
    /// </summary>
    [EnumMember(Value = "UDD")]
    [IsoId("_tpSzMvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is unauthenticated direct debit for domestic use.")]
    UnauthenticatedDirectDebit = ExternalLocalInstrumentCode.UnauthenticatedDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to an intra-group bank initiated cash management payment
    /// Encoded/decoded by serializers as &quot;CCI&quot;.
    /// </summary>
    [EnumMember(Value = "CCI")]
    [IsoId("_tpSzNfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an intra-group bank initiated cash management payment")]
    CashConcentrationIntragroup = ExternalLocalInstrumentCode.CashConcentrationIntragroup, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a bank transfer.
    /// Encoded/decoded by serializers as &quot;BTR&quot;.
    /// </summary>
    [EnumMember(Value = "BTR")]
    [IsoId("_tpb9IvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a bank transfer.")]
    BankTransfer = ExternalLocalInstrumentCode.BankTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to check same day settlement wire.
    /// Encoded/decoded by serializers as &quot;CKS&quot;.
    /// </summary>
    [EnumMember(Value = "CKS")]
    [IsoId("_tpb9JfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to check same day settlement wire.")]
    CheckSameDaySettlementWire = ExternalLocalInstrumentCode.CheckSameDaySettlementWire, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to customer transfer.
    /// Encoded/decoded by serializers as &quot;CTR&quot;.
    /// </summary>
    [EnumMember(Value = "CTR")]
    [IsoId("_tpluIvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to customer transfer.")]
    CustomerTransfer = ExternalLocalInstrumentCode.CustomerTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a customer transfer, which may include information related to a cover payment or extended remittance information.  
    /// Encoded/decoded by serializers as &quot;CTP&quot;.
    /// </summary>
    [EnumMember(Value = "CTP")]
    [IsoId("_tpluJfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a customer transfer, which may include information related to a cover payment or extended remittance information.  ")]
    CustomerTransferPlus = ExternalLocalInstrumentCode.CustomerTransferPlus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to deposit to sender&apos;s account.
    /// Encoded/decoded by serializers as &quot;DEP&quot;.
    /// </summary>
    [EnumMember(Value = "DEP")]
    [IsoId("_tpluKPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to deposit to sender's account.")]
    DepositToSendersAccount = ExternalLocalInstrumentCode.DepositToSendersAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to Fed funds returned.
    /// Encoded/decoded by serializers as &quot;FFR&quot;.
    /// </summary>
    [EnumMember(Value = "FFR")]
    [IsoId("_tpluK_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to Fed funds returned.")]
    FedFundsReturned = ExternalLocalInstrumentCode.FedFundsReturned, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to Fed funds sold.
    /// Encoded/decoded by serializers as &quot;FFS&quot;.
    /// </summary>
    [EnumMember(Value = "FFS")]
    [IsoId("_tpvfIvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to Fed funds sold.")]
    FedFundsSold = ExternalLocalInstrumentCode.FedFundsSold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to non-value service message.
    /// Encoded/decoded by serializers as &quot;SVC&quot;.
    /// </summary>
    [EnumMember(Value = "SVC")]
    [IsoId("_tpvfJfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to non-value service message.")]
    NonValueServiceMessage = ExternalLocalInstrumentCode.NonValueServiceMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to drawdown response (value) to honor a drawdown request.
    /// Encoded/decoded by serializers as &quot;DRW&quot;.
    /// </summary>
    [EnumMember(Value = "DRW")]
    [IsoId("_tpvfKPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to drawdown response (value) to honor a drawdown request.")]
    DrawdownResponseValueToHonorADrawdownRequest = ExternalLocalInstrumentCode.DrawdownResponseValueToHonorADrawdownRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to bank-to-bank drawdown request or response (non-value)
    /// Encoded/decoded by serializers as &quot;DRB&quot;.
    /// </summary>
    [EnumMember(Value = "DRB")]
    [IsoId("_tpvfK_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to bank-to-bank drawdown request or response (non-value)")]
    BankToBankDrawdownRequestOrResponseNonvalue = ExternalLocalInstrumentCode.BankToBankDrawdownRequestOrResponseNonvalue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to customer or corporate drawdown request or response (non-value).
    /// Encoded/decoded by serializers as &quot;DRC&quot;.
    /// </summary>
    [EnumMember(Value = "DRC")]
    [IsoId("_tpvfLvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to customer or corporate drawdown request or response (non-value).")]
    CustomerOrCorporateDrawdownRequestOrResponseNonvalue = ExternalLocalInstrumentCode.CustomerOrCorporateDrawdownRequestOrResponseNonvalue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to international ACH.
    /// Encoded/decoded by serializers as &quot;IAT&quot;.
    /// </summary>
    [EnumMember(Value = "IAT")]
    [IsoId("_tp4pEvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to international ACH.")]
    InternationalACH = ExternalLocalInstrumentCode.InternationalACH, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to cash concentration or disbursement corporate counterparty.
    /// Encoded/decoded by serializers as &quot;CCD&quot;.
    /// </summary>
    [EnumMember(Value = "CCD")]
    [IsoId("_tp4pFfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to cash concentration or disbursement corporate counterparty.")]
    CashConcentrationOrDisbursementCorporateCounterparty = ExternalLocalInstrumentCode.CashConcentrationOrDisbursementCorporateCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to corporate trade exchange.
    /// Encoded/decoded by serializers as &quot;CTX&quot;.
    /// </summary>
    [EnumMember(Value = "CTX")]
    [IsoId("_tp4pGPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to corporate trade exchange.")]
    CorporateTradeExchange = ExternalLocalInstrumentCode.CorporateTradeExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to prearranged payment or deposit consumer counterparty.
    /// Encoded/decoded by serializers as &quot;PPD&quot;.
    /// </summary>
    [EnumMember(Value = "PPD")]
    [IsoId("_tp4pG_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to prearranged payment or deposit consumer counterparty.")]
    PrearrangedPaymentOrDepositConsumerCounterparty = ExternalLocalInstrumentCode.PrearrangedPaymentOrDepositConsumerCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A credit entry initiated by or on behalf of the holder of a consumer account
    /// Encoded/decoded by serializers as &quot;CIE&quot;.
    /// </summary>
    [EnumMember(Value = "CIE")]
    [IsoId("_tp4pHvRYEeuLhpyIdtJzwg")]
    [Description(@"A credit entry initiated by or on behalf of the holder of a consumer account")]
    CustomerInitiatedEntry = ExternalLocalInstrumentCode.CustomerInitiatedEntry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to re-presented check entry.
    /// Encoded/decoded by serializers as &quot;RCK&quot;.
    /// </summary>
    [EnumMember(Value = "RCK")]
    [IsoId("_tqCaEvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to re-presented check entry.")]
    RepresentedCheckEntry = ExternalLocalInstrumentCode.RepresentedCheckEntry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to accounts receivable check.
    /// Encoded/decoded by serializers as &quot;ARC&quot;.
    /// </summary>
    [EnumMember(Value = "ARC")]
    [IsoId("_tqCaFfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to accounts receivable check.")]
    AccountsReceivableCheck = ExternalLocalInstrumentCode.AccountsReceivableCheck, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to internet initiated entry.
    /// Encoded/decoded by serializers as &quot;WEB&quot;.
    /// </summary>
    [EnumMember(Value = "WEB")]
    [IsoId("_tqCaGPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to internet initiated entry.")]
    InternetInitiatedEntry = ExternalLocalInstrumentCode.InternetInitiatedEntry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to point-of-purchase.
    /// Encoded/decoded by serializers as &quot;POP&quot;.
    /// </summary>
    [EnumMember(Value = "POP")]
    [IsoId("_tqLkAvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to point-of-purchase.")]
    PointOfPurchase = ExternalLocalInstrumentCode.PointOfPurchase, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to point-of-sale.
    /// Encoded/decoded by serializers as &quot;POS&quot;.
    /// </summary>
    [EnumMember(Value = "POS")]
    [IsoId("_tqLkBfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to point-of-sale.")]
    PointOfSale = ExternalLocalInstrumentCode.PointOfSale, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to telephone initiated entry.
    /// Encoded/decoded by serializers as &quot;TEL&quot;.
    /// </summary>
    [EnumMember(Value = "TEL")]
    [IsoId("_tqLkCPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to telephone initiated entry.")]
    TelephoneInitiatedEntry = ExternalLocalInstrumentCode.TelephoneInitiatedEntry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay preferred payment via Instant Credit Transfer but Credit Transfer is also possible.
    /// Encoded/decoded by serializers as &quot;ITP&quot;.
    /// </summary>
    [EnumMember(Value = "ITP")]
    [IsoId("_It7dAVEFEey6cYDbEubNXg")]
    [Description(@"Request-to-pay preferred payment via Instant Credit Transfer but Credit Transfer is also possible.")]
    InstantCreditTransferPreferred = ExternalLocalInstrumentCode.InstantCreditTransferPreferred, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay preferred payment via Credit Transfer but Instant Credit Transfer is also possible.
    /// Encoded/decoded by serializers as &quot;CTP&quot;.
    /// </summary>
    [EnumMember(Value = "CTP")]
    [IsoId("_K0CN4VEFEey6cYDbEubNXg")]
    [Description(@"Request-to-pay preferred payment via Credit Transfer but Instant Credit Transfer is also possible.")]
    CreditTransferPreferred = ExternalLocalInstrumentCode.CreditTransferPreferred, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of New Payments Architecture (NPA) payment. Payments are processed over a three-day cycle and available to customers early in the morning of Day 3.
    /// Encoded/decoded by serializers as &quot;MDP&quot;.
    /// </summary>
    [EnumMember(Value = "MDP")]
    [IsoId("_yIC_seAnEey0k8vo1GQhqQ")]
    [Description(@"Type of New Payments Architecture (NPA) payment. Payments are processed over a three-day cycle and available to customers early in the morning of Day 3.")]
    MultiDayPayment = ExternalLocalInstrumentCode.MultiDayPayment, // same ordinal as derivation source for type conversions
    
}
