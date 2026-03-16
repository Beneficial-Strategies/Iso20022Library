// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WOybgtp-Ed-ak6NoX_4Aeg_-1191324327")]
[Description(@"Specifies the underlying reason for cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonCode))]
public enum CancelledStatusReason8Code
{
    /// <summary>
    /// Transaction is cancelled by a party other than the instructing party, eg, a market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_WOybg9p-Ed-ak6NoX_4Aeg_-1191324296")]
    [Description(
        @"Transaction is cancelled by a party other than the instructing party, eg, a market infrastructure such as a stock exchange."
    )]
    CancelledByOther = CancelledStatusReasonCode.CancelledByOther, // same ordinal as derivation source for type conversions
}
