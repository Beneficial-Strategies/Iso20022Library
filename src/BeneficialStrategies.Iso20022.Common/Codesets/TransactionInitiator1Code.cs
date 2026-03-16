// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the transaction initiator.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ER1VgGzgEemD24gVaMSpeA")]
[Description(@"Identifies the transaction initiator.")]
[DerivedFrom(typeof(TransactionInitiatorCode))]
public enum TransactionInitiator1Code
{
    /// <summary>
    /// Merchant initiated transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_KWdxcWzgEemD24gVaMSpeA")]
    [Description(@"Merchant initiated transaction.")]
    Merchant = TransactionInitiatorCode.Merchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer initiated transaction.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_KicX8WzgEemD24gVaMSpeA")]
    [Description(@"Customer initiated transaction.")]
    Customer = TransactionInitiatorCode.Customer, // same ordinal as derivation source for type conversions
}
