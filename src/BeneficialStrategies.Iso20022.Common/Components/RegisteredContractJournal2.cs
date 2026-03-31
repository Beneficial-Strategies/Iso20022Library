// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_EtCfVW4-EeiU9cctagi5ow")]
[DisplayName("Registered Contract Journal")]
public record RegisteredContractJournal2
{
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_E2br4W4-EeiU9cctagi5ow")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; }

    /// <summary>
    /// Unique registered contract identification.
    /// </summary>
    [IsoId("_E2br424-EeiU9cctagi5ow")]
    [DisplayName("Unique Identification")]
    [IsoXmlTag("UnqId")]
    public DocumentIdentification28? UniqueIdentification { get; init; }

    /// <summary>
    /// Date of closure of the registered contract.
    /// </summary>
    [IsoId("_E2br5W4-EeiU9cctagi5ow")]
    [DisplayName("Closure Date")]
    [IsoXmlTag("ClsrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ClosureDate { get; init; }

    /// <summary>
    /// Reason of closure.
    /// </summary>
    [IsoId("_E2br524-EeiU9cctagi5ow")]
    [DisplayName("Closure Reason")]
    [IsoXmlTag("ClsrRsn")]
    public required ContractClosureReason1Choice_ ClosureReason { get; init; }
}
