// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation26"/>
[IsoId("_vHb7XxUHEequmIwg9GMA4Q")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation26
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation26.PaymentIdentification"/>
    [IsoId("_vcQ71RUHEequmIwg9GMA4Q")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.PaymentTypeInformation"/>
    [IsoId("_vcQ71xUHEequmIwg9GMA4Q")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.InterbankSettlementAmount"/>
    [IsoId("_vcQ72RUHEequmIwg9GMA4Q")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.InterbankSettlementDate"/>
    [IsoId("_vcQ72xUHEequmIwg9GMA4Q")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.SettlementPriority"/>
    [IsoId("_vcQ73RUHEequmIwg9GMA4Q")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.SettlementTimeIndication"/>
    [IsoId("_vcQ73xUHEequmIwg9GMA4Q")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.SettlementTimeRequest"/>
    [IsoId("_vcQ74RUHEequmIwg9GMA4Q")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.UltimateDebtor"/>
    [IsoId("_vcQ74xUHEequmIwg9GMA4Q")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification6? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.Debtor"/>
    [IsoId("_vcQ75RUHEequmIwg9GMA4Q")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification6 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.DebtorAccount"/>
    [IsoId("_vcQ75xUHEequmIwg9GMA4Q")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.DebtorAgent"/>
    [IsoId("_vcQ76RUHEequmIwg9GMA4Q")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.DebtorAgentAccount"/>
    [IsoId("_vcQ76xUHEequmIwg9GMA4Q")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.InstructionForDebtorAgent"/>
    [IsoId("_vcQ77RUHEequmIwg9GMA4Q")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.Purpose"/>
    [IsoId("_vcQ77xUHEequmIwg9GMA4Q")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation26.RemittanceInformation"/>
    [IsoId("_vcQ78RUHEequmIwg9GMA4Q")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }
}
