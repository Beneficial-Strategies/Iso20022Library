// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the modification to be applied on the securities account reference data.
/// </summary>
[IsoId("_70DO0Tp0Eemk2e6qGBk8IQ")]
[DisplayName("Securities Account Modification")]
public record SecuritiesAccountModification2
{
    /// <summary>
    /// Specifies the type of requested modification.
    /// </summary>
    [IsoId("_7-eWITp0Eemk2e6qGBk8IQ")]
    [DisplayName("Scope Indication")]
    [IsoXmlTag("ScpIndctn")]
    public required DataModification1Code ScopeIndication { get; init; }

    /// <summary>
    /// Specifies which elements to be modified for the securities account reference data.
    /// </summary>
    [IsoId("_7-eWIzp0Eemk2e6qGBk8IQ")]
    [DisplayName("Requested Modification")]
    [IsoXmlTag("ReqdMod")]
    public required SecuritiesAccountModification2Choice_ RequestedModification { get; init; }
}
