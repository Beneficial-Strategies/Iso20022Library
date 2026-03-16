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
[IsoId("_MQV_WwgqEeSUG-8hqXsVMQ")]
[DisplayName("Modification Scope")]
public record ModificationScope22
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_MqYP8QgqEeSUG-8hqXsVMQ")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Identification of information which is part of a service level agreement.
    /// </summary>
    [IsoId("_MqYP8wgqEeSUG-8hqXsVMQ")]
    [DisplayName("Service Level Agreement")]
    [IsoXmlTag("SvcLvlAgrmt")]
    public required DocumentToSend2 ServiceLevelAgreement { get; init; }
}
