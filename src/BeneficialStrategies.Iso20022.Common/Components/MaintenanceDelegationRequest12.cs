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
[IsoId("_19YacbYFEfCUZfsQO4rYeA")]
[DisplayName("Maintenance Delegation Request12")]
public record MaintenanceDelegationRequest12
{
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_1-LEpbYFEfCUZfsQO4rYeA")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public required GenericIdentification176 TMIdentification { get; init; }

    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_1-LEq7YFEfCUZfsQO4rYeA")]
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    public GenericIdentification176? MasterTMIdentification { get; init; }

    /// <summary>
    /// Date and time of the TMS.
    /// </summary>
    [IsoId("_1-LEsbYFEfCUZfsQO4rYeA")]
    [DisplayName("TM Date Time")]
    [IsoXmlTag("TMDtTm")]
    public required IsoISODateTime TMDateTime { get; init; }

    /// <summary>
    /// Challenge value sent by the POI to be received back in a message response.
    /// </summary>
    [IsoId("_1-LEt7YFEfCUZfsQO4rYeA")]
    [DisplayName("TM Challenge Value")]
    [IsoXmlTag("TMChllngVal")]
    public required IsoMax140Binary TMChallengeValue { get; init; }

    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_1-LEvbYFEfCUZfsQO4rYeA")]
    [DisplayName("Requested Delegation")]
    [IsoXmlTag("ReqdDlgtn")]
    [MinLength(1)]
    public ValueList<MaintenanceDelegation20> RequestedDelegation { get; init; } = [];
}
