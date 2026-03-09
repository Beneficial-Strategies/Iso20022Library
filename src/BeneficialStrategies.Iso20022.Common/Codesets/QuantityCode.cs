// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Quantity is unknown by the sender or has not been established.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZXgf89p-Ed-ak6NoX_4Aeg_973159431")]
[Description(@"Quantity is unknown by the sender or has not been established.")]
[Derivations(typeof(Quantity2Code),typeof(Quantity4Code),typeof(Quantity5Code),typeof(Quantity3Code),typeof(Quantity1Code))]
public enum QuantityCode
{
    /// <summary>
    /// Quantity has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ZXgf9Np-Ed-ak6NoX_4Aeg_746966356")]
    [Description(@"Quantity has not been established.")]
    Open,
    
    /// <summary>
    /// Quantity is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZXgf9dp-Ed-ak6NoX_4Aeg_746966416")]
    [Description(@"Quantity is unknown by the sender or has not been established.")]
    UnknownQuantity,
    
    /// <summary>
    /// Instruction applies to the entire eligible balance of underlying securities.
    /// Encoded/decoded by serializers as &quot;QALL&quot;.
    /// </summary>
    [EnumMember(Value = "QALL")]
    [IsoId("_ZXgf9tp-Ed-ak6NoX_4Aeg_1023951187")]
    [Description(@"Instruction applies to the entire eligible balance of underlying securities.")]
    AllSecurities,
    
    /// <summary>
    /// Instruction applies to the entire eligible balance of underlying securities.
    /// Encoded/decoded by serializers as &quot;ANYA&quot;.
    /// </summary>
    [EnumMember(Value = "ANYA")]
    [IsoId("_EWP5F_mWEeCcAY_zfcalaA")]
    [Description(@"Instruction applies to the entire eligible balance of underlying securities.")]
    AnyAndAll,
    
}
