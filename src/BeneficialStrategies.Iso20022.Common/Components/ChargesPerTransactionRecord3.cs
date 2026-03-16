// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charges Per Transaction Record3.
/// </summary>
[IsoId("_4FcvQTEyEe6g-ffJsqGiSA")]
[DisplayName("Charges Per Transaction Record3")]
public record ChargesPerTransactionRecord3
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax140Text? AdditionalInformation { get; init; }

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
    /// Charges Breakdown.
    /// </summary>
    [DisplayName("Charges Breakdown")]
    [IsoXmlTag("ChrgsBrkdwn")]
    public ValueList<ChargesBreakdown1> ChargesBreakdown { get; init; } = [];

    /// <summary>
    /// Charges Requestor.
    /// </summary>
    [DisplayName("Charges Requestor")]
    [IsoXmlTag("ChrgsRqstr")]
    public BranchAndFinancialInstitutionIdentification8? ChargesRequestor { get; init; }

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
    /// Total Charges Per Record.
    /// </summary>
    [DisplayName("Total Charges Per Record")]
    [IsoXmlTag("TtlChrgsPerRcrd")]
    public TotalCharges8? TotalChargesPerRecord { get; init; }

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
