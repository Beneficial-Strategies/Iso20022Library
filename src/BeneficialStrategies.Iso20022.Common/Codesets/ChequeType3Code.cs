// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of cheque.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a-7Jtdp-Ed-ak6NoX_4Aeg_1310151180")]
[Description(@"Specifies the type of cheque.")]
[DerivedFrom(typeof(ChequeTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ChequeType3Code>))]
#endif
public enum ChequeType3Code
{
    /// <summary>
    /// A guaranteed bank cheque with a future value date (do not pay before], which in commercial terms is a &apos;negotiatable instrument&apos;: the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer&apos;s account is debited on value date.
    /// Encoded/decoded by serializers as &quot;DRFT&quot;.
    /// </summary>
    [EnumMember(Value = "DRFT")]
    [IsoId("_a-7Jttp-Ed-ak6NoX_4Aeg_1310151272")]
    [Description(
        @"A guaranteed bank cheque with a future value date (do not pay before], which in commercial terms is a 'negotiatable instrument': the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer's account is debited on value date."
    )]
    Draft = ChequeTypeCode.Draft, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An instrument with a future value date (do not pay before], which in commercial terms is a &apos;negotiatable instrument&apos;: the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer&apos;s account is debited on value date.
    /// Encoded/decoded by serializers as &quot;ELDR&quot;.
    /// </summary>
    [EnumMember(Value = "ELDR")]
    [IsoId("_a-7Jt9p-Ed-ak6NoX_4Aeg_1310151519")]
    [Description(
        @"An instrument with a future value date (do not pay before], which in commercial terms is a 'negotiatable instrument': the beneficiary can receive early payment from any bank under subtraction of a discount. The ordering customer's account is debited on value date."
    )]
    ElectronicDraft = ChequeTypeCode.ElectronicDraft, // same ordinal as derivation source for type conversions
}
