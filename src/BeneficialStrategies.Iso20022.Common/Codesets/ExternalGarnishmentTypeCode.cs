// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the garnishment type as published in an external document type code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vfkPYLf7Eee9KIDjEHK7ZQ")]
[Description(
    @"Specifies the garnishment type as published in an external document type code list."
)]
[Derivations(typeof(ExternalGarnishmentType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalGarnishmentTypeCode>))]
#endif
public enum ExternalGarnishmentTypeCode
{
    /// <summary>
    /// Garnishment from a third party payer for Child Support
    /// Encoded/decoded by serializers as &quot;GNCS&quot;.
    /// </summary>
    [EnumMember(Value = "GNCS")]
    [IsoId("_uTKPk_RYEeuLhpyIdtJzwg")]
    [Description(@"Garnishment from a third party payer for Child Support")]
    GarnishmentForChildSupport,

    /// <summary>
    /// Garnishment from a direct payer for Child Support
    /// Encoded/decoded by serializers as &quot;GNDP&quot;.
    /// </summary>
    [EnumMember(Value = "GNDP")]
    [IsoId("_uTUAkPRYEeuLhpyIdtJzwg")]
    [Description(@"Garnishment from a direct payer for Child Support")]
    GarnishmentForChildSupportFromDirectPayer,

    /// <summary>
    /// Garnishment from a third party payer to taxing agency
    /// Encoded/decoded by serializers as &quot;GTPP&quot;.
    /// </summary>
    [EnumMember(Value = "GTPP")]
    [IsoId("_uTUAk_RYEeuLhpyIdtJzwg")]
    [Description(@"Garnishment from a third party payer to taxing agency")]
    GarnishmentToTaxingAgency,
}
