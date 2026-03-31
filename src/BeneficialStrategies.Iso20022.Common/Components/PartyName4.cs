// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the party name entity through  the valid short and long names of the party within the system.
/// </summary>
[IsoId("_5LPDsWSzEeifFbri5DlfYA")]
[DisplayName("Party Name")]
public record PartyName4
{
    /// <summary>
    /// Specifies the date from which the party name is valid.
    /// </summary>
    [IsoId("_5apYsWSzEeifFbri5DlfYA")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidFrom { get; init; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_5apYs2SzEeifFbri5DlfYA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; }

    /// <summary>
    /// Specifies the short name of the organisation.
    /// </summary>
    [IsoId("_5apYtWSzEeifFbri5DlfYA")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }
}
