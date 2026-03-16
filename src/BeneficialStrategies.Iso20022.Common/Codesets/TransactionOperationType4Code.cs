// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction operation action type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_klf60Q1GEeaj35fzaZHUIg")]
[Description(@"Specifies the transaction operation action type.")]
[DerivedFrom(typeof(TransactionOperationTypeCode))]
public enum TransactionOperationType4Code
{
    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as &quot;NEWT&quot;.
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_kzZz9w1GEeaj35fzaZHUIg")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction = TransactionOperationTypeCode.NewTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction amends a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;AMND&quot;.
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_rVWeAQ1GEeaj35fzaZHUIg")]
    [Description(@"Transaction amends a previously sent transaction.")]
    Amendment = TransactionOperationTypeCode.Amendment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction requests the deletion/cancellation of a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_sSjGEQ1GEeaj35fzaZHUIg")]
    [Description(
        @"Transaction requests the deletion/cancellation of a previously sent transaction."
    )]
    Cancellation = TransactionOperationTypeCode.Cancellation, // same ordinal as derivation source for type conversions
}
