// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics, such as the identification or the creation date and time, specific to the message.
/// </summary>
[IsoId("_5-JF8Vg_Eeiv7OYKCzUSAg")]
[DisplayName("Message Header")]
public record MessageHeader10
{
    /// <summary>
    /// Point to point reference, as assigned by the sender, to unambiguously identify the message.|Usage: The sender has to make sure that MessageIdentification is unique for a pre-agreed period.
    /// </summary>
    [IsoId("_6KOaI1g_Eeiv7OYKCzUSAg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_6KOaJVg_Eeiv7OYKCzUSAg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Recalls the criteria (search and return criteria) defined in a preceding query.
    /// </summary>
    [IsoId("_6KOaK1g_Eeiv7OYKCzUSAg")]
    [DisplayName("Query Name")]
    [IsoXmlTag("QryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryName { get; init; }
}
