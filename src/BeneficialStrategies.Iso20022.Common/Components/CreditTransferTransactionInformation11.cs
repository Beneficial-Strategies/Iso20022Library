// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransactionInformation11"/>
[IsoId("_P2y-uNp-Ed-ak6NoX_4Aeg_167029543")]
[DisplayName("Credit Transfer Transaction Information")]
public partial record CreditTransferTransactionInformation11
{
    /// <inheritdoc cref="ICreditTransferTransactionInformation11.PaymentIdentification"/>
    [IsoId("_P2y-udp-Ed-ak6NoX_4Aeg_167031446")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.PaymentTypeInformation"/>
    [IsoId("_P2y-utp-Ed-ak6NoX_4Aeg_167952095")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.InterbankSettlementAmount"/>
    [IsoId("_P2y-u9p-Ed-ak6NoX_4Aeg_167029574")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.InterbankSettlementDate"/>
    [IsoId("_P2y-vNp-Ed-ak6NoX_4Aeg_167029604")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.SettlementPriority"/>
    [IsoId("_P2y-vdp-Ed-ak6NoX_4Aeg_-1033995353")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.SettlementTimeIndication"/>
    [IsoId("_P2y-vtp-Ed-ak6NoX_4Aeg_167951602")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.SettlementTimeRequest"/>
    [IsoId("_P28vsNp-Ed-ak6NoX_4Aeg_167031385")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.AcceptanceDateTime"/>
    [IsoId("_P28vsdp-Ed-ak6NoX_4Aeg_167030036")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.PoolingAdjustmentDate"/>
    [IsoId("_P28vstp-Ed-ak6NoX_4Aeg_167030067")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.InstructedAmount"/>
    [IsoId("_P28vs9p-Ed-ak6NoX_4Aeg_167029914")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.ExchangeRate"/>
    [IsoId("_P28vtNp-Ed-ak6NoX_4Aeg_167029944")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.ChargeBearer"/>
    [IsoId("_P28vtdp-Ed-ak6NoX_4Aeg_167030006")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.ChargesInformation"/>
    [IsoId("_P28vttp-Ed-ak6NoX_4Aeg_167951724")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation5> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.PreviousInstructingAgent"/>
    [IsoId("_P28vt9p-Ed-ak6NoX_4Aeg_167952457")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.PreviousInstructingAgentAccount"/>
    [IsoId("_P28vuNp-Ed-ak6NoX_4Aeg_167030530")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount16? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.InstructingAgent"/>
    [IsoId("_P28vudp-Ed-ak6NoX_4Aeg_167951479")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.InstructedAgent"/>
    [IsoId("_P3F5oNp-Ed-ak6NoX_4Aeg_167952518")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.IntermediaryAgent1"/>
    [IsoId("_P3F5odp-Ed-ak6NoX_4Aeg_167951571")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.IntermediaryAgent1Account"/>
    [IsoId("_P3F5otp-Ed-ak6NoX_4Aeg_167030839")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount16? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.IntermediaryAgent2"/>
    [IsoId("_P3F5o9p-Ed-ak6NoX_4Aeg_167952610")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.IntermediaryAgent2Account"/>
    [IsoId("_P3F5pNp-Ed-ak6NoX_4Aeg_167030469")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount16? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.IntermediaryAgent3"/>
    [IsoId("_P3F5pdp-Ed-ak6NoX_4Aeg_167952579")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.IntermediaryAgent3Account"/>
    [IsoId("_P3F5ptp-Ed-ak6NoX_4Aeg_167030900")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount16? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.UltimateDebtor"/>
    [IsoId("_P3F5p9p-Ed-ak6NoX_4Aeg_167030992")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.InitiatingParty"/>
    [IsoId("_P3PqoNp-Ed-ak6NoX_4Aeg_167030963")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification32? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.Debtor"/>
    [IsoId("_P3Pqodp-Ed-ak6NoX_4Aeg_167031053")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification32 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.DebtorAccount"/>
    [IsoId("_P3Pqotp-Ed-ak6NoX_4Aeg_167030560")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount16? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.DebtorAgent"/>
    [IsoId("_P3Pqo9p-Ed-ak6NoX_4Aeg_167952671")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.DebtorAgentAccount"/>
    [IsoId("_P3PqpNp-Ed-ak6NoX_4Aeg_167030407")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount16? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.CreditorAgent"/>
    [IsoId("_P3Y0kNp-Ed-ak6NoX_4Aeg_167951510")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.CreditorAgentAccount"/>
    [IsoId("_P3Y0kdp-Ed-ak6NoX_4Aeg_167030438")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount16? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.Creditor"/>
    [IsoId("_P3Y0ktp-Ed-ak6NoX_4Aeg_167031137")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification32 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.CreditorAccount"/>
    [IsoId("_P3Y0k9p-Ed-ak6NoX_4Aeg_167952733")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.UltimateCreditor"/>
    [IsoId("_P3Y0lNp-Ed-ak6NoX_4Aeg_167031084")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.InstructionForCreditorAgent"/>
    [IsoId("_P3Y0ldp-Ed-ak6NoX_4Aeg_167952064")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.InstructionForNextAgent"/>
    [IsoId("_P3Y0ltp-Ed-ak6NoX_4Aeg_167952156")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.Purpose"/>
    [IsoId("_P3Y0l9p-Ed-ak6NoX_4Aeg_167030129")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.RegulatoryReporting"/>
    [IsoId("_P3Y0mNp-Ed-ak6NoX_4Aeg_167030098")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.RelatedRemittanceInformation"/>
    [IsoId("_P3ilkNp-Ed-ak6NoX_4Aeg_167952003")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation11.RemittanceInformation"/>
    [IsoId("_P3ilkdp-Ed-ak6NoX_4Aeg_167951663")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation5? RemittanceInformation { get; init; }
}
