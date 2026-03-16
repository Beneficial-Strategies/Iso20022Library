// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content Information Type38.
/// </summary>
[IsoId("_MazHkY-VEe6oobnCtR50kw")]
[DisplayName("Content Information Type38")]
public partial record ContentInformationType38
{
    #nullable enable

    /// <summary>
    /// Authenticated Data.
    /// </summary>
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData10? AuthenticatedData { get; init; } 

    /// <summary>
    /// Content Type.
    /// </summary>
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; } 

    /// <summary>
    /// Signed Data.
    /// </summary>
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData9? SignedData { get; init; } 

    
    #nullable disable
    
}
