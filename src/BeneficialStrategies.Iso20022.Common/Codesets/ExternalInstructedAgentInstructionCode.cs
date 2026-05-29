// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction or adjustment, as provided to the instructed agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bEAp2rt6Eeq_cfXrH83Rcw")]
[Description(
    @"Specifies further instructions concerning the processing of a payment instruction or adjustment, as provided to the instructed agent."
)]
[Derivations(typeof(ExternalInstructedAgentInstruction1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInstructedAgentInstructionCode>))]
public enum ExternalInstructedAgentInstructionCode
{
    /// <summary>
    /// Reminder. A charge request message has been previously sent.
    /// Encoded/decoded by serializers as &quot;REMD&quot;.
    /// </summary>
    [EnumMember(Value = "REMD")]
    [IsoId("_sGUQENVPEe62uOJHIwvcig")]
    [Description(@"Reminder. A charge request message has been previously sent.")]
    Reminder,
}
