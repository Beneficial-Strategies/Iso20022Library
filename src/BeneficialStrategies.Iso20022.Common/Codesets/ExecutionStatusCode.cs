// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the status on a  transaction is pending initiation or has been initiated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kx_YcMX0EeiSF9q-coWegA")]
[Description(
    @"Specifies if the status on a  transaction is pending initiation or has been initiated."
)]
[Derivations(typeof(ExecutionStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExecutionStatusCode>))]
#endif
public enum ExecutionStatusCode
{
    /// <summary>
    /// Transaction which has been initiated and has not yet closed.
    /// Encoded/decoded by serializers as &quot;INTD&quot;.
    /// </summary>
    [EnumMember(Value = "INTD")]
    [IsoId("_9-YvcMX0EeiSF9q-coWegA")]
    [Description(@"Transaction which has been initiated and has not yet closed.")]
    Initiated,

    /// <summary>
    /// Pending Initiation.
    /// Encoded/decoded by serializers as &quot;PINT&quot;.
    /// </summary>
    [EnumMember(Value = "PINT")]
    [IsoId("_CeKtcMX1EeiSF9q-coWegA")]
    [Description(@"Pending Initiation.")]
    PendingInitiation,
}
