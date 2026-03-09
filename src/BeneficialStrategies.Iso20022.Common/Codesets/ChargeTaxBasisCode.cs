// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Define the Charges/tax basis for the trade being allocated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1DJsdojEeC60axPepSq7g_143503788")]
[Description(@"Define the Charges/tax basis for the trade being allocated.")]
[Derivations(typeof(ChargeTaxBasis1Code))]
public enum ChargeTaxBasisCode
{
    /// <summary>
    /// Charges/tax basis is flat or absolute for the trade being allocated.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("__1DJstojEeC60axPepSq7g_303938455")]
    [Description(@"Charges/tax basis is flat or absolute for the trade being allocated.")]
    FlatOrAbsolute,
    
    /// <summary>
    /// Charge/tax basis is per unit of financial instrument.
    /// Encoded/decoded by serializers as &quot;PERU&quot;.
    /// </summary>
    [EnumMember(Value = "PERU")]
    [IsoId("__1DJs9ojEeC60axPepSq7g_-13293518")]
    [Description(@"Charge/tax basis is per unit of financial instrument.")]
    PerUnit,
    
}
