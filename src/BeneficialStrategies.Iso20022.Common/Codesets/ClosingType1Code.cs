// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the timing or method for terminating the agreement - for repos.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KgvwANonEeCWg-hsBVGrDA_-669343258")]
[Description(@"Specifies the timing or method for terminating the agreement - for repos.")]
[DerivedFrom(typeof(TerminationTypeCode))]
public enum ClosingType1Code
{
    /// <summary>
    /// Repo with a term of one day.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_KgvwAdonEeCWg-hsBVGrDA_975924177")]
    [Description(@"Repo with a term of one day.")]
    Overnight = TerminationTypeCode.Overnight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo with a term of more than one day.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_KgvwAtonEeCWg-hsBVGrDA_-1666415611")]
    [Description(@"Repo with a term of more than one day.")]
    Term = TerminationTypeCode.Term, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies &quot;a classic term repo with the added feature that the cash is repaid to the buyer in installments&quot; (Definition from &quot;Mastering Repo Markets&quot; by Bob Steiner).
    /// Encoded/decoded by serializers as &quot;FLEX&quot;.
    /// </summary>
    [EnumMember(Value = "FLEX")]
    [IsoId("_KgvwA9onEeCWg-hsBVGrDA_-1488296939")]
    [Description(
        @"Identifies ""a classic term repo with the added feature that the cash is repaid to the buyer in installments"" (Definition from ""Mastering Repo Markets"" by Bob Steiner)."
    )]
    Flexible = TerminationTypeCode.Flexible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo which can be terminated by either party at any time, and which has an unspecified repurchase date.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_KgvwBNonEeCWg-hsBVGrDA_-1780254677")]
    [Description(
        @"Repo which can be terminated by either party at any time, and which has an unspecified repurchase date."
    )]
    Open = TerminationTypeCode.Open, // same ordinal as derivation source for type conversions
}
