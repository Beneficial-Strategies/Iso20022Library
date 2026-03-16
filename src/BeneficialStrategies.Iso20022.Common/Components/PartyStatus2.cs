// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business status of the party for processing in the system.
/// </summary>
[IsoId("_7_fcO1hLEeih3fUfzR38Ig")]
[DisplayName("Party Status")]
public record PartyStatus2
{
    /// <summary>
    /// Status of the party maintenance instruction.
    /// </summary>
    [IsoId("_8KDGZVhLEeih3fUfzR38Ig")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status6Code Status { get; init; }

    /// <summary>
    /// Specifies the underlying reason for the status of an object.
    /// </summary>
    [IsoId("_8KDGZ1hLEeih3fUfzR38Ig")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReasonInformation10? StatusReason { get; init; }

    /// <summary>
    /// Specifications of a party defined within a system.
    /// </summary>
    [IsoId("_8KDGaVhLEeih3fUfzR38Ig")]
    [DisplayName("System Party Identification")]
    [IsoXmlTag("SysPtyId")]
    public SystemPartyIdentification8? SystemPartyIdentification { get; init; }
}
