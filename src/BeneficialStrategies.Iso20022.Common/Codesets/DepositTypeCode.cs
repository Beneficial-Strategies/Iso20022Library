// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the deposit is fixed term or call/notice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcWfQtp-Ed-ak6NoX_4Aeg_505422877")]
[Description(@"Specifies whether the deposit is fixed term or call/notice.")]
[Derivations(typeof(DepositType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DepositTypeCode>))]
#endif
public enum DepositTypeCode
{
    /// <summary>
    /// Specifies that it is a fixed term deposit.
    /// Encoded/decoded by serializers as &quot;FITE&quot;.
    /// </summary>
    [EnumMember(Value = "FITE")]
    [IsoId("_YcWfQ9p-Ed-ak6NoX_4Aeg_-1782295847")]
    [Description(@"Specifies that it is a fixed term deposit.")]
    FixedTerm,

    /// <summary>
    /// Specifies that it is a call/notice deposit.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_YcWfRNp-Ed-ak6NoX_4Aeg_-224803349")]
    [Description(@"Specifies that it is a call/notice deposit.")]
    Call,
}
