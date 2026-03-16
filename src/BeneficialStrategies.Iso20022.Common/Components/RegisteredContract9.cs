// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amendment data of document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_WABfgW49EeiU9cctagi5ow")]
[DisplayName("Registered Contract")]
public record RegisteredContract9
{
    /// <summary>
    /// Unique and unambiguous identification of the contract registration amendment.
    /// </summary>
    [IsoId("_WJQ7EW49EeiU9cctagi5ow")]
    [DisplayName("Contract Registration Amendment Identification")]
    [IsoXmlTag("CtrctRegnAmdmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ContractRegistrationAmendmentIdentification { get; init; }

    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_WJQ7E249EeiU9cctagi5ow")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty5 ReportingParty { get; init; }

    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_WJQ7FW49EeiU9cctagi5ow")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; }

    /// <summary>
    /// Amendment details applied on one or several registered contracts.
    /// </summary>
    [IsoId("_WJQ7F249EeiU9cctagi5ow")]
    [DisplayName("Registered Contract Amendment")]
    [IsoXmlTag("RegdCtrctAmdmnt")]
    public ValueList<RegisteredContract10> RegisteredContractAmendment { get; init; } = [];

    // ID for the above is _WJQ7F249EeiU9cctagi5ow

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_WJQ7H249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
