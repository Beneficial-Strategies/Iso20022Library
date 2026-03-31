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
[IsoId("_Nff_g_M9Eei4qfiLgRIZBA")]
[Description(@"Contains Tax Reclaim options")]
[Derivations(typeof(TaxReclaimMethod1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TaxReclaimMethodCode>))]
#endif
public enum TaxReclaimMethodCode
{
    /// <summary>
    /// Invoice printed but treated as supplemental because electronic copy is used for tax reclaim
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_Nff_hPM9Eei4qfiLgRIZBA")]
    [Description(
        @"Invoice printed but treated as supplemental because electronic copy is used for tax reclaim"
    )]
    InvoicePrintedSupplimental,

    /// <summary>
    /// Printed invoice suppressed because electronic master version is used for tax reclaim
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_Nff_hfM9Eei4qfiLgRIZBA")]
    [Description(
        @"Printed invoice suppressed because electronic master version is used for tax reclaim"
    )]
    InvoiceSuppressed,

    /// <summary>
    /// Invoice printed and given to purchaser and then used for tax reclaim
    /// Encoded/decoded by serializers as &quot;INPP&quot;.
    /// </summary>
    [EnumMember(Value = "INPP")]
    [IsoId("_fHw2sPM9Eei4qfiLgRIZBA")]
    [Description(@"Invoice printed and given to purchaser and then used for tax reclaim")]
    InvoicePrintedPrimary,

    /// <summary>
    /// Other tax reclaim method not elsewhere specified
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_4yGRcPM-Eei4qfiLgRIZBA")]
    [Description(@"Other tax reclaim method not elsewhere specified")]
    Other,
}
