// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies further the current state of an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bretttp-Ed-ak6NoX_4Aeg_-674425940")]
[Description(@"Qualifies further the current state of an account.")]
[DerivedFrom(typeof(AccountStatusCode))]
public enum AccountStatus2Code
{
    /// <summary>
    /// Account can be used for its intended purpose.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_brett9p-Ed-ak6NoX_4Aeg_-427843353")]
    [Description(@"Account can be used for its intended purpose.")]
    Enabled = AccountStatusCode.Enabled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account cannot be used for its intended purpose, either temporarily or permanently.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_bretuNp-Ed-ak6NoX_4Aeg_-426923282")]
    [Description(@"Account cannot be used for its intended purpose, either temporarily or permanently.")]
    Disabled = AccountStatusCode.Disabled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is temporary and can be partially used for its intended purpose. The account will be fully available for use when the account servicer has received all relevant documents.
    /// Encoded/decoded by serializers as &quot;FORM&quot;.
    /// </summary>
    [EnumMember(Value = "FORM")]
    [IsoId("_brn3oNp-Ed-ak6NoX_4Aeg_-413993874")]
    [Description(@"Account is temporary and can be partially used for its intended purpose. The account will be fully available for use when the account servicer has received all relevant documents.")]
    ProForma = AccountStatusCode.ProForma, // same ordinal as derivation source for type conversions
    
}
