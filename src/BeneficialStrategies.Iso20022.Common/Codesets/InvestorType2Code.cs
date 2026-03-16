// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PP8k8NdbEeibyvRfU9vJ7w")]
[Description(@"Specifies the type of investor.")]
[DerivedFrom(typeof(InvestorTypeCode))]
public enum InvestorType2Code
{
    /// <summary>
    /// Investor is both professional per se and elective professional.
    /// Encoded/decoded by serializers as &quot;BOT3&quot;.
    /// </summary>
    [EnumMember(Value = "BOT3")]
    [IsoId("_Rk308ddbEeibyvRfU9vJ7w")]
    [Description(@"Investor is both professional per se and elective professional.")]
    BothProfessionalPerSeAndElectiveProfessional =
        InvestorTypeCode.BothProfessionalPerSeAndElectiveProfessional, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor is an elective professional.
    /// Encoded/decoded by serializers as &quot;EPRO&quot;.
    /// </summary>
    [EnumMember(Value = "EPRO")]
    [IsoId("_SH1YEddbEeibyvRfU9vJ7w")]
    [Description(@"Investor is an elective professional.")]
    ElectiveProfessional = InvestorTypeCode.ElectiveProfessional, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor is professional or professional per se.
    /// Encoded/decoded by serializers as &quot;PRF2&quot;.
    /// </summary>
    [EnumMember(Value = "PRF2")]
    [IsoId("_TMkLgddbEeibyvRfU9vJ7w")]
    [Description(@"Investor is professional or professional per se.")]
    ProfessionalOrPerSe = InvestorTypeCode.ProfessionalOrPerSe, // same ordinal as derivation source for type conversions
}
