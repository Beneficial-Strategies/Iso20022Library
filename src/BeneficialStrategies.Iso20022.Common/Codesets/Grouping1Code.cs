// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the grouping options of the payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_auruSNp-Ed-ak6NoX_4Aeg_-1275607506")]
[Description(@"Specifies the grouping options of the payment transaction.")]
[DerivedFrom(typeof(GroupingCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Grouping1Code>))]
#endif
public enum Grouping1Code
{
    /// <summary>
    /// Indicates that for each occurrences of the payment information block, exactly one occurrence of the payment transaction block is present.
    /// Encoded/decoded by serializers as &quot;SNGL&quot;.
    /// </summary>
    [EnumMember(Value = "SNGL")]
    [IsoId("_au04MNp-Ed-ak6NoX_4Aeg_-1275607481")]
    [Description(
        @"Indicates that for each occurrences of the payment information block, exactly one occurrence of the payment transaction block is present."
    )]
    Single = GroupingCode.Single, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that there is only one occurrence of the payment information block and several occurrences of the payment transaction block.
    /// Encoded/decoded by serializers as &quot;GRPD&quot;.
    /// </summary>
    [EnumMember(Value = "GRPD")]
    [IsoId("_au04Mdp-Ed-ak6NoX_4Aeg_-1275607464")]
    [Description(
        @"Indicates that there is only one occurrence of the payment information block and several occurrences of the payment transaction block."
    )]
    Grouped = GroupingCode.Grouped, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that there are one or several occurrences of the payment information block where each of the occurrences might contain one or several occurrences of the payment transaction block.
    /// Encoded/decoded by serializers as &quot;MIXD&quot;.
    /// </summary>
    [EnumMember(Value = "MIXD")]
    [IsoId("_au04Mtp-Ed-ak6NoX_4Aeg_-1275607446")]
    [Description(
        @"Indicates that there are one or several occurrences of the payment information block where each of the occurrences might contain one or several occurrences of the payment transaction block."
    )]
    Mixed = GroupingCode.Mixed, // same ordinal as derivation source for type conversions
}
