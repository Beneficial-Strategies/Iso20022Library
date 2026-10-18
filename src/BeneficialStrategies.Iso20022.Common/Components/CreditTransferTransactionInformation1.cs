// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransactionInformation1"/>
[IsoId("_PxIbqtp-Ed-ak6NoX_4Aeg_565576791")]
[DisplayName("Credit Transfer Transaction Information")]
public partial record CreditTransferTransactionInformation1
{
    /// <inheritdoc cref="ICreditTransferTransactionInformation1.PaymentIdentification"/>
    [IsoId("_PxIbq9p-Ed-ak6NoX_4Aeg_566501928")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.PaymentTypeInformation"/>
    [IsoId("_PxSMkNp-Ed-ak6NoX_4Aeg_-191624599")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation1? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.Amount"/>
    [IsoId("_PxSMkdp-Ed-ak6NoX_4Aeg_566501270")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType2Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.ExchangeRateInformation"/>
    [IsoId("_PxSMktp-Ed-ak6NoX_4Aeg_1916719833")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRateInformation1? ExchangeRateInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.ChargeBearer"/>
    [IsoId("_PxSMk9p-Ed-ak6NoX_4Aeg_565576809")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.ChequeInstruction"/>
    [IsoId("_PxSMlNp-Ed-ak6NoX_4Aeg_566501400")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque5? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.UltimateDebtor"/>
    [IsoId("_PxSMldp-Ed-ak6NoX_4Aeg_-2045887143")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification8? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.IntermediaryAgent1"/>
    [IsoId("_PxSMltp-Ed-ak6NoX_4Aeg_-2048656805")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.IntermediaryAgent1Account"/>
    [IsoId("_PxSMl9p-Ed-ak6NoX_4Aeg_-2061587448")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount7? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.IntermediaryAgent2"/>
    [IsoId("_PxSMmNp-Ed-ak6NoX_4Aeg_-2046810648")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.IntermediaryAgent2Account"/>
    [IsoId("_PxSMmdp-Ed-ak6NoX_4Aeg_-2059740000")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount7? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.IntermediaryAgent3"/>
    [IsoId("_PxbWgNp-Ed-ak6NoX_4Aeg_-2046812015")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.IntermediaryAgent3Account"/>
    [IsoId("_PxbWgdp-Ed-ak6NoX_4Aeg_-2059741896")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount7? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.CreditorAgent"/>
    [IsoId("_PxbWgtp-Ed-ak6NoX_4Aeg_-2047735100")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.CreditorAgentAccount"/>
    [IsoId("_PxbWg9p-Ed-ak6NoX_4Aeg_-2060665461")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount7? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.Creditor"/>
    [IsoId("_PxbWhNp-Ed-ak6NoX_4Aeg_-2045889081")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification8? Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.CreditorAccount"/>
    [IsoId("_PxbWhdp-Ed-ak6NoX_4Aeg_-2058816435")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount7? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.UltimateCreditor"/>
    [IsoId("_PxbWhtp-Ed-ak6NoX_4Aeg_-2046810042")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification8? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.InstructionForCreditorAgent"/>
    [IsoId("_PxbWh9p-Ed-ak6NoX_4Aeg_566500867")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.InstructionForDebtorAgent"/>
    [IsoId("_PxbWiNp-Ed-ak6NoX_4Aeg_233236695")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.Purpose"/>
    [IsoId("_PxlHgNp-Ed-ak6NoX_4Aeg_565577025")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose1Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.RegulatoryReporting"/>
    [IsoId("_PxlHgdp-Ed-ak6NoX_4Aeg_566502408")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting2> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.Tax"/>
    [IsoId("_PxlHgtp-Ed-ak6NoX_4Aeg_-138019399")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation2? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.RelatedRemittanceInformation"/>
    [IsoId("_PxlHg9p-Ed-ak6NoX_4Aeg_-2057894791")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation1> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation1.RemittanceInformation"/>
    [IsoId("_PxlHhNp-Ed-ak6NoX_4Aeg_566502331")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation1? RemittanceInformation { get; init; }
}
