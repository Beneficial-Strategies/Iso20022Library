// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the cash debit for the subscription charge is made immediately or accumulated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_10dH4jL3EeKU9IrkkToqcw_-75321880")]
[Description(@"Indicates whether the cash debit for the subscription charge is made immediately or accumulated.")]
[Derivations(typeof(SubscriptionChargeApplicationType1Code))]
public enum SubscriptionChargeApplicationTypeCode
{
    /// <summary>
    /// Charges are accumulated and charged later.
    /// Encoded/decoded by serializers as &quot;ACCU&quot;.
    /// </summary>
    [EnumMember(Value = "ACCU")]
    [IsoId("_10dH4zL3EeKU9IrkkToqcw_147562620")]
    [Description(@"Charges are accumulated and charged later.")]
    Accumulated,
    
    /// <summary>
    /// Charges are charged when instructed.
    /// Encoded/decoded by serializers as &quot;IMDT&quot;.
    /// </summary>
    [EnumMember(Value = "IMDT")]
    [IsoId("_10dH5DL3EeKU9IrkkToqcw_-484988111")]
    [Description(@"Charges are charged when instructed.")]
    Immediate,
    
}
