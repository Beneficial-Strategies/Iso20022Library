// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides details on the  type of the cash reinvestment in a given currency.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mPNa4I68EeaxxtxaoOwzAg")]
[Description(@"Provides details on the  type of the cash reinvestment in a given currency.")]
[Derivations(typeof(ReinvestmentType1Code))]
public enum ReinvestmentTypeCode
{
    /// <summary>
    /// Reinvestment type is registered money market fund that is a public debt constant net asset value money market fund, low volatility net asset value money market fund or variable net asset value money market fund.
    /// Encoded/decoded by serializers as &quot;MMFT&quot;.
    /// </summary>
    [EnumMember(Value = "MMFT")]
    [IsoId("_uUQPYI68EeaxxtxaoOwzAg")]
    [Description(@"Reinvestment type is registered money market fund that is a public debt constant net asset value money market fund, low volatility net asset value money market fund or variable net asset value money market fund.")]
    RegisteredMoneyMarketFund,
    
    /// <summary>
    /// Reinvestment type is a pool of commingled assets.
    /// Encoded/decoded by serializers as &quot;OCMP&quot;.
    /// </summary>
    [EnumMember(Value = "OCMP")]
    [IsoId("_yAyykI68EeaxxtxaoOwzAg")]
    [Description(@"Reinvestment type is a pool of commingled assets.")]
    OtherCommingledPool,
    
    /// <summary>
    /// Reinvestment type is market where repurchase agreements are traded. 
    /// Encoded/decoded by serializers as &quot;REPM&quot;.
    /// </summary>
    [EnumMember(Value = "REPM")]
    [IsoId("_07ZigI68EeaxxtxaoOwzAg")]
    [Description(@"Reinvestment type is market where repurchase agreements are traded. ")]
    RepurchaseAgreementMarket,
    
    /// <summary>
    /// Reinvestment type is direct purchase of securities.
    /// Encoded/decoded by serializers as &quot;SDPU&quot;.
    /// </summary>
    [EnumMember(Value = "SDPU")]
    [IsoId("_3fNjEI68EeaxxtxaoOwzAg")]
    [Description(@"Reinvestment type is direct purchase of securities.")]
    SecuritiesDirectPurchase,
    
    /// <summary>
    /// Other type of reinvestment.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_7TWjEI68EeaxxtxaoOwzAg")]
    [Description(@"Other type of reinvestment.")]
    Other,
    
}
