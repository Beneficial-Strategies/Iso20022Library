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
[IsoId("_nXxcYddiEeispNOuywCdbA")]
[DisplayName("Securities Account")]
public record SecuritiesAccount36
{
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_nqN3QddiEeispNOuywCdbA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_nqN3VddiEeispNOuywCdbA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public GenericIdentification30? Type { get; init; }

    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_nqN3addiEeispNOuywCdbA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    [IsoId("_pnzv4ddjEeispNOuywCdbA")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; }
}
