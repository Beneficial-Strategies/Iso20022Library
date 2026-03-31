// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the status of the cancellation request.
/// </summary>
[IsoId("_V2V_M249EeiU9cctagi5ow")]
[DisplayName("Modification Status Reason")]
public record ModificationStatusReason2
{
    /// <summary>
    /// Party that issues the cancellation status.
    /// </summary>
    [IsoId("_V_kzk249EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_V_kzlW49EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ModificationStatusReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the cancellation status reason.
    /// </summary>
    [IsoId("_V_kzl249EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
