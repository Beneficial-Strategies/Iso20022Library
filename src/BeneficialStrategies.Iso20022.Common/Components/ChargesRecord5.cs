// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further individual record details on the charges related to the payment transaction.
/// </summary>
[IsoId("_n3siQbt7Eeq_cfXrH83Rcw")]
[DisplayName("Charges Record")]
public record ChargesRecord5
{
    /// <summary>
    /// Unique and unambiguous identification of the charges record for reconciliation purpose.
    /// Usage: this identification shall be used as the end-to-end identification in the resulting message for the payment of the charges, to allow for automated reconciliation.
    /// </summary>
    [IsoId("_62YjACkaEeuBrrgCSpsocg")]
    [DisplayName("Charges Record Identification")]
    [IsoXmlTag("ChrgsRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ChargesRecordIdentification { get; init; }

    /// <summary>
    /// Identifies the underlying transaction(s) to which the charges apply.
    /// </summary>
    [IsoId("_YDA8oCkYEeuBrrgCSpsocg")]
    [DisplayName("Underlying Transaction")]
    [IsoXmlTag("UndrlygTx")]
    public ValueList<TransactionReferences7> UnderlyingTransaction { get; init; } = [];

    // ID for the above is _YDA8oCkYEeuBrrgCSpsocg

    /// <summary>
    /// Amount of transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_n4aT8bt7Eeq_cfXrH83Rcw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the charges amount is a credit or a debit amount. |Usage: A zero amount is considered to be a credit.
    /// </summary>
    [IsoId("_n4aT87t7Eeq_cfXrH83Rcw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Date and time at which the charges are or will be available.
    /// </summary>
    [IsoId("_n4aT9bt7Eeq_cfXrH83Rcw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }

    /// <summary>
    /// Specifies the debtor agent of the initial transaction, if different from the charges account owner.
    /// </summary>
    [IsoId("_n4aT-bt7Eeq_cfXrH83Rcw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <summary>
    /// Specifies the account of the debtor agent of the initial transaction, when instructing agent is different from the charges account owner.
    /// </summary>
    [IsoId("_7Rl5sbt8Eeq_cfXrH83Rcw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Agent that services the charges account.
    /// </summary>
    [IsoId("_n4aT_7t7Eeq_cfXrH83Rcw")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; init; }

    /// <summary>
    /// Account of the agent that services the charges account.
    /// </summary>
    [IsoId("_vKb6obt8Eeq_cfXrH83Rcw")]
    [DisplayName("Charges Account Agent Account")]
    [IsoXmlTag("ChrgsAcctAgtAcct")]
    public CashAccount40? ChargesAccountAgentAccount { get; init; }

    /// <summary>
    /// Specifies the type of charge.
    /// </summary>
    [IsoId("_n4aT97t7Eeq_cfXrH83Rcw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType3Choice_? Type { get; init; }

    /// <summary>
    /// Further information related to the processing of the payment adjustment instruction that may need to be acted upon by the next agent.
    /// </summary>
    [IsoId("_x72GISm4EeutWNGMV2XKIQ")]
    [DisplayName("Instruction For Instructed Agent")]
    [IsoXmlTag("InstrForInstdAgt")]
    public InstructionForInstructedAgent1? InstructionForInstructedAgent { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_n4aUAbt7Eeq_cfXrH83Rcw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
