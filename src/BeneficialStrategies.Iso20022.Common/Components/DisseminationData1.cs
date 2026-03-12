// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information regarding the dissemination of data.
/// </summary>
[IsoId("_S9HpkCJmEe2zWP9pqvmqdw")]
[DisplayName("Dissemination Data")]
public partial record DisseminationData1
{
    #nullable enable
    
    /// <summary>
    /// Trade repository generated unique and random identifier for each publicly disseminated message.
    /// </summary>
    [IsoId("_n3PTECJmEe2zWP9pqvmqdw")]
    [DisplayName("Dissemination Identifier")]
    [IsoXmlTag("DssmntnIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public required IsoMax52Text DisseminationIdentifier { get; init; } 
    
    /// <summary>
    /// Trade repository generated unique and random identifier of the original, publicly-disseminated swap transaction and pricing data.
    /// Usage: OriginalDisseminationIdentifier is applicable only for action types other than New.
    /// </summary>
    [IsoId("_u_-QUCJmEe2zWP9pqvmqdw")]
    [DisplayName("Original Dissemination Identifier")]
    [IsoXmlTag("OrgnlDssmntnIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? OriginalDisseminationIdentifier { get; init; } 
    
    /// <summary>
    /// Date and time, to the nearest second, that a trade repository publicly disseminates trade data.
    /// </summary>
    [IsoId("_wu1l4CJmEe2zWP9pqvmqdw")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TimeStamp { get; init; } 
    
    
    #nullable disable
    
}
