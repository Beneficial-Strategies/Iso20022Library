// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Registered Contract Journal3.
/// </summary>
[IsoId("_4lkZwTEyEe6g-ffJsqGiSA")]
[DisplayName("Registered Contract Journal3")]
public record RegisteredContractJournal3
{
    /// <summary>
    /// Closure Date.
    /// </summary>
    [DisplayName("Closure Date")]
    [IsoXmlTag("ClsrDt")]
    public required IsoISODate ClosureDate { get; init; }

    /// <summary>
    /// Closure Reason.
    /// </summary>
    [DisplayName("Closure Reason")]
    [IsoXmlTag("ClsrRsn")]
    public required ContractClosureReason1Choice_ ClosureReason { get; init; }

    /// <summary>
    /// Registration Agent.
    /// </summary>
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification8 RegistrationAgent { get; init; }

    /// <summary>
    /// Unique Identification.
    /// </summary>
    [DisplayName("Unique Identification")]
    [IsoXmlTag("UnqId")]
    public DocumentIdentification28? UniqueIdentification { get; init; }
}
