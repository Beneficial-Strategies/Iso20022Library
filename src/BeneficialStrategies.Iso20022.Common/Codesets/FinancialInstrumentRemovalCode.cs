// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the removal process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_J5tA0PkMEeicy5Zn42b9bg")]
[Description(@"Specifies the removal process.")]
[Derivations(typeof(FinancialInstrumentRemoval1Code))]
public enum FinancialInstrumentRemovalCode
{
    /// <summary>
    /// Financial instrument must be removed from the collateral pool.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_V1k88PkMEeicy5Zn42b9bg")]
    [Description(@"Financial instrument must be removed from the collateral pool.")]
    Removal,
    
    /// <summary>
    /// Removal period for the financial instrument from the collateral pool must be extended.
    /// Encoded/decoded by serializers as &quot;EXTN&quot;.
    /// </summary>
    [EnumMember(Value = "EXTN")]
    [IsoId("_cuv0MPkMEeicy5Zn42b9bg")]
    [Description(@"Removal period for the financial instrument from the collateral pool must be extended.")]
    Extension,
    
    /// <summary>
    /// Financial instrument removal is termintated.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_97V78PkMEeicy5Zn42b9bg")]
    [Description(@"Financial instrument removal is termintated.")]
    Termination,
    
}
