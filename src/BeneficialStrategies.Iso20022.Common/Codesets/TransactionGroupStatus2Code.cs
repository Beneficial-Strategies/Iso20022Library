// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a group of payment transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrjY5dp-Ed-ak6NoX_4Aeg_14174870")]
[Description(@"Specifies the status of a group of payment transactions.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum TransactionGroupStatus2Code
{
    /// <summary>
    /// A number of transactions have been accepted, whereas another number of transactions have not yet achieved &apos;accepted&apos; status.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_YrjY5tp-Ed-ak6NoX_4Aeg_14174990")]
    [Description(@"A number of transactions have been accepted, whereas another number of transactions have not yet achieved 'accepted' status.")]
    PartiallyAccepted = PaymentStatusCode.PartiallyAccepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_YrjY59p-Ed-ak6NoX_4Aeg_14175042")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation has been rejected.")]
    Rejected = PaymentStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
}
