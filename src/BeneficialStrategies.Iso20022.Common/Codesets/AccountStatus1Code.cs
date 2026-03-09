// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies further the current state of an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bretstp-Ed-ak6NoX_4Aeg_-2008339319")]
[Description(@"Qualifies further the current state of an account.")]
[DerivedFrom(typeof(AccountStatusCode))]
public enum AccountStatus1Code
{
    /// <summary>
    /// Account can be used for its intended purpose.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_brets9p-Ed-ak6NoX_4Aeg_-910847163")]
    [Description(@"Account can be used for its intended purpose.")]
    Enabled = AccountStatusCode.Enabled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account cannot be used for its intended purpose, either temporarily or permanently.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_brettNp-Ed-ak6NoX_4Aeg_-898842246")]
    [Description(@"Account cannot be used for its intended purpose, either temporarily or permanently.")]
    Disabled = AccountStatusCode.Disabled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account cannot be used any longer.
    /// Encoded/decoded by serializers as &quot;DELE&quot;.
    /// </summary>
    [EnumMember(Value = "DELE")]
    [IsoId("_brettdp-Ed-ak6NoX_4Aeg_-885910656")]
    [Description(@"Account cannot be used any longer.")]
    Deleted = AccountStatusCode.Deleted, // same ordinal as derivation source for type conversions
    
}
