// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities proceeds; whether they are newly issued or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w-5BQBH0EeKKuerhIbkpig")]
[Description(@"Specifies the type of securities proceeds; whether they are newly issued or not.")]
[DerivedFrom(typeof(NewSecuritiesIssuanceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NewSecuritiesIssuanceType1Code>))]
#endif
public enum NewSecuritiesIssuanceType1Code
{
    /// <summary>
    /// Securities proceeds are not new issues.
    /// Encoded/decoded by serializers as &quot;EXIS&quot;.
    /// </summary>
    [EnumMember(Value = "EXIS")]
    [IsoId("_hPR4URH1EeKKuerhIbkpig")]
    [Description(@"Securities proceeds are not new issues.")]
    ExistingIssue = NewSecuritiesIssuanceTypeCode.ExistingIssue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities proceeds are newly issued.
    /// Encoded/decoded by serializers as &quot;NEIS&quot;.
    /// </summary>
    [EnumMember(Value = "NEIS")]
    [IsoId("_hXeLARH1EeKKuerhIbkpig")]
    [Description(@"Securities proceeds are newly issued.")]
    NewIssue = NewSecuritiesIssuanceTypeCode.NewIssue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not known whether the securities proceeds are newly issued or not.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_hlxswxH1EeKKuerhIbkpig")]
    [Description(@"Not known whether the securities proceeds are newly issued or not.")]
    Unknown = NewSecuritiesIssuanceTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
