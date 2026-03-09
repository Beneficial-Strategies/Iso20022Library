// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the payment scenario used for a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rJyl4DKlEeipv8GJ5uBgPw")]
[Description(@"Describes the payment scenario used for a payment transaction.")]
[Derivations(typeof(PaymentScenario2Code),typeof(PaymentScenario1Code),typeof(PaymentScenario3Code))]
public enum PaymentScenarioCode
{
    /// <summary>
    /// Indicates cover payment(s).
    /// Encoded/decoded by serializers as &quot;COVE&quot;.
    /// </summary>
    [EnumMember(Value = "COVE")]
    [IsoId("_5KoqcDKlEeipv8GJ5uBgPw")]
    [Description(@"Indicates cover payment(s).")]
    Cover,
    
    /// <summary>
    /// Indicates customer credit transfer(s).
    /// Encoded/decoded by serializers as &quot;CCTR&quot;.
    /// </summary>
    [EnumMember(Value = "CCTR")]
    [IsoId("_rs1SUHYhEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s).")]
    CustomerCreditTransfer,
    
    /// <summary>
    /// Indicates customer credit transfer(s) and cover(s).
    /// Encoded/decoded by serializers as &quot;CTCO&quot;.
    /// </summary>
    [EnumMember(Value = "CTCO")]
    [IsoId("_xw0OAHYhEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s) and cover(s).")]
    CustomerCreditTransferAndCover,
    
    /// <summary>
    /// Indicates customer credit transfer(s) without cover.
    /// Encoded/decoded by serializers as &quot;CCTW&quot;.
    /// </summary>
    [EnumMember(Value = "CCTW")]
    [IsoId("_u4b2MHYiEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s) without cover.")]
    CustomerCreditTransferWithoutCover,
    
    /// <summary>
    /// Indicates customer credit transfer(s) with cover.
    /// Encoded/decoded by serializers as &quot;CCTC&quot;.
    /// </summary>
    [EnumMember(Value = "CCTC")]
    [IsoId("_7WlY8HYiEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s) with cover.")]
    CustomerCreditTransferWithCover,
    
}
