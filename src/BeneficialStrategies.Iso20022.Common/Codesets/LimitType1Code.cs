// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of risk management limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vof3ldp-Ed-ak6NoX_4Aeg_-702729300")]
[Description(@"Specifies the type of risk management limit.")]
[DerivedFrom(typeof(LimitTypeCode))]
public enum LimitType1Code
{
    /// <summary>
    /// Limit is a maximum amount value applied to, or by, a participant to a set of counterparties. The multilateral limit is taken into account by the transaction administrator to contain the risk in the system. With the help of the multilateral limit, the direct participant restricts the use of liquidity when clearing payments with all other direct participants for which no bilateral limit is set.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_Vof3ltp-Ed-ak6NoX_4Aeg_-230810934")]
    [Description(@"Limit is a maximum amount value applied to, or by, a participant to a set of counterparties. The multilateral limit is taken into account by the transaction administrator to contain the risk in the system. With the help of the multilateral limit, the direct participant restricts the use of liquidity when clearing payments with all other direct participants for which no bilateral limit is set.")]
    Multilateral = LimitTypeCode.Multilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit is applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.
    /// Encoded/decoded by serializers as &quot;BILI&quot;.
    /// </summary>
    [EnumMember(Value = "BILI")]
    [IsoId("_Vof3l9p-Ed-ak6NoX_4Aeg_-230810874")]
    [Description(@"Limit is applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.")]
    Bilateral = LimitTypeCode.Bilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit is applied by one party to a specific counterparty, and corresponds to the maximum net balance acceptable by the party that is setting the limit. The limit is calculated as an arithmetic sum in value of the bilateral flows exchanged between the two parties. The net bilateral limit can be expressed as a debit or a credit balance.
    /// Encoded/decoded by serializers as &quot;NELI&quot;.
    /// </summary>
    [EnumMember(Value = "NELI")]
    [IsoId("_Vof3mNp-Ed-ak6NoX_4Aeg_-230810779")]
    [Description(@"Limit is applied by one party to a specific counterparty, and corresponds to the maximum net balance acceptable by the party that is setting the limit. The limit is calculated as an arithmetic sum in value of the bilateral flows exchanged between the two parties. The net bilateral limit can be expressed as a debit or a credit balance.")]
    NetBilateral = LimitTypeCode.NetBilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit is a maximum value set by a direct participant with respect to its indirect participant. The limit represents the maximum amount the indirect participant can use to settle its operations.
    /// Encoded/decoded by serializers as &quot;INBI&quot;.
    /// </summary>
    [EnumMember(Value = "INBI")]
    [IsoId("_Vof3mdp-Ed-ak6NoX_4Aeg_-230810425")]
    [Description(@"Limit is a maximum value set by a direct participant with respect to its indirect participant. The limit represents the maximum amount the indirect participant can use to settle its operations.")]
    IndirectBilateral = LimitTypeCode.IndirectBilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum value set by either the transaction administrator or by a member for the participation of a member in the system. The global limit may be expressed as a credit or debit maximum value and is taken into account by the transaction administrator when processing transaction inside the system. With the help of the global limit, the direct participant may limit the use of liquidity when clearing specific type of payments.
    /// Encoded/decoded by serializers as &quot;GLBL&quot;.
    /// </summary>
    [EnumMember(Value = "GLBL")]
    [IsoId("_VopBgNp-Ed-ak6NoX_4Aeg_-230810039")]
    [Description(@"Maximum value set by either the transaction administrator or by a member for the participation of a member in the system. The global limit may be expressed as a credit or debit maximum value and is taken into account by the transaction administrator when processing transaction inside the system. With the help of the global limit, the direct participant may limit the use of liquidity when clearing specific type of payments.")]
    Global = LimitTypeCode.Global, // same ordinal as derivation source for type conversions
    
}
