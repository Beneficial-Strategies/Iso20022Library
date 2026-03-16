// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of a configuration.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ActivationStatus2Code")]
[Description(@"Status of a configuration.")]
[DerivedFrom(typeof(ActivationStatusCode))]
public enum ActivationStatus2Code
{
    /// <summary>
    /// The configuration update has failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_ActivationStatus2Code_Fail")]
    [Description(@"The configuration update has failed.")]
    Fail = ActivationStatusCode.Fail,

    /// <summary>
    /// The configuration download was successful and is now awaiting a future activation date.
    /// Encoded/decoded by serializers as &quot;WACT&quot;.
    /// </summary>
    [EnumMember(Value = "WACT")]
    [IsoId("_ActivationStatus2Code_AwaitingActivation")]
    [Description(
        @"The configuration download was successful and is now awaiting a future activation date."
    )]
    AwaitingActivation = ActivationStatusCode.AwaitingActivation,
}
