// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charges Record9.
/// </summary>
[IsoId("_4MJNNzEyEe6g-ffJsqGiSA")]
[DisplayName("Charges Record9")]
public record ChargesRecord9
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax140Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Charges Account Agent.
    /// </summary>
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification8? ChargesAccountAgent { get; init; }

    /// <summary>
    /// Charges Account Agent Account.
    /// </summary>
    [DisplayName("Charges Account Agent Account")]
    [IsoXmlTag("ChrgsAcctAgtAcct")]
    public CashAccount40? ChargesAccountAgentAccount { get; init; }

    /// <summary>
    /// Charges Identification.
    /// </summary>
    [DisplayName("Charges Identification")]
    [IsoXmlTag("ChrgsId")]
    public IsoMax35Text? ChargesIdentification { get; init; }

    /// <summary>
    /// Charges Requestor.
    /// </summary>
    [DisplayName("Charges Requestor")]
    [IsoXmlTag("ChrgsRqstr")]
    public BranchAndFinancialInstitutionIdentification8? ChargesRequestor { get; init; }

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Debtor Agent.
    /// </summary>
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <summary>
    /// Debtor Agent Account.
    /// </summary>
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Instruction For Instructed Agent.
    /// </summary>
    [DisplayName("Instruction For Instructed Agent")]
    [IsoXmlTag("InstrForInstdAgt")]
    public InstructionForInstructedAgent1? InstructionForInstructedAgent { get; init; }

    /// <summary>
    /// Record Identification.
    /// </summary>
    [DisplayName("Record Identification")]
    [IsoXmlTag("RcrdId")]
    public IsoMax35Text? RecordIdentification { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType3Choice_? Type { get; init; }

    /// <summary>
    /// Underlying Transaction.
    /// </summary>
    [DisplayName("Underlying Transaction")]
    [IsoXmlTag("UndrlygTx")]
    public required TransactionReferences7 UnderlyingTransaction { get; init; }

    /// <summary>
    /// Value Date.
    /// </summary>
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }
}
