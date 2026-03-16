// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the deposit is fixed term or call/notice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcMuSNp-Ed-ak6NoX_4Aeg_-543523872")]
[Description(@"Specifies whether the deposit is fixed term or call/notice.")]
[DerivedFrom(typeof(DepositTypeCode))]
public enum DepositType1Code
{
    /// <summary>
    /// Specifies that it is a fixed term deposit.
    /// Encoded/decoded by serializers as &quot;FITE&quot;.
    /// </summary>
    [EnumMember(Value = "FITE")]
    [IsoId("_YcWfQNp-Ed-ak6NoX_4Aeg_-2068684174")]
    [Description(@"Specifies that it is a fixed term deposit.")]
    FixedTerm = DepositTypeCode.FixedTerm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that it is a call/notice deposit.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_YcWfQdp-Ed-ak6NoX_4Aeg_1908506461")]
    [Description(@"Specifies that it is a call/notice deposit.")]
    Call = DepositTypeCode.Call, // same ordinal as derivation source for type conversions
}
