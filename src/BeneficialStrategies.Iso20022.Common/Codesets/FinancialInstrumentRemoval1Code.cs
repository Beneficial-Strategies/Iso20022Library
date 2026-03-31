// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the removal process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MUJ0kPkNEeicy5Zn42b9bg")]
[Description(@"Specifies the removal process.")]
[DerivedFrom(typeof(FinancialInstrumentRemovalCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FinancialInstrumentRemoval1Code>))]
#endif
public enum FinancialInstrumentRemoval1Code
{
    /// <summary>
    /// Removal period for the financial instrument from the collateral pool must be extended.
    /// Encoded/decoded by serializers as &quot;EXTN&quot;.
    /// </summary>
    [EnumMember(Value = "EXTN")]
    [IsoId("_YxHEgfkNEeicy5Zn42b9bg")]
    [Description(
        @"Removal period for the financial instrument from the collateral pool must be extended."
    )]
    Extension = FinancialInstrumentRemovalCode.Extension, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument must be removed from the collateral pool.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_ZAgycvkNEeicy5Zn42b9bg")]
    [Description(@"Financial instrument must be removed from the collateral pool.")]
    Removal = FinancialInstrumentRemovalCode.Removal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument removal is termintated.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_ZGSDQfkNEeicy5Zn42b9bg")]
    [Description(@"Financial instrument removal is termintated.")]
    Termination = FinancialInstrumentRemovalCode.Termination, // same ordinal as derivation source for type conversions
}
