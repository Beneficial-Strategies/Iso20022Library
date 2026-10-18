// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation28"/>
[IsoId("_eD_pI9cZEeqRFcf2R4bPBw")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation28
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation28.PaymentIdentification"/>
    [IsoId("_eFZ-NdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.PaymentTypeInformation"/>
    [IsoId("_eFZ-N9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.InstructedAmount"/>
    [IsoId("_eFZ-OdcZEeqRFcf2R4bPBw")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public required ActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.ChargeBearer"/>
    [IsoId("_eFZ-O9cZEeqRFcf2R4bPBw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.DirectDebitTransaction"/>
    [IsoId("_eFZ-PdcZEeqRFcf2R4bPBw")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction11? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.UltimateCreditor"/>
    [IsoId("_eFZ-P9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.DebtorAgent"/>
    [IsoId("_eFZ-QdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.DebtorAgentAccount"/>
    [IsoId("_eFZ-Q9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.Debtor"/>
    [IsoId("_eFZ-RdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.DebtorAccount"/>
    [IsoId("_eFZ-R9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount40 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.UltimateDebtor"/>
    [IsoId("_eFZ-SdcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.InstructionForCreditorAgent"/>
    [IsoId("_eFZ-S9cZEeqRFcf2R4bPBw")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForCreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.Purpose"/>
    [IsoId("_eFZ-TdcZEeqRFcf2R4bPBw")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.RegulatoryReporting"/>
    [IsoId("_eFZ-T9cZEeqRFcf2R4bPBw")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.Tax"/>
    [IsoId("_eFZ-UdcZEeqRFcf2R4bPBw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation10? Tax { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.RelatedRemittanceInformation"/>
    [IsoId("_eFZ-U9cZEeqRFcf2R4bPBw")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.RemittanceInformation"/>
    [IsoId("_eFZ-VdcZEeqRFcf2R4bPBw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation21? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation28.SupplementaryData"/>
    [IsoId("_eFZ-V9cZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
