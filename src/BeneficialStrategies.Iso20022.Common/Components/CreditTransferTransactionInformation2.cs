// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransactionInformation2"/>
[IsoId("_PwY0tdp-Ed-ak6NoX_4Aeg_-106374737")]
[DisplayName("Credit Transfer Transaction Information")]
public partial record CreditTransferTransactionInformation2
{
    /// <inheritdoc cref="ICreditTransferTransactionInformation2.PaymentIdentification"/>
    [IsoId("_PwY0ttp-Ed-ak6NoX_4Aeg_2098070233")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification2 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.PaymentTypeInformation"/>
    [IsoId("_PwY0t9p-Ed-ak6NoX_4Aeg_682307452")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation3? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.InterbankSettlementAmount"/>
    [IsoId("_PwY0uNp-Ed-ak6NoX_4Aeg_-1322502579")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required CurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.InterbankSettlementDate"/>
    [IsoId("_PwY0udp-Ed-ak6NoX_4Aeg_-767465995")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.SettlementTimeIndication"/>
    [IsoId("_PwY0utp-Ed-ak6NoX_4Aeg_6445050")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.SettlementTimeRequest"/>
    [IsoId("_PwY0u9p-Ed-ak6NoX_4Aeg_966462995")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest1? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.AcceptanceDateTime"/>
    [IsoId("_PwY0vNp-Ed-ak6NoX_4Aeg_1053866212")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.PoolingAdjustmentDate"/>
    [IsoId("_PwilsNp-Ed-ak6NoX_4Aeg_-781739202")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.InstructedAmount"/>
    [IsoId("_Pwilsdp-Ed-ak6NoX_4Aeg_-1297565992")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public CurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.ExchangeRate"/>
    [IsoId("_Pwilstp-Ed-ak6NoX_4Aeg_-986341048")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.ChargeBearer"/>
    [IsoId("_Pwils9p-Ed-ak6NoX_4Aeg_-930005781")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.ChargesInformation"/>
    [IsoId("_PwiltNp-Ed-ak6NoX_4Aeg_-332920223")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation1> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.PreviousInstructingAgent"/>
    [IsoId("_Pwiltdp-Ed-ak6NoX_4Aeg_-2071059758")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.PreviousInstructingAgentAccount"/>
    [IsoId("_Pwilttp-Ed-ak6NoX_4Aeg_1032911358")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount7? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.InstructingAgent"/>
    [IsoId("_Pwilt9p-Ed-ak6NoX_4Aeg_-2040581709")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.InstructedAgent"/>
    [IsoId("_PwiluNp-Ed-ak6NoX_4Aeg_-2113539496")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.IntermediaryAgent1"/>
    [IsoId("_Pwiludp-Ed-ak6NoX_4Aeg_1809247478")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.IntermediaryAgent1Account"/>
    [IsoId("_PwrvoNp-Ed-ak6NoX_4Aeg_-1491069251")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount7? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.IntermediaryAgent2"/>
    [IsoId("_Pwrvodp-Ed-ak6NoX_4Aeg_-1981475557")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.IntermediaryAgent2Account"/>
    [IsoId("_Pwrvotp-Ed-ak6NoX_4Aeg_804803392")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount7? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.IntermediaryAgent3"/>
    [IsoId("_Pwrvo9p-Ed-ak6NoX_4Aeg_-2011029531")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.IntermediaryAgent3Account"/>
    [IsoId("_PwrvpNp-Ed-ak6NoX_4Aeg_790028235")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount7? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.UltimateDebtor"/>
    [IsoId("_Pwrvpdp-Ed-ak6NoX_4Aeg_-358708225")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification8? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.InitiatingParty"/>
    [IsoId("_Pwrvptp-Ed-ak6NoX_4Aeg_-372559691")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification8? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.Debtor"/>
    [IsoId("_Pwrvp9p-Ed-ak6NoX_4Aeg_-362401349")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification8 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.DebtorAccount"/>
    [IsoId("_PwrvqNp-Ed-ak6NoX_4Aeg_720541782")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount7? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.DebtorAgent"/>
    [IsoId("_Pw1goNp-Ed-ak6NoX_4Aeg_1893286938")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.DebtorAgentAccount"/>
    [IsoId("_Pw1godp-Ed-ak6NoX_4Aeg_688441268")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount7? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.CreditorAgent"/>
    [IsoId("_Pw1gotp-Ed-ak6NoX_4Aeg_-2143094093")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification3 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.CreditorAgentAccount"/>
    [IsoId("_Pw1go9p-Ed-ak6NoX_4Aeg_656115818")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount7? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.Creditor"/>
    [IsoId("_Pw1gpNp-Ed-ak6NoX_4Aeg_-377179016")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification8 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.CreditorAccount"/>
    [IsoId("_Pw1gpdp-Ed-ak6NoX_4Aeg_-872202728")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount7? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.UltimateCreditor"/>
    [IsoId("_Pw1gptp-Ed-ak6NoX_4Aeg_-627453312")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification8? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.InstructionForCreditorAgent"/>
    [IsoId("_Pw1gp9p-Ed-ak6NoX_4Aeg_-1299402383")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.InstructionForNextAgent"/>
    [IsoId("_Pw1gqNp-Ed-ak6NoX_4Aeg_545462259")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.Purpose"/>
    [IsoId("_Pw1gqdp-Ed-ak6NoX_4Aeg_-152558433")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose1Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.RegulatoryReporting"/>
    [IsoId("_Pw_RoNp-Ed-ak6NoX_4Aeg_-210307224")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting2> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.RelatedRemittanceInformation"/>
    [IsoId("_Pw_Rodp-Ed-ak6NoX_4Aeg_154483444")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation1> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation2.RemittanceInformation"/>
    [IsoId("_Pw_Rotp-Ed-ak6NoX_4Aeg_-2080988572")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation1? RemittanceInformation { get; init; }
}
