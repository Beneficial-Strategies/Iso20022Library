// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external cheque cancellation status code in the format of character string with a maximum length of 4 characters.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wRR50rtvEeq_cfXrH83Rcw")]
[Description(@"Specifies the external cheque cancellation status code in the format of character string with a maximum length of 4 characters.")]
[DerivedFrom(typeof(ExternalChequeCancellationStatusCode))]
public enum ExternalChequeCancellationStatus1Code
{
    /// <summary>
    /// Cheque cancellation request or request to stop the cheque is accepted.
    /// Encoded/decoded by serializers as &quot;ACCR&quot;.
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("")]
    [Description(@"Cheque cancellation request or request to stop the cheque is accepted.")]
    AcceptedCancellationOrStopChequeRequest = ExternalChequeCancellationStatusCode.AcceptedCancellationOrStopChequeRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque cancellation request or request to stop the cheque is rejected.
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("")]
    [Description(@"Cheque cancellation request or request to stop the cheque is rejected.")]
    RejectedCancellationOrStopChequeRequest = ExternalChequeCancellationStatusCode.RejectedCancellationOrStopChequeRequest, // same ordinal as derivation source for type conversions

}
