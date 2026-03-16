// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the action applies to a file or a record.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_O_lBYDEmEemzCpWiCwK4aQ")]
[Description(@"Indicates whether the action applies to a file or a record.")]
[DerivedFrom(typeof(FileActionScopeCode))]
public enum FileActionScope1Code
{
    /// <summary>
    /// Action applies to a file
    /// Encoded/decoded by serializers as &quot;FILE&quot;.
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_SafpETEmEemzCpWiCwK4aQ")]
    [Description(@"Action applies to a file")]
    File = FileActionScopeCode.File, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Action applies to a record
    /// Encoded/decoded by serializers as &quot;RECD&quot;.
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_Sv9iwTEmEemzCpWiCwK4aQ")]
    [Description(@"Action applies to a record")]
    Record = FileActionScopeCode.Record, // same ordinal as derivation source for type conversions
}
