// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of a payment instruction at a specified time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7DWVNp-Ed-ak6NoX_4Aeg_1461915328")]
[Description(@"Specifies the state of a payment instruction at a specified time.")]
[DerivedFrom(typeof(CashPaymentStatusCode))]
public enum CashPaymentStatus2Code
{
    /// <summary>
    /// The payment is awaiting settlement.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_a7DWVdp-Ed-ak6NoX_4Aeg_1461915330")]
    [Description(@"The payment is awaiting settlement.")]
    Pending = CashPaymentStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The payment has been settled or stopped.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_a7DWVtp-Ed-ak6NoX_4Aeg_1461915331")]
    [Description(@"The payment has been settled or stopped.")]
    Final = CashPaymentStatusCode.Final, // same ordinal as derivation source for type conversions
}
