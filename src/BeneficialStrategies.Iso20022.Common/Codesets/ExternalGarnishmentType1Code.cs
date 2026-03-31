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
[IsoId("_DsFkYInoEeOORMXOfBk1Bw")]
[Description(
    @"Specifies the garnishment type as published in an external document type code list."
)]
[DerivedFrom(typeof(ExternalGarnishmentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalGarnishmentType1Code>))]
#endif
public enum ExternalGarnishmentType1Code
{
    /// <summary>
    /// Garnishment from a third party payer for Child Support
    /// Encoded/decoded by serializers as &quot;GNCS&quot;.
    /// </summary>
    [EnumMember(Value = "GNCS")]
    [IsoId("_uTKPlfRYEeuLhpyIdtJzwg")]
    [Description(@"Garnishment from a third party payer for Child Support")]
    GarnishmentForChildSupport = ExternalGarnishmentTypeCode.GarnishmentForChildSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Garnishment from a direct payer for Child Support
    /// Encoded/decoded by serializers as &quot;GNDP&quot;.
    /// </summary>
    [EnumMember(Value = "GNDP")]
    [IsoId("_uTUAkvRYEeuLhpyIdtJzwg")]
    [Description(@"Garnishment from a direct payer for Child Support")]
    GarnishmentForChildSupportFromDirectPayer =
        ExternalGarnishmentTypeCode.GarnishmentForChildSupportFromDirectPayer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Garnishment from a third party payer to taxing agency
    /// Encoded/decoded by serializers as &quot;GTPP&quot;.
    /// </summary>
    [EnumMember(Value = "GTPP")]
    [IsoId("_uTUAlfRYEeuLhpyIdtJzwg")]
    [Description(@"Garnishment from a third party payer to taxing agency")]
    GarnishmentToTaxingAgency = ExternalGarnishmentTypeCode.GarnishmentToTaxingAgency, // same ordinal as derivation source for type conversions
}
