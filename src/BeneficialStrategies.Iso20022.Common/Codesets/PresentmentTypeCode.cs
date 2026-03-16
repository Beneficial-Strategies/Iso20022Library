// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which elements types must be presented in an e-invoice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YFIMkEWeEempSe_3C1a9EQ")]
[Description(@"Specifies which elements types must be presented in an e-invoice.")]
[Derivations(typeof(PresentmentType1Code))]
public enum PresentmentTypeCode
{
    /// <summary>
    /// Full information of the presented e-invoice should be presented to the debtor.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_bca4gEWeEempSe_3C1a9EQ")]
    [Description(@"Full information of the presented e-invoice should be presented to the debtor.")]
    Full,

    /// <summary>
    /// Only information necessary to initiate the payment should be presented to the debtor.
    /// Encoded/decoded by serializers as &quot;PAYD&quot;.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_bgijgEWeEempSe_3C1a9EQ")]
    [Description(
        @"Only information necessary to initiate the payment should be presented to the debtor."
    )]
    RequiredPaymentData,
}
