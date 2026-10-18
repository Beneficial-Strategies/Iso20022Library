// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction73"/>
[IsoId("d64d5a68-1284-4122-abcc-66b60f276023")]
[DisplayName("Credit Transfer Transaction73")]
public partial record CreditTransferTransaction73
{
    /// <inheritdoc cref="ICreditTransferTransaction73.PaymentIdentification"/>
    [IsoId("d64d5a68-0001-0001-0001-12844122abcc")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.PaymentTypeInformation"/>
    [IsoId("d64d5a68-0002-0002-0002-12844122abcc")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.InterbankSettlementAmount"/>
    [IsoId("d64d5a68-0003-0003-0003-12844122abcc")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.InterbankSettlementDate"/>
    [IsoId("d64d5a68-0004-0004-0004-12844122abcc")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.SettlementPriority"/>
    [IsoId("d64d5a68-0005-0005-0005-12844122abcc")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.SettlementTimeIndication"/>
    [IsoId("d64d5a68-0006-0006-0006-12844122abcc")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.SettlementTimeRequest"/>
    [IsoId("d64d5a68-0007-0007-0007-12844122abcc")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.AdditionalDateTime"/>
    [DisplayName("Additional Date Time")]
    [IsoXmlTag("AddtlDtTm")]
    public AdditionalDateTime1? AdditionalDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.InstructedAmount"/>
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.ChargeBearer"/>
    [IsoId("d64d5a68-0008-0008-0008-12844122abcc")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.ChargesInformation"/>
    [IsoId("d64d5a68-0009-0009-0009-12844122abcc")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges16> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction73.ExchangeRate"/>
    [IsoId("d64d5a68-0010-0010-0010-12844122abcc")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.AgreedRate"/>
    [IsoId("d64d5a68-0011-0011-0011-12844122abcc")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public CurrencyExchange26? AgreedRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.MandateRelatedInformation"/>
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.PaymentSignature"/>
    [DisplayName("Payment Signature")]
    [IsoXmlTag("PmtSgntr")]
    public CryptographicKey1Choice_? PaymentSignature { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.PreviousInstructingAgent1"/>
    [IsoId("d64d5a68-0012-0012-0012-12844122abcc")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.PreviousInstructingAgent1Account"/>
    [IsoId("d64d5a68-0013-0013-0013-12844122abcc")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount40? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.PreviousInstructingAgent2"/>
    [IsoId("d64d5a68-0014-0014-0014-12844122abcc")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.PreviousInstructingAgent2Account"/>
    [IsoId("d64d5a68-0015-0015-0015-12844122abcc")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount40? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.PreviousInstructingAgent3"/>
    [IsoId("d64d5a68-0016-0016-0016-12844122abcc")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.PreviousInstructingAgent3Account"/>
    [IsoId("d64d5a68-0017-0017-0017-12844122abcc")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount40? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.InstructingAgent"/>
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.InstructedAgent"/>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.IntermediaryAgent1"/>
    [IsoId("d64d5a68-0018-0018-0018-12844122abcc")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.IntermediaryAgent1Account"/>
    [IsoId("d64d5a68-0019-0019-0019-12844122abcc")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.IntermediaryAgent2"/>
    [IsoId("d64d5a68-0020-0020-0020-12844122abcc")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.IntermediaryAgent2Account"/>
    [IsoId("d64d5a68-0021-0021-0021-12844122abcc")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.IntermediaryAgent3"/>
    [IsoId("d64d5a68-0022-0022-0022-12844122abcc")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.IntermediaryAgent3Account"/>
    [IsoId("d64d5a68-0023-0023-0023-12844122abcc")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.Debtor"/>
    [IsoId("d64d5a68-0024-0024-0024-12844122abcc")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification272 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.DebtorAccount"/>
    [IsoId("d64d5a68-0025-0025-0025-12844122abcc")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.DebtorAgent"/>
    [IsoId("d64d5a68-0026-0026-0026-12844122abcc")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.DebtorAgentAccount"/>
    [IsoId("d64d5a68-0027-0027-0027-12844122abcc")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.UltimateDebtor"/>
    [IsoId("d64d5a68-0028-0028-0028-12844122abcc")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.InitiatingParty"/>
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification272? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.CreditorAgent"/>
    [IsoId("d64d5a68-0029-0029-0029-12844122abcc")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.CreditorAgentAccount"/>
    [IsoId("d64d5a68-0030-0030-0030-12844122abcc")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.Creditor"/>
    [IsoId("d64d5a68-0031-0031-0031-12844122abcc")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.CreditorAccount"/>
    [IsoId("d64d5a68-0032-0032-0032-12844122abcc")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.UltimateCreditor"/>
    [IsoId("d64d5a68-0033-0033-0033-12844122abcc")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.InstructionForCreditorAgent"/>
    [IsoId("d64d5a68-0034-0034-0034-12844122abcc")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction73.InstructionForNextAgent"/>
    [IsoId("d64d5a68-0035-0035-0035-12844122abcc")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction73.Purpose"/>
    [IsoId("d64d5a68-0036-0036-0036-12844122abcc")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.RegulatoryReporting"/>
    [IsoId("d64d5a68-0037-0037-0037-12844122abcc")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public ValueList<RegulatoryReporting10> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction73.Tax"/>
    [IsoId("d64d5a68-0038-0038-0038-12844122abcc")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxData1? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.RelatedRemittanceInformation"/>
    [IsoId("d64d5a68-0039-0039-0039-12844122abcc")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public ValueList<RemittanceLocation8> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction73.RemittanceInformation"/>
    [IsoId("d64d5a68-0040-0040-0040-12844122abcc")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation22? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction73.SupplementaryData"/>
    [IsoId("d64d5a68-0041-0041-0041-12844122abcc")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
