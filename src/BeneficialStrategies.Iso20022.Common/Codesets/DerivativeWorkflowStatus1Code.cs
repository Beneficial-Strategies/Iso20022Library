// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of exchange&apos;s notice of change on a derivative.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_12PQkjL3EeKU9IrkkToqcw_-742843847")]
[Description(@"Specifies the status of exchange's notice of change on a derivative.")]
[DerivedFrom(typeof(DerivativeWorkflowStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DerivativeWorkflowStatus1Code>))]
#endif
public enum DerivativeWorkflowStatus1Code
{
    /// <summary>
    /// Notice is an advance warning that an adjustment may be applied.
    /// Encoded/decoded by serializers as &quot;PREL&quot;.
    /// </summary>
    [EnumMember(Value = "PREL")]
    [IsoId("_12PQkzL3EeKU9IrkkToqcw_-1279574546")]
    [Description(@"Notice is an advance warning that an adjustment may be applied.")]
    Preliminary = DerivativeWorkflowStatusCode.Preliminary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notice confirms that an adjustment will be applied.
    /// Encoded/decoded by serializers as &quot;ADJU&quot;.
    /// </summary>
    [EnumMember(Value = "ADJU")]
    [IsoId("_12PQlDL3EeKU9IrkkToqcw_1932288914")]
    [Description(@"Notice confirms that an adjustment will be applied.")]
    Adjustment = DerivativeWorkflowStatusCode.Adjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notice confirms that no adjustment will be applied.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_12PQlTL3EeKU9IrkkToqcw_-1908591113")]
    [Description(@"Notice confirms that no adjustment will be applied.")]
    NoAction = DerivativeWorkflowStatusCode.NoAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GCA VS (Global Corporate Actions Validation Service) is unable to confirm that there is a corporate action corresponding to this notice.
    /// Encoded/decoded by serializers as &quot;UCON&quot;.
    /// </summary>
    [EnumMember(Value = "UCON")]
    [IsoId("_12ZBkDL3EeKU9IrkkToqcw_-77667944")]
    [Description(
        @"GCA VS (Global Corporate Actions Validation Service) is unable to confirm that there is a corporate action corresponding to this notice."
    )]
    Unconfirmed = DerivativeWorkflowStatusCode.Unconfirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Details were entered in error. All data should be ignored.
    /// Encoded/decoded by serializers as &quot;DLTD&quot;.
    /// </summary>
    [EnumMember(Value = "DLTD")]
    [IsoId("_12ZBkTL3EeKU9IrkkToqcw_247449563")]
    [Description(@"Details were entered in error. All data should be ignored.")]
    Deleted = DerivativeWorkflowStatusCode.Deleted, // same ordinal as derivation source for type conversions
}
