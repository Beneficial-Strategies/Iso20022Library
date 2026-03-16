// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract Registration7.
/// </summary>
[IsoId("_7I5SITEyEe6g-ffJsqGiSA")]
[DisplayName("Contract Registration7")]
public partial record ContractRegistration7
{
    #nullable enable

    /// <summary>
    /// Contract Registration Identification.
    /// </summary>
    [DisplayName("Contract Registration Identification")]
    [IsoXmlTag("CtrctRegnId")]
    public required IsoMax35Text ContractRegistrationIdentification { get; init; } 

    /// <summary>
    /// Contract Registration Opening.
    /// </summary>
    [DisplayName("Contract Registration Opening")]
    [IsoXmlTag("CtrctRegnOpng")]
    public ValueList<ContractRegistration8> ContractRegistrationOpening { get; init; } = [];

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

    
    #nullable disable
    
}
