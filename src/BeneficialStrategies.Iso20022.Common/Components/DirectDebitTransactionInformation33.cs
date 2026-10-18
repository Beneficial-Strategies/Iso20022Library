// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation33"/>
[Description(@"Provides further details specific to the individual direct debit transaction(s) included in the message.")]
[IsoId("_69BZlTEyEe6g-ffJsqGiSA")]
[DisplayName("Direct Debit Transaction Information33")]
public partial record DirectDebitTransactionInformation33
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation33.Debtor"/>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification8 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.DebtorAccount"/>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.DebtorAgent"/>
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.DebtorAgentAccount"/>
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.InstructionForDebtorAgent"/>
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    public IsoMax210Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.InterbankSettlementAmount"/>
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.InterbankSettlementDate"/>
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.PaymentIdentification"/>
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.PaymentTypeInformation"/>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.Purpose"/>
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.RemittanceInformation"/>
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.SettlementPriority"/>
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.SettlementTimeIndication"/>
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.SettlementTimeRequest"/>
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation33.UltimateDebtor"/>
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification8? UltimateDebtor { get; init; }
}
