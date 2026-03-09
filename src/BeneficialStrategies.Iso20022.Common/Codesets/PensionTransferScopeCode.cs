// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the scope of a pension transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dOJOUE4YEeiQHa-q1Uephw")]
[Description(@"Specifies the scope of a pension transfer.")]
[Derivations(typeof(PensionTransferScope1Code))]
public enum PensionTransferScopeCode
{
    /// <summary>
    /// Transfer is for the full pension.
    /// Encoded/decoded by serializers as &quot;FULP&quot;.
    /// </summary>
    [EnumMember(Value = "FULP")]
    [IsoId("_iTuBAE4YEeiQHa-q1Uephw")]
    [Description(@"Transfer is for the full pension.")]
    FullPension,
    
    /// <summary>
    /// Transfer is for the uncrystallised portion.
    /// Encoded/decoded by serializers as &quot;UCRY&quot;.
    /// </summary>
    [EnumMember(Value = "UCRY")]
    [IsoId("_kTXkkE4YEeiQHa-q1Uephw")]
    [Description(@"Transfer is for the uncrystallised portion.")]
    UncrystallisedPart,
    
    /// <summary>
    /// Transfer is for the crystallised portion.
    /// Encoded/decoded by serializers as &quot;CRYS&quot;.
    /// </summary>
    [EnumMember(Value = "CRYS")]
    [IsoId("_n1K3YE4YEeiQHa-q1Uephw")]
    [Description(@"Transfer is for the crystallised portion.")]
    CrystallisedPart,
    
    /// <summary>
    /// Transfer is for a specific drawdown tranche.
    /// Encoded/decoded by serializers as &quot;SDDT&quot;.
    /// </summary>
    [EnumMember(Value = "SDDT")]
    [IsoId("_pY9lYE4YEeiQHa-q1Uephw")]
    [Description(@"Transfer is for a specific drawdown tranche.")]
    DrawdownTranche,
    
}
