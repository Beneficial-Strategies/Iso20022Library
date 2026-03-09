// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VlqmANp-Ed-ak6NoX_4Aeg_1005907551")]
[Description(@"Specifies the type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(ChargeTypeCode))]
public enum ChargeType6Code
{
    /// <summary>
    /// Sales charge paid by the investor when redeeming an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_VlqmAdp-Ed-ak6NoX_4Aeg_1245099661")]
    [Description(@"Sales charge paid by the investor when redeeming an investment such as an investment fund.")]
    BackEndLoad = ChargeTypeCode.BackEndLoad, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_VlqmAtp-Ed-ak6NoX_4Aeg_1245100437")]
    [Description(@"Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.")]
    FrontEndLoad = ChargeTypeCode.FrontEndLoad, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In investment funds, charge related to a switch transaction.
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_VlqmA9p-Ed-ak6NoX_4Aeg_1245100455")]
    [Description(@"In investment funds, charge related to a switch transaction.")]
    Switch = ChargeTypeCode.Switch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders.
    /// Encoded/decoded by serializers as &quot;DLEV&quot;.
    /// </summary>
    [EnumMember(Value = "DLEV")]
    [IsoId("_VlqmBNp-Ed-ak6NoX_4Aeg_1245100497")]
    [Description(@"In investment funds, a charge payable by the investor covering bid-offer spreads and dealing charges for the underlying investments. The dilution levy is paid to the fund for the benefit of other unit holders.")]
    DilutionLevy = ChargeTypeCode.DilutionLevy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_VlqmBdp-Ed-ak6NoX_4Aeg_1245100515")]
    [Description(@"Charge that has been reduced from the standard initial charge levied by a fund, eg, during a launch period or as negotiated by a funds supermarket / discount broker.")]
    Discount = ChargeTypeCode.Discount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee charged to the investor for early redemption of the fund.
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_VlqmBtp-Ed-ak6NoX_4Aeg_1260797609")]
    [Description(@"Fee charged to the investor for early redemption of the fund.")]
    Penalty = ChargeTypeCode.Penalty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee paid to an investment manager for services. The fee usually includes fund administration costs and investor relationship management. Typically, the amount paid is a percentage of the assets under management.
    /// Encoded/decoded by serializers as &quot;MANF&quot;.
    /// </summary>
    [EnumMember(Value = "MANF")]
    [IsoId("_VlqmB9p-Ed-ak6NoX_4Aeg_1675459316")]
    [Description(@"Fee paid to an investment manager for services. The fee usually includes fund administration costs and investor relationship management. Typically, the amount paid is a percentage of the assets under management.")]
    ManagementFee = ChargeTypeCode.ManagementFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge paid for the postage.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_VlqmCNp-Ed-ak6NoX_4Aeg_1706860958")]
    [Description(@"Charge paid for the postage.")]
    PostageCharge = ChargeTypeCode.PostageCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee charged by a regulatory authority, eg, Securities and Exchange fees.
    /// Encoded/decoded by serializers as &quot;REGF&quot;.
    /// </summary>
    [EnumMember(Value = "REGF")]
    [IsoId("_VlqmCdp-Ed-ak6NoX_4Aeg_1760424834")]
    [Description(@"Fee charged by a regulatory authority, eg, Securities and Exchange fees.")]
    RegulatoryFee = ChargeTypeCode.RegulatoryFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge for shipping, including the insurance of securities.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_Vlzv8Np-Ed-ak6NoX_4Aeg_1860165643")]
    [Description(@"Charge for shipping, including the insurance of securities.")]
    ShippingCharge = ChargeTypeCode.ShippingCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee paid for the provision of financial services.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_Vlzv8dp-Ed-ak6NoX_4Aeg_2119673574")]
    [Description(@"Fee paid for the provision of financial services.")]
    ServiceProvisionFee = ChargeTypeCode.ServiceProvisionFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another type of charge.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vlzv8tp-Ed-ak6NoX_4Aeg_-1186201355")]
    [Description(@"Another type of charge.")]
    Other = ChargeTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deferred sales charge.
    /// Encoded/decoded by serializers as &quot;CDSC&quot;.
    /// </summary>
    [EnumMember(Value = "CDSC")]
    [IsoId("_Vlzv89p-Ed-ak6NoX_4Aeg_177837095")]
    [Description(@"Deferred sales charge.")]
    ContingencyDeferredSalesCharge = ChargeTypeCode.ContingencyDeferredSalesCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_Vlzv9Np-Ed-ak6NoX_4Aeg_338690890")]
    [Description(@"The part of an investor's subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year.")]
    Equalisation = ChargeTypeCode.Equalisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In investment funds, the charge of the correspondent bank for transferring money.
    /// Encoded/decoded by serializers as &quot;CBCH&quot;.
    /// </summary>
    [EnumMember(Value = "CBCH")]
    [IsoId("_Vlzv9dp-Ed-ak6NoX_4Aeg_-953190669")]
    [Description(@"In investment funds, the charge of the correspondent bank for transferring money.")]
    CorrespondentBankCharge = ChargeTypeCode.CorrespondentBankCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In investment funds, pre-arranged addition to the trade amount based on the published net asset value.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_Vlzv9tp-Ed-ak6NoX_4Aeg_-953190332")]
    [Description(@"In investment funds, pre-arranged addition to the trade amount based on the published net asset value.")]
    Premium = ChargeTypeCode.Premium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge paid at the time of the first subscription.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_Vlzv99p-Ed-ak6NoX_4Aeg_-953189971")]
    [Description(@"Charge paid at the time of the first subscription.")]
    Initial = ChargeTypeCode.Initial, // same ordinal as derivation source for type conversions
    
}
