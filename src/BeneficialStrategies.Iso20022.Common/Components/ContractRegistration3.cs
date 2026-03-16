// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control contract registration details.
/// </summary>
[IsoId("_JEKGD249EeiU9cctagi5ow")]
[DisplayName("Contract Registration")]
public record ContractRegistration3
{
    /// <summary>
    /// Unique and unambiguous identification of the contract registration.
    /// </summary>
    [IsoId("_JNscgW49EeiU9cctagi5ow")]
    [DisplayName("Contract Registration Identification")]
    [IsoXmlTag("CtrctRegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ContractRegistrationIdentification { get; init; }

    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_JNscg249EeiU9cctagi5ow")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty5 ReportingParty { get; init; }

    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_JNschW49EeiU9cctagi5ow")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; }

    /// <summary>
    /// Details about the opening of the contract registration.
    /// </summary>
    [IsoId("_JNsch249EeiU9cctagi5ow")]
    [DisplayName("Contract Registration Opening")]
    [IsoXmlTag("CtrctRegnOpng")]
    public ValueList<ContractRegistration4> ContractRegistrationOpening { get; init; } = [];

    // ID for the above is _JNsch249EeiU9cctagi5ow

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_JNscj249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
