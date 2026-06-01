// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A code that identifies the type of MOTO transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oasPEH28Ee6YlIMyoxWMJA")]
[Description(@"A code that identifies the type of MOTO transaction.")]
[DerivedFrom(typeof(MOTOV2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<MOTO2Code>))]
public enum MOTO2Code
{
    /// <summary>
    /// Mail order.
    /// Encoded/decoded by serializers as &quot;MAOR&quot;.
    /// </summary>
    [EnumMember(Value = "MAOR")]
    [IsoId("_gTBz4TVlEe-9laP_EysMaA")]
    [Description(@"Mail order.")]
    MailOrder = MOTOV2Code.MailOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mail order or telephone order.
    /// Encoded/decoded by serializers as &quot;MOTO&quot;.
    /// </summary>
    [EnumMember(Value = "MOTO")]
    [IsoId("_gTBz4zVlEe-9laP_EysMaA")]
    [Description(@"Mail order or telephone order.")]
    MailOrderOrTelephoneOrder = MOTOV2Code.MailOrderOrTelephoneOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Telephone order
    /// Encoded/decoded by serializers as &quot;TPOR&quot;.
    /// </summary>
    [EnumMember(Value = "TPOR")]
    [IsoId("_gTBz5TVlEe-9laP_EysMaA")]
    [Description(@"Telephone order")]
    TelephoneOrder = MOTOV2Code.TelephoneOrder, // same ordinal as derivation source for type conversions
}
