// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_RElAdNp-Ed-ak6NoX_4Aeg_-218769686")]
[DisplayName("Modification Scope")]
public record ModificationScope3
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RElAddp-Ed-ak6NoX_4Aeg_-218769643")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification2Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Information about the nationality and the legal status (minor or major) of a person.
    /// </summary>
    [IsoId("_RElAdtp-Ed-ak6NoX_4Aeg_-1223828075")]
    [DisplayName("Citizenship")]
    [IsoXmlTag("Ctznsh")]
    public required CitizenshipInformation Citizenship { get; init; }
}
