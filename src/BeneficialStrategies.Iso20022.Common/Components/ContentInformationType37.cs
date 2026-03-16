// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content Information Type37.
/// </summary>
[IsoId("_8zWjgY-SEe6oobnCtR50kw")]
[DisplayName("Content Information Type37")]
public partial record ContentInformationType37
{
    #nullable enable

    /// <summary>
    /// Authenticated Data.
    /// </summary>
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public required AuthenticatedData10 AuthenticatedData { get; init; } 

    /// <summary>
    /// Content Type.
    /// </summary>
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; } 

    
    #nullable disable
    
}
