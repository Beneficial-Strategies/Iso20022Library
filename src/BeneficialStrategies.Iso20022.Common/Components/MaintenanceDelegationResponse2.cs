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
[IsoId("_OZ8TsY4HEeWrZqsymMFdfg")]
[DisplayName("Maintenance Delegation Response")]
public record MaintenanceDelegationResponse2
{
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_Okq9AY4HEeWrZqsymMFdfg")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public required GenericIdentification72 TMIdentification { get; init; }

    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_Okq9A44HEeWrZqsymMFdfg")]
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    public GenericIdentification72? MasterTMIdentification { get; init; }

    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_Okq9BY4HEeWrZqsymMFdfg")]
    [DisplayName("Delegation Response")]
    [IsoXmlTag("DlgtnRspn")]
    public ValueList<MaintenanceDelegation4> DelegationResponse { get; init; } = [];
    // ID for the above is _Okq9BY4HEeWrZqsymMFdfg
}
