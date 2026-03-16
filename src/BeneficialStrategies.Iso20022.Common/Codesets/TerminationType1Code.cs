// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the timing or method for terminating the agreement - for repos.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yll619p-Ed-ak6NoX_4Aeg_2070054481")]
[Description(@"Specifies the timing or method for terminating the agreement - for repos.")]
[DerivedFrom(typeof(TerminationTypeCode))]
public enum TerminationType1Code
{
    /// <summary>
    /// Repo with a term of one day.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_Yll62Np-Ed-ak6NoX_4Aeg_1580324024")]
    [Description(@"Repo with a term of one day.")]
    Overnight = TerminationTypeCode.Overnight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo with a term of more than one day.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_YlvEwNp-Ed-ak6NoX_4Aeg_1580324066")]
    [Description(@"Repo with a term of more than one day.")]
    Term = TerminationTypeCode.Term, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies &quot;a classic term repo with the added feature that the cash is repaid to the buyer in installments&quot; (Definition from &quot;Mastering Repo Markets&quot; by Bob Steiner).
    /// Encoded/decoded by serializers as &quot;FLEX&quot;.
    /// </summary>
    [EnumMember(Value = "FLEX")]
    [IsoId("_YlvEwdp-Ed-ak6NoX_4Aeg_1580324109")]
    [Description(
        @"Identifies ""a classic term repo with the added feature that the cash is repaid to the buyer in installments"" (Definition from ""Mastering Repo Markets"" by Bob Steiner)."
    )]
    Flexible = TerminationTypeCode.Flexible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo which can be terminated by either party at any time, and which has an unspecified repurchase date.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_YlvEwtp-Ed-ak6NoX_4Aeg_1580324126")]
    [Description(
        @"Repo which can be terminated by either party at any time, and which has an unspecified repurchase date."
    )]
    Open = TerminationTypeCode.Open, // same ordinal as derivation source for type conversions
}
