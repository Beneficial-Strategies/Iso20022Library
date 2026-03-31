// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional References2.
/// </summary>
[IsoId("_-rEYgSpvEe2NrplE7WhvBA")]
[DisplayName("Additional References2")]
public record AdditionalReferences2
{
    /// <summary>
    /// Message Name.
    /// </summary>
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    public IsoMax35Text? MessageName { get; init; }

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Reference Issuer.
    /// </summary>
    [DisplayName("Reference Issuer")]
    [IsoXmlTag("RefIssr")]
    public IsoMax35Text? ReferenceIssuer { get; init; }
}
