// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation23"/>
[IsoId("_KVEUc249EeiU9cctagi5ow")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation23
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation23.PaymentIdentification"/>
    [IsoId("_KgsVdW49EeiU9cctagi5ow")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.PaymentTypeInformation"/>
    [IsoId("_KgsVd249EeiU9cctagi5ow")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.InstructedAmount"/>
    [IsoId("_KgsVeW49EeiU9cctagi5ow")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public required ActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.ChargeBearer"/>
    [IsoId("_KgsVe249EeiU9cctagi5ow")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.DirectDebitTransaction"/>
    [IsoId("_KgsVfW49EeiU9cctagi5ow")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction10? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.UltimateCreditor"/>
    [IsoId("_KgsVf249EeiU9cctagi5ow")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.DebtorAgent"/>
    [IsoId("_KgsVgW49EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.DebtorAgentAccount"/>
    [IsoId("_KgsVg249EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.Debtor"/>
    [IsoId("_KgsVhW49EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.DebtorAccount"/>
    [IsoId("_KgsVh249EeiU9cctagi5ow")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount38 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.UltimateDebtor"/>
    [IsoId("_KgsViW49EeiU9cctagi5ow")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.InstructionForCreditorAgent"/>
    [IsoId("_KgsVi249EeiU9cctagi5ow")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForCreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.Purpose"/>
    [IsoId("_KgsVjW49EeiU9cctagi5ow")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.RegulatoryReporting"/>
    [IsoId("_KgsVj249EeiU9cctagi5ow")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.Tax"/>
    [IsoId("_KgsVkW49EeiU9cctagi5ow")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation8? Tax { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.RelatedRemittanceInformation"/>
    [IsoId("_KgsVk249EeiU9cctagi5ow")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.RemittanceInformation"/>
    [IsoId("_KgsVlW49EeiU9cctagi5ow")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation23.SupplementaryData"/>
    [IsoId("_KgsVl249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
