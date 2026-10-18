// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction4"/>
[IsoId("_t03tglkyEeGeoaLUQk__nA_-1126231527")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction4
{
    /// <inheritdoc cref="ICreditTransferTransaction4.PaymentIdentification"/>
    [IsoId("_t1BegFkyEeGeoaLUQk__nA_-188937521")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.PaymentTypeInformation"/>
    [IsoId("_t1BegVkyEeGeoaLUQk__nA_416384236")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.InterbankSettlementAmount"/>
    [IsoId("_t1BeglkyEeGeoaLUQk__nA_-996072760")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.InterbankSettlementDate"/>
    [IsoId("_t1Beg1kyEeGeoaLUQk__nA_834850409")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.SettlementPriority"/>
    [IsoId("_t1LPgFkyEeGeoaLUQk__nA_-2045880265")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.SettlementTimeIndication"/>
    [IsoId("_t1LPgVkyEeGeoaLUQk__nA_616982832")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.SettlementTimeRequest"/>
    [IsoId("_t1LPglkyEeGeoaLUQk__nA_999437940")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.PreviousInstructingAgent"/>
    [IsoId("_t1LPg1kyEeGeoaLUQk__nA_2077458278")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.PreviousInstructingAgentAccount"/>
    [IsoId("_t1LPhFkyEeGeoaLUQk__nA_-1456743865")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount24? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.InstructingAgent"/>
    [IsoId("_t1UZcFkyEeGeoaLUQk__nA_427176735")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.InstructedAgent"/>
    [IsoId("_t1UZcVkyEeGeoaLUQk__nA_1187941888")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.IntermediaryAgent1"/>
    [IsoId("_t1UZclkyEeGeoaLUQk__nA_-891800088")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.IntermediaryAgent1Account"/>
    [IsoId("_t1UZc1kyEeGeoaLUQk__nA_1559298219")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.IntermediaryAgent2"/>
    [IsoId("_t1UZdFkyEeGeoaLUQk__nA_2013385488")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.IntermediaryAgent2Account"/>
    [IsoId("_t1eKcFkyEeGeoaLUQk__nA_1163311970")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.IntermediaryAgent3"/>
    [IsoId("_t1eKcVkyEeGeoaLUQk__nA_-1437436306")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.IntermediaryAgent3Account"/>
    [IsoId("_t1n7cFkyEeGeoaLUQk__nA_-359415968")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.UltimateDebtor"/>
    [IsoId("_t1n7cVkyEeGeoaLUQk__nA_998394988")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification5? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.Debtor"/>
    [IsoId("_t1n7clkyEeGeoaLUQk__nA_1967624386")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification5 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.DebtorAccount"/>
    [IsoId("_t1n7c1kyEeGeoaLUQk__nA_-709163393")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.DebtorAgent"/>
    [IsoId("_t1n7dFkyEeGeoaLUQk__nA_1893623706")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.DebtorAgentAccount"/>
    [IsoId("_t1xFYFkyEeGeoaLUQk__nA_311973648")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.CreditorAgent"/>
    [IsoId("_t1xFYVkyEeGeoaLUQk__nA_-1361309295")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.CreditorAgentAccount"/>
    [IsoId("_t162YFkyEeGeoaLUQk__nA_250814271")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.Creditor"/>
    [IsoId("_t162YVkyEeGeoaLUQk__nA_1868993788")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification5 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.CreditorAccount"/>
    [IsoId("_t162YlkyEeGeoaLUQk__nA_494068776")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.UltimateCreditor"/>
    [IsoId("_t162Y1kyEeGeoaLUQk__nA_948156045")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification5? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.InstructionForCreditorAgent"/>
    [IsoId("_t162ZFkyEeGeoaLUQk__nA_2116749552")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent2> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction4.InstructionForNextAgent"/>
    [IsoId("_t2EAUFkyEeGeoaLUQk__nA_1831788173")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction4.RemittanceInformation"/>
    [IsoId("_t2EAUVkyEeGeoaLUQk__nA_-1702413970")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction4.UnderlyingCustomerCreditTransfer"/>
    [IsoId("_t2EAUlkyEeGeoaLUQk__nA_582596468")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    public CreditTransferTransaction3? UnderlyingCustomerCreditTransfer { get; init; }
}
