// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies quantity of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mxo5YQCgEeGqP72A5EmwKQ")]
[Description(@"Specifies quantity of a financial instrument.")]
[DerivedFrom(typeof(QuantityCode))]
public enum Quantity4Code
{
    /// <summary>
    /// Quantity is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_mxyqZQCgEeGqP72A5EmwKQ")]
    [Description(@"Quantity is unknown by the sender or has not been established.")]
    UnknownQuantity = QuantityCode.UnknownQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction applies to the entire eligible balance of underlying securities.
    /// Encoded/decoded by serializers as &quot;ANYA&quot;.
    /// </summary>
    [EnumMember(Value = "ANYA")]
    [IsoId("_n0ZW7gCgEeGqP72A5EmwKQ")]
    [Description(@"Instruction applies to the entire eligible balance of underlying securities.")]
    AnyAndAll = QuantityCode.AnyAndAll, // same ordinal as derivation source for type conversions
}
