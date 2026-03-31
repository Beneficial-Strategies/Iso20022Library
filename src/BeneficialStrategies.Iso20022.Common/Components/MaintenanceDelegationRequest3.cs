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
[IsoId("_HakaIbAHEeah1_v59tW6Rg")]
[DisplayName("Maintenance Delegation Request")]
public record MaintenanceDelegationRequest3
{
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_HlmlcbAHEeah1_v59tW6Rg")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public required GenericIdentification72 TMIdentification { get; init; }

    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_Hlmlc7AHEeah1_v59tW6Rg")]
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    public GenericIdentification72? MasterTMIdentification { get; init; }

    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_HlmldbAHEeah1_v59tW6Rg")]
    [DisplayName("Requested Delegation")]
    [IsoXmlTag("ReqdDlgtn")]
    public ValueList<MaintenanceDelegation5> RequestedDelegation { get; init; } = [];
    // ID for the above is _HlmldbAHEeah1_v59tW6Rg
}
