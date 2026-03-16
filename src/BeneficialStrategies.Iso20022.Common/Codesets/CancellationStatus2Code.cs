// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bYs7p9p-Ed-ak6NoX_4Aeg_-1025146236")]
[Description(@"Specifies the cancellation status.")]
[DerivedFrom(typeof(CancellationStatusCode))]
public enum CancellationStatus2Code
{
    /// <summary>
    /// Cancellation instruction/request has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_bYs7qNp-Ed-ak6NoX_4Aeg_-1024226245")]
    [Description(
        @"Cancellation instruction/request has been sent to the next party, that is, the next intermediary."
    )]
    SentToNextParty = CancellationStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bY2soNp-Ed-ak6NoX_4Aeg_-1024226221")]
    [Description(
        @"Cancellation instruction / request has been received and has been acknowledged / accepted for further processing."
    )]
    Accepted = CancellationStatusCode.Accepted, // same ordinal as derivation source for type conversions
}
