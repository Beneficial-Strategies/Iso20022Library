// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a financial instrument is transferred as an asset or as cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xvY1YKxWEemRcYBAkJyjkg")]
[Description(@"Specifies whether a financial instrument is transferred as an asset or as cash.")]
[DerivedFrom(typeof(TransferTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransferType4Code>))]
#endif
public enum TransferType4Code
{
    /// <summary>
    /// Transfer as cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_y8KKgaxWEemRcYBAkJyjkg")]
    [Description(@"Transfer as cash.")]
    Cash = TransferTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ISIN is converted to another ISIN and then transferred.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_zABW0axWEemRcYBAkJyjkg")]
    [Description(@"ISIN is converted to another ISIN and then transferred.")]
    Conversion = TransferTypeCode.Conversion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Asset excluded from transfer.
    /// Encoded/decoded by serializers as &quot;EXCL&quot;.
    /// </summary>
    [EnumMember(Value = "EXCL")]
    [IsoId("_zE7sAaxWEemRcYBAkJyjkg")]
    [Description(@"Asset excluded from transfer.")]
    Excluded = TransferTypeCode.Excluded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer the security as an asset in specie, that is, &apos;in its actual form&apos;.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_zJGaUaxWEemRcYBAkJyjkg")]
    [Description(@"Transfer the security as an asset in specie, that is, 'in its actual form'.")]
    InSpecie = TransferTypeCode.InSpecie, // same ordinal as derivation source for type conversions
}
