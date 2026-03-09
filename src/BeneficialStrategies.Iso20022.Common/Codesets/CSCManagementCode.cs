// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// CSC (Card Security Code) management associated with the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWii4QEcEeCQm6a_G2yO_w_1480882734")]
[Description(@"CSC (Card Security Code) management associated with the transaction.")]
[Derivations(typeof(CSCManagement1Code))]
public enum CSCManagementCode
{
    /// <summary>
    /// Card security code present.
    /// Encoded/decoded by serializers as &quot;PRST&quot;.
    /// </summary>
    [EnumMember(Value = "PRST")]
    [IsoId("_TWii4gEcEeCQm6a_G2yO_w_-86583445")]
    [Description(@"Card security code present.")]
    CSCPresent,
    
    /// <summary>
    /// Card security code by-passed or not provided by the merchant.
    /// Encoded/decoded by serializers as &quot;BYPS&quot;.
    /// </summary>
    [EnumMember(Value = "BYPS")]
    [IsoId("_TWrswAEcEeCQm6a_G2yO_w_-1184407427")]
    [Description(@"Card security code by-passed or not provided by the merchant.")]
    CSCByPass,
    
    /// <summary>
    /// Card security code unreadable.
    /// Encoded/decoded by serializers as &quot;UNRD&quot;.
    /// </summary>
    [EnumMember(Value = "UNRD")]
    [IsoId("_TWrswQEcEeCQm6a_G2yO_w_-1151247658")]
    [Description(@"Card security code unreadable.")]
    CSCUnread,
    
    /// <summary>
    /// No card security code imprint.
    /// Encoded/decoded by serializers as &quot;NCSC&quot;.
    /// </summary>
    [EnumMember(Value = "NCSC")]
    [IsoId("_TWrswgEcEeCQm6a_G2yO_w_1063680011")]
    [Description(@"No card security code imprint.")]
    NoCSC,
    
}
