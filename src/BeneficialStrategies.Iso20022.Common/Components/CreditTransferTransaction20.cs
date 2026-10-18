// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction20"/>
[IsoId("_e_6s-R77EeSxevWRRWxNAg")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction20
{
    /// <inheritdoc cref="ICreditTransferTransaction20.PaymentIdentification"/>
    [IsoId("_fQ5IAx77EeSxevWRRWxNAg")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.PaymentTypeInformation"/>
    [IsoId("_fQ5IBR77EeSxevWRRWxNAg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.Amount"/>
    [IsoId("_fQ5IBx77EeSxevWRRWxNAg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType4Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.ExchangeRateInformation"/>
    [IsoId("_fQ5ICR77EeSxevWRRWxNAg")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.ChargeBearer"/>
    [IsoId("_fQ5ICx77EeSxevWRRWxNAg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.ChequeInstruction"/>
    [IsoId("_fQ5IDR77EeSxevWRRWxNAg")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque7? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.UltimateDebtor"/>
    [IsoId("_fQ5IDx77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.IntermediaryAgent1"/>
    [IsoId("_fQ5IER77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.IntermediaryAgent1Account"/>
    [IsoId("_fQ5IEx77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.IntermediaryAgent2"/>
    [IsoId("_fQ5IFR77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.IntermediaryAgent2Account"/>
    [IsoId("_fQ5IFx77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.IntermediaryAgent3"/>
    [IsoId("_fQ5IGR77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.IntermediaryAgent3Account"/>
    [IsoId("_fQ5IGx77EeSxevWRRWxNAg")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.CreditorAgent"/>
    [IsoId("_fQ5IHR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.CreditorAgentAccount"/>
    [IsoId("_fQ5IHx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.Creditor"/>
    [IsoId("_fQ5IIR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification43? Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.CreditorAccount"/>
    [IsoId("_fQ5IIx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.UltimateCreditor"/>
    [IsoId("_fQ5IJR77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.InstructionForCreditorAgent"/>
    [IsoId("_fQ5IJx77EeSxevWRRWxNAg")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction20.InstructionForDebtorAgent"/>
    [IsoId("_fQ5IKR77EeSxevWRRWxNAg")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.Purpose"/>
    [IsoId("_fQ5IKx77EeSxevWRRWxNAg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.RegulatoryReporting"/>
    [IsoId("_fQ5ILR77EeSxevWRRWxNAg")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction20.Tax"/>
    [IsoId("_fQ5ILx77EeSxevWRRWxNAg")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.RelatedRemittanceInformation"/>
    [IsoId("_fQ5IMR77EeSxevWRRWxNAg")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation4> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction20.RemittanceInformation"/>
    [IsoId("_fQ5IMx77EeSxevWRRWxNAg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation10? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction20.SupplementaryData"/>
    [IsoId("_fQ5INR77EeSxevWRRWxNAg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
