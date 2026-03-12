// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by a clearing system, to unambiguously identify a member of the clearing system.
/// </summary>
[IsoId("_TMehHNp-Ed-ak6NoX_4Aeg_151445359")]
[DisplayName("Clearing System Member Identification")]
public partial record ClearingSystemMemberIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_TMehHdp-Ed-ak6NoX_4Aeg_-1082144614")]
    [DisplayName("Clearing System Identification")]
    [IsoXmlTag("ClrSysId")]
    public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a member of a clearing system.
    /// </summary>
    [IsoId("_TMehHtp-Ed-ak6NoX_4Aeg_151445420")]
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MemberIdentification { get; init; } 
    
    
    #nullable disable
    
}
