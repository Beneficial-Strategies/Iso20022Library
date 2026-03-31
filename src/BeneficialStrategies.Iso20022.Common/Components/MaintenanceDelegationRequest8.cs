// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of maintenance delegations.
/// </summary>
[IsoId("_OZycgU6oEeyGi9JAv6wq7Q")]
[DisplayName("Maintenance Delegation Request")]
public record MaintenanceDelegationRequest8
{
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_Of_yMU6oEeyGi9JAv6wq7Q")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public required GenericIdentification176 TMIdentification { get; init; }

    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_Of_yM06oEeyGi9JAv6wq7Q")]
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    public GenericIdentification176? MasterTMIdentification { get; init; }

    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_Of_yNU6oEeyGi9JAv6wq7Q")]
    [DisplayName("Requested Delegation")]
    [IsoXmlTag("ReqdDlgtn")]
    public ValueList<MaintenanceDelegation13> RequestedDelegation { get; init; } = [];
    // ID for the above is _Of_yNU6oEeyGi9JAv6wq7Q
}
