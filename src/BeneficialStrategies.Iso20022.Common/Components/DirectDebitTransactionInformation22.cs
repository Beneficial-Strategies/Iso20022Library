// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation22"/>
[IsoId("_tKKwA2k2Eeanu6HLe77Rkg")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation22
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation22.PaymentIdentification"/>
    [IsoId("_tT1pNWk2Eeanu6HLe77Rkg")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.PaymentTypeInformation"/>
    [IsoId("_tT1pN2k2Eeanu6HLe77Rkg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation24? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.InstructedAmount"/>
    [IsoId("_tT1pOWk2Eeanu6HLe77Rkg")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public required ActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.ChargeBearer"/>
    [IsoId("_tT1pO2k2Eeanu6HLe77Rkg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.DirectDebitTransaction"/>
    [IsoId("_tT1pPWk2Eeanu6HLe77Rkg")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction9? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.UltimateCreditor"/>
    [IsoId("_tT1pP2k2Eeanu6HLe77Rkg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.DebtorAgent"/>
    [IsoId("_tT1pQWk2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.DebtorAgentAccount"/>
    [IsoId("_tT1pQ2k2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.Debtor"/>
    [IsoId("_tT1pRWk2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.DebtorAccount"/>
    [IsoId("_tT1pR2k2Eeanu6HLe77Rkg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount24 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.UltimateDebtor"/>
    [IsoId("_tT1pSWk2Eeanu6HLe77Rkg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.InstructionForCreditorAgent"/>
    [IsoId("_tT1pS2k2Eeanu6HLe77Rkg")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForCreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.Purpose"/>
    [IsoId("_tT1pTWk2Eeanu6HLe77Rkg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.RegulatoryReporting"/>
    [IsoId("_tT1pT2k2Eeanu6HLe77Rkg")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.Tax"/>
    [IsoId("_tT1pUWk2Eeanu6HLe77Rkg")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.RelatedRemittanceInformation"/>
    [IsoId("_tT1pU2k2Eeanu6HLe77Rkg")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation4> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.RemittanceInformation"/>
    [IsoId("_tT1pVWk2Eeanu6HLe77Rkg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation11? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation22.SupplementaryData"/>
    [IsoId("_tT1pV2k2Eeanu6HLe77Rkg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
