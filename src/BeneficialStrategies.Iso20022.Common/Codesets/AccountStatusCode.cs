// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current state of an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_brn3odp-Ed-ak6NoX_4Aeg_-1657976569")]
[Description(@"Specifies the current state of an account.")]
[Derivations(typeof(AccountStatus2Code),typeof(AccountStatus1Code),typeof(AccountStatus3Code),typeof(AccountStatus4Code))]
public enum AccountStatusCode
{
    /// <summary>
    /// Account can be used for its intended purpose.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_brn3otp-Ed-ak6NoX_4Aeg_-1967705692")]
    [Description(@"Account can be used for its intended purpose.")]
    Enabled,
    
    /// <summary>
    /// Account cannot be used for its intended purpose, either temporarily or permanently.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_brn3o9p-Ed-ak6NoX_4Aeg_-1949232976")]
    [Description(@"Account cannot be used for its intended purpose, either temporarily or permanently.")]
    Disabled,
    
    /// <summary>
    /// Account cannot be used any longer.
    /// Encoded/decoded by serializers as &quot;DELE&quot;.
    /// </summary>
    [EnumMember(Value = "DELE")]
    [IsoId("_brn3pNp-Ed-ak6NoX_4Aeg_-1923375698")]
    [Description(@"Account cannot be used any longer.")]
    Deleted,
    
    /// <summary>
    /// Account is temporary and can be partially used for its intended purpose. The account will be fully available for use when the account servicer has received all relevant documents.
    /// Encoded/decoded by serializers as &quot;FORM&quot;.
    /// </summary>
    [EnumMember(Value = "FORM")]
    [IsoId("_brn3pdp-Ed-ak6NoX_4Aeg_-54743257")]
    [Description(@"Account is temporary and can be partially used for its intended purpose. The account will be fully available for use when the account servicer has received all relevant documents.")]
    ProForma,
    
    /// <summary>
    /// Account change is pending approval.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_Oi_OkCF1EeW9XJWqfgXIIA")]
    [Description(@"Account change is pending approval.")]
    Pending,
    
}
