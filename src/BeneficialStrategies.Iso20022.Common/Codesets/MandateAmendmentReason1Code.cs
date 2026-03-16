// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for requesting the amendment of a mandate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afolp9p-Ed-ak6NoX_4Aeg_-1111888511")]
[Description(@"Specifies the reason for requesting the amendment of a mandate.")]
[DerivedFrom(typeof(MandateReasonCode))]
public enum MandateAmendmentReason1Code
{
    /// <summary>
    /// Agent details are incorrect or have changed.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_afolqNp-Ed-ak6NoX_4Aeg_-1007530300")]
    [Description(@"Agent details are incorrect or have changed.")]
    IncorrectAgent = MandateReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency for the mandate is incorrect or has changed.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_afxvkNp-Ed-ak6NoX_4Aeg_-909639032")]
    [Description(@"Currency for the mandate is incorrect or has changed.")]
    IncorrectCurrency = MandateReasonCode.IncorrectCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer requested the change.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_afxvkdp-Ed-ak6NoX_4Aeg_-883779837")]
    [Description(@"Customer requested the change.")]
    RequestedByCustomer = MandateReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account details are not correct.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_afxvktp-Ed-ak6NoX_4Aeg_-639046895")]
    [Description(@"Account details are not correct.")]
    IncorrectAccount = MandateReasonCode.IncorrectAccount, // same ordinal as derivation source for type conversions
}
