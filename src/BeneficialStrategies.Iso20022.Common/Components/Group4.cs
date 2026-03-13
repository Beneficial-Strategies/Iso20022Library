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
[IsoId("_IuZ4hW49EeiU9cctagi5ow")]
[DisplayName("Group")]
public partial record Group4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the identification of the group.
    /// </summary>
    [IsoId("_I5uXoW49EeiU9cctagi5ow")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText GroupIdentification { get; init; } 
    
    /// <summary>
    /// Specifies a party and related certificate.
    /// </summary>
    [IsoId("_I5uXo249EeiU9cctagi5ow")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public ValueList<PartyAndCertificate4> Party { get; init; } = [];
    // ID for the above is _I5uXo249EeiU9cctagi5ow
    
    
    #nullable disable
    
}
