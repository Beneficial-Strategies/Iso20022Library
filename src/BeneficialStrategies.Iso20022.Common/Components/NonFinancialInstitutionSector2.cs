// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information concerning non financial counterparties.
/// </summary>
[IsoId("_QSs_AcDyEeW6TPUXKSV6dQ")]
[DisplayName("Non Financial Institution Sector")]
public partial record NonFinancialInstitutionSector2
{
    #nullable enable
    
    /// <summary>
    /// Taxonomy for non-financial counterparties. The categories correspond to the main sections of NACE classification as defined in the regulation.
    /// </summary>
    [IsoId("_Q2aJAcDyEeW6TPUXKSV6dQ")]
    [DisplayName("Sector")]
    [IsoXmlTag("Sctr")]
    [IsoSimpleType(IsoSimpleType.NACEDomainIdentifier)]
    public IsoNACEDomainIdentifier? Sector { get; init; } 
    
    /// <summary>
    /// Information whether the reporting counterparty is above the clearing threshold.
    /// </summary>
    [IsoId("_Q2aJBcDyEeW6TPUXKSV6dQ")]
    [DisplayName("Clearing Threshold")]
    [IsoXmlTag("ClrThrshld")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ClearingThreshold { get; init; } 
    
    /// <summary>
    /// Directly linked to commercial activity or treasury financing: Information on whether the contract is objectively measurable as directly linked to the reporting counterparty&apos;s commercial or treasury financing activity.
    /// </summary>
    [IsoId("_Q2aJB8DyEeW6TPUXKSV6dQ")]
    [DisplayName("Directly Linked Activity")]
    [IsoXmlTag("DrctlyLkdActvty")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DirectlyLinkedActivity { get; init; } 
    
    
    #nullable disable
    
}
