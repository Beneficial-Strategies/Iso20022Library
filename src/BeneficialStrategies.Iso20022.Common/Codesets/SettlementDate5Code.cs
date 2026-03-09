// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the date of settlement, in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__wR-c9ojEeC60axPepSq7g_1940950548")]
[Description(@"Specifies the date of settlement, in coded form.")]
[DerivedFrom(typeof(SettlementDateCode))]
public enum SettlementDate5Code
{
    /// <summary>
    /// Settlement takes place under the standard rules applicable to the market and instrument.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("__wR-dNojEeC60axPepSq7g_-2042913404")]
    [Description(@"Settlement takes place under the standard rules applicable to the market and instrument.")]
    Regular = SettlementDateCode.Regular, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("__wR-ddojEeC60axPepSq7g_-518845108")]
    [Description(@"Settlement takes place on the trade date.")]
    Cash = SettlementDateCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the day after trade date.
    /// Encoded/decoded by serializers as &quot;NXTD&quot;.
    /// </summary>
    [EnumMember(Value = "NXTD")]
    [IsoId("__wbvcNojEeC60axPepSq7g_1934277231")]
    [Description(@"Settlement takes place on the day after trade date.")]
    NextDay = SettlementDateCode.NextDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus one business day.
    /// Encoded/decoded by serializers as &quot;TONE&quot;.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("__wbvcdojEeC60axPepSq7g_-1599924912")]
    [Description(@"Settlement takes place on the trade date plus one business day.")]
    TPlusOne = SettlementDateCode.TPlusOne, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus two business days.
    /// Encoded/decoded by serializers as &quot;TTWO&quot;.
    /// </summary>
    [EnumMember(Value = "TTWO")]
    [IsoId("__wbvctojEeC60axPepSq7g_230998257")]
    [Description(@"Settlement takes place on the trade date plus two business days.")]
    TPlusTwo = SettlementDateCode.TPlusTwo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus three business days.
    /// Encoded/decoded by serializers as &quot;TTRE&quot;.
    /// </summary>
    [EnumMember(Value = "TTRE")]
    [IsoId("__wbvc9ojEeC60axPepSq7g_1755066553")]
    [Description(@"Settlement takes place on the trade date plus three business days.")]
    TPlusThree = SettlementDateCode.TPlusThree, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus four business days.
    /// Encoded/decoded by serializers as &quot;TFOR&quot;.
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("__wbvdNojEeC60axPepSq7g_685085526")]
    [Description(@"Settlement takes place on the trade date plus four business days.")]
    TPlusFour = SettlementDateCode.TPlusFour, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus five business days.
    /// Encoded/decoded by serializers as &quot;TFIV&quot;.
    /// </summary>
    [EnumMember(Value = "TFIV")]
    [IsoId("__wbvddojEeC60axPepSq7g_1010203033")]
    [Description(@"Settlement takes place on the trade date plus five business days.")]
    TPlusFive = SettlementDateCode.TPlusFive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place at the choice/option of the seller.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("__wk5YNojEeC60axPepSq7g_-40862622")]
    [Description(@"Settlement takes place at the choice/option of the seller.")]
    SellersOption = SettlementDateCode.SellersOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place when the financial instrument is distributed.
    /// Encoded/decoded by serializers as &quot;WDIS&quot;.
    /// </summary>
    [EnumMember(Value = "WDIS")]
    [IsoId("__wk5YdojEeC60axPepSq7g_1814515449")]
    [Description(@"Settlement takes place when the financial instrument is distributed.")]
    WhenDistributed = SettlementDateCode.WhenDistributed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place when the financial instrument is issued or distributed.
    /// Encoded/decoded by serializers as &quot;WHID&quot;.
    /// </summary>
    [EnumMember(Value = "WHID")]
    [IsoId("__wk5YtojEeC60axPepSq7g_-1719686694")]
    [Description(@"Settlement takes place when the financial instrument is issued or distributed.")]
    WhenIssuedOrDistributed = SettlementDateCode.WhenIssuedOrDistributed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place as a result of a &quot;to be announced&quot; trade.
    /// Encoded/decoded by serializers as &quot;TBAT&quot;.
    /// </summary>
    [EnumMember(Value = "TBAT")]
    [IsoId("__wk5Y9ojEeC60axPepSq7g_-195618398")]
    [Description(@"Settlement takes place as a result of a ""to be announced"" trade.")]
    ToBeAnnouncedTrade = SettlementDateCode.ToBeAnnouncedTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is to be done when the security is issued.
    /// Encoded/decoded by serializers as &quot;WISS&quot;.
    /// </summary>
    [EnumMember(Value = "WISS")]
    [IsoId("__wk5ZNojEeC60axPepSq7g_1464768024")]
    [Description(@"Settlement is to be done when the security is issued.")]
    WhenIssued = SettlementDateCode.WhenIssued, // same ordinal as derivation source for type conversions
    
}
