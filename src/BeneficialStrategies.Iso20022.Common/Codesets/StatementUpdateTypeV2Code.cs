// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of a statement update, eg, it is a complete statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQWvFNp-Ed-ak6NoX_4Aeg_-843565019")]
[Description(@"Specifies the nature of a statement update, eg, it is a complete statement.")]
[Derivations(typeof(StatementUpdateType1Code))]
public enum StatementUpdateTypeV2Code
{
    /// <summary>
    /// Statement is complete.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ZQWvFdp-Ed-ak6NoX_4Aeg_-843564993")]
    [Description(@"Statement is complete.")]
    Complete,

    /// <summary>
    /// Statement contains changes only.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_ZQWvFtp-Ed-ak6NoX_4Aeg_-843564977")]
    [Description(@"Statement contains changes only.")]
    Delta,
}
