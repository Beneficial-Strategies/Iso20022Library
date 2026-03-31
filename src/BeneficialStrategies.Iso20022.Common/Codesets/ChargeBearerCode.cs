// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a8F4Itp-Ed-ak6NoX_4Aeg_-746027402")]
[Description(
    @"Specifies which party(ies) will pay charges due for processing of the payment transaction."
)]
[Derivations(typeof(ChargeBearer1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ChargeBearerCode>))]
#endif
public enum ChargeBearerCode
{
    /// <summary>
    /// All transaction charges are to be borne by the debtor.
    /// Encoded/decoded by serializers as &quot;OUR&quot;.
    /// </summary>
    [EnumMember(Value = "OUR")]
    [IsoId("_a8F4I9p-Ed-ak6NoX_4Aeg_268292445")]
    [Description(@"All transaction charges are to be borne by the debtor.")]
    BorneByDebtor,

    /// <summary>
    /// All transaction charges are to be borne by the creditor.
    /// Encoded/decoded by serializers as &quot;BEN&quot;.
    /// </summary>
    [EnumMember(Value = "BEN")]
    [IsoId("_a8F4JNp-Ed-ak6NoX_4Aeg_272908720")]
    [Description(@"All transaction charges are to be borne by the creditor.")]
    BorneByCreditor,

    /// <summary>
    /// Under the credit transfer scenario, transaction charges on the sender&apos;s side are to be borne by the debtor; transaction charges on the receiver&apos;s side are to be borne by the creditor.
    /// Encoded/decoded by serializers as &quot;SHA&quot;.
    /// </summary>
    [EnumMember(Value = "SHA")]
    [IsoId("_a8F4Jdp-Ed-ak6NoX_4Aeg_283991933")]
    [Description(
        @"Under the credit transfer scenario, transaction charges on the sender's side are to be borne by the debtor; transaction charges on the receiver's side are to be borne by the creditor."
    )]
    Shared,

    /// <summary>
    /// All charges are to be borne by the investor.
    /// Encoded/decoded by serializers as &quot;INVR&quot;.
    /// </summary>
    [EnumMember(Value = "INVR")]
    [IsoId("_a8F4Jtp-Ed-ak6NoX_4Aeg_180265057")]
    [Description(@"All charges are to be borne by the investor.")]
    Investor,

    /// <summary>
    /// All charges are to be borne by the intermediary.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_a8F4J9p-Ed-ak6NoX_4Aeg_180265058")]
    [Description(@"All charges are to be borne by the intermediary.")]
    Intermediary,
}
