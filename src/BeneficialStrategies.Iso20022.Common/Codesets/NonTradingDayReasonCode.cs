// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason capturing a non trading day.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7DQxQGw4EeWD9e8QDBgUOw")]
[Description(@"Specifies the reason capturing a non trading day.")]
[Derivations(typeof(NonTradingDayReason1Code))]
public enum NonTradingDayReasonCode
{
    /// <summary>
    /// Other reasons a day is a non-trading day e.g. technical fault, company specific non-trading day not known in advance.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_DG_-MGw5EeWD9e8QDBgUOw")]
    [Description(@"Other reasons a day is a non-trading day e.g. technical fault, company specific non-trading day not known in advance.")]
    Other,
    
    /// <summary>
    /// The date is a full day trading holiday with no trades performed.
    /// Encoded/decoded by serializers as &quot;THOL&quot;.
    /// </summary>
    [EnumMember(Value = "THOL")]
    [IsoId("_EzKlEGw5EeWD9e8QDBgUOw")]
    [Description(@"The date is a full day trading holiday with no trades performed.")]
    TradingHoliday,
    
    /// <summary>
    /// Trading venue was open for an amount of time, up to half the day.
    /// Encoded/decoded by serializers as &quot;HALF&quot;.
    /// </summary>
    [EnumMember(Value = "HALF")]
    [IsoId("_LNwp8Gw5EeWD9e8QDBgUOw")]
    [Description(@"Trading venue was open for an amount of time, up to half the day.")]
    HalfDay,
    
    /// <summary>
    /// Date is a bank holiday.
    /// Encoded/decoded by serializers as &quot;BHOL&quot;.
    /// </summary>
    [EnumMember(Value = "BHOL")]
    [IsoId("_AEFxYGw6EeWD9e8QDBgUOw")]
    [Description(@"Date is a bank holiday.")]
    BankHoliday,
    
    /// <summary>
    /// Date is a public holiday.
    /// Encoded/decoded by serializers as &quot;PHOL&quot;.
    /// </summary>
    [EnumMember(Value = "PHOL")]
    [IsoId("_B2sXcGw6EeWD9e8QDBgUOw")]
    [Description(@"Date is a public holiday.")]
    PublicHoliday,
    
    /// <summary>
    /// Date being reported falls during the weekend.
    /// Encoded/decoded by serializers as &quot;WKND&quot;.
    /// </summary>
    [EnumMember(Value = "WKND")]
    [IsoId("_DhnoMGw6EeWD9e8QDBgUOw")]
    [Description(@"Date being reported falls during the weekend.")]
    Weekend,
    
}
