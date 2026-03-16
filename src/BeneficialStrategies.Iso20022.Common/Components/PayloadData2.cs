// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payload Data2.
/// </summary>
[IsoId("_nn0a4exNEe6M4Kz-BKMIbA")]
[DisplayName("Payload Data2")]
public partial record PayloadData2
{
    #nullable enable

    /// <summary>
    /// Creation Date And Time.
    /// </summary>
    [DisplayName("Creation Date And Time")]
    [IsoXmlTag("CreDtAndTm")]
    public required IsoISODateTime CreationDateAndTime { get; init; } 

    /// <summary>
    /// Payload Identifier.
    /// </summary>
    [DisplayName("Payload Identifier")]
    [IsoXmlTag("PyldIdr")]
    public required IsoMax35Text PayloadIdentifier { get; init; } 

    /// <summary>
    /// Possible Duplicate Flag.
    /// </summary>
    [DisplayName("Possible Duplicate Flag")]
    [IsoXmlTag("PssblDplctFlg")]
    public IsoTrueFalseIndicator? PossibleDuplicateFlag { get; init; } 

    
    #nullable disable
    
}
