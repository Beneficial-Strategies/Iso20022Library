// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the action on the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ya3Rgdp-Ed-ak6NoX_4Aeg_1660587071")]
[Description(@"Specifies the action on the cash account.")]
[Derivations(typeof(UseCases1Code))]
public enum UseCasesCode
{
    /// <summary>
    /// Code indicating the opening of an account.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_Ya3Rgtp-Ed-ak6NoX_4Aeg_1759403756")]
    [Description(@"Code indicating the opening of an account.")]
    Opening,

    /// <summary>
    /// Code indicating the maintenance of an account.
    /// Encoded/decoded by serializers as &quot;MNTN&quot;.
    /// </summary>
    [EnumMember(Value = "MNTN")]
    [IsoId("_Ya3Rg9p-Ed-ak6NoX_4Aeg_1772332772")]
    [Description(@"Code indicating the maintenance of an account.")]
    Maintenance,

    /// <summary>
    /// Code indicating the closing of an account.
    /// Encoded/decoded by serializers as &quot;CLSG&quot;.
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_Ya3RhNp-Ed-ak6NoX_4Aeg_1784340417")]
    [Description(@"Code indicating the closing of an account.")]
    Closing,

    /// <summary>
    /// Code indicating the view of an account.
    /// Encoded/decoded by serializers as &quot;VIEW&quot;.
    /// </summary>
    [EnumMember(Value = "VIEW")]
    [IsoId("_Ya3Rhdp-Ed-ak6NoX_4Aeg_2026301994")]
    [Description(@"Code indicating the view of an account.")]
    View,
}
