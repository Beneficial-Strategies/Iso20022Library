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
[IsoId("_Y8Y9hTVlEe-9laP_EysMaA")]
[Description(@"A code that identifies the type of MOTO transaction.")]
[Derivations(typeof(MOTO2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<MOTOV2Code>))]
public enum MOTOV2Code
{
    /// <summary>
    /// Mail order.
    /// Encoded/decoded by serializers as &quot;MAOR&quot;.
    /// </summary>
    [EnumMember(Value = "MAOR")]
    [IsoId("_Y8Y9iDVlEe-9laP_EysMaA")]
    [Description(@"Mail order.")]
    MailOrder,

    /// <summary>
    /// Mail order or telephone order.
    /// Encoded/decoded by serializers as &quot;MOTO&quot;.
    /// </summary>
    [EnumMember(Value = "MOTO")]
    [IsoId("_Y8Y9hzVlEe-9laP_EysMaA")]
    [Description(@"Mail order or telephone order.")]
    MailOrderOrTelephoneOrder,

    /// <summary>
    /// Telephone order
    /// Encoded/decoded by serializers as &quot;TPOR&quot;.
    /// </summary>
    [EnumMember(Value = "TPOR")]
    [IsoId("_Y8Y9hjVlEe-9laP_EysMaA")]
    [Description(@"Telephone order")]
    TelephoneOrder,
}
