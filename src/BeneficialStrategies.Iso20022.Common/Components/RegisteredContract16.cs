// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Registered Contract16.
/// </summary>
[IsoId("_2KDZkTEyEe6g-ffJsqGiSA")]
[DisplayName("Registered Contract16")]
public record RegisteredContract16
{
    /// <summary>
    /// Contract Registration Amendment Identification.
    /// </summary>
    [DisplayName("Contract Registration Amendment Identification")]
    [IsoXmlTag("CtrctRegnAmdmntId")]
    public required IsoMax35Text ContractRegistrationAmendmentIdentification { get; init; }

    /// <summary>
    /// Registered Contract Amendment.
    /// </summary>
    [DisplayName("Registered Contract Amendment")]
    [IsoXmlTag("RegdCtrctAmdmnt")]
    public ValueList<RegisteredContract17> RegisteredContractAmendment { get; init; } = [];

    /// <summary>
    /// Registration Agent.
    /// </summary>
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification8 RegistrationAgent { get; init; }

    /// <summary>
    /// Reporting Party.
    /// </summary>
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty6 ReportingParty { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
