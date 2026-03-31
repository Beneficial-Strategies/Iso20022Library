// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business reference(s) to one or more relevant messages previously sent by other parties, or by the same party issuing this message.
/// </summary>
[IsoId("_Rca4sNp-Ed-ak6NoX_4Aeg_-583688066")]
[DisplayName("Additional References")]
public record AdditionalReferences
{
    /// <summary>
    /// Unambiguous reference to a previous message having a business relevance with this message.
    /// </summary>
    [IsoId("_Rca4sdp-Ed-ak6NoX_4Aeg_-470092785")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Name of the message which contained the given additional reference as its message reference.
    /// </summary>
    [IsoId("_Rca4stp-Ed-ak6NoX_4Aeg_200384123")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageName { get; init; }

    /// <summary>
    /// Party that initially assigned the given additional reference.
    /// </summary>
    [IsoId("_Rca4s9p-Ed-ak6NoX_4Aeg_421105069")]
    [DisplayName("Reference Issuer")]
    [IsoXmlTag("RefIssr")]
    public PartyIdentification? ReferenceIssuer { get; init; }
}
