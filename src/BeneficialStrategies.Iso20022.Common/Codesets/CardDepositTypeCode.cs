// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the type of deposit
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nVXTF9CHEei_pMueJh_zOA")]
[Description(@"Contains the type of deposit")]
[Derivations(typeof(CardDepositType1Code))]
public enum CardDepositTypeCode
{
    /// <summary>
    /// Cash
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_nVa9cNCHEei_pMueJh_zOA")]
    [Description(@"Cash")]
    Cash,
    
    /// <summary>
    /// Cheque
    /// Encoded/decoded by serializers as &quot;CHEC&quot;.
    /// </summary>
    [EnumMember(Value = "CHEC")]
    [IsoId("_nVaWYNCHEei_pMueJh_zOA")]
    [Description(@"Cheque")]
    Cheque,
    
    /// <summary>
    /// Envelope
    /// Encoded/decoded by serializers as &quot;ENVL&quot;.
    /// </summary>
    [EnumMember(Value = "ENVL")]
    [IsoId("_nVa9cdCHEei_pMueJh_zOA")]
    [Description(@"Envelope")]
    Envelope,
    
    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_nVaWYdCHEei_pMueJh_zOA")]
    [Description(@"Other National")]
    OtherNational,
    
    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_nVaWYtCHEei_pMueJh_zOA")]
    [Description(@"Other Private")]
    OtherPrivate,
    
    /// <summary>
    /// Card
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_6GwjkBsxEeqrvK3udMUsNQ")]
    [Description(@"Card")]
    Card,
    
}
