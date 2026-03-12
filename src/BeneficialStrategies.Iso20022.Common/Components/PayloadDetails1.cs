// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component identifies the instance of the document exchanged.
/// </summary>
[IsoId("_jL4pQu5NEeCisYr99QEiWA_-884807516")]
[DisplayName("Payload Details")]
public partial record PayloadDetails1
{
    #nullable enable
    
    /// <summary>
    /// String of characters that uniquely identifies the file, which was delivered by the sender.
    /// </summary>
    [IsoId("_jL4pQ-5NEeCisYr99QEiWA_773260286")]
    [DisplayName("Payload Identifier")]
    [IsoXmlTag("PyldIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text PayloadIdentifier { get; init; } 
    
    /// <summary>
    /// Date and time when the file was created by the sender.
    /// </summary>
    [IsoId("_jL4pRO5NEeCisYr99QEiWA_739714352")]
    [DisplayName("Creation Date And Time")]
    [IsoXmlTag("CreDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateAndTime { get; init; } 
    
    /// <summary>
    /// Flag indicating if the file exchanged between the two business applications is possibly a duplicate. If this indicator is not present within the message, please note that the default value would be &quot;False&quot;.
    /// </summary>
    [IsoId("_jMCaQO5NEeCisYr99QEiWA_-217630319")]
    [DisplayName("Possible Duplicate Flag")]
    [IsoXmlTag("PssblDplctFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PossibleDuplicateFlag { get; init; } 
    
    
    #nullable disable
    
}
