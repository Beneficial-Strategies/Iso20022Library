// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the action applies to a file or a record.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NFe4o90mEeil7LQldntseg")]
[Description(@"Indicates whether the action applies to a file or a record.")]
[Derivations(typeof(FileActionScope1Code))]
public enum FileActionScopeCode
{
    /// <summary>
    /// Action applies to a file
    /// Encoded/decoded by serializers as &quot;FILE&quot;.
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_NFffsN0mEeil7LQldntseg")]
    [Description(@"Action applies to a file")]
    File,
    
    /// <summary>
    /// Action applies to a record
    /// Encoded/decoded by serializers as &quot;RECD&quot;.
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_NFffsd0mEeil7LQldntseg")]
    [Description(@"Action applies to a record")]
    Record,
    
}
