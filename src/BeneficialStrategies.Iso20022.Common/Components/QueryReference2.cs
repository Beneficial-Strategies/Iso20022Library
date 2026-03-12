// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Gives the name and the reference of the query.
/// </summary>
[IsoId("_-v9i0QeBEe2fOITqoTnSLQ")]
[DisplayName("Query Reference")]
public partial record QueryReference2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the query.
    /// </summary>
    [IsoId("__CSo8QeBEe2fOITqoTnSLQ")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text QueryReference { get; init; } 
    
    /// <summary>
    /// Name of the query.
    /// </summary>
    [IsoId("__CSo8weBEe2fOITqoTnSLQ")]
    [DisplayName("Query Name")]
    [IsoXmlTag("QryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QueryName { get; init; } 
    
    
    #nullable disable
    
}
