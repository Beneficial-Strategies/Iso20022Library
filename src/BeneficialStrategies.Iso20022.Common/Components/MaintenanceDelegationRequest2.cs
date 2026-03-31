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
[IsoId("_svUwAY4CEeWrZqsymMFdfg")]
[DisplayName("Maintenance Delegation Request")]
public record MaintenanceDelegationRequest2
{
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_s6W7UY4CEeWrZqsymMFdfg")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public required GenericIdentification72 TMIdentification { get; init; }

    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_s6W7U44CEeWrZqsymMFdfg")]
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    public GenericIdentification72? MasterTMIdentification { get; init; }

    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_s6W7VY4CEeWrZqsymMFdfg")]
    [DisplayName("Requested Delegation")]
    [IsoXmlTag("ReqdDlgtn")]
    public ValueList<MaintenanceDelegation3> RequestedDelegation { get; init; } = [];
    // ID for the above is _s6W7VY4CEeWrZqsymMFdfg
}
