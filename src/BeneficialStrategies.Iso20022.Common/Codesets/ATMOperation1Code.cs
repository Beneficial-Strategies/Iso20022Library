// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of logical or physical operation on an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2p6D0OhAEeSbwP3G-MV9YA")]
[Description(@"Type of logical or physical operation on an ATM.")]
[DerivedFrom(typeof(ATMOperationCode))]
public enum ATMOperation1Code
{
    /// <summary>
    /// Adjust logical counters of the cassette.
    /// Encoded/decoded by serializers as &quot;ADJU&quot;.
    /// </summary>
    [EnumMember(Value = "ADJU")]
    [IsoId("_EHHP0ehBEeSbwP3G-MV9YA")]
    [Description(@"Adjust logical counters of the cassette.")]
    Adjust = ATMOperationCode.Adjust, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Add physically media to cassette.
    /// Encoded/decoded by serializers as &quot;INSR&quot;.
    /// </summary>
    [EnumMember(Value = "INSR")]
    [IsoId("_EQDwc-hBEeSbwP3G-MV9YA")]
    [Description(@"Add physically media to cassette.")]
    InsertMedia = ATMOperationCode.InsertMedia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loading cassette.
    /// Encoded/decoded by serializers as &quot;LOAD&quot;.
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_ERi-MehBEeSbwP3G-MV9YA")]
    [Description(@"Loading cassette.")]
    Loading = ATMOperationCode.Loading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Substract physically media from cassette.
    /// Encoded/decoded by serializers as &quot;REMV&quot;.
    /// </summary>
    [EnumMember(Value = "REMV")]
    [IsoId("_EZ5B4ehBEeSbwP3G-MV9YA")]
    [Description(@"Substract physically media from cassette.")]
    RemoveMedia = ATMOperationCode.RemoveMedia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unloading cassette.
    /// Encoded/decoded by serializers as &quot;UNLD&quot;.
    /// </summary>
    [EnumMember(Value = "UNLD")]
    [IsoId("_Ei-sc-hBEeSbwP3G-MV9YA")]
    [Description(@"Unloading cassette.")]
    Unloading = ATMOperationCode.Unloading, // same ordinal as derivation source for type conversions
}
