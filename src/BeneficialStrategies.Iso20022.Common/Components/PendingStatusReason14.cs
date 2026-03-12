// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a pending status.
/// </summary>
[IsoId("_8Fjr0UzAEeafiMTDrtSnyw")]
[DisplayName("Pending Status Reason")]
public partial record PendingStatusReason14
{
    #nullable enable
    
    /// <summary>
    /// Reason for the pending account status.
    /// </summary>
    [IsoId("_8fTBgUzAEeafiMTDrtSnyw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required PendingStatusReason2Choice_ Code { get; init; } 
    
    /// <summary>
    /// Additional information about the reason for the pending account status.
    /// </summary>
    [IsoId("_8fTBg0zAEeafiMTDrtSnyw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
