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
[IsoId("_YvuHNtp-Ed-ak6NoX_4Aeg_-901469544")]
[Description(@"Defines the type of action to take when the trigger hits.")]
[DerivedFrom(typeof(TriggerActionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TriggerAction1Code>))]
#endif
public enum TriggerAction1Code
{
    /// <summary>
    /// Trigger action is activate.
    /// Encoded/decoded by serializers as &quot;ACTI&quot;.
    /// </summary>
    [EnumMember(Value = "ACTI")]
    [IsoId("_YvuHN9p-Ed-ak6NoX_4Aeg_353594698")]
    [Description(@"Trigger action is activate.")]
    Activate = TriggerActionCode.Activate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trigger action is modify.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_Yv34MNp-Ed-ak6NoX_4Aeg_353594733")]
    [Description(@"Trigger action is modify.")]
    Modify = TriggerActionCode.Modify, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trigger action is cancel.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_Yv34Mdp-Ed-ak6NoX_4Aeg_353594985")]
    [Description(@"Trigger action is cancel.")]
    Cancel = TriggerActionCode.Cancel, // same ordinal as derivation source for type conversions
}
