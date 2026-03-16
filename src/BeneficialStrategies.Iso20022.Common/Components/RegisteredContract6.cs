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
[IsoId("_EXwBT249EeiU9cctagi5ow")]
[DisplayName("Registered Contract")]
public record RegisteredContract6
{
    /// <summary>
    /// Unique and unambiguous identification of the registered contract closure.
    /// </summary>
    [IsoId("_EjORcW49EeiU9cctagi5ow")]
    [DisplayName("Registered Contract Closure Identification")]
    [IsoXmlTag("RegdCtrctClsrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RegisteredContractClosureIdentification { get; init; }

    /// <summary>
    /// Party who registered the currency control contract.
    /// </summary>
    [IsoId("_EjOReW49EeiU9cctagi5ow")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty5 ReportingParty { get; init; }

    /// <summary>
    /// Agent who registered the currency control contract.
    /// </summary>
    [IsoId("_EjORe249EeiU9cctagi5ow")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; }

    /// <summary>
    /// Original registered contract identification.
    /// </summary>
    [IsoId("_EjORfW49EeiU9cctagi5ow")]
    [DisplayName("Original Registered Contract")]
    [IsoXmlTag("OrgnlRegdCtrct")]
    public required DocumentIdentification29 OriginalRegisteredContract { get; init; }

    /// <summary>
    /// Priority of the registered contract closure.
    /// </summary>
    [IsoId("_EjORhW49EeiU9cctagi5ow")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public required Priority2Code Priority { get; init; }

    /// <summary>
    /// Reason of the closure.
    /// </summary>
    [IsoId("_EjORh249EeiU9cctagi5ow")]
    [DisplayName("Closure Reason")]
    [IsoXmlTag("ClsrRsn")]
    public required ContractClosureReason1Choice_ ClosureReason { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_EjORiW49EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
