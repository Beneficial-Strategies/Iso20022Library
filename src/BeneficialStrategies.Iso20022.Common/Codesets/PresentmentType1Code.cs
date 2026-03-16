// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which elements types must be presented in an e-invoice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pTnR0EWeEempSe_3C1a9EQ")]
[Description(@"Specifies which elements types must be presented in an e-invoice.")]
[DerivedFrom(typeof(PresentmentTypeCode))]
public enum PresentmentType1Code
{
    /// <summary>
    /// Full information of the presented e-invoice should be presented to the debtor.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_rJ0lgUWeEempSe_3C1a9EQ")]
    [Description(@"Full information of the presented e-invoice should be presented to the debtor.")]
    Full = PresentmentTypeCode.Full, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Only information necessary to initiate the payment should be presented to the debtor.
    /// Encoded/decoded by serializers as &quot;PAYD&quot;.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_rPjaEUWeEempSe_3C1a9EQ")]
    [Description(
        @"Only information necessary to initiate the payment should be presented to the debtor."
    )]
    RequiredPaymentData = PresentmentTypeCode.RequiredPaymentData, // same ordinal as derivation source for type conversions
}
