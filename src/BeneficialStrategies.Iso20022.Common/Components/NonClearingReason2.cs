// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the reason for which the contract has not been cleared.
/// </summary>
[IsoId("_Ak0bdZPuEey0rJ3Gl6WZVA")]
[DisplayName("Non Clearing Reason")]
public partial record NonClearingReason2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for a clearing exemption or exception.
    /// </summary>
    [IsoId("_AmE_sZPuEey0rJ3Gl6WZVA")]
    [DisplayName("Clearing Exemption Exception")]
    [IsoXmlTag("ClrXmptnXcptn")]
    public SimpleValueList<ClearingExemptionException1Code> ClearingExemptionException { get; init; } = new SimpleValueList<ClearingExemptionException1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _AmE_sZPuEey0rJ3Gl6WZVA
    
    /// <summary>
    /// Indicates the reason for which the contract has not been cleared.
    /// </summary>
    [IsoId("_AmE_s5PuEey0rJ3Gl6WZVA")]
    [DisplayName("Non Clearing Reason Information")]
    [IsoXmlTag("NonClrRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? NonClearingReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
