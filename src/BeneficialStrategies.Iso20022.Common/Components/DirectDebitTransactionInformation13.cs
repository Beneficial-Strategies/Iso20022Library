// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation13"/>
[IsoId("_hGoh4SHIEeK1OvoXgbVMNg")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation13
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation13.PaymentIdentification"/>
    [IsoId("_hb8DiSHIEeK1OvoXgbVMNg")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.PaymentTypeInformation"/>
    [IsoId("_hb8DjSHIEeK1OvoXgbVMNg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation24? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.InstructedAmount"/>
    [IsoId("_hb8DlSHIEeK1OvoXgbVMNg")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public required ActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.ChargeBearer"/>
    [IsoId("_hb8DmSHIEeK1OvoXgbVMNg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.DirectDebitTransaction"/>
    [IsoId("_hb8DoSHIEeK1OvoXgbVMNg")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction7? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.UltimateCreditor"/>
    [IsoId("_hb8DpSHIEeK1OvoXgbVMNg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.DebtorAgent"/>
    [IsoId("_hb8DrSHIEeK1OvoXgbVMNg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.DebtorAgentAccount"/>
    [IsoId("_hb8DsSHIEeK1OvoXgbVMNg")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.Debtor"/>
    [IsoId("_hb8DtSHIEeK1OvoXgbVMNg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.DebtorAccount"/>
    [IsoId("_hb8DuSHIEeK1OvoXgbVMNg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount24 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.UltimateDebtor"/>
    [IsoId("_hb8DvSHIEeK1OvoXgbVMNg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.InstructionForCreditorAgent"/>
    [IsoId("_hb8DwSHIEeK1OvoXgbVMNg")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForCreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.Purpose"/>
    [IsoId("_hb8DxSHIEeK1OvoXgbVMNg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.RegulatoryReporting"/>
    [IsoId("_hb8DySHIEeK1OvoXgbVMNg")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.Tax"/>
    [IsoId("_hb8DzSHIEeK1OvoXgbVMNg")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.RelatedRemittanceInformation"/>
    [IsoId("_hb8D0SHIEeK1OvoXgbVMNg")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.RemittanceInformation"/>
    [IsoId("_hb8D1SHIEeK1OvoXgbVMNg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation13.SupplementaryData"/>
    [IsoId("_mEBo-iHIEeK1OvoXgbVMNg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
