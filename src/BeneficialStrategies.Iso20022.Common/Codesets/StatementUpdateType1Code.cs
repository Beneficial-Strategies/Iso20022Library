// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of a statement update, for example, it is a complete statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQM-F9p-Ed-ak6NoX_4Aeg_1112854815")]
[Description(@"Specifies the nature of a statement update, for example, it is a complete statement.")]
[DerivedFrom(typeof(StatementUpdateTypeV2Code))]
public enum StatementUpdateType1Code
{
    /// <summary>
    /// Statement is complete.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ZQM-GNp-Ed-ak6NoX_4Aeg_1368668707")]
    [Description(@"Statement is complete.")]
    Complete = StatementUpdateTypeV2Code.Complete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Statement contains changes only.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_ZQWvENp-Ed-ak6NoX_4Aeg_1368668708")]
    [Description(@"Statement contains changes only.")]
    Delta = StatementUpdateTypeV2Code.Delta, // same ordinal as derivation source for type conversions
    
}
