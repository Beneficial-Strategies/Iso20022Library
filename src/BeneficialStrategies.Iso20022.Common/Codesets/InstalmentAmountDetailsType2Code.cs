// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Instalment amount detail type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8d5Y8JJNEeuuktRxxQZoNQ")]
[Description(@"Instalment amount detail type.")]
[DerivedFrom(typeof(InstalmentAmountDetailsTypeCode))]
public enum InstalmentAmountDetailsType2Code
{
    /// <summary>
    /// Total financing cost per annum.
    /// Encoded/decoded by serializers as &quot;AFCO&quot;.
    /// </summary>
    [EnumMember(Value = "AFCO")]
    [IsoId("_LaEdUZJOEeuuktRxxQZoNQ")]
    [Description(@"Total financing cost per annum.")]
    AnnualFinancingCost = InstalmentAmountDetailsTypeCode.AnnualFinancingCost, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Expense Amount
    /// Encoded/decoded by serializers as &quot;EXPN&quot;.
    /// </summary>
    [EnumMember(Value = "EXPN")]
    [IsoId("_LhX_MZJOEeuuktRxxQZoNQ")]
    [Description(@"Expense Amount")]
    Expense = InstalmentAmountDetailsTypeCode.Expense, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fees amount
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_Lnl78ZJOEeuuktRxxQZoNQ")]
    [Description(@"Fees amount")]
    Fees = InstalmentAmountDetailsTypeCode.Fees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Funded amount
    /// Encoded/decoded by serializers as &quot;FUNA&quot;.
    /// </summary>
    [EnumMember(Value = "FUNA")]
    [IsoId("_LuRywZJOEeuuktRxxQZoNQ")]
    [Description(@"Funded amount")]
    Funded = InstalmentAmountDetailsTypeCode.Funded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insurance amount
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_L1TAwZJOEeuuktRxxQZoNQ")]
    [Description(@"Insurance amount")]
    Insurance = InstalmentAmountDetailsTypeCode.Insurance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest amount.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_L7lO8ZJOEeuuktRxxQZoNQ")]
    [Description(@"Interest amount.")]
    Interest = InstalmentAmountDetailsTypeCode.Interest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other amounts
    /// Encoded/decoded by serializers as &quot;OTHC&quot;.
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_MBmXYZJOEeuuktRxxQZoNQ")]
    [Description(@"Other amounts")]
    OtherCharges = InstalmentAmountDetailsTypeCode.OtherCharges, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Grace period unit type
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_MH07MZJOEeuuktRxxQZoNQ")]
    [Description(@"Grace period unit type")]
    OtherNational = InstalmentAmountDetailsTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Grace period unit type
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_MOe80ZJOEeuuktRxxQZoNQ")]
    [Description(@"Grace period unit type")]
    OtherPrivate = InstalmentAmountDetailsTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Principal amount.
    /// Encoded/decoded by serializers as &quot;PRNC&quot;.
    /// </summary>
    [EnumMember(Value = "PRNC")]
    [IsoId("_MUKuEZJOEeuuktRxxQZoNQ")]
    [Description(@"Principal amount.")]
    Principal = InstalmentAmountDetailsTypeCode.Principal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested amount
    /// Encoded/decoded by serializers as &quot;RQST&quot;.
    /// </summary>
    [EnumMember(Value = "RQST")]
    [IsoId("_MbQNgZJOEeuuktRxxQZoNQ")]
    [Description(@"Requested amount")]
    Requested = InstalmentAmountDetailsTypeCode.Requested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instalment amount tax
    /// Encoded/decoded by serializers as &quot;TAXX&quot;.
    /// </summary>
    [EnumMember(Value = "TAXX")]
    [IsoId("_MhsMsZJOEeuuktRxxQZoNQ")]
    [Description(@"Instalment amount tax")]
    Tax = InstalmentAmountDetailsTypeCode.Tax, // same ordinal as derivation source for type conversions
    
}
