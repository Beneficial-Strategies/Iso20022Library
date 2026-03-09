// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of payment card.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zd5TUg93EeGeV5vP7Mvdig_-963241833")]
[Description(@"Specifies the type of payment card.")]
[DerivedFrom(typeof(CardTypeCode))]
public enum CardType1Code
{
    /// <summary>
    /// Card where the holder has been granted a line of credit. The card enables the holder to make purchases and withdraw cash up to a pre-arranged ceiling.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_zd5TUw93EeGeV5vP7Mvdig_-1511071309")]
    [Description(@"Card where the holder has been granted a line of credit. The card enables the holder to make purchases and withdraw cash up to a pre-arranged ceiling.")]
    CreditCard = CardTypeCode.CreditCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card enabling the holder to have its purchases directly charged to its account. The card may also combine other functions, for example, cash card or cheque guaranteed card.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_zd5TVA93EeGeV5vP7Mvdig_-502422457")]
    [Description(@"Card enabling the holder to have its purchases directly charged to its account. The card may also combine other functions, for example, cash card or cheque guaranteed card.")]
    DebitCard = CardTypeCode.DebitCard, // same ordinal as derivation source for type conversions
    
}
