// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of lottery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afolpNp-Ed-ak6NoX_4Aeg_1755473361")]
[Description(@"Specifies the type of lottery.")]
[Derivations(typeof(LotteryType1Code))]
public enum LotteryTypeCode
{
    /// <summary>
    /// Original lottery that has been announced for a specific amount and date.
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_afolpdp-Ed-ak6NoX_4Aeg_2038993840")]
    [Description(@"Original lottery that has been announced for a specific amount and date.")]
    OriginalLotteryNotification,
    
    /// <summary>
    /// Supplemental or additional quantity called on a previously announced original lottery.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_afolptp-Ed-ak6NoX_4Aeg_2144275992")]
    [Description(@"Supplemental or additional quantity called on a previously announced original lottery.")]
    SupplementalLotteryNotification,
    
}
