// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a9b7-dp-Ed-ak6NoX_4Aeg_-1157330660")]
[Description(@"Specifies the type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(ChargeTypeCode))]
public enum ChargeType9Code
{
    /// <summary>
    /// Fee paid to an investment manager for services. The fee usually includes fund administration costs and investor relationship management. Typically, the amount paid is a percentage of the assets under management.
    /// Encoded/decoded by serializers as &quot;MANF&quot;.
    /// </summary>
    [EnumMember(Value = "MANF")]
    [IsoId("_a9lF4Np-Ed-ak6NoX_4Aeg_-1114851871")]
    [Description(@"Fee paid to an investment manager for services. The fee usually includes fund administration costs and investor relationship management. Typically, the amount paid is a percentage of the assets under management.")]
    ManagementFee = ChargeTypeCode.ManagementFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sales charge paid by the investor when redeeming an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_a9lF4dp-Ed-ak6NoX_4Aeg_-1114850509")]
    [Description(@"Sales charge paid by the investor when redeeming an investment such as an investment fund.")]
    BackEndLoad = ChargeTypeCode.BackEndLoad, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_a9lF4tp-Ed-ak6NoX_4Aeg_-1073293657")]
    [Description(@"Sales charge paid immediately by the investor when subscribing to an investment such as an investment fund.")]
    FrontEndLoad = ChargeTypeCode.FrontEndLoad, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee paid for advisory services rendered.
    /// Encoded/decoded by serializers as &quot;ADVI&quot;.
    /// </summary>
    [EnumMember(Value = "ADVI")]
    [IsoId("_a9lF49p-Ed-ak6NoX_4Aeg_-1114850492")]
    [Description(@"Fee paid for advisory services rendered.")]
    AdvisoryFee = ChargeTypeCode.AdvisoryFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee paid to a custodian in respect of custodial services.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_a9lF5Np-Ed-ak6NoX_4Aeg_-1114850474")]
    [Description(@"Fee paid to a custodian in respect of custodial services.")]
    CustodyFee = ChargeTypeCode.CustodyFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee paid in respect of publications made.
    /// Encoded/decoded by serializers as &quot;PUBL&quot;.
    /// </summary>
    [EnumMember(Value = "PUBL")]
    [IsoId("_a9lF5dp-Ed-ak6NoX_4Aeg_-1114850457")]
    [Description(@"Fee paid in respect of publications made.")]
    PublicationFee = ChargeTypeCode.PublicationFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee paid for accounting services rendered.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_a9lF5tp-Ed-ak6NoX_4Aeg_-1114850166")]
    [Description(@"Fee paid for accounting services rendered.")]
    AccountingFee = ChargeTypeCode.AccountingFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_a9lF59p-Ed-ak6NoX_4Aeg_-1114850036")]
    [Description(@"The part of an investor's subscription amount that is held by the fund in order to pay incentive or performance fees at the end of the fiscal year.")]
    Equalisation = ChargeTypeCode.Equalisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee charged to the investor for early redemption of the fund.
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_a9lF6Np-Ed-ak6NoX_4Aeg_-486651348")]
    [Description(@"Fee charged to the investor for early redemption of the fund.")]
    Penalty = ChargeTypeCode.Penalty, // same ordinal as derivation source for type conversions
    
}
