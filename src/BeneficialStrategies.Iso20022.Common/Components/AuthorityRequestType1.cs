// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the authority request type.
/// </summary>
[IsoId("_1uJfwPG1EeGldvY3i8Fbvw")]
[DisplayName("Authority Request Type")]
public partial record AuthorityRequestType1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the requested message name identifier.
    /// </summary>
    [IsoId("_8kjW4PG1EeGldvY3i8Fbvw")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the message name.
    /// </summary>
    [IsoId("_FsZFIPG2EeGldvY3i8Fbvw")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? MessageName { get; init; } 
    
    
    #nullable disable
    
}
