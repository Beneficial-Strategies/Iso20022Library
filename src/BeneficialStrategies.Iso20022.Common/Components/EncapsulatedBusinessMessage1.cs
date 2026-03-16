// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines an encapsulated form of an ISO 20022 message and, if present, its associated Business Application Header. The encapsulation guarantees uniqueness of ID/IDREFs though the use of the Prefix element. This element can be added during message preparation to ID/IDREFs. In order to verify the signature in the Hdr element or inside the encapsulated message, for each occurrence of an ID orIDREF that possesses the same value as a prefix, the prefix part is removed before signature verification. This is not done for surrounding signatures.
/// </summary>
[IsoId("_OTgzMTky-AOSNFX-8224490")]
[DisplayName("Encapsulated Business Message")]
public record EncapsulatedBusinessMessage1
{
    /// <summary>
    /// The Business Application Header associated to the encapsulated message if it exists.
    /// </summary>
    [IsoId("_NzE0NzI0-AOSNFX-5096924")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public BusinessApplicationHeader1? Header { get; init; }

    /// <summary>
    /// Prefix of ID/IDREFs in the encapsulated message to be removed before signature verification.
    /// </summary>
    [IsoId("_NzE0NzI1-AOSNFX-5096924")]
    [DisplayName("Prefix")]
    [IsoXmlTag("Prfx")]
    [IsoSimpleType(IsoSimpleType.ID)]
    public IsoID? Prefix { get; init; }

    /// <summary>
    /// If yes, the Msg element contains only a subset of the original message.
    /// </summary>
    [IsoId("_NzE0NzI2-AOSNFX-5096924")]
    [DisplayName("Partial")]
    [IsoXmlTag("Prtl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Partial { get; init; }

    /// <summary>
    /// The encapsulated ISO 20022 message.
    /// </summary>
    [IsoId("_NzE0NzI3-AOSNFX-5096924")]
    [DisplayName("Message")]
    [IsoXmlTag("Msg")]
    public required StrictPayload Message { get; init; }
}
