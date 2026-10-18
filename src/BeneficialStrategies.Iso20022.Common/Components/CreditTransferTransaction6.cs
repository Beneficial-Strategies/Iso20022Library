// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction6"/>
[IsoId("_lb9OQSHGEeK1OvoXgbVMNg")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction6
{
    /// <inheritdoc cref="ICreditTransferTransaction6.PaymentIdentification"/>
    [IsoId("_lyKH4yHGEeK1OvoXgbVMNg")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.PaymentTypeInformation"/>
    [IsoId("_lyKH5yHGEeK1OvoXgbVMNg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.Amount"/>
    [IsoId("_lyKH7yHGEeK1OvoXgbVMNg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType3Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.ExchangeRateInformation"/>
    [IsoId("_lyKH8yHGEeK1OvoXgbVMNg")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.ChargeBearer"/>
    [IsoId("_lyKH9yHGEeK1OvoXgbVMNg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.ChequeInstruction"/>
    [IsoId("_lyKH_yHGEeK1OvoXgbVMNg")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque7? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.UltimateDebtor"/>
    [IsoId("_lyKIByHGEeK1OvoXgbVMNg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.IntermediaryAgent1"/>
    [IsoId("_lyKIDyHGEeK1OvoXgbVMNg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.IntermediaryAgent1Account"/>
    [IsoId("_lyKIEyHGEeK1OvoXgbVMNg")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.IntermediaryAgent2"/>
    [IsoId("_lyKIFyHGEeK1OvoXgbVMNg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.IntermediaryAgent2Account"/>
    [IsoId("_lyKIGyHGEeK1OvoXgbVMNg")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.IntermediaryAgent3"/>
    [IsoId("_lyKIHyHGEeK1OvoXgbVMNg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.IntermediaryAgent3Account"/>
    [IsoId("_lyKIIyHGEeK1OvoXgbVMNg")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.CreditorAgent"/>
    [IsoId("_lyKIJyHGEeK1OvoXgbVMNg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.CreditorAgentAccount"/>
    [IsoId("_lyKILyHGEeK1OvoXgbVMNg")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.Creditor"/>
    [IsoId("_lyKIMyHGEeK1OvoXgbVMNg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification43? Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.CreditorAccount"/>
    [IsoId("_lyKINyHGEeK1OvoXgbVMNg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.UltimateCreditor"/>
    [IsoId("_lyKIPyHGEeK1OvoXgbVMNg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.InstructionForCreditorAgent"/>
    [IsoId("_lyKIQyHGEeK1OvoXgbVMNg")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction6.InstructionForDebtorAgent"/>
    [IsoId("_lyKIRyHGEeK1OvoXgbVMNg")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.Purpose"/>
    [IsoId("_lyKITyHGEeK1OvoXgbVMNg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.RegulatoryReporting"/>
    [IsoId("_lyKIUyHGEeK1OvoXgbVMNg")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction6.Tax"/>
    [IsoId("_lyKIVyHGEeK1OvoXgbVMNg")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.RelatedRemittanceInformation"/>
    [IsoId("_lyKIWyHGEeK1OvoXgbVMNg")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction6.RemittanceInformation"/>
    [IsoId("_lyKIXyHGEeK1OvoXgbVMNg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction6.SupplementaryData"/>
    [IsoId("_t5whAyHGEeK1OvoXgbVMNg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
