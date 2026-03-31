// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information specific to the individual direct debit transaction(s) included in the message.
/// </summary>
[IsoId("_P1wc49p-Ed-ak6NoX_4Aeg_1595924985")]
[DisplayName("Direct Debit Transaction Information")]
public record DirectDebitTransactionInformation9
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_P1wc5Np-Ed-ak6NoX_4Aeg_1595926335")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_P1wc5dp-Ed-ak6NoX_4Aeg_1595925441")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation20? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_P1wc5tp-Ed-ak6NoX_4Aeg_1595925318")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public required ActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_P1wc59p-Ed-ak6NoX_4Aeg_1595925017")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Set of elements providing information specific to the direct debit mandate.
    /// </summary>
    [IsoId("_P1wc6Np-Ed-ak6NoX_4Aeg_1595925564")]
    [DisplayName("Direct Debit Transaction")]
    [IsoXmlTag("DrctDbtTx")]
    public DirectDebitTransaction6? DirectDebitTransaction { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_P15m0Np-Ed-ak6NoX_4Aeg_1595926243")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_P15m0dp-Ed-ak6NoX_4Aeg_1595925811")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_P15m0tp-Ed-ak6NoX_4Aeg_1595926396")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount16? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_P15m09p-Ed-ak6NoX_4Aeg_1595925965")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification32 Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_P15m1Np-Ed-ak6NoX_4Aeg_1595926488")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount16 DebtorAccount { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_P15m1dp-Ed-ak6NoX_4Aeg_1595925873")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <summary>
    /// Further information, related to the processing of the payment instruction, that may need to be acted upon by the creditor agent, depending on agreement between creditor and the creditor agent.
    /// </summary>
    [IsoId("_P15m1tp-Ed-ak6NoX_4Aeg_1595925379")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForCreditorAgent { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_P15m19p-Ed-ak6NoX_4Aeg_1595925516")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_P15m2Np-Ed-ak6NoX_4Aeg_1595926797")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <summary>
    /// Set of elements used to provide details on the tax.
    /// </summary>
    [IsoId("_P2DX0Np-Ed-ak6NoX_4Aeg_1595926427")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <summary>
    /// Set of elements used to provide information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_P2DX0dp-Ed-ak6NoX_4Aeg_1595926519")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_P2DX0tp-Ed-ak6NoX_4Aeg_1595926304")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation5? RemittanceInformation { get; init; }
}
