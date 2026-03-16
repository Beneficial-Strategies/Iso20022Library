// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an activation code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ActivationStatusCode")]
[Description(@"Specifies an activation code.")]
public enum ActivationStatusCode
{
    /// <summary>
    /// MIRS is activated.
    /// Encoded/decoded by serializers as &quot;ACTI&quot;.
    /// </summary>
    [EnumMember(Value = "ACTI")]
    [IsoId("_ActivationStatusCode_Activated")]
    [Description(@"MIRS is activated.")]
    Activated,

    /// <summary>
    /// MIRS is deactivated.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_ActivationStatusCode_Deactivated")]
    [Description(@"MIRS is deactivated.")]
    Deactivated,

    /// <summary>
    /// The configuration update has failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_ActivationStatusCode_Fail")]
    [Description(@"The configuration update has failed.")]
    Fail,

    /// <summary>
    /// The configuration download was successful and is now awaiting a future activation date.
    /// Encoded/decoded by serializers as &quot;WACT&quot;.
    /// </summary>
    [EnumMember(Value = "WACT")]
    [IsoId("_ActivationStatusCode_AwaitingActivation")]
    [Description(@"The configuration download was successful and is now awaiting a future activation date.")]
    AwaitingActivation,

}
