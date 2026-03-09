// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the bank in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Mn3W4NNtEeKdOs2hjJ_3WQ")]
[Description(@"Specifies the role of the bank in the transaction.")]
[DerivedFrom(typeof(BankRoleCode))]
public enum BankRole1Code
{
    /// <summary>
    /// Bank of the buyer.
    /// Encoded/decoded by serializers as &quot;BUYB&quot;.
    /// </summary>
    [EnumMember(Value = "BUYB")]
    [IsoId("_ReWlMdmCEeKjKfTom1JlPQ")]
    [Description(@"Bank of the buyer.")]
    BuyersBank = BankRoleCode.BuyersBank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Obligor bank.
    /// Encoded/decoded by serializers as &quot;OBLB&quot;.
    /// </summary>
    [EnumMember(Value = "OBLB")]
    [IsoId("_RnCnIdmCEeKjKfTom1JlPQ")]
    [Description(@"Obligor bank.")]
    ObligorBank = BankRoleCode.ObligorBank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recipient bank.
    /// Encoded/decoded by serializers as &quot;RECB&quot;.
    /// </summary>
    [EnumMember(Value = "RECB")]
    [IsoId("_RvpwkdmCEeKjKfTom1JlPQ")]
    [Description(@"Recipient bank.")]
    RecipientBank = BankRoleCode.RecipientBank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank of the seller.
    /// Encoded/decoded by serializers as &quot;SELB&quot;.
    /// </summary>
    [EnumMember(Value = "SELB")]
    [IsoId("_R4wCMdmCEeKjKfTom1JlPQ")]
    [Description(@"Bank of the seller.")]
    SellersBank = BankRoleCode.SellersBank, // same ordinal as derivation source for type conversions
    
}
