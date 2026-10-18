// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransactionInformation10"/>
[IsoId("_P2Mhxdp-Ed-ak6NoX_4Aeg_-2050583400")]
[DisplayName("Credit Transfer Transaction Information")]
public partial record CreditTransferTransactionInformation10
{
    /// <inheritdoc cref="ICreditTransferTransactionInformation10.PaymentIdentification"/>
    [IsoId("_P2Mhxtp-Ed-ak6NoX_4Aeg_-2050582784")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.PaymentTypeInformation"/>
    [IsoId("_P2Mhx9p-Ed-ak6NoX_4Aeg_-2050582814")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.Amount"/>
    [IsoId("_P2MhyNp-Ed-ak6NoX_4Aeg_-2050581435")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType3Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.ExchangeRateInformation"/>
    [IsoId("_P2WSwNp-Ed-ak6NoX_4Aeg_-2050581928")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRateInformation1? ExchangeRateInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.ChargeBearer"/>
    [IsoId("_P2WSwdp-Ed-ak6NoX_4Aeg_-2050583369")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.ChequeInstruction"/>
    [IsoId("_P2WSwtp-Ed-ak6NoX_4Aeg_-2050582876")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque6? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.UltimateDebtor"/>
    [IsoId("_P2WSw9p-Ed-ak6NoX_4Aeg_-2049661379")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.IntermediaryAgent1"/>
    [IsoId("_P2WSxNp-Ed-ak6NoX_4Aeg_-2050582390")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.IntermediaryAgent1Account"/>
    [IsoId("_P2WSxdp-Ed-ak6NoX_4Aeg_-2050581496")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount16? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.IntermediaryAgent2"/>
    [IsoId("_P2WSxtp-Ed-ak6NoX_4Aeg_-2050582451")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.IntermediaryAgent2Account"/>
    [IsoId("_P2WSx9p-Ed-ak6NoX_4Aeg_-2050581527")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount16? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.IntermediaryAgent3"/>
    [IsoId("_P2WSyNp-Ed-ak6NoX_4Aeg_-2050582359")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.IntermediaryAgent3Account"/>
    [IsoId("_P2gDwNp-Ed-ak6NoX_4Aeg_-2050581836")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount16? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.CreditorAgent"/>
    [IsoId("_P2gDwdp-Ed-ak6NoX_4Aeg_-2050582482")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.CreditorAgentAccount"/>
    [IsoId("_P2gDwtp-Ed-ak6NoX_4Aeg_-2050581897")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount16? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.Creditor"/>
    [IsoId("_P2gDw9p-Ed-ak6NoX_4Aeg_-2049661433")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification32? Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.CreditorAccount"/>
    [IsoId("_P2gDxNp-Ed-ak6NoX_4Aeg_-2050581805")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.UltimateCreditor"/>
    [IsoId("_P2gDxdp-Ed-ak6NoX_4Aeg_-2050582753")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.InstructionForCreditorAgent"/>
    [IsoId("_P2gDxtp-Ed-ak6NoX_4Aeg_-2050582997")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.InstructionForDebtorAgent"/>
    [IsoId("_P2gDx9p-Ed-ak6NoX_4Aeg_-2050583339")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.Purpose"/>
    [IsoId("_P2gDyNp-Ed-ak6NoX_4Aeg_-2050581989")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.RegulatoryReporting"/>
    [IsoId("_P2gDydp-Ed-ak6NoX_4Aeg_-2049661348")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.Tax"/>
    [IsoId("_P2pNsNp-Ed-ak6NoX_4Aeg_-2050582081")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.RelatedRemittanceInformation"/>
    [IsoId("_P2pNsdp-Ed-ak6NoX_4Aeg_-2050582019")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation10.RemittanceInformation"/>
    [IsoId("_P2pNstp-Ed-ak6NoX_4Aeg_-2050582937")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation5? RemittanceInformation { get; init; }
}
