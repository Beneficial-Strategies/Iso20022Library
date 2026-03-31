// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the party responsible for the liability.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__2hJcCDMEeWPMvNwVtiMsA")]
[Description(@"Specifies the party responsible for the liability.")]
[DerivedFrom(typeof(LiabilityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Liability1Code>))]
#endif
public enum Liability1Code
{
    /// <summary>
    /// Investor is responsible.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_Bm3FsSDNEeWPMvNwVtiMsA")]
    [Description(@"Investor is responsible.")]
    Investor = LiabilityCode.Investor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Broker is responsible.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_D6Zo4Ta2EeWxoIK_IhudJg")]
    [Description(@"Broker is responsible.")]
    Broker = LiabilityCode.Broker, // same ordinal as derivation source for type conversions
}
