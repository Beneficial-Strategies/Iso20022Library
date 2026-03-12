// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a master agreement.
/// </summary>
[IsoId("_JIKzgS4yEeuxhbw_aW6haw")]
[DisplayName("Master Agreement")]
public partial record MasterAgreement7
{
    #nullable enable
    
    /// <summary>
    /// Reference to any master agreement, if existent (such as ISDA Master Agreement; Master Power Purchase and Sale Agreement; International ForEx Master Agreement; European Master Agreement or any local Master Agreements).
    /// </summary>
    [IsoId("_Jf0egS4yEeuxhbw_aW6haw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AgreementType2Choice_ Type { get; init; } 
    
    /// <summary>
    /// Reference to the year of the master agreement version used for the reported trade, if applicable (such as 1992, 2002, etc).
    /// </summary>
    [IsoId("_Jf0egy4yEeuxhbw_aW6haw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? Version { get; init; } 
    
    /// <summary>
    /// Additional information specifying the other type of the master agreement.
    /// </summary>
    [IsoId("_J6ADoS4zEeuxhbw_aW6haw")]
    [DisplayName("Other Master Agreement Details")]
    [IsoXmlTag("OthrMstrAgrmtDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? OtherMasterAgreementDetails { get; init; } 
    
    
    #nullable disable
    
}
