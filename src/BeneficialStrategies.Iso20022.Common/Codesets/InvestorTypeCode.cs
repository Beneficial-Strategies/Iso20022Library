// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_adQABtp-Ed-ak6NoX_4Aeg_-2008632624")]
[Description(@"Specifies the type of investor.")]
[Derivations(typeof(InvestorType1Code), typeof(InvestorType2Code), typeof(InvestorType3Code))]
public enum InvestorTypeCode
{
    /// <summary>
    /// Investor is a retail investor.
    /// Encoded/decoded by serializers as &quot;RETL&quot;.
    /// </summary>
    [EnumMember(Value = "RETL")]
    [IsoId("_adQAB9p-Ed-ak6NoX_4Aeg_-382312596")]
    [Description(@"Investor is a retail investor.")]
    Retail,

    /// <summary>
    /// Investor is a professional or institutional investor.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_adQACNp-Ed-ak6NoX_4Aeg_-381389414")]
    [Description(@"Investor is a professional or institutional investor.")]
    Professional,

    /// <summary>
    /// Investor is an employee.
    /// Encoded/decoded by serializers as &quot;STAF&quot;.
    /// </summary>
    [EnumMember(Value = "STAF")]
    [IsoId("_adZJ8Np-Ed-ak6NoX_4Aeg_-380465554")]
    [Description(@"Investor is an employee.")]
    Staff,

    /// <summary>
    /// Investor is a physical person.
    /// Encoded/decoded by serializers as &quot;PPER&quot;.
    /// </summary>
    [EnumMember(Value = "PPER")]
    [IsoId("_adZJ8dp-Ed-ak6NoX_4Aeg_-379542526")]
    [Description(@"Investor is a physical person.")]
    PhysicalPerson,

    /// <summary>
    /// Investor is an institutional investor.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_as4-gdp-Ed-ak6NoX_4Aeg_761186524")]
    [Description(@"Investor is an institutional investor.")]
    Institutional,

    /// <summary>
    /// Investor is both an institutional and an individual investor.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_as4-g9p-Ed-ak6NoX_4Aeg_1143521122")]
    [Description(@"Investor is both an institutional and an individual investor.")]
    RetailAndInstitutional,

    /// <summary>
    /// Investor is eligible to receive income gross, eg, a pension scheme.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_as4-hNp-Ed-ak6NoX_4Aeg_1589583717")]
    [Description(@"Investor is eligible to receive income gross, eg, a pension scheme.")]
    GrossDistribution,

    /// <summary>
    /// Investor meets the fund entry policy restriction.
    /// Encoded/decoded by serializers as &quot;QUAL&quot;.
    /// </summary>
    [EnumMember(Value = "QUAL")]
    [IsoId("_as4-hdp-Ed-ak6NoX_4Aeg_2077202988")]
    [Description(@"Investor meets the fund entry policy restriction.")]
    Qualified,

    /// <summary>
    /// Investor is both professional and retail.
    /// Encoded/decoded by serializers as &quot;BOT2&quot;.
    /// </summary>
    [EnumMember(Value = "BOT2")]
    [IsoId("_ej33cNdaEeibyvRfU9vJ7w")]
    [Description(@"Investor is both professional and retail.")]
    BothProfessionalAndRetail,

    /// <summary>
    /// Investor is both professional per se and elective professional.
    /// Encoded/decoded by serializers as &quot;BOT3&quot;.
    /// </summary>
    [EnumMember(Value = "BOT3")]
    [IsoId("_-tuIwNdaEeibyvRfU9vJ7w")]
    [Description(@"Investor is both professional per se and elective professional.")]
    BothProfessionalPerSeAndElectiveProfessional,

    /// <summary>
    /// Investor is an elective professional.
    /// Encoded/decoded by serializers as &quot;EPRO&quot;.
    /// </summary>
    [EnumMember(Value = "EPRO")]
    [IsoId("_DTjEYNdbEeibyvRfU9vJ7w")]
    [Description(@"Investor is an elective professional.")]
    ElectiveProfessional,

    /// <summary>
    /// Investor is neither professional or retail.
    /// Encoded/decoded by serializers as &quot;NEI1&quot;.
    /// </summary>
    [EnumMember(Value = "NEI1")]
    [IsoId("_GOaTANdbEeibyvRfU9vJ7w")]
    [Description(@"Investor is neither professional or retail.")]
    NeitherProfessionalOrRetail,

    /// <summary>
    /// Investor is professional or professional per se.
    /// Encoded/decoded by serializers as &quot;PRF2&quot;.
    /// </summary>
    [EnumMember(Value = "PRF2")]
    [IsoId("_H_B8ENdbEeibyvRfU9vJ7w")]
    [Description(@"Investor is professional or professional per se.")]
    ProfessionalOrPerSe,
}
