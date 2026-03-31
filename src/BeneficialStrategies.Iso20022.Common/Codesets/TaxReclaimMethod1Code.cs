// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains Tax Reclaim options
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5jRhwDEuEemzCpWiCwK4aQ")]
[Description(@"Contains Tax Reclaim options")]
[DerivedFrom(typeof(TaxReclaimMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TaxReclaimMethod1Code>))]
#endif
public enum TaxReclaimMethod1Code
{
    /// <summary>
    /// Invoice printed and given to purchaser and then used for tax reclaim
    /// Encoded/decoded by serializers as &quot;INPP&quot;.
    /// </summary>
    [EnumMember(Value = "INPP")]
    [IsoId("_8RyWcTEuEemzCpWiCwK4aQ")]
    [Description(@"Invoice printed and given to purchaser and then used for tax reclaim")]
    InvoicePrintedPrimary = TaxReclaimMethodCode.InvoicePrintedPrimary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invoice printed but treated as supplemental because electronic copy is used for tax reclaim
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_8lwbUTEuEemzCpWiCwK4aQ")]
    [Description(
        @"Invoice printed but treated as supplemental because electronic copy is used for tax reclaim"
    )]
    InvoicePrintedSupplimental = TaxReclaimMethodCode.InvoicePrintedSupplimental, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Printed invoice suppressed because electronic master version is used for tax reclaim
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_866zATEuEemzCpWiCwK4aQ")]
    [Description(
        @"Printed invoice suppressed because electronic master version is used for tax reclaim"
    )]
    InvoiceSuppressed = TaxReclaimMethodCode.InvoiceSuppressed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other tax reclaim method not elsewhere specified
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_9QYFoTEuEemzCpWiCwK4aQ")]
    [Description(@"Other tax reclaim method not elsewhere specified")]
    Other = TaxReclaimMethodCode.Other, // same ordinal as derivation source for type conversions
}
