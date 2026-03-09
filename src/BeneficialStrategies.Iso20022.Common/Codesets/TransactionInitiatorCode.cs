// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the transaction initiator.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jfoDtmzfEemD24gVaMSpeA")]
[Description(@"Identifies the transaction initiator.")]
[Derivations(typeof(TransactionInitiator1Code))]
public enum TransactionInitiatorCode
{
    /// <summary>
    /// Merchant initiated transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_jfoDt2zfEemD24gVaMSpeA")]
    [Description(@"Merchant initiated transaction.")]
    Merchant,
    
    /// <summary>
    /// Customer initiated transaction.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_jfoDuGzfEemD24gVaMSpeA")]
    [Description(@"Customer initiated transaction.")]
    Customer,
    
}
