// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation11"/>
[IsoId("_tJNhYFkyEeGeoaLUQk__nA_375718804")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation11
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation11.PaymentIdentification"/>
    [IsoId("_tJNhYVkyEeGeoaLUQk__nA_-2073194627")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.PaymentTypeInformation"/>
    [IsoId("_tJNhYlkyEeGeoaLUQk__nA_1371699151")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation24? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.InstructedAmount"/>
    [IsoId("_tJNhY1kyEeGeoaLUQk__nA_-1629812594")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public required ActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.ChargeBearer"/>
    [IsoId("_tJNhZFkyEeGeoaLUQk__nA_-1640911371")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.DirectDebitTransaction"/>
    [IsoId("_tJXSYFkyEeGeoaLUQk__nA_2111070841")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction7? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.UltimateCreditor"/>
    [IsoId("_tJXSYVkyEeGeoaLUQk__nA_1582982892")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.DebtorAgent"/>
    [IsoId("_tJXSYlkyEeGeoaLUQk__nA_2037070161")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.DebtorAgentAccount"/>
    [IsoId("_tJXSY1kyEeGeoaLUQk__nA_-1671950109")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.Debtor"/>
    [IsoId("_tJXSZFkyEeGeoaLUQk__nA_69143219")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.DebtorAccount"/>
    [IsoId("_tJgcUFkyEeGeoaLUQk__nA_1558352974")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount24 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.UltimateDebtor"/>
    [IsoId("_tJgcUVkyEeGeoaLUQk__nA_910745431")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.InstructionForCreditorAgent"/>
    [IsoId("_tJqNUFkyEeGeoaLUQk__nA_1441748766")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForCreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.Purpose"/>
    [IsoId("_tJqNUVkyEeGeoaLUQk__nA_-929950948")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.RegulatoryReporting"/>
    [IsoId("_tJqNUlkyEeGeoaLUQk__nA_1521147359")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.Tax"/>
    [IsoId("_tJqNU1kyEeGeoaLUQk__nA_800043603")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.RelatedRemittanceInformation"/>
    [IsoId("_tJz-UFkyEeGeoaLUQk__nA_271955654")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation11.RemittanceInformation"/>
    [IsoId("_tJz-UVkyEeGeoaLUQk__nA_726042923")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }
}
