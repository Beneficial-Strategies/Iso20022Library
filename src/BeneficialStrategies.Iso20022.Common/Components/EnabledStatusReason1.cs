// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for an enabled status.
/// </summary>
[IsoId("_tdbsMEy9EeafiMTDrtSnyw")]
[DisplayName("Enabled Status Reason")]
public partial record EnabledStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the enabled account status.
    /// </summary>
    [IsoId("_JPoAwEy-EeafiMTDrtSnyw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required EnabledStatusReason2Choice_ Code { get; init; } 
    
    /// <summary>
    /// Additional information about the reason for the enabled account status.
    /// </summary>
    [IsoId("_MI23sEy-EeafiMTDrtSnyw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
