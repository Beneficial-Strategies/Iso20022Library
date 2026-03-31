// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Level of urgency in contacting the terminal management system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUAMNQEcEeCQm6a_G2yO_w_-248608949")]
[Description(@"Level of urgency in contacting the terminal management system.")]
[DerivedFrom(typeof(TMSContactLevelCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TMSContactLevel1Code>))]
#endif
public enum TMSContactLevel1Code
{
    /// <summary>
    /// Terminal management system has to be contacted before the next transaction.
    /// Encoded/decoded by serializers as &quot;CRIT&quot;.
    /// </summary>
    [EnumMember(Value = "CRIT")]
    [IsoId("_TUAMNgEcEeCQm6a_G2yO_w_-1249727148")]
    [Description(@"Terminal management system has to be contacted before the next transaction.")]
    Critical = TMSContactLevelCode.Critical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal management system has to be contacted as soon as possible (for example after reconciliation).
    /// Encoded/decoded by serializers as &quot;ASAP&quot;.
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_TUAMNwEcEeCQm6a_G2yO_w_-1944834992")]
    [Description(
        @"Terminal management system has to be contacted as soon as possible (for example after reconciliation)."
    )]
    AsSoonAsPossible = TMSContactLevelCode.AsSoonAsPossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal management system has to be contacted at the date and time provided.
    /// Encoded/decoded by serializers as &quot;DTIM&quot;.
    /// </summary>
    [EnumMember(Value = "DTIM")]
    [IsoId("_TUAMOAEcEeCQm6a_G2yO_w_2032355643")]
    [Description(@"Terminal management system has to be contacted at the date and time provided.")]
    DateTime = TMSContactLevelCode.DateTime, // same ordinal as derivation source for type conversions
}
