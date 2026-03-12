// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates derivative contract was tranched.
/// </summary>
[IsoId("_Ocsf0byOEeaUov4jN5X9Qw")]
[DisplayName("Tranche")]
public partial record Tranche2
{
    #nullable enable
    
    /// <summary>
    /// Indicates the point at which losses in the pool will attach to a particular tranche.
    /// </summary>
    [IsoId("_OpEH4byOEeaUov4jN5X9Qw")]
    [DisplayName("Attachment Point")]
    [IsoXmlTag("AttchmntPt")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? AttachmentPoint { get; init; } 
    
    /// <summary>
    /// Indicates the point beyond which losses do not affect the particular tranche.
    /// </summary>
    [IsoId("_OpEH47yOEeaUov4jN5X9Qw")]
    [DisplayName("Detachment Point")]
    [IsoXmlTag("DtchmntPt")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? DetachmentPoint { get; init; } 
    
    
    #nullable disable
    
}
