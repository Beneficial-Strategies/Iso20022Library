// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Credit Transfer Transaction61.
/// </summary>
[IsoId("_8vY92TEsEe6GxLzpkVnWYg")]
[DisplayName("Credit Transfer Transaction61")]
public record CreditTransferTransaction61
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType4Choice_ Amount { get; init; }

    /// <summary>
    /// Charge Bearer.
    /// </summary>
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Cheque Instruction.
    /// </summary>
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque19? ChequeInstruction { get; init; }

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification272? Creditor { get; init; }

    /// <summary>
    /// Creditor Account.
    /// </summary>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Creditor Agent.
    /// </summary>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? CreditorAgent { get; init; }

    /// <summary>
    /// Creditor Agent Account.
    /// </summary>
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Exchange Rate Information.
    /// </summary>
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }

    /// <summary>
    /// Instruction For Creditor Agent.
    /// </summary>
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <summary>
    /// Instruction For Debtor Agent.
    /// </summary>
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    public InstructionForDebtorAgent1? InstructionForDebtorAgent { get; init; }

    /// <summary>
    /// Intermediary Agent1.
    /// </summary>
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Intermediary Agent1Account.
    /// </summary>
    [DisplayName("Intermediary Agent1Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Intermediary Agent2.
    /// </summary>
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Intermediary Agent2Account.
    /// </summary>
    [DisplayName("Intermediary Agent2Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Intermediary Agent3.
    /// </summary>
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Intermediary Agent3Account.
    /// </summary>
    [DisplayName("Intermediary Agent3Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Mandate Related Information.
    /// </summary>
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Payment Identification.
    /// </summary>
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6 PaymentIdentification { get; init; }

    /// <summary>
    /// Payment Type Information.
    /// </summary>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Purpose.
    /// </summary>
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Regulatory Reporting.
    /// </summary>
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public RegulatoryReporting3? RegulatoryReporting { get; init; }

    /// <summary>
    /// Related Remittance Information.
    /// </summary>
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public RemittanceLocation8? RelatedRemittanceInformation { get; init; }

    /// <summary>
    /// Remittance Information.
    /// </summary>
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation22? RemittanceInformation { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxData1? Tax { get; init; }

    /// <summary>
    /// Ultimate Creditor.
    /// </summary>
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <summary>
    /// Ultimate Debtor.
    /// </summary>
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }
}
