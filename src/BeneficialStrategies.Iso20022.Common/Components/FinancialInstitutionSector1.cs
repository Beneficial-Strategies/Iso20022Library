// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information concerning financial counterparties.
/// </summary>
[IsoId("_M0T6AQz2Ee2YoLD-1vFj0g")]
[DisplayName("Financial Institution Sector")]
public partial record FinancialInstitutionSector1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the nature of the counterparty business activities. 
    /// </summary>
    [IsoId("_UgEEwAz2Ee2YoLD-1vFj0g")]
    [DisplayName("Sector")]
    [IsoXmlTag("Sctr")]
    public ValueList<FinancialPartyClassification2Choice_> Sector { get; init; } = new ValueList<FinancialPartyClassification2Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _UgEEwAz2Ee2YoLD-1vFj0g
    
    /// <summary>
    /// Information whether the counterparty is above the clearing threshold.
    /// Usage: If the element is not present, the ClearingThreshold is False.
    /// </summary>
    [IsoId("_W7SxEAz2Ee2YoLD-1vFj0g")]
    [DisplayName("Clearing Threshold")]
    [IsoXmlTag("ClrThrshld")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ClearingThreshold { get; init; } 
    
    
    #nullable disable
    
}
