// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation15"/>
[IsoId("_F4y_SGcKEeKAGeP1fbluEg")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation15
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation15.PaymentIdentification"/>
    [IsoId("_WUritmcKEeKAGeP1fbluEg")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.PaymentTypeInformation"/>
    [IsoId("_F40NOGcKEeKAGeP1fbluEg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.InterbankSettlementAmount"/>
    [IsoId("_F40NTmcKEeKAGeP1fbluEg")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.InterbankSettlementDate"/>
    [IsoId("_wGmt0HzxEeKpJYN-DrBsZQ")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.SettlementPriority"/>
    [IsoId("_KgLs13z2EeKpJYN-DrBsZQ")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.SettlementTimeRequest"/>
    [IsoId("_EJr8dmcLEeKAGeP1fbluEg")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.UltimateDebtor"/>
    [IsoId("_F400QGcKEeKAGeP1fbluEg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification5? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.Debtor"/>
    [IsoId("_F4zmO2cKEeKAGeP1fbluEg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification5 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.DebtorAccount"/>
    [IsoId("_F4zmIGcKEeKAGeP1fbluEg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.DebtorAgent"/>
    [IsoId("_F4zmMWcKEeKAGeP1fbluEg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.DebtorAgentAccount"/>
    [IsoId("_F4zmNmcKEeKAGeP1fbluEg")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.InstructionForDebtorAgent"/>
    [IsoId("_F4zmJ2cKEeKAGeP1fbluEg")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation15.RemittanceInformation"/>
    [IsoId("_Sv5-8GcLEeKAGeP1fbluEg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }
}
