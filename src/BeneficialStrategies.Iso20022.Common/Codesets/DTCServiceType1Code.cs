// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of DTC (The Depository Trust Company) service for example Cash In Lieu/ Round Up, Foreign Tax Relief, etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_14xnNDL3EeKU9IrkkToqcw_-790926092")]
[Description(
    @"Indicates the type of DTC (The Depository Trust Company) service for example Cash In Lieu/ Round Up, Foreign Tax Relief, etc."
)]
[DerivedFrom(typeof(DTCServiceType))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCServiceType1Code>))]
#endif
public enum DTCServiceType1Code
{
    /// <summary>
    /// Cash In Lieu or Round Up service.
    /// Encoded/decoded by serializers as &quot;CILR&quot;.
    /// </summary>
    [EnumMember(Value = "CILR")]
    [IsoId("_14xnNTL3EeKU9IrkkToqcw_-623906197")]
    [Description(@"Cash In Lieu or Round Up service.")]
    CashInLieuRoundUp = DTCServiceType.CashInLieuRoundUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// U.S. Tax Withholding service.
    /// Encoded/decoded by serializers as &quot;USTX&quot;.
    /// </summary>
    [EnumMember(Value = "USTX")]
    [IsoId("_14xnNjL3EeKU9IrkkToqcw_843242566")]
    [Description(@"U.S. Tax Withholding service.")]
    USTaxWithholding = DTCServiceType.USTaxWithholding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Foreign Tax Relief service.
    /// Encoded/decoded by serializers as &quot;FTXR&quot;.
    /// </summary>
    [EnumMember(Value = "FTXR")]
    [IsoId("_146xIDL3EeKU9IrkkToqcw_1672203018")]
    [Description(@"Foreign Tax Relief service.")]
    ForeignTaxRelief = DTCServiceType.ForeignTaxRelief, // same ordinal as derivation source for type conversions
}
