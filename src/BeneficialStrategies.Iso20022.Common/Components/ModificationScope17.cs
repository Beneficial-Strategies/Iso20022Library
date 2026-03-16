// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of modification to be applied on a data set.
/// </summary>
[IsoId("_1B0xARRXEeOKWo1NF21OVw")]
[DisplayName("Modification Scope")]
public record ModificationScope17
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_1Zo0ERRXEeOKWo1NF21OVw")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification2Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    [IsoId("_kOYzkBRYEeOKWo1NF21OVw")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public required GenericIdentification44 OtherIdentification { get; init; }
}
