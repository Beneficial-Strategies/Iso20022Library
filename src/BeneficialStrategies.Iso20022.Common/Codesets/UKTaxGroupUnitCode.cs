// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the UK tax group to which units belong. For UK tax, the first dividend that an investor receives from a funds investment is deemed to be part income and part return of capital. The capital element is &apos;equalisation&apos;, and is exempt from income tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YzcwpNp-Ed-ak6NoX_4Aeg_2015540550")]
[Description(
    @"Specifies the UK tax group to which units belong. For UK tax, the first dividend that an investor receives from a funds investment is deemed to be part income and part return of capital. The capital element is 'equalisation', and is exempt from income tax."
)]
[Derivations(typeof(UKTaxGroupUnit1Code))]
public enum UKTaxGroupUnitCode
{
    /// <summary>
    /// The units that were purchased prior to the last ex-div date.
    /// Encoded/decoded by serializers as &quot;GRP1&quot;.
    /// </summary>
    [EnumMember(Value = "GRP1")]
    [IsoId("_Yzcwpdp-Ed-ak6NoX_4Aeg_2015540551")]
    [Description(@"The units that were purchased prior to the last ex-div date.")]
    Group1,

    /// <summary>
    /// The units that were purchased since the ex-div date, and that benefit from the tax exemption.
    /// Encoded/decoded by serializers as &quot;GRP2&quot;.
    /// </summary>
    [EnumMember(Value = "GRP2")]
    [IsoId("_Yzcwptp-Ed-ak6NoX_4Aeg_2015540552")]
    [Description(
        @"The units that were purchased since the ex-div date, and that benefit from the tax exemption."
    )]
    Group2,
}
