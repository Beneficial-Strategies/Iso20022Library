// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a single payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yr2T19p-Ed-ak6NoX_4Aeg_916455448")]
[Description(@"Specifies the status of a single payment transaction.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum TransactionIndividualStatus2Code
{
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_Yr2T2Np-Ed-ak6NoX_4Aeg_916455781")]
    [Description(
        @"Payment initiation or individual transaction included in the payment initiation has been rejected."
    )]
    Rejected = PaymentStatusCode.Rejected, // same ordinal as derivation source for type conversions
}
