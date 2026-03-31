// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of communication channel.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_y2ltsBRFEeOKWo1NF21OVw")]
[Description(@"Specifies the type of communication channel.")]
[DerivedFrom(typeof(TransactionChannelCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionChannel2Code>))]
#endif
public enum TransactionChannel2Code
{
    /// <summary>
    /// Financial advisor.
    /// Encoded/decoded by serializers as &quot;FIAD&quot;.
    /// </summary>
    [EnumMember(Value = "FIAD")]
    [IsoId("_5TAXgRRFEeOKWo1NF21OVw")]
    [Description(@"Financial advisor.")]
    FinancialAdvisor = TransactionChannelCode.FinancialAdvisor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Home banking.
    /// Encoded/decoded by serializers as &quot;HOBA&quot;.
    /// </summary>
    [EnumMember(Value = "HOBA")]
    [IsoId("_5fNAcRRFEeOKWo1NF21OVw")]
    [Description(@"Home banking.")]
    HomeBanking = TransactionChannelCode.HomeBanking, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Office or branch.
    /// Encoded/decoded by serializers as &quot;BRAN&quot;.
    /// </summary>
    [EnumMember(Value = "BRAN")]
    [IsoId("_7iH6cRRFEeOKWo1NF21OVw")]
    [Description(@"Office or branch.")]
    OfficeOrBranch = TransactionChannelCode.OfficeOrBranch, // same ordinal as derivation source for type conversions
}
