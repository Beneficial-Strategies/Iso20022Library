// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbcAoGliEeGaMcKyqKNRfQ_-953519462")]
[Description(@"Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).")]
[Derivations(typeof(GlobalNote1Code))]
public enum GlobalNoteCode
{
    /// <summary>
    /// Form of global certificate which refers to the books and records of the ICSDs to determine the Issue Outstanding Amount (IOA).
    /// Encoded/decoded by serializers as &quot;NGNO&quot;.
    /// </summary>
    [EnumMember(Value = "NGNO")]
    [IsoId("_hbcAoWliEeGaMcKyqKNRfQ_1154534279")]
    [Description(@"Form of global certificate which refers to the books and records of the ICSDs to determine the Issue Outstanding Amount (IOA).")]
    NewGlobalNote,
    
    /// <summary>
    /// Form of global certificate which requires physical annotation on the attached schedule to reflect changes in the Issue Outstanding Amount (IOA).
    /// Encoded/decoded by serializers as &quot;CGNO&quot;.
    /// </summary>
    [EnumMember(Value = "CGNO")]
    [IsoId("_hbcAomliEeGaMcKyqKNRfQ_1453098033")]
    [Description(@"Form of global certificate which requires physical annotation on the attached schedule to reflect changes in the Issue Outstanding Amount (IOA).")]
    ClassicalGlobalNote,
    
}
