// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the condition under which automatic borrowing is allowed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bjlV9dp-Ed-ak6NoX_4Aeg_-1856844468")]
[Description(@"Specifies the condition under which automatic borrowing is allowed.")]
[DerivedFrom(typeof(AutoBorrowingCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AutoBorrowing1Code>))]
#endif
public enum AutoBorrowing1Code
{
    /// <summary>
    /// Only last resort borrowing should be considered to make settlement occur.
    /// Encoded/decoded by serializers as &quot;LAMI&quot;.
    /// </summary>
    [EnumMember(Value = "LAMI")]
    [IsoId("_bjlV9tp-Ed-ak6NoX_4Aeg_-1856844449")]
    [Description(@"Only last resort borrowing should be considered to make settlement occur.")]
    LastResort = AutoBorrowingCode.LastResort, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No automatic borrowing should take place.
    /// Encoded/decoded by serializers as &quot;NBOR&quot;.
    /// </summary>
    [EnumMember(Value = "NBOR")]
    [IsoId("_bjlV99p-Ed-ak6NoX_4Aeg_-1856844448")]
    [Description(@"No automatic borrowing should take place.")]
    NoAutomatic = AutoBorrowingCode.NoAutomatic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Automatic borrowing should take place.
    /// Encoded/decoded by serializers as &quot;YBOR&quot;.
    /// </summary>
    [EnumMember(Value = "YBOR")]
    [IsoId("_bjlV-Np-Ed-ak6NoX_4Aeg_-1856844433")]
    [Description(@"Automatic borrowing should take place.")]
    Automatic = AutoBorrowingCode.Automatic, // same ordinal as derivation source for type conversions
}
