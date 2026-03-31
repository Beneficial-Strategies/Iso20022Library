// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
[IsoId("_8FX1EUfEEey6Is2iMqV8fg")]
[DisplayName("Securities Account")]
public record SecuritiesAccount42
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_8bufkUfEEey6Is2iMqV8fg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_8bufk0fEEey6Is2iMqV8fg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PurposeCode8Choice_? Type { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_8buflUfEEey6Is2iMqV8fg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    [IsoId("_8bufl0fEEey6Is2iMqV8fg")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? Designation { get; init; }
}
