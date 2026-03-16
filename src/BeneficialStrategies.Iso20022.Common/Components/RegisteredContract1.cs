// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control registered contract amendment details.
/// </summary>
[IsoId("_nI5VVdL9EeSDLevdaFPXHw")]
[DisplayName("Registered Contract")]
public record RegisteredContract1
{
    /// <summary>
    /// Unique and unambiguous identification of the contract registration amendment.
    /// </summary>
    [IsoId("_nI5VVtL9EeSDLevdaFPXHw")]
    [DisplayName("Contract Registration Amendment Identification")]
    [IsoXmlTag("CtrctRegnAmdmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ContractRegistrationAmendmentIdentification { get; init; }

    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_nI5VWNL9EeSDLevdaFPXHw")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty2 ReportingParty { get; init; }

    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_nI5VV9L9EeSDLevdaFPXHw")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; }

    /// <summary>
    /// Amendment details applied on one or several registered contracts.
    /// </summary>
    [IsoId("_nI5VWdL9EeSDLevdaFPXHw")]
    [DisplayName("Registered Contract Amendment")]
    [IsoXmlTag("RegdCtrctAmdmnt")]
    public ValueList<RegisteredContract3> RegisteredContractAmendment { get; init; } = [];

    // ID for the above is _nI5VWdL9EeSDLevdaFPXHw

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("__7OX8TmyEeWDb47rJ6ki4Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
