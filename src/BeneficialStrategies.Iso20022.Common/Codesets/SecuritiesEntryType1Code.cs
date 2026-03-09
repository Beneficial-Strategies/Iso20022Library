// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities entry on an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VoyyiNp-Ed-ak6NoX_4Aeg_-382974261")]
[Description(@"Specifies the type of securities entry on an account.")]
[DerivedFrom(typeof(SecuritiesEntryTypeCode))]
public enum SecuritiesEntryType1Code
{
    /// <summary>
    /// Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as &quot;BLOK&quot;.
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_Vo78cNp-Ed-ak6NoX_4Aeg_-3409008")]
    [Description(@"Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.")]
    Blocked = SecuritiesEntryTypeCode.Blocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total number of securities eligible for this event.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_Vo78cdp-Ed-ak6NoX_4Aeg_-3408991")]
    [Description(@"Total number of securities eligible for this event.")]
    Eligible = SecuritiesEntryTypeCode.Eligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that are pending delivery.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_Vo78ctp-Ed-ak6NoX_4Aeg_-3408990")]
    [Description(@"Balance of securities that are pending delivery.")]
    PendingDelivery = SecuritiesEntryTypeCode.PendingDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that are pending receipt.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_Vo78c9p-Ed-ak6NoX_4Aeg_-3408973")]
    [Description(@"Balance of securities that are pending receipt.")]
    PendingReceipt = SecuritiesEntryTypeCode.PendingReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that are registered (in the name of a nominee or of the beneficial owner).
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_Vo78dNp-Ed-ak6NoX_4Aeg_-3408956")]
    [Description(@"Balance of securities that are registered (in the name of a nominee or of the beneficial owner).")]
    Registered = SecuritiesEntryTypeCode.Registered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities representing only settled transactions.
    /// Encoded/decoded by serializers as &quot;SETD&quot;.
    /// </summary>
    [EnumMember(Value = "SETD")]
    [IsoId("_VpFtcNp-Ed-ak6NoX_4Aeg_464815535")]
    [Description(@"Balance of securities representing only settled transactions.")]
    Settled = SecuritiesEntryTypeCode.Settled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that have been borrowed from another party.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_VpFtcdp-Ed-ak6NoX_4Aeg_935568190")]
    [Description(@"Balance of securities that have been borrowed from another party.")]
    Borrowed = SecuritiesEntryTypeCode.Borrowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that have been loaned to a third party.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_VpFtctp-Ed-ak6NoX_4Aeg_1188610881")]
    [Description(@"Balance of securities that have been loaned to a third party.")]
    OnLoan = SecuritiesEntryTypeCode.OnLoan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities that remain registered in the name of the prior beneficial owner of securities.
    /// Encoded/decoded by serializers as &quot;SPOS&quot;.
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_VpFtc9p-Ed-ak6NoX_4Aeg_1695625369")]
    [Description(@"Balance of securities that remain registered in the name of the prior beneficial owner of securities.")]
    StreetPosition = SecuritiesEntryTypeCode.StreetPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities representing traded transactions.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_VpFtdNp-Ed-ak6NoX_4Aeg_1761193858")]
    [Description(@"Balance of securities representing traded transactions.")]
    Traded = SecuritiesEntryTypeCode.Traded, // same ordinal as derivation source for type conversions
    
}
