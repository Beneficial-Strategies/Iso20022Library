// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of action to take when the trigger hits.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yv34Mtp-Ed-ak6NoX_4Aeg_-920863827")]
[Description(@"Defines the type of action to take when the trigger hits.")]
[Derivations(typeof(TriggerAction1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TriggerActionCode>))]
#endif
public enum TriggerActionCode
{
    /// <summary>
    /// Trigger action is activate.
    /// Encoded/decoded by serializers as &quot;ACTI&quot;.
    /// </summary>
    [EnumMember(Value = "ACTI")]
    [IsoId("_Yv34M9p-Ed-ak6NoX_4Aeg_-556071238")]
    [Description(@"Trigger action is activate.")]
    Activate,

    /// <summary>
    /// Trigger action is modify.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_Yv34NNp-Ed-ak6NoX_4Aeg_-531138136")]
    [Description(@"Trigger action is modify.")]
    Modify,

    /// <summary>
    /// Trigger action is cancel.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_Yv34Ndp-Ed-ak6NoX_4Aeg_-527443091")]
    [Description(@"Trigger action is cancel.")]
    Cancel,
}
