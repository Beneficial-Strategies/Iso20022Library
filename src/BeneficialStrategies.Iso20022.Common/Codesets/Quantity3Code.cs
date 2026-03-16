// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies quantity of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7AQ5seGZEd-1Ktb5rVaajw")]
[Description(@"Specifies quantity of a financial instrument.")]
[DerivedFrom(typeof(QuantityCode))]
public enum Quantity3Code
{
    /// <summary>
    /// Instruction applies to the entire eligible balance of underlying securities.
    /// Encoded/decoded by serializers as &quot;QALL&quot;.
    /// </summary>
    [EnumMember(Value = "QALL")]
    [IsoId("_q5bENmtdEeCY4-KZ9JEyUQ_-1074232711")]
    [Description(@"Instruction applies to the entire eligible balance of underlying securities.")]
    AllSecurities = QuantityCode.AllSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_q5kOIGtdEeCY4-KZ9JEyUQ_-1913030463")]
    [Description(@"Quantity is unknown by the sender or has not been established.")]
    UnknownQuantity = QuantityCode.UnknownQuantity, // same ordinal as derivation source for type conversions
}
