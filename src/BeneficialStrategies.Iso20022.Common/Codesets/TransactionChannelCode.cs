// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of communication channel.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVWQBgEcEeCQm6a_G2yO_w_644173117")]
[Description(@"Specifies the type of communication channel.")]
[Derivations(typeof(TransactionChannel1Code),typeof(TransactionChannel2Code),typeof(TransactionChannel3Code),typeof(TransactionChannel5Code))]
public enum TransactionChannelCode
{
    /// <summary>
    /// Mail order.
    /// Encoded/decoded by serializers as &quot;MAIL&quot;.
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_TVWQBwEcEeCQm6a_G2yO_w_977545378")]
    [Description(@"Mail order.")]
    MailOrder,
    
    /// <summary>
    /// Telephone order.
    /// Encoded/decoded by serializers as &quot;TLPH&quot;.
    /// </summary>
    [EnumMember(Value = "TLPH")]
    [IsoId("_TVWQCAEcEeCQm6a_G2yO_w_1632008527")]
    [Description(@"Telephone order.")]
    TelephoneOrder,
    
    /// <summary>
    /// Electronic commerce.
    /// Encoded/decoded by serializers as &quot;ECOM&quot;.
    /// </summary>
    [EnumMember(Value = "ECOM")]
    [IsoId("_TVWQCQEcEeCQm6a_G2yO_w_-1433707025")]
    [Description(@"Electronic commerce.")]
    ElectronicCommerce,
    
    /// <summary>
    /// Payment on television.
    /// Encoded/decoded by serializers as &quot;TVPY&quot;.
    /// </summary>
    [EnumMember(Value = "TVPY")]
    [IsoId("_TVWQCgEcEeCQm6a_G2yO_w_-2041458064")]
    [Description(@"Payment on television.")]
    TelevisionPayment,
    
    /// <summary>
    /// Office or branch.
    /// Encoded/decoded by serializers as &quot;BRAN&quot;.
    /// </summary>
    [EnumMember(Value = "BRAN")]
    [IsoId("_TaM_UBRFEeOKWo1NF21OVw")]
    [Description(@"Office or branch.")]
    OfficeOrBranch,
    
    /// <summary>
    /// Home banking.
    /// Encoded/decoded by serializers as &quot;HOBA&quot;.
    /// </summary>
    [EnumMember(Value = "HOBA")]
    [IsoId("_TwXckBRFEeOKWo1NF21OVw")]
    [Description(@"Home banking.")]
    HomeBanking,
    
    /// <summary>
    /// Financial advisor.
    /// Encoded/decoded by serializers as &quot;FIAD&quot;.
    /// </summary>
    [EnumMember(Value = "FIAD")]
    [IsoId("_UBVQwBRFEeOKWo1NF21OVw")]
    [Description(@"Financial advisor.")]
    FinancialAdvisor,
    
    /// <summary>
    /// Payment performed through a cardholder mobile device.
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_0EyQwGkBEeS7zPBpvm732w")]
    [Description(@"Payment performed through a cardholder mobile device.")]
    MobilePayment,
    
    /// <summary>
    /// Electronic commerce with cardholder authentication.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_3fSowGkBEeS7zPBpvm732w")]
    [Description(@"Electronic commerce with cardholder authentication.")]
    SecuredElectronicCommerce,
    
    /// <summary>
    /// Payment performed through a merchant mobile device.
    /// Encoded/decoded by serializers as &quot;MPOS&quot;.
    /// </summary>
    [EnumMember(Value = "MPOS")]
    [IsoId("_BAAuQLDHEeaW-9Sj0pzN5A")]
    [Description(@"Payment performed through a merchant mobile device.")]
    MobilePOS,
    
}
