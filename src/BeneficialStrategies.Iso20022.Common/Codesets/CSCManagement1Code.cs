// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// CSC (Card Security Code) management associated with the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TS9qYQEcEeCQm6a_G2yO_w_-804127704")]
[Description(@"CSC (Card Security Code) management associated with the transaction.")]
[DerivedFrom(typeof(CSCManagementCode))]
public enum CSCManagement1Code
{
    /// <summary>
    /// Card security code present.
    /// Encoded/decoded by serializers as &quot;PRST&quot;.
    /// </summary>
    [EnumMember(Value = "PRST")]
    [IsoId("_TS9qYgEcEeCQm6a_G2yO_w_-1905065506")]
    [Description(@"Card security code present.")]
    CSCPresent = CSCManagementCode.CSCPresent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card security code by-passed or not provided by the merchant.
    /// Encoded/decoded by serializers as &quot;BYPS&quot;.
    /// </summary>
    [EnumMember(Value = "BYPS")]
    [IsoId("_TS9qYwEcEeCQm6a_G2yO_w_-1032051106")]
    [Description(@"Card security code by-passed or not provided by the merchant.")]
    CSCByPass = CSCManagementCode.CSCByPass, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card security code unreadable.
    /// Encoded/decoded by serializers as &quot;UNRD&quot;.
    /// </summary>
    [EnumMember(Value = "UNRD")]
    [IsoId("_TS9qZAEcEeCQm6a_G2yO_w_905174067")]
    [Description(@"Card security code unreadable.")]
    CSCUnread = CSCManagementCode.CSCUnread, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No card security code imprint.
    /// Encoded/decoded by serializers as &quot;NCSC&quot;.
    /// </summary>
    [EnumMember(Value = "NCSC")]
    [IsoId("_TS9qZQEcEeCQm6a_G2yO_w_1419047201")]
    [Description(@"No card security code imprint.")]
    NoCSC = CSCManagementCode.NoCSC, // same ordinal as derivation source for type conversions
    
}
