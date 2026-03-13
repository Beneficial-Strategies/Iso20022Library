// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group of parties with their related security certificate.
/// </summary>
[IsoId("_D1xVkW49EeiU9cctagi5ow")]
[DisplayName("Group")]
public partial record Group3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_D_AxIW49EeiU9cctagi5ow")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; } 
    
    /// <summary>
    /// Specifies the identification of the group.
    /// </summary>
    [IsoId("_D_AxI249EeiU9cctagi5ow")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText GroupIdentification { get; init; } 
    
    /// <summary>
    /// Specifies a party and related certificate.
    /// </summary>
    [IsoId("_D_AxJW49EeiU9cctagi5ow")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public ValueList<PartyAndCertificate5> Party { get; init; } = [];
    // ID for the above is _D_AxJW49EeiU9cctagi5ow
    
    
    #nullable disable
    
}
