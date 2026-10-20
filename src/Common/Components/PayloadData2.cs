// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payload Data2.
/// </summary>
[IsoId("_nn0a4exNEe6M4Kz-BKMIbA")]
[DisplayName("Payload Data2")]
public partial record PayloadData2
{
    /// <summary>
    /// Payload Identifier.
    /// </summary>
    [DisplayName("Payload Identifier")]
    [IsoXmlTag("PyldIdr")]
    public required Max35Text PayloadIdentifier { get; init; }

    /// <summary>
    /// Creation Date And Time.
    /// </summary>
    [DisplayName("Creation Date And Time")]
    [IsoXmlTag("CreDtAndTm")]
    public required ISODateTime CreationDateAndTime { get; init; }

    /// <summary>
    /// Possible Duplicate Flag.
    /// </summary>
    [DisplayName("Possible Duplicate Flag")]
    [IsoXmlTag("PssblDplctFlg")]
    public TrueFalseIndicator? PossibleDuplicateFlag { get; init; }
}
