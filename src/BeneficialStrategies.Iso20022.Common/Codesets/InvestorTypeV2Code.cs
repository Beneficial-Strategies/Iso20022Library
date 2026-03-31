// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I92ekLVMEeqkjqDuFVh1-A")]
[Description(@"Specifies the type of investor.")]
[Derivations(typeof(InvestorType4Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestorTypeV2Code>))]
#endif
public enum InvestorTypeV2Code
{
    /// <summary>
    /// Investor is both professional and retail.
    /// Encoded/decoded by serializers as &quot;BOT2&quot;.
    /// </summary>
    [EnumMember(Value = "BOT2")]
    [IsoId("_nezffbVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is both professional and retail.")]
    BothProfessionalAndRetail,

    /// <summary>
    /// Investor is both professional per se and elective professional.
    /// Encoded/decoded by serializers as &quot;BOT3&quot;.
    /// </summary>
    [EnumMember(Value = "BOT3")]
    [IsoId("_nezffrVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is both professional per se and elective professional.")]
    BothProfessionalPerSeAndElectiveProfessional,

    /// <summary>
    /// Investor is an elective professional.
    /// Encoded/decoded by serializers as &quot;EPRO&quot;.
    /// </summary>
    [EnumMember(Value = "EPRO")]
    [IsoId("_nezff7VMEeqkjqDuFVh1-A")]
    [Description(@"Investor is an elective professional.")]
    ElectiveProfessional,

    /// <summary>
    /// Investor is eligible to receive income gross, for example, a pension scheme.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_nezfgLVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is eligible to receive income gross, for example, a pension scheme.")]
    GrossDistribution,

    /// <summary>
    /// Investor is an institutional investor.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_nezfgbVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is an institutional investor.")]
    Institutional,

    /// <summary>
    /// Investor is neither professional or retail.
    /// Encoded/decoded by serializers as &quot;NEI1&quot;.
    /// </summary>
    [EnumMember(Value = "NEI1")]
    [IsoId("_nezfgrVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is neither professional or retail.")]
    NeitherProfessionalOrRetail,

    /// <summary>
    /// Investor is a physical person.
    /// Encoded/decoded by serializers as &quot;PPER&quot;.
    /// </summary>
    [EnumMember(Value = "PPER")]
    [IsoId("_nezfg7VMEeqkjqDuFVh1-A")]
    [Description(@"Investor is a physical person.")]
    PhysicalPerson,

    /// <summary>
    /// Investor is a professional or institutional investor.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_nezfhLVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is a professional or institutional investor.")]
    Professional,

    /// <summary>
    /// Investor is professional or professional per se.
    /// Encoded/decoded by serializers as &quot;PRF2&quot;.
    /// </summary>
    [EnumMember(Value = "PRF2")]
    [IsoId("_nezfhbVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is professional or professional per se.")]
    ProfessionalOrPerSe,

    /// <summary>
    /// Investor meets the fund entry policy restriction.
    /// Encoded/decoded by serializers as &quot;QUAL&quot;.
    /// </summary>
    [EnumMember(Value = "QUAL")]
    [IsoId("_nezfhrVMEeqkjqDuFVh1-A")]
    [Description(@"Investor meets the fund entry policy restriction.")]
    Qualified,

    /// <summary>
    /// Investor is a retail investor.
    /// Encoded/decoded by serializers as &quot;RETL&quot;.
    /// </summary>
    [EnumMember(Value = "RETL")]
    [IsoId("_nezfh7VMEeqkjqDuFVh1-A")]
    [Description(@"Investor is a retail investor.")]
    Retail,

    /// <summary>
    /// Investor is both an institutional and an individual investor.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_nezfiLVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is both an institutional and an individual investor.")]
    RetailAndInstitutional,

    /// <summary>
    /// Investor is an employee.
    /// Encoded/decoded by serializers as &quot;STAF&quot;.
    /// </summary>
    [EnumMember(Value = "STAF")]
    [IsoId("_nezfibVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is an employee.")]
    Staff,

    /// <summary>
    /// Investor is neither professional per se or elective professional.
    /// Encoded/decoded by serializers as &quot;NPRF&quot;.
    /// </summary>
    [EnumMember(Value = "NPRF")]
    [IsoId("_qi4UcLVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is neither professional per se or elective professional.")]
    NotProfessionalPerSeElectiveProfessional,

    /// <summary>
    /// Investor is professional per se but not elective professional.
    /// Encoded/decoded by serializers as &quot;PRF3&quot;.
    /// </summary>
    [EnumMember(Value = "PRF3")]
    [IsoId("_uCo_4LVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is professional per se but not elective professional.")]
    ProfessionalPerSeNotElectiveProfessional,

    /// <summary>
    /// Investor is an elective professional but not professional per se.
    /// Encoded/decoded by serializers as &quot;PRF4&quot;.
    /// </summary>
    [EnumMember(Value = "PRF4")]
    [IsoId("_3bjQALVMEeqkjqDuFVh1-A")]
    [Description(@"Investor is an elective professional but not professional per se.")]
    ElectiveProfessionalNotProfessionalPerSe,
}
