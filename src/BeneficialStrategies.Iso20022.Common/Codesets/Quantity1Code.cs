// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies quantity of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZXWu9Np-Ed-ak6NoX_4Aeg_1332281009")]
[Description(@"Specifies quantity of a financial instrument.")]
[DerivedFrom(typeof(QuantityCode))]
public enum Quantity1Code
{
    /// <summary>
    /// Instruction applies to the entire eligible balance of underlying securities.
    /// Encoded/decoded by serializers as &quot;QALL&quot;.
    /// </summary>
    [EnumMember(Value = "QALL")]
    [IsoId("_ZXWu9dp-Ed-ak6NoX_4Aeg_1332281018")]
    [Description(@"Instruction applies to the entire eligible balance of underlying securities.")]
    AllSecurities = QuantityCode.AllSecurities, // same ordinal as derivation source for type conversions
}
