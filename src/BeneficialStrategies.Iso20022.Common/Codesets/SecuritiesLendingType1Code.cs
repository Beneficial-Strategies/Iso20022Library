// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of securities lending contract.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__wINcdojEeC60axPepSq7g_2101036027")]
[Description(@"Type of securities lending contract.")]
[DerivedFrom(typeof(SecuritiesLendingTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesLendingType1Code>))]
#endif
public enum SecuritiesLendingType1Code
{
    /// <summary>
    /// Securities lending contract is new and registered.
    /// Encoded/decoded by serializers as &quot;NWRG&quot;.
    /// </summary>
    [EnumMember(Value = "NWRG")]
    [IsoId("__wINctojEeC60axPepSq7g_-1300895809")]
    [Description(@"Securities lending contract is new and registered.")]
    NewRegistration = SecuritiesLendingTypeCode.NewRegistration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities lending contract is renewed.
    /// Encoded/decoded by serializers as &quot;RENW&quot;.
    /// </summary>
    [EnumMember(Value = "RENW")]
    [IsoId("__wINc9ojEeC60axPepSq7g_166252954")]
    [Description(@"Securities lending contract is renewed.")]
    RollOverRenewal = SecuritiesLendingTypeCode.RollOverRenewal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities lending contract is called back.
    /// Encoded/decoded by serializers as &quot;CABK&quot;.
    /// </summary>
    [EnumMember(Value = "CABK")]
    [IsoId("__wINdNojEeC60axPepSq7g_-1719429399")]
    [Description(@"Securities lending contract is called back.")]
    CallBack = SecuritiesLendingTypeCode.CallBack, // same ordinal as derivation source for type conversions
}
