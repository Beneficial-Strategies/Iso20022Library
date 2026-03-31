// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Instruction19.
/// </summary>
[IsoId("_MZWWcD02Ee-thIfLZ94a1w")]
[DisplayName("Settlement Instruction19")]
public record SettlementInstruction19
{
    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public BranchAndFinancialInstitutionIdentification8? Creditor { get; init; }

    /// <summary>
    /// Creditor Account.
    /// </summary>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Creditor Agent.
    /// </summary>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 CreditorAgent { get; init; }

    /// <summary>
    /// Creditor Agent Account.
    /// </summary>
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Requested Settlement Date.
    /// </summary>
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    public IsoISODate? RequestedSettlementDate { get; init; }
}
