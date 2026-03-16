// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the final status of a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_an04VNp-Ed-ak6NoX_4Aeg_-1727527994")]
[Description(@"Specifies the final status of a transaction.")]
[DerivedFrom(typeof(PaymentInstructionStatusCode))]
public enum FinalStatusCode
{
    /// <summary>
    /// Transaction has been successfully processed by the clearing agent.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_an04Vdp-Ed-ak6NoX_4Aeg_-1727527993")]
    [Description(@"Transaction has been successfully processed by the clearing agent.")]
    Settled = PaymentInstructionStatusCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been rejected by the clearing agent.
    /// Encoded/decoded by serializers as &quot;RJTD&quot;.
    /// </summary>
    [EnumMember(Value = "RJTD")]
    [IsoId("_an04Vtp-Ed-ak6NoX_4Aeg_-1727527992")]
    [Description(@"Transaction has been rejected by the clearing agent.")]
    Rejected = PaymentInstructionStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_an04V9p-Ed-ak6NoX_4Aeg_-1727527991")]
    [Description(@"Transaction has been cancelled.")]
    Cancelled = PaymentInstructionStatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been successfully processed by the clearing agent. Settlement will take place outside of the system.
    /// Encoded/decoded by serializers as &quot;FNLD&quot;.
    /// </summary>
    [EnumMember(Value = "FNLD")]
    [IsoId("_an04WNp-Ed-ak6NoX_4Aeg_-1727527990")]
    [Description(
        @"Transaction has been successfully processed by the clearing agent. Settlement will take place outside of the system."
    )]
    Finalised = PaymentInstructionStatusCode.Finalised, // same ordinal as derivation source for type conversions
}
