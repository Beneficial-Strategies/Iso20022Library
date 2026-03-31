// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if excess cash collateral in the currency is automatically returned as per the collateral provider’s Excess Cash Margin Instruction (colr.017).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_F-c7MALdEeutW5-TpeYJhA")]
[Description(
    @"Indicates if excess cash collateral in the currency is automatically returned as per the collateral provider’s Excess Cash Margin Instruction (colr.017).|"
)]
[Derivations(typeof(ReturnExcessCash1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReturnExcessCashCode>))]
#endif
public enum ReturnExcessCashCode
{
    /// <summary>
    /// Excess cash in the currency is returned.
    /// Encoded/decoded by serializers as &quot;RTND&quot;.
    /// </summary>
    [EnumMember(Value = "RTND")]
    [IsoId("_3vlnwALnEeutW5-TpeYJhA")]
    [Description(@"Excess cash in the currency is returned.")]
    AutomaticallyReturned,

    /// <summary>
    /// Automatic return of excess cash has not been requested for the currency.
    /// Encoded/decoded by serializers as &quot;RTDN&quot;.
    /// </summary>
    [EnumMember(Value = "RTDN")]
    [IsoId("_LhNYIALoEeutW5-TpeYJhA")]
    [Description(@"Automatic return of excess cash has not been requested for the currency. ")]
    NoAutomaticReturn,

    /// <summary>
    /// Automatic return of cash is temporarily suspended (for example due to a currency holiday).
    /// Encoded/decoded by serializers as &quot;SSPD&quot;.
    /// </summary>
    [EnumMember(Value = "SSPD")]
    [IsoId("_b-cmoQLoEeutW5-TpeYJhA")]
    [Description(
        @"Automatic return of cash is temporarily suspended (for example due to a currency holiday)."
    )]
    Suspended,
}
