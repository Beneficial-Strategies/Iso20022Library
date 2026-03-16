// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the timing or method for terminating the agreement - for repos.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YlvEw9p-Ed-ak6NoX_4Aeg_2067283309")]
[Description(@"Specifies the timing or method for terminating the agreement - for repos.")]
[Derivations(typeof(ClosingType1Code), typeof(TerminationType1Code))]
public enum TerminationTypeCode
{
    /// <summary>
    /// Repo with a term of one day.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_YlvExNp-Ed-ak6NoX_4Aeg_-2111318723")]
    [Description(@"Repo with a term of one day.")]
    Overnight,

    /// <summary>
    /// Repo with a term of more than one day.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_YlvExdp-Ed-ak6NoX_4Aeg_-2097465461")]
    [Description(@"Repo with a term of more than one day.")]
    Term,

    /// <summary>
    /// Identifies &quot;a classic term repo with the added feature that the cash is repaid to the buyer in installments&quot; (Definition from &quot;Mastering Repo Markets&quot; by Bob Steiner).
    /// Encoded/decoded by serializers as &quot;FLEX&quot;.
    /// </summary>
    [EnumMember(Value = "FLEX")]
    [IsoId("_YlvExtp-Ed-ak6NoX_4Aeg_-1882287160")]
    [Description(
        @"Identifies ""a classic term repo with the added feature that the cash is repaid to the buyer in installments"" (Definition from ""Mastering Repo Markets"" by Bob Steiner)."
    )]
    Flexible,

    /// <summary>
    /// Repo which can be terminated by either party at any time, and which has an unspecified repurchase date.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_Yl41wNp-Ed-ak6NoX_4Aeg_-1871202775")]
    [Description(
        @"Repo which can be terminated by either party at any time, and which has an unspecified repurchase date."
    )]
    Open,
}
