// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction2"/>
[IsoId("_tQqNMFkyEeGeoaLUQk__nA_734910466")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction2
{
    /// <inheritdoc cref="ICreditTransferTransaction2.PaymentIdentification"/>
    [IsoId("_tQqNMVkyEeGeoaLUQk__nA_1075158669")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.PaymentTypeInformation"/>
    [IsoId("_tQqNMlkyEeGeoaLUQk__nA_-1388885458")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.InterbankSettlementAmount"/>
    [IsoId("_tQqNM1kyEeGeoaLUQk__nA_-1818031476")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.InterbankSettlementDate"/>
    [IsoId("_tQqNNFkyEeGeoaLUQk__nA_895285762")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.SettlementPriority"/>
    [IsoId("_tQz-MFkyEeGeoaLUQk__nA_-1580535271")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.SettlementTimeIndication"/>
    [IsoId("_tQz-MVkyEeGeoaLUQk__nA_-324396261")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.SettlementTimeRequest"/>
    [IsoId("_tQz-MlkyEeGeoaLUQk__nA_-335495038")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.AcceptanceDateTime"/>
    [IsoId("_tQz-M1kyEeGeoaLUQk__nA_1077380890")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.PoolingAdjustmentDate"/>
    [IsoId("_tQz-NFkyEeGeoaLUQk__nA_-2069483299")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.InstructedAmount"/>
    [IsoId("_tQ9vMFkyEeGeoaLUQk__nA_-711672343")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.ExchangeRate"/>
    [IsoId("_tQ9vMVkyEeGeoaLUQk__nA_1739425964")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.ChargeBearer"/>
    [IsoId("_tQ9vMlkyEeGeoaLUQk__nA_-566587723")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public required ChargeBearerType1Code ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.ChargesInformation"/>
    [IsoId("_tQ9vM1kyEeGeoaLUQk__nA_1718422715")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction2.PreviousInstructingAgent"/>
    [IsoId("_tQ9vNFkyEeGeoaLUQk__nA_-2073308402")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.PreviousInstructingAgentAccount"/>
    [IsoId("_tRG5IFkyEeGeoaLUQk__nA_-398242261")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount24? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.InstructingAgent"/>
    [IsoId("_tRG5IVkyEeGeoaLUQk__nA_-1788023981")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.InstructedAgent"/>
    [IsoId("_tRG5IlkyEeGeoaLUQk__nA_-1027258828")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.IntermediaryAgent1"/>
    [IsoId("_tRG5I1kyEeGeoaLUQk__nA_-1268995986")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.IntermediaryAgent1Account"/>
    [IsoId("_tRG5JFkyEeGeoaLUQk__nA_-1683421858")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.IntermediaryAgent2"/>
    [IsoId("_tRQqIFkyEeGeoaLUQk__nA_531803462")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.IntermediaryAgent2Account"/>
    [IsoId("_tRQqIVkyEeGeoaLUQk__nA_-975849243")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.IntermediaryAgent3"/>
    [IsoId("_tRQqIlkyEeGeoaLUQk__nA_-857978258")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.IntermediaryAgent3Account"/>
    [IsoId("_tRQqI1kyEeGeoaLUQk__nA_-532860751")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.UltimateDebtor"/>
    [IsoId("_tRQqJFkyEeGeoaLUQk__nA_1211990508")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.InitiatingParty"/>
    [IsoId("_tRabIFkyEeGeoaLUQk__nA_-1464797271")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.Debtor"/>
    [IsoId("_tRabIVkyEeGeoaLUQk__nA_-413664199")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.DebtorAccount"/>
    [IsoId("_tRabIlkyEeGeoaLUQk__nA_2037434108")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.DebtorAgent"/>
    [IsoId("_tRabI1kyEeGeoaLUQk__nA_1623008236")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.DebtorAgentAccount"/>
    [IsoId("_tRjlEFkyEeGeoaLUQk__nA_788242403")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.CreditorAgent"/>
    [IsoId("_tRjlEVkyEeGeoaLUQk__nA_1113359910")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.CreditorAgentAccount"/>
    [IsoId("_tRtWEFkyEeGeoaLUQk__nA_-779223776")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.Creditor"/>
    [IsoId("_tRtWEVkyEeGeoaLUQk__nA_-609549665")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.CreditorAccount"/>
    [IsoId("_tRtWElkyEeGeoaLUQk__nA_-640929808")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.UltimateCreditor"/>
    [IsoId("_tRtWE1kyEeGeoaLUQk__nA_1076154295")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.InstructionForCreditorAgent"/>
    [IsoId("_tRtWFFkyEeGeoaLUQk__nA_1530241564")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction2.InstructionForNextAgent"/>
    [IsoId("_tR2gAFkyEeGeoaLUQk__nA_1519142787")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction2.Purpose"/>
    [IsoId("_tR2gAVkyEeGeoaLUQk__nA_1701762718")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction2.RegulatoryReporting"/>
    [IsoId("_tR2gAlkyEeGeoaLUQk__nA_1487172023")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction2.RelatedRemittanceInformation"/>
    [IsoId("_tSARAFkyEeGeoaLUQk__nA_1941259292")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction2.RemittanceInformation"/>
    [IsoId("_tSARAVkyEeGeoaLUQk__nA_-522784835")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }
}
