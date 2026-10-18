// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation1"/>
[IsoId("_PwF5wNp-Ed-ak6NoX_4Aeg_-698254258")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation1
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation1.PaymentIdentification"/>
    [IsoId("_PwF5wdp-Ed-ak6NoX_4Aeg_-697330319")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.PaymentTypeInformation"/>
    [IsoId("_PwF5wtp-Ed-ak6NoX_4Aeg_709731807")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation2? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.InstructedAmount"/>
    [IsoId("_PwF5w9p-Ed-ak6NoX_4Aeg_-1231988816")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public required CurrencyAndAmount InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.ChargeBearer"/>
    [IsoId("_PwF5xNp-Ed-ak6NoX_4Aeg_-134577148")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.DirectDebitTransaction"/>
    [IsoId("_PwF5xdp-Ed-ak6NoX_4Aeg_-80903261")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction1? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.UltimateCreditor"/>
    [IsoId("_PwF5xtp-Ed-ak6NoX_4Aeg_671768228")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification8? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.DebtorAgent"/>
    [IsoId("_PwF5x9p-Ed-ak6NoX_4Aeg_-726885796")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.DebtorAgentAccount"/>
    [IsoId("_PwF5yNp-Ed-ak6NoX_4Aeg_-725962912")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount7? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.Debtor"/>
    [IsoId("_PwF5ydp-Ed-ak6NoX_4Aeg_-727807794")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification8 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.DebtorAccount"/>
    [IsoId("_PwPDsNp-Ed-ak6NoX_4Aeg_-727806805")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount7 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.UltimateDebtor"/>
    [IsoId("_PwPDsdp-Ed-ak6NoX_4Aeg_-694562141")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification8? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.InstructionForCreditorAgent"/>
    [IsoId("_PwPDstp-Ed-ak6NoX_4Aeg_1236038580")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForCreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.Purpose"/>
    [IsoId("_PwPDs9p-Ed-ak6NoX_4Aeg_-697332656")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose1Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.RegulatoryReporting"/>
    [IsoId("_PwPDtNp-Ed-ak6NoX_4Aeg_-696409271")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting2> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.Tax"/>
    [IsoId("_PwPDtdp-Ed-ak6NoX_4Aeg_-696409073")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation2? Tax { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.RelatedRemittanceInformation"/>
    [IsoId("_PwPDttp-Ed-ak6NoX_4Aeg_-694561639")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation1> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation1.RemittanceInformation"/>
    [IsoId("_PwPDt9p-Ed-ak6NoX_4Aeg_-696410019")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation1? RemittanceInformation { get; init; }
}
