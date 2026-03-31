// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the date of settlement, in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZLby1dp-Ed-ak6NoX_4Aeg_1690826366")]
[Description(@"Specifies the date of settlement, in coded form.")]
[DerivedFrom(typeof(SettlementDateCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementDate4Code>))]
#endif
public enum SettlementDate4Code
{
    /// <summary>
    /// Settlement is to be done when the security is issued.
    /// Encoded/decoded by serializers as &quot;WISS&quot;.
    /// </summary>
    [EnumMember(Value = "WISS")]
    [IsoId("_ZLby1tp-Ed-ak6NoX_4Aeg_1853523100")]
    [Description(@"Settlement is to be done when the security is issued.")]
    WhenIssued = SettlementDateCode.WhenIssued, // same ordinal as derivation source for type conversions
}
