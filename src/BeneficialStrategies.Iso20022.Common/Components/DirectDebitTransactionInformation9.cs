// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation9"/>
[IsoId("_P1wc49p-Ed-ak6NoX_4Aeg_1595924985")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation9
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation9.PaymentIdentification"/>
    [IsoId("_P1wc5Np-Ed-ak6NoX_4Aeg_1595926335")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.PaymentTypeInformation"/>
    [IsoId("_P1wc5dp-Ed-ak6NoX_4Aeg_1595925441")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation20? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.InstructedAmount"/>
    [IsoId("_P1wc5tp-Ed-ak6NoX_4Aeg_1595925318")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public required ActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.ChargeBearer"/>
    [IsoId("_P1wc59p-Ed-ak6NoX_4Aeg_1595925017")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.DirectDebitTransaction"/>
    [IsoId("_P1wc6Np-Ed-ak6NoX_4Aeg_1595925564")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction6? DirectDebitTransaction { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.UltimateCreditor"/>
    [IsoId("_P15m0Np-Ed-ak6NoX_4Aeg_1595926243")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.DebtorAgent"/>
    [IsoId("_P15m0dp-Ed-ak6NoX_4Aeg_1595925811")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.DebtorAgentAccount"/>
    [IsoId("_P15m0tp-Ed-ak6NoX_4Aeg_1595926396")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount16? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.Debtor"/>
    [IsoId("_P15m09p-Ed-ak6NoX_4Aeg_1595925965")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification32 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.DebtorAccount"/>
    [IsoId("_P15m1Np-Ed-ak6NoX_4Aeg_1595926488")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount16 DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.UltimateDebtor"/>
    [IsoId("_P15m1dp-Ed-ak6NoX_4Aeg_1595925873")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.InstructionForCreditorAgent"/>
    [IsoId("_P15m1tp-Ed-ak6NoX_4Aeg_1595925379")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForCreditorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.Purpose"/>
    [IsoId("_P15m19p-Ed-ak6NoX_4Aeg_1595925516")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.RegulatoryReporting"/>
    [IsoId("_P15m2Np-Ed-ak6NoX_4Aeg_1595926797")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.Tax"/>
    [IsoId("_P2DX0Np-Ed-ak6NoX_4Aeg_1595926427")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.RelatedRemittanceInformation"/>
    [IsoId("_P2DX0dp-Ed-ak6NoX_4Aeg_1595926519")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IDirectDebitTransactionInformation9.RemittanceInformation"/>
    [IsoId("_P2DX0tp-Ed-ak6NoX_4Aeg_1595926304")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation5? RemittanceInformation { get; init; }
}
