// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the cancellation request of an invoice financing request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a0VqUNp-Ed-ak6NoX_4Aeg_434017571")]
[Description(@"Specifies the status of the cancellation request of an invoice financing request.")]
[DerivedFrom(typeof(CancellationStatusCode))]
public enum CancellationStatus4Code
{
    /// <summary>
    /// Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_a0VqUdp-Ed-ak6NoX_4Aeg_-927683854")]
    [Description(@"Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.")]
    Accepted = CancellationStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation instruction / request has been rejected / denied for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_a0VqUtp-Ed-ak6NoX_4Aeg_-831637751")]
    [Description(@"Cancellation instruction / request has been rejected / denied for further processing.")]
    Rejected = CancellationStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
}
