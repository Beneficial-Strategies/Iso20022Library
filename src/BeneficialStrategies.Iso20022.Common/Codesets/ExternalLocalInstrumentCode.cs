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
[IsoId("_69ANUIKYEeeCI5iKR7LsYQ")]
[Description(@"Specifies the external local instrument code in the format of character string with a maximum length of 35 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalLocalInstrument1Code))]
public enum ExternalLocalInstrumentCode
{
    /// <summary>
    /// Transaction is related to a direct debit instruction authorized under a confirmed electronic mandate.
    /// Encoded/decoded by serializers as &quot;DDMC&quot;.
    /// </summary>
    [EnumMember(Value = "DDMC")]
    [IsoId("_tmA1tvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit instruction authorized under a confirmed electronic mandate.")]
    DirectDebitConfirmedElectronicMandate,
    
    /// <summary>
    /// Transaction is related to a direct debit instruction authorized under a paper based mandate, supported by paper authorization signed by the debtor.
    /// Encoded/decoded by serializers as &quot;DDMP&quot;.
    /// </summary>
    [EnumMember(Value = "DDMP")]
    [IsoId("_tmA1ufRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit instruction authorized under a paper based mandate, supported by paper authorization signed by the debtor.")]
    DirectDebitPaperMandateWithPaperAuthorization,
    
    /// <summary>
    /// Transaction is related to a direct debit instruction authorized under an unconfirmed electronic mandate requiring confirmation by the debtor.
    /// Encoded/decoded by serializers as &quot;DDMU&quot;.
    /// </summary>
    [EnumMember(Value = "DDMU")]
    [IsoId("_tmJ_oPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit instruction authorized under an unconfirmed electronic mandate requiring confirmation by the debtor.")]
    DirectDebitUnconfirmedElectronicMandate,
    
    /// <summary>
    /// Transaction is related to an Instant Credit Transfer under the rules of the Centrale Bank van Aruba, based on the EPC SCT Inst scheme, with a specific batch time-out delay.
    /// Encoded/decoded by serializers as &quot;BPA&quot;.
    /// </summary>
    [EnumMember(Value = "BPA")]
    [IsoId("_tmJ_o_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an Instant Credit Transfer under the rules of the Centrale Bank van Aruba, based on the EPC SCT Inst scheme, with a specific batch time-out delay.")]
    BatchPaymentsAruba,
    
    /// <summary>
    /// Transaction is related to an Instant Credit Transfer under the rules of the Centrale Bank van Aruba, based on the EPC SCT Inst scheme.
    /// Encoded/decoded by serializers as &quot;IPA&quot;.
    /// </summary>
    [EnumMember(Value = "IPA")]
    [IsoId("_tmJ_pvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an Instant Credit Transfer under the rules of the Centrale Bank van Aruba, based on the EPC SCT Inst scheme.")]
    InstantPaymentsAruba,
    
    /// <summary>
    /// Transaction is related to credit transfers
    /// Encoded/decoded by serializers as &quot;TRF&quot;.
    /// </summary>
    [EnumMember(Value = "TRF")]
    [IsoId("_tmJ_qfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to credit transfers")]
    CreditTransfers,
    
    /// <summary>
    /// Transaction is related to a direct debit that is not pre authorised (Einzugsermächtigung). 
    /// Encoded/decoded by serializers as &quot;82&quot;.
    /// </summary>
    [EnumMember(Value = "82")]
    [IsoId("_tmTwoPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is not pre authorised (Einzugsermächtigung). ")]
    NonPreauthorisedDirectDebitAT,
    
    /// <summary>
    /// Transaction is related to a direct debit that is pre authorised (Abbuchungsauftrag). 
    /// Encoded/decoded by serializers as &quot;83&quot;.
    /// </summary>
    [EnumMember(Value = "83")]
    [IsoId("_tmTwo_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is pre authorised (Abbuchungsauftrag). ")]
    PreauthorisedDirectDebitAT,
    
    /// <summary>
    /// Transaction is related to cash per post.|Transaction to ultimate recipient having no bank account. Primary beneficiary is a postal service provider. Funds are paid out by cash. Additional necessary information for address and delivery options need to be attached.|
    /// Encoded/decoded by serializers as &quot;CPP&quot;.
    /// </summary>
    [EnumMember(Value = "CPP")]
    [IsoId("_tmTwpvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to cash per post.|Transaction to ultimate recipient having no bank account. Primary beneficiary is a postal service provider. Funds are paid out by cash. Additional necessary information for address and delivery options need to be attached.|")]
    CashPerPost,
    
    /// <summary>
    /// Transaction is related to returned credit transfers.
    /// Encoded/decoded by serializers as &quot;RTR&quot;.
    /// </summary>
    [EnumMember(Value = "RTR")]
    [IsoId("_tmTwqfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to returned credit transfers.")]
    ReturnedCreditTransfers,
    
    /// <summary>
    /// Transaction is related to truncated credit transfers.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process..The original instrument rules are retained throughout the life of the instrument.|Transaction triggered by specific marked and populated paper slip.|Reconciliation reference is secured by check digits supporting secure optical recognition. All other remittance information is truncated prior transmission.|
    /// Encoded/decoded by serializers as &quot;GST&quot;.
    /// </summary>
    [EnumMember(Value = "GST")]
    [IsoId("_tmc6kPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to truncated credit transfers.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process..The original instrument rules are retained throughout the life of the instrument.|Transaction triggered by specific marked and populated paper slip.|Reconciliation reference is secured by check digits supporting secure optical recognition. All other remittance information is truncated prior transmission.|")]
    TruncatedCreditTransfers,
    
    /// <summary>
    /// Transaction is related to direct debits.
    /// Encoded/decoded by serializers as &quot;DDT&quot;.
    /// </summary>
    [EnumMember(Value = "DDT")]
    [IsoId("_tmc6k_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to direct debits.")]
    DirectDebits,
    
    /// <summary>
    /// Transaction is related to returned direct debits.
    /// Encoded/decoded by serializers as &quot;RDD&quot;.
    /// </summary>
    [EnumMember(Value = "RDD")]
    [IsoId("_tmc6lvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to returned direct debits.")]
    ReturnedDirectDebits,
    
    /// <summary>
    /// Transaction is related to truncated checks.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process..The original instrument rules are retained throughout the life of the instrument.
    /// Encoded/decoded by serializers as &quot;CHN&quot;.
    /// </summary>
    [EnumMember(Value = "CHN")]
    [IsoId("_tmmrkPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to truncated checks.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process..The original instrument rules are retained throughout the life of the instrument.")]
    TruncatedChecks,
    
    /// <summary>
    /// Transaction is related to revoked credit transfers
    /// Encoded/decoded by serializers as &quot;STR&quot;.
    /// </summary>
    [EnumMember(Value = "STR")]
    [IsoId("_tmmrk_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked credit transfers")]
    RevokedCreditTransfers,
    
    /// <summary>
    /// Transaction is related to revoked direct debits.
    /// Encoded/decoded by serializers as &quot;SDD&quot;.
    /// </summary>
    [EnumMember(Value = "SDD")]
    [IsoId("_tmmrlvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked direct debits.")]
    RevokedDirectDebits,
    
    /// <summary>
    /// Transaction is related to revoked returned credit transfers
    /// Encoded/decoded by serializers as &quot;SRT&quot;.
    /// </summary>
    [EnumMember(Value = "SRT")]
    [IsoId("_tmmrmfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked returned credit transfers")]
    RevokedReturnedCreditTransfers,
    
    /// <summary>
    /// Transaction is related to revoked returned direct debits.
    /// Encoded/decoded by serializers as &quot;SRD&quot;.
    /// </summary>
    [EnumMember(Value = "SRD")]
    [IsoId("_tmmrnPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked returned direct debits.")]
    RevokedReturnedDirectDebits,
    
    /// <summary>
    /// Transaction is related to revoked truncated checks.
    /// Encoded/decoded by serializers as &quot;SCN&quot;.
    /// </summary>
    [EnumMember(Value = "SCN")]
    [IsoId("_tmwckPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked truncated checks.")]
    RevokedTruncatedChecks,
    
    /// <summary>
    /// Transaction is related to revoked truncated credit transfers.
    /// Encoded/decoded by serializers as &quot;SGT&quot;.
    /// </summary>
    [EnumMember(Value = "SGT")]
    [IsoId("_tmwck_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to revoked truncated credit transfers.")]
    RevokedTruncatedCreditTransfers,
    
    /// <summary>
    /// Transaction is related to card clearing.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_tmwclvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to card clearing.")]
    CardClearing,
    
    /// <summary>
    /// Transaction is related to a direct debit that is not pre authorised (Einzugsermächtigung). 
    /// Encoded/decoded by serializers as &quot;05&quot;.
    /// </summary>
    [EnumMember(Value = "05")]
    [IsoId("_tm5mgPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is not pre authorised (Einzugsermächtigung). ")]
    NonPreauthorisedDirectDebitDE,
    
    /// <summary>
    /// Transaction is related to a direct debit that is pre authorised (Abbuchungsauftrag). 
    /// Encoded/decoded by serializers as &quot;04&quot;.
    /// </summary>
    [EnumMember(Value = "04")]
    [IsoId("_tm5mg_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is pre authorised (Abbuchungsauftrag). ")]
    PreauthorisedDirectDebitDE,
    
    /// <summary>
    /// Transaction is related to the German Image-based Cheque Collection Procedure “Imagegestützter Scheckeinzug - ISE”
    /// Encoded/decoded by serializers as &quot;ISE&quot;.
    /// </summary>
    [EnumMember(Value = "ISE")]
    [IsoId("_tm5mhvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the German Image-based Cheque Collection Procedure “Imagegestützter Scheckeinzug - ISE”")]
    ImageBasedChequeCollection,
    
    /// <summary>
    /// Transaction is related to the German Paperless Cheque Collection procedure “Belegloser Scheckeinzug - BSE”
    /// Encoded/decoded by serializers as &quot;BSE&quot;.
    /// </summary>
    [EnumMember(Value = "BSE")]
    [IsoId("_tm5mifRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the German Paperless Cheque Collection procedure “Belegloser Scheckeinzug - BSE”")]
    PaperlessChequeCollection,
    
    /// <summary>
    /// Transaction is related to a business-to-business direct debit (CSB58).
    /// Encoded/decoded by serializers as &quot;58&quot;.
    /// </summary>
    [EnumMember(Value = "58")]
    [IsoId("_tm5mjPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a business-to-business direct debit (CSB58).")]
    BusinessToBusinessDirectDebit,
    
    /// <summary>
    /// Transaction is related to a business-to-customer direct debit (CSB19).
    /// Encoded/decoded by serializers as &quot;19&quot;.
    /// </summary>
    [EnumMember(Value = "19")]
    [IsoId("_tnDXgPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a business-to-customer direct debit (CSB19).")]
    BusinessToCustomerDirectDebit,
    
    /// <summary>
    /// Indicates that the payment is sent by an authorized third party on behalf of the participant. 
    /// Encoded/decoded by serializers as &quot;ASTI&quot;.
    /// </summary>
    [EnumMember(Value = "ASTI")]
    [IsoId("_tnDXg_RYEeuLhpyIdtJzwg")]
    [Description(@"Indicates that the payment is sent by an authorized third party on behalf of the participant. ")]
    AncillarySystemTransferInitiation,
    
    /// <summary>
    /// Indicates that the payment was initiated manually using a GUI (Graphical User Interface).
    /// Encoded/decoded by serializers as &quot;BACP&quot;.
    /// </summary>
    [EnumMember(Value = "BACP")]
    [IsoId("_tnDXhvRYEeuLhpyIdtJzwg")]
    [Description(@"Indicates that the payment was initiated manually using a GUI (Graphical User Interface).")]
    BackupPayment,
    
    /// <summary>
    /// Indicates that the payment is sent by responsible Central Bank on behalf of the participant in case of contingency.
    /// Encoded/decoded by serializers as &quot;MANP&quot;.
    /// </summary>
    [EnumMember(Value = "MANP")]
    [IsoId("_tnDXifRYEeuLhpyIdtJzwg")]
    [Description(@"Indicates that the payment is sent by responsible Central Bank on behalf of the participant in case of contingency.")]
    MandatedPayment,
    
    /// <summary>
    /// Indicates that the payment is submitted to move  liquidity to the technical account - dedicated to real-time settlement in an external system (for example ancillary system) . The payment is processed in a separate payment queue besides the normal processing.
    /// Encoded/decoded by serializers as &quot;SBTI&quot;.
    /// </summary>
    [EnumMember(Value = "SBTI")]
    [IsoId("_tnNIgPRYEeuLhpyIdtJzwg")]
    [Description(@"Indicates that the payment is submitted to move  liquidity to the technical account - dedicated to real-time settlement in an external system (for example ancillary system) . The payment is processed in a separate payment queue besides the normal processing.")]
    SettlementBankTransferInitiation,
    
    /// <summary>
    /// Transaction is related to an urgent direct debit that is pre authorised (Avis de Prélèvement accéléré).
    /// Encoded/decoded by serializers as &quot;85&quot;.
    /// </summary>
    [EnumMember(Value = "85")]
    [IsoId("_tnNIg_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an urgent direct debit that is pre authorised (Avis de Prélèvement accéléré).")]
    PreauthorisedDirectDebitAccéléréAcceleratedClearing2DayOrdinaireNormalClearing4Day,
    
    /// <summary>
    /// Transaction is related to a direct debit that is pre authorised (Avis de Prélèvement).
    /// Encoded/decoded by serializers as &quot;08&quot;.
    /// </summary>
    [EnumMember(Value = "08")]
    [IsoId("_tnNIhvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is pre authorised (Avis de Prélèvement).")]
    PreauthorisedDirectDebitOrdinaireNormalClearing4Day,
    
    /// <summary>
    /// Transaction is related to an urgent direct debit that is pre authorised (Avis de Prélèvement vérifié).
    /// Encoded/decoded by serializers as &quot;89&quot;.
    /// </summary>
    [EnumMember(Value = "89")]
    [IsoId("_tnNIifRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an urgent direct debit that is pre authorised (Avis de Prélèvement vérifié).")]
    PreauthorisedDirectDebitVérifiéVerifiedClearing,
    
    /// <summary>
    /// LCR - Lettre de Change Relevé (Recovered Bill of Exchange) and BOR - Billet à Orde Relevé (Promissory Note)
    /// Encoded/decoded by serializers as &quot;60&quot;.
    /// </summary>
    [EnumMember(Value = "60")]
    [IsoId("_tnNIjPRYEeuLhpyIdtJzwg")]
    [Description(@"LCR - Lettre de Change Relevé (Recovered Bill of Exchange) and BOR - Billet à Orde Relevé (Promissory Note)")]
    RecoveredBillofExchangeorPromissoryNote,
    
    /// <summary>
    /// Transaction is related to a non-pre authorised collection (RIBA).
    /// Encoded/decoded by serializers as &quot;RIBA&quot;.
    /// </summary>
    [EnumMember(Value = "RIBA")]
    [IsoId("_tnW5gPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a non-pre authorised collection (RIBA).")]
    NonPreauthorisedDirectDebitRIBA,
    
    /// <summary>
    /// Transaction is related to a direct debit that is pre authorised and revocable (RID Ordinario).
    /// Encoded/decoded by serializers as &quot;RIDO&quot;.
    /// </summary>
    [EnumMember(Value = "RIDO")]
    [IsoId("_tnW5g_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a direct debit that is pre authorised and revocable (RID Ordinario).")]
    PreauthorisedRevocableDirectDebit,
    
    /// <summary>
    /// Transaction is related to an urgent direct debit that is pre authorised and revocable (RID Veloce).
    /// Encoded/decoded by serializers as &quot;RIDV&quot;.
    /// </summary>
    [EnumMember(Value = "RIDV")]
    [IsoId("_tngDcPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an urgent direct debit that is pre authorised and revocable (RID Veloce).")]
    PreauthorisedRevocableUrgentDirectDebit,
    
    /// <summary>
    /// Transaction is related to payments via internet owned by Currence.
    /// Encoded/decoded by serializers as &quot;IDEAL&quot;.
    /// </summary>
    [EnumMember(Value = "IDEAL")]
    [IsoId("_tngDc_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via internet owned by Currence.")]
    PaymentsViaInternetOwnedByCurrence,
    
    /// <summary>
    /// The transaction is related to a regular  Credit Transfer and will be instantly processed under the Dutch AOS on top of the EPC SCT scheme.
    /// Encoded/decoded by serializers as &quot;INSTNT01&quot;.
    /// </summary>
    [EnumMember(Value = "INSTNT01")]
    [IsoId("_tngDdvRYEeuLhpyIdtJzwg")]
    [Description(@"The transaction is related to a regular  Credit Transfer and will be instantly processed under the Dutch AOS on top of the EPC SCT scheme.")]
    InstantCreditTransferNotTimeCritical,
    
    /// <summary>
    /// The transaction is related to an Instant Credit Transfer under the rules of the Dutch AOS on top of the EPC SCT Inst scheme.
    /// Encoded/decoded by serializers as &quot;INSTTC01&quot;.
    /// </summary>
    [EnumMember(Value = "INSTTC01")]
    [IsoId("_tngDefRYEeuLhpyIdtJzwg")]
    [Description(@"The transaction is related to an Instant Credit Transfer under the rules of the Dutch AOS on top of the EPC SCT Inst scheme.")]
    InstantCreditTransferTimeCritical,
    
    /// <summary>
    /// Transaction is related to payments via internet owned by Currence which uses an Instant Credit Transfer.
    /// Encoded/decoded by serializers as &quot;INSTIDEAL&quot;.
    /// </summary>
    [EnumMember(Value = "INSTIDEAL")]
    [IsoId("_tngDfPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via internet owned by Currence which uses an Instant Credit Transfer.")]
    PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransfer,
    
    /// <summary>
    /// Transaction is related to payments via internet owned by Currence which uses a regular  Credit Transfer and will be instantly processed under the Dutch AOS on top of the EPC SCT scheme.
    /// Encoded/decoded by serializers as &quot;INSTNT01IDEAL&quot;.
    /// </summary>
    [EnumMember(Value = "INSTNT01IDEAL")]
    [IsoId("_tnp0cPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via internet owned by Currence which uses a regular  Credit Transfer and will be instantly processed under the Dutch AOS on top of the EPC SCT scheme.")]
    PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransferNotTimeCritical,
    
    /// <summary>
    /// Transaction is related to payments via internet owned by Currence which uses an Instant Credit Transfer under the rules of the Dutch AOS on top of the EPC SCT Inst scheme.
    /// Encoded/decoded by serializers as &quot;INSTTC01IDEAL&quot;.
    /// </summary>
    [EnumMember(Value = "INSTTC01IDEAL")]
    [IsoId("_tnp0c_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via internet owned by Currence which uses an Instant Credit Transfer under the rules of the Dutch AOS on top of the EPC SCT Inst scheme.")]
    PaymentsViaInternetOwnedByCurrenceUsingInstantCreditTransferTimeCritical,
    
    /// <summary>
    /// Transaction is related to a Domestic payment initiated by PAIN.001
    /// Encoded/decoded by serializers as &quot;NLDO&quot;.
    /// </summary>
    [EnumMember(Value = "NLDO")]
    [IsoId("_tnp0dvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a Domestic payment initiated by PAIN.001")]
    DutchDomesticBulkPayment,
    
    /// <summary>
    /// Transaction is related to a Domestic payment initiated by PAIN.001
    /// Encoded/decoded by serializers as &quot;NLUP&quot;.
    /// </summary>
    [EnumMember(Value = "NLUP")]
    [IsoId("_tny-YPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a Domestic payment initiated by PAIN.001")]
    DutchUrgentPayment,
    
    /// <summary>
    /// Transaction is related to payments via a ‘Standaard Digitale Nota’ InvoiceAcceptgiro payment.
    /// Encoded/decoded by serializers as &quot;SDN&quot;.
    /// </summary>
    [EnumMember(Value = "SDN")]
    [IsoId("_tny-Y_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via a ‘Standaard Digitale Nota’ InvoiceAcceptgiro payment.")]
    PaymentsViaStandaardDigitaleNota,
    
    /// <summary>
    /// Transaction is related to payments via Acceptgiro owned by Currence.
    /// Encoded/decoded by serializers as &quot;ACCEPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCEPT")]
    [IsoId("_tn8vYPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to payments via Acceptgiro owned by Currence.")]
    PaymentViaAcceptgiroOwnedByCurrence,
    
    /// <summary>
    /// Transaction is related to an Incident Management Correction procedure based on the DD infrastructure.
    /// Encoded/decoded by serializers as &quot;ICMC&quot;.
    /// </summary>
    [EnumMember(Value = "ICMC")]
    [IsoId("_tn8vY_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an Incident Management Correction procedure based on the DD infrastructure.")]
    IncidentManagementCorrection,
    
    /// <summary>
    /// Transaction is related to direct debit scheme owned by the NVB.
    /// Encoded/decoded by serializers as &quot;NLGOV&quot;.
    /// </summary>
    [EnumMember(Value = "NLGOV")]
    [IsoId("_tn8vZvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to direct debit scheme owned by the NVB.")]
    DirectDebitInitiatedByTheGovernmentWithSpecialConditions,
    
    /// <summary>
    /// Transaction is related to mass payment beneficiary.|
    /// Encoded/decoded by serializers as &quot;0090&quot;.
    /// </summary>
    [EnumMember(Value = "0090")]
    [IsoId("_tn8vafRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to mass payment beneficiary.|")]
    MassPaymentBeneficiary,
    
    /// <summary>
    /// Transaction is related to mass payment ours.|
    /// Encoded/decoded by serializers as &quot;0091&quot;.
    /// </summary>
    [EnumMember(Value = "0091")]
    [IsoId("_tn8vbPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to mass payment ours.|")]
    MassPaymentOurs,
    
    /// <summary>
    /// Transaction is related to mass payment shared.|
    /// Encoded/decoded by serializers as &quot;0092&quot;.
    /// </summary>
    [EnumMember(Value = "0092")]
    [IsoId("_toF5UPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to mass payment shared.|")]
    MassPaymentShared,
    
    /// <summary>
    /// Transaction is related to standing order.
    /// Encoded/decoded by serializers as &quot;0002&quot;.
    /// </summary>
    [EnumMember(Value = "0002")]
    [IsoId("_toF5U_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to standing order.")]
    StandingOrder,
    
    /// <summary>
    /// Transaction is related to one-off authorisation.
    /// Encoded/decoded by serializers as &quot;0221&quot;.
    /// </summary>
    [EnumMember(Value = "0221")]
    [IsoId("_toF5VvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to one-off authorisation.")]
    OneOffAuthorisation,
    
    /// <summary>
    /// Transaction is related to one-off authorisation charities.
    /// Encoded/decoded by serializers as &quot;0224&quot;.
    /// </summary>
    [EnumMember(Value = "0224")]
    [IsoId("_toF5WfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to one-off authorisation charities.")]
    OneOffAuthorisationCharities,
    
    /// <summary>
    /// Transaction is related to one-off authorisation construction industry.
    /// Encoded/decoded by serializers as &quot;0226&quot;.
    /// </summary>
    [EnumMember(Value = "0226")]
    [IsoId("_toPqUPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to one-off authorisation construction industry.")]
    OneOffAuthorisationConstructionIndustry,
    
    /// <summary>
    /// Transaction is related to one-off authorisation tuition fees.
    /// Encoded/decoded by serializers as &quot;0225&quot;.
    /// </summary>
    [EnumMember(Value = "0225")]
    [IsoId("_toPqU_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to one-off authorisation tuition fees.")]
    OneOffAuthorisationTuitionFees,
    
    /// <summary>
    /// Transaction is related to standing authorisation companies.
    /// Encoded/decoded by serializers as &quot;0222&quot;.
    /// </summary>
    [EnumMember(Value = "0222")]
    [IsoId("_toPqVvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to standing authorisation companies.")]
    StandingAuthorisationCompanies,
    
    /// <summary>
    /// Transaction is related to standing authorisation companies without debtor revocation right.
    /// Encoded/decoded by serializers as &quot;0227&quot;.
    /// </summary>
    [EnumMember(Value = "0227")]
    [IsoId("_toZbUPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to standing authorisation companies without debtor revocation right.")]
    StandingAuthorisationCompaniesWithoutDebtorRevocationRight,
    
    /// <summary>
    /// Transaction is related to standing authorisation general.|
    /// Encoded/decoded by serializers as &quot;0220&quot;.
    /// </summary>
    [EnumMember(Value = "0220")]
    [IsoId("_toZbU_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to standing authorisation general.|")]
    StandingAuthorisationGeneral,
    
    /// <summary>
    /// Transaction is related to standing authorisation lotteries.
    /// Encoded/decoded by serializers as &quot;0223&quot;.
    /// </summary>
    [EnumMember(Value = "0223")]
    [IsoId("_toilQPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to standing authorisation lotteries.")]
    StandingAuthorisationLotteries,
    
    /// <summary>
    /// Transaction is related to converted (bank) payment.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process.The instrument rules change upon conversion.
    /// Encoded/decoded by serializers as &quot;0001&quot;.
    /// </summary>
    [EnumMember(Value = "0001")]
    [IsoId("_toilQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to converted (bank) payment.|Conversion of physical instrument to electonric form for transmission to the paying bank and where the original paper document does not continue in the clearing process.The instrument rules change upon conversion.")]
    ConvertedBankPayment,
    
    /// <summary>
    /// Transaction is related to business payment
    /// Encoded/decoded by serializers as &quot;0000&quot;.
    /// </summary>
    [EnumMember(Value = "0000")]
    [IsoId("_toilRvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to business payment")]
    BusinessPayment,
    
    /// <summary>
    /// Transaction is related to cross border customer credit transfer.
    /// Encoded/decoded by serializers as &quot;IN&quot;.
    /// </summary>
    [EnumMember(Value = "IN")]
    [IsoId("_tosWQPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to cross border customer credit transfer.")]
    CrossBorderCustomerCreditTransfer,
    
    /// <summary>
    /// Transaction is related to overnight clearing.
    /// Encoded/decoded by serializers as &quot;ONCL&quot;.
    /// </summary>
    [EnumMember(Value = "ONCL")]
    [IsoId("_tosWQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to overnight clearing.")]
    Overnight,
    
    /// <summary>
    /// Credit transfer contains Extended Remittance Information (ERI) as defined within the applicable scheme.
    /// Encoded/decoded by serializers as &quot;PERI&quot;.
    /// </summary>
    [EnumMember(Value = "PERI")]
    [IsoId("_tosWRvRYEeuLhpyIdtJzwg")]
    [Description(@"Credit transfer contains Extended Remittance Information (ERI) as defined within the applicable scheme.")]
    PaymentWithERI,
    
    /// <summary>
    /// Transaction is related to New Zealand High Value Clearing System (HVCS) same day clearing payments.
    /// Encoded/decoded by serializers as &quot;SDCL&quot;.
    /// </summary>
    [EnumMember(Value = "SDCL")]
    [IsoId("_tosWSfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to New Zealand High Value Clearing System (HVCS) same day clearing payments.")]
    SameDayClearedPayments,
    
    /// <summary>
    /// SEPA Core Direct Debit with ‘no refund’ option
    /// Encoded/decoded by serializers as &quot;DDNR&quot;.
    /// </summary>
    [EnumMember(Value = "DDNR")]
    [IsoId("_tosWTPRYEeuLhpyIdtJzwg")]
    [Description(@"SEPA Core Direct Debit with ‘no refund’ option")]
    CoreNoRefund,
    
    /// <summary>
    /// SEPA Fixed Amount Direct Debit
    /// Encoded/decoded by serializers as &quot;DDFA&quot;.
    /// </summary>
    [EnumMember(Value = "DDFA")]
    [IsoId("_to2HQPRYEeuLhpyIdtJzwg")]
    [Description(@"SEPA Fixed Amount Direct Debit")]
    DirectDebitFixedAmount,
    
    /// <summary>
    /// Transaction is related to SEPA direct debit -core.
    /// Encoded/decoded by serializers as &quot;CORE&quot;.
    /// </summary>
    [EnumMember(Value = "CORE")]
    [IsoId("_to2HQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to SEPA direct debit -core.")]
    SEPADirectDebitCore,
    
    /// <summary>
    /// SEPA B2B Direct Debit AMI based on a paper mandate
    /// Encoded/decoded by serializers as &quot;B2BAMIPM&quot;.
    /// </summary>
    [EnumMember(Value = "B2BAMIPM")]
    [IsoId("_to_RMPRYEeuLhpyIdtJzwg")]
    [Description(@"SEPA B2B Direct Debit AMI based on a paper mandate")]
    SEPAB2BDirectDebitAMI,
    
    /// <summary>
    /// Transaction is related to SEPA business to business direct debit.
    /// Encoded/decoded by serializers as &quot;B2B&quot;.
    /// </summary>
    [EnumMember(Value = "B2B")]
    [IsoId("_to_RM_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to SEPA business to business direct debit.")]
    SEPABusinessToBusinessDirectDebit,
    
    /// <summary>
    /// Optional shorter time cycle (D-1) for SEPA Core Direct Debit AMI based on a paper mandate
    /// Encoded/decoded by serializers as &quot;CR1AMIPM&quot;.
    /// </summary>
    [EnumMember(Value = "CR1AMIPM")]
    [IsoId("_to_RNvRYEeuLhpyIdtJzwg")]
    [Description(@"Optional shorter time cycle (D-1) for SEPA Core Direct Debit AMI based on a paper mandate")]
    SEPACoreD1DirectDebitAMI,
    
    /// <summary>
    /// SEPA Core Direct Debit AMI based on a paper mandate
    /// Encoded/decoded by serializers as &quot;CORAMIPM&quot;.
    /// </summary>
    [EnumMember(Value = "CORAMIPM")]
    [IsoId("_to_ROfRYEeuLhpyIdtJzwg")]
    [Description(@"SEPA Core Direct Debit AMI based on a paper mandate")]
    SEPACoreDirectDebitAMI,
    
    /// <summary>
    /// Optional shorter time cycle (D-1) for SEPA Core Direct Debit
    /// Encoded/decoded by serializers as &quot;COR1&quot;.
    /// </summary>
    [EnumMember(Value = "COR1")]
    [IsoId("_to_RPPRYEeuLhpyIdtJzwg")]
    [Description(@"Optional shorter time cycle (D-1) for SEPA Core Direct Debit")]
    SEPADirectDebit1DaySettlement,
    
    /// <summary>
    /// SEPA Fixed Amount Direct Debit AMI based on a paper mandate
    /// Encoded/decoded by serializers as &quot;FADAMIPM&quot;.
    /// </summary>
    [EnumMember(Value = "FADAMIPM")]
    [IsoId("_tpJCMPRYEeuLhpyIdtJzwg")]
    [Description(@"SEPA Fixed Amount Direct Debit AMI based on a paper mandate")]
    SEPAFADirectDebitAMI,
    
    /// <summary>
    /// Transaction is related to the CLSClearedFX service for Eurex.  |Usage: The code is mandatory for all pacs.009 payments to this service.
    /// Encoded/decoded by serializers as &quot;CLSCCPERX&quot;.
    /// </summary>
    [EnumMember(Value = "CLSCCPERX")]
    [IsoId("_tpJCM_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the CLSClearedFX service for Eurex.  |Usage: The code is mandatory for all pacs.009 payments to this service.")]
    CLSClearedFXForEurex,
    
    /// <summary>
    /// Transaction is related to the CLSClearedFX service for London Exchange Clearing House. |Usage: The code is mandatory for all pacs.009 payments to this service.
    /// Encoded/decoded by serializers as &quot;CLSCCPLCH&quot;.
    /// </summary>
    [EnumMember(Value = "CLSCCPLCH")]
    [IsoId("_tpJCNvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the CLSClearedFX service for London Exchange Clearing House. |Usage: The code is mandatory for all pacs.009 payments to this service.")]
    CLSClearedFXForLCH,
    
    /// <summary>
    /// Transaction is related to an Instant Credit Transfer.|Use case example: SEPA Instant Credit Transfer (SCT Inst)
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_tpJCOfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an Instant Credit Transfer.|Use case example: SEPA Instant Credit Transfer (SCT Inst)")]
    InstantCreditTransfer,
    
    /// <summary>
    /// Transaction is authenticated direct debit for domestic use.
    /// Encoded/decoded by serializers as &quot;ADD&quot;.
    /// </summary>
    [EnumMember(Value = "ADD")]
    [IsoId("_tpJCPPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is authenticated direct debit for domestic use.")]
    AuthenticatedDirectDebit,
    
    /// <summary>
    /// Transaction is unauthenticated direct debit for domestic use.
    /// Encoded/decoded by serializers as &quot;UDD&quot;.
    /// </summary>
    [EnumMember(Value = "UDD")]
    [IsoId("_tpSzMPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is unauthenticated direct debit for domestic use.")]
    UnauthenticatedDirectDebit,
    
    /// <summary>
    /// Transaction is related to an intra-group bank initiated cash management payment
    /// Encoded/decoded by serializers as &quot;CCI&quot;.
    /// </summary>
    [EnumMember(Value = "CCI")]
    [IsoId("_tpSzM_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to an intra-group bank initiated cash management payment")]
    CashConcentrationIntragroup,
    
    /// <summary>
    /// Transaction is related to a bank transfer.
    /// Encoded/decoded by serializers as &quot;BTR&quot;.
    /// </summary>
    [EnumMember(Value = "BTR")]
    [IsoId("_tpb9IPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a bank transfer.")]
    BankTransfer,
    
    /// <summary>
    /// Transaction is related to check same day settlement wire.
    /// Encoded/decoded by serializers as &quot;CKS&quot;.
    /// </summary>
    [EnumMember(Value = "CKS")]
    [IsoId("_tpb9I_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to check same day settlement wire.")]
    CheckSameDaySettlementWire,
    
    /// <summary>
    /// Transaction is related to customer transfer.
    /// Encoded/decoded by serializers as &quot;CTR&quot;.
    /// </summary>
    [EnumMember(Value = "CTR")]
    [IsoId("_tpluIPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to customer transfer.")]
    CustomerTransfer,
    
    /// <summary>
    /// Transaction is related to a customer transfer, which may include information related to a cover payment or extended remittance information.  
    /// Encoded/decoded by serializers as &quot;CTP&quot;.
    /// </summary>
    [EnumMember(Value = "CTP")]
    [IsoId("_tpluI_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a customer transfer, which may include information related to a cover payment or extended remittance information.  ")]
    CustomerTransferPlus,
    
    /// <summary>
    /// Transaction is related to deposit to sender&apos;s account.
    /// Encoded/decoded by serializers as &quot;DEP&quot;.
    /// </summary>
    [EnumMember(Value = "DEP")]
    [IsoId("_tpluJvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to deposit to sender's account.")]
    DepositToSendersAccount,
    
    /// <summary>
    /// Transaction is related to Fed funds returned.
    /// Encoded/decoded by serializers as &quot;FFR&quot;.
    /// </summary>
    [EnumMember(Value = "FFR")]
    [IsoId("_tpluKfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to Fed funds returned.")]
    FedFundsReturned,
    
    /// <summary>
    /// Transaction is related to Fed funds sold.
    /// Encoded/decoded by serializers as &quot;FFS&quot;.
    /// </summary>
    [EnumMember(Value = "FFS")]
    [IsoId("_tpvfIPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to Fed funds sold.")]
    FedFundsSold,
    
    /// <summary>
    /// Transaction is related to non-value service message.
    /// Encoded/decoded by serializers as &quot;SVC&quot;.
    /// </summary>
    [EnumMember(Value = "SVC")]
    [IsoId("_tpvfI_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to non-value service message.")]
    NonValueServiceMessage,
    
    /// <summary>
    /// Transaction is related to drawdown response (value) to honor a drawdown request.
    /// Encoded/decoded by serializers as &quot;DRW&quot;.
    /// </summary>
    [EnumMember(Value = "DRW")]
    [IsoId("_tpvfJvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to drawdown response (value) to honor a drawdown request.")]
    DrawdownResponseValueToHonorADrawdownRequest,
    
    /// <summary>
    /// Transaction is related to bank-to-bank drawdown request or response (non-value)
    /// Encoded/decoded by serializers as &quot;DRB&quot;.
    /// </summary>
    [EnumMember(Value = "DRB")]
    [IsoId("_tpvfKfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to bank-to-bank drawdown request or response (non-value)")]
    BankToBankDrawdownRequestOrResponseNonvalue,
    
    /// <summary>
    /// Transaction is related to customer or corporate drawdown request or response (non-value).
    /// Encoded/decoded by serializers as &quot;DRC&quot;.
    /// </summary>
    [EnumMember(Value = "DRC")]
    [IsoId("_tpvfLPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to customer or corporate drawdown request or response (non-value).")]
    CustomerOrCorporateDrawdownRequestOrResponseNonvalue,
    
    /// <summary>
    /// Transaction is related to international ACH.
    /// Encoded/decoded by serializers as &quot;IAT&quot;.
    /// </summary>
    [EnumMember(Value = "IAT")]
    [IsoId("_tp4pEPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to international ACH.")]
    InternationalACH,
    
    /// <summary>
    /// Transaction is related to cash concentration or disbursement corporate counterparty.
    /// Encoded/decoded by serializers as &quot;CCD&quot;.
    /// </summary>
    [EnumMember(Value = "CCD")]
    [IsoId("_tp4pE_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to cash concentration or disbursement corporate counterparty.")]
    CashConcentrationOrDisbursementCorporateCounterparty,
    
    /// <summary>
    /// Transaction is related to corporate trade exchange.
    /// Encoded/decoded by serializers as &quot;CTX&quot;.
    /// </summary>
    [EnumMember(Value = "CTX")]
    [IsoId("_tp4pFvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to corporate trade exchange.")]
    CorporateTradeExchange,
    
    /// <summary>
    /// Transaction is related to prearranged payment or deposit consumer counterparty.
    /// Encoded/decoded by serializers as &quot;PPD&quot;.
    /// </summary>
    [EnumMember(Value = "PPD")]
    [IsoId("_tp4pGfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to prearranged payment or deposit consumer counterparty.")]
    PrearrangedPaymentOrDepositConsumerCounterparty,
    
    /// <summary>
    /// A credit entry initiated by or on behalf of the holder of a consumer account
    /// Encoded/decoded by serializers as &quot;CIE&quot;.
    /// </summary>
    [EnumMember(Value = "CIE")]
    [IsoId("_tp4pHPRYEeuLhpyIdtJzwg")]
    [Description(@"A credit entry initiated by or on behalf of the holder of a consumer account")]
    CustomerInitiatedEntry,
    
    /// <summary>
    /// Transaction is related to re-presented check entry.
    /// Encoded/decoded by serializers as &quot;RCK&quot;.
    /// </summary>
    [EnumMember(Value = "RCK")]
    [IsoId("_tqCaEPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to re-presented check entry.")]
    RepresentedCheckEntry,
    
    /// <summary>
    /// Transaction is related to accounts receivable check.
    /// Encoded/decoded by serializers as &quot;ARC&quot;.
    /// </summary>
    [EnumMember(Value = "ARC")]
    [IsoId("_tqCaE_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to accounts receivable check.")]
    AccountsReceivableCheck,
    
    /// <summary>
    /// Transaction is related to internet initiated entry.
    /// Encoded/decoded by serializers as &quot;WEB&quot;.
    /// </summary>
    [EnumMember(Value = "WEB")]
    [IsoId("_tqCaFvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to internet initiated entry.")]
    InternetInitiatedEntry,
    
    /// <summary>
    /// Transaction is related to point-of-purchase.
    /// Encoded/decoded by serializers as &quot;POP&quot;.
    /// </summary>
    [EnumMember(Value = "POP")]
    [IsoId("_tqLkAPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to point-of-purchase.")]
    PointOfPurchase,
    
    /// <summary>
    /// Transaction is related to point-of-sale.
    /// Encoded/decoded by serializers as &quot;POS&quot;.
    /// </summary>
    [EnumMember(Value = "POS")]
    [IsoId("_tqLkA_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to point-of-sale.")]
    PointOfSale,
    
    /// <summary>
    /// Transaction is related to telephone initiated entry.
    /// Encoded/decoded by serializers as &quot;TEL&quot;.
    /// </summary>
    [EnumMember(Value = "TEL")]
    [IsoId("_tqLkBvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to telephone initiated entry.")]
    TelephoneInitiatedEntry,
    
    /// <summary>
    /// Request-to-pay preferred payment via Credit Transfer but Instant Credit Transfer is also possible.
    /// Encoded/decoded by serializers as &quot;CTP&quot;.
    /// </summary>
    [EnumMember(Value = "CTP")]
    [IsoId("_o0mT8FEEEey6cYDbEubNXg")]
    [Description(@"Request-to-pay preferred payment via Credit Transfer but Instant Credit Transfer is also possible.")]
    CreditTransferPreferred,
    
    /// <summary>
    /// Request-to-pay preferred payment via Instant Credit Transfer but Credit Transfer is also possible.
    /// Encoded/decoded by serializers as &quot;ITP&quot;.
    /// </summary>
    [EnumMember(Value = "ITP")]
    [IsoId("_60dy0FEEEey6cYDbEubNXg")]
    [Description(@"Request-to-pay preferred payment via Instant Credit Transfer but Credit Transfer is also possible.")]
    InstantCreditTransferPreferred,
    
    /// <summary>
    /// Type of New Payments Architecture (NPA) payment. Payments are processed over a three-day cycle and available to customers early in the morning of Day 3.
    /// Encoded/decoded by serializers as &quot;MDP&quot;.
    /// </summary>
    [EnumMember(Value = "MDP")]
    [IsoId("_Uq5aoOAmEey0k8vo1GQhqQ")]
    [Description(@"Type of New Payments Architecture (NPA) payment. Payments are processed over a three-day cycle and available to customers early in the morning of Day 3.")]
    MultiDayPayment,
    
}
