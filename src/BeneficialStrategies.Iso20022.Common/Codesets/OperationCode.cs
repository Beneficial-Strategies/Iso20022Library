// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the relationship between two variables.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aO8eR9p-Ed-ak6NoX_4Aeg_336257253")]
[Description(@"Indicates the relationship between two variables.")]
[Derivations(typeof(Operation1Code))]
public enum OperationCode
{
    /// <summary>
    /// Indicates a range delimited by two variables.
    /// Encoded/decoded by serializers as &quot;TILL&quot;.
    /// </summary>
    [EnumMember(Value = "TILL")]
    [IsoId("_aPFoMNp-Ed-ak6NoX_4Aeg_336257262")]
    [Description(@"Indicates a range delimited by two variables.")]
    Till,
    
    /// <summary>
    /// Indicates either of two variables is valid, but not both.
    /// Encoded/decoded by serializers as &quot;ORRR&quot;.
    /// </summary>
    [EnumMember(Value = "ORRR")]
    [IsoId("_aPFoMdp-Ed-ak6NoX_4Aeg_336257263")]
    [Description(@"Indicates either of two variables is valid, but not both.")]
    Or,
    
    /// <summary>
    /// Indicates that only when both variables are given, the operation is valid.
    /// Encoded/decoded by serializers as &quot;ANDD&quot;.
    /// </summary>
    [EnumMember(Value = "ANDD")]
    [IsoId("_aPFoMtp-Ed-ak6NoX_4Aeg_336257264")]
    [Description(@"Indicates that only when both variables are given, the operation is valid.")]
    And,
    
}
