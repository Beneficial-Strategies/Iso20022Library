// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group Header130.
/// </summary>
[IsoId("_zN7P0T01Ee-thIfLZ94a1w")]
[DisplayName("Group Header130")]
public record GroupHeader130
{
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
    /// Charges Requestor.
    /// </summary>
    [DisplayName("Charges Requestor")]
    [IsoXmlTag("ChrgsRqstr")]
    public BranchAndFinancialInstitutionIdentification8? ChargesRequestor { get; init; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Settlement Instruction.
    /// </summary>
    [DisplayName("Settlement Instruction")]
    [IsoXmlTag("SttlmInstr")]
    public SettlementInstruction19? SettlementInstruction { get; init; }

    /// <summary>
    /// Total Charges.
    /// </summary>
    [DisplayName("Total Charges")]
    [IsoXmlTag("TtlChrgs")]
    public TotalCharges7? TotalCharges { get; init; }
}
