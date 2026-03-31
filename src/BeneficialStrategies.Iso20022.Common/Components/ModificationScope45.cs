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
[IsoId("_C66R4ZTMEemqYPWMBuVawg")]
[DisplayName("Modification Scope")]
public record ModificationScope45
{
    /// <summary>
    /// Type of modification to be applied.
    /// </summary>
    [IsoId("_DOsJgZTMEemqYPWMBuVawg")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Additional information such as remarks or notes that must be conveyed about the party and or limitations and restrictions.
    /// </summary>
    [IsoId("_DOsJg5TMEemqYPWMBuVawg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditiononalInformation13> AdditionalInformation { get; init; } = [];
    // ID for the above is _DOsJg5TMEemqYPWMBuVawg
}
