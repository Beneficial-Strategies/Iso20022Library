// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of dates.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m23dkeEMEd-qUMZtd_eZuQ")]
[Description(@"Specifies the type of dates.")]
[DerivedFrom(typeof(DateTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DateType8Code>))]
#endif
public enum DateType8Code
{
    /// <summary>
    /// Date is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_q3yFcmtdEeCY4-KZ9JEyUQ_98980666")]
    [Description(@"Date is unknown by the sender or has not been established.")]
    Unknown = DateTypeCode.Unknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ongoing basis, which indicates that the date is determined by &quot;ongoing basis&quot; process, for example &quot;au fil de l&apos;eau&quot;.
    /// Encoded/decoded by serializers as &quot;ONGO&quot;.
    /// </summary>
    [EnumMember(Value = "ONGO")]
    [IsoId("_q3yFc2tdEeCY4-KZ9JEyUQ_-1984793229")]
    [Description(
        @"Ongoing basis, which indicates that the date is determined by ""ongoing basis"" process, for example ""au fil de l'eau""."
    )]
    Ongoing = DateTypeCode.Ongoing, // same ordinal as derivation source for type conversions
}
