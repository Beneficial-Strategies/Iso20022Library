// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of actions to be performed.
/// </summary>
[IsoId("_B1YNAEXVEeegp_DADCe7HQ")]
[DisplayName("Action")]
public partial record Action9
{
    #nullable enable
    
    /// <summary>
    /// Destination of the action.
    /// </summary>
    [IsoId("_R3PHEEXVEeegp_DADCe7HQ")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyType20Code? Destination { get; init; } 
    
    /// <summary>
    /// Action type to be performed.
    /// </summary>
    [IsoId("_WxEj0EXVEeegp_DADCe7HQ")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public ActionType11Code? ActionType { get; init; } 
    
    /// <summary>
    /// Other action type to be performed.
    /// </summary>
    [IsoId("_ccz-oEXVEeegp_DADCe7HQ")]
    [DisplayName("Other Action Type")]
    [IsoXmlTag("OthrActnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherActionType { get; init; } 
    
    /// <summary>
    /// Additional information to the type of action to be performed (for example, channel to be used for additional verification or authentication).
    /// </summary>
    [IsoId("_nWyY4EXVEeegp_DADCe7HQ")]
    [DisplayName("Action Information")]
    [IsoXmlTag("ActnInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ActionInformation { get; init; } 
    
    
    #nullable disable
    
}
