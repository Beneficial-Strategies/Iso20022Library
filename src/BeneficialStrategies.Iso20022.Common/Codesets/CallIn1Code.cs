// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of pay-in call report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bXNt6Np-Ed-ak6NoX_4Aeg_-324730819")]
[Description(@"Specifies the type of pay-in call report.")]
[DerivedFrom(typeof(CallInCode))]
public enum CallIn1Code
{
    /// <summary>
    /// Pay-in call is for account value.
    /// Encoded/decoded by serializers as &quot;CFAV&quot;.
    /// </summary>
    [EnumMember(Value = "CFAV")]
    [IsoId("_bXNt6dp-Ed-ak6NoX_4Aeg_556310168")]
    [Description(@"Pay-in call is for account value.")]
    CallForAccountValue = CallInCode.CallForAccountValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pay-in call is for settlement.
    /// Encoded/decoded by serializers as &quot;CFST&quot;.
    /// </summary>
    [EnumMember(Value = "CFST")]
    [IsoId("_bXW30Np-Ed-ak6NoX_4Aeg_600636833")]
    [Description(@"Pay-in call is for settlement.")]
    CallForSettlement = CallInCode.CallForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pay-in call is for currency close.
    /// Encoded/decoded by serializers as &quot;CFCC&quot;.
    /// </summary>
    [EnumMember(Value = "CFCC")]
    [IsoId("_bXW30dp-Ed-ak6NoX_4Aeg_628342105")]
    [Description(@"Pay-in call is for currency close.")]
    CallForCurrencyClose = CallInCode.CallForCurrencyClose, // same ordinal as derivation source for type conversions
}
