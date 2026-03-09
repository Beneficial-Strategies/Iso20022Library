// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the date of settlement, in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZLSo6dp-Ed-ak6NoX_4Aeg_-69704193")]
[Description(@"Specifies the date of settlement, in coded form.")]
[DerivedFrom(typeof(SettlementDateCode))]
public enum SettlementDate3Code
{
    /// <summary>
    /// Settlement takes place at the choice/option of the seller.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_ZLby0Np-Ed-ak6NoX_4Aeg_-219579438")]
    [Description(@"Settlement takes place at the choice/option of the seller.")]
    SellersOption = SettlementDateCode.SellersOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place as a result of a &quot;to be announced&quot; trade.
    /// Encoded/decoded by serializers as &quot;TBAT&quot;.
    /// </summary>
    [EnumMember(Value = "TBAT")]
    [IsoId("_ZLby0dp-Ed-ak6NoX_4Aeg_-73663569")]
    [Description(@"Settlement takes place as a result of a ""to be announced"" trade.")]
    ToBeAnnouncedTrade = SettlementDateCode.ToBeAnnouncedTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place when the financial instrument is distributed.
    /// Encoded/decoded by serializers as &quot;WDIS&quot;.
    /// </summary>
    [EnumMember(Value = "WDIS")]
    [IsoId("_ZLby0tp-Ed-ak6NoX_4Aeg_341923237")]
    [Description(@"Settlement takes place when the financial instrument is distributed.")]
    WhenDistributed = SettlementDateCode.WhenDistributed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place when the financial instrument is issued or distributed.
    /// Encoded/decoded by serializers as &quot;WHID&quot;.
    /// </summary>
    [EnumMember(Value = "WHID")]
    [IsoId("_ZLby09p-Ed-ak6NoX_4Aeg_372397488")]
    [Description(@"Settlement takes place when the financial instrument is issued or distributed.")]
    WhenIssuedOrDistributed = SettlementDateCode.WhenIssuedOrDistributed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is to be done when the security is issued.
    /// Encoded/decoded by serializers as &quot;WISS&quot;.
    /// </summary>
    [EnumMember(Value = "WISS")]
    [IsoId("_ZLby1Np-Ed-ak6NoX_4Aeg_671619815")]
    [Description(@"Settlement is to be done when the security is issued.")]
    WhenIssued = SettlementDateCode.WhenIssued, // same ordinal as derivation source for type conversions
    
}
