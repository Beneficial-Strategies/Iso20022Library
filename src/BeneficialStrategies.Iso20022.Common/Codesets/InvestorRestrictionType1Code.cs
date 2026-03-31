// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies to whom or what the restriction applies.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_harytGliEeGaMcKyqKNRfQ_-1983357855")]
[Description(@"Specifies to whom or what the restriction applies.")]
[DerivedFrom(typeof(InvestorRestrictionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestorRestrictionType1Code>))]
#endif
public enum InvestorRestrictionType1Code
{
    /// <summary>
    /// Restriction applies to a legal resident.
    /// Encoded/decoded by serializers as &quot;LERE&quot;.
    /// </summary>
    [EnumMember(Value = "LERE")]
    [IsoId("_harytWliEeGaMcKyqKNRfQ_1492655760")]
    [Description(@"Restriction applies to a legal resident.")]
    LegalResident = InvestorRestrictionTypeCode.LegalResident, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Restriction applies to a citizen.
    /// Encoded/decoded by serializers as &quot;CITI&quot;.
    /// </summary>
    [EnumMember(Value = "CITI")]
    [IsoId("_harytmliEeGaMcKyqKNRfQ_-1044474030")]
    [Description(@"Restriction applies to a citizen.")]
    Citizen = InvestorRestrictionTypeCode.Citizen, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Restriction applies to an individual.
    /// Encoded/decoded by serializers as &quot;INDV&quot;.
    /// </summary>
    [EnumMember(Value = "INDV")]
    [IsoId("_haryt2liEeGaMcKyqKNRfQ_1166734162")]
    [Description(@"Restriction applies to an individual.")]
    Individual = InvestorRestrictionTypeCode.Individual, // same ordinal as derivation source for type conversions
}
