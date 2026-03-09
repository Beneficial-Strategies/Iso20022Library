// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the level of service offered.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ymocpdp-Ed-ak6NoX_4Aeg_-630382090")]
[Description(@"Specifies the level of service offered.")]
[DerivedFrom(typeof(TradeFinanceServiceCode))]
public enum TradeFinanceService2Code
{
    /// <summary>
    /// Code for level 1 services.
    /// Encoded/decoded by serializers as &quot;LEV1&quot;.
    /// </summary>
    [EnumMember(Value = "LEV1")]
    [IsoId("_Ymocptp-Ed-ak6NoX_4Aeg_-547265145")]
    [Description(@"Code for level 1 services.")]
    Level1Services = TradeFinanceServiceCode.Level1Services, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for level 2 services.
    /// Encoded/decoded by serializers as &quot;LEV2&quot;.
    /// </summary>
    [EnumMember(Value = "LEV2")]
    [IsoId("_Ymocp9p-Ed-ak6NoX_4Aeg_-543571648")]
    [Description(@"Code for level 2 services.")]
    Level2Services = TradeFinanceServiceCode.Level2Services, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for level 3 services.
    /// Encoded/decoded by serializers as &quot;LEV3&quot;.
    /// </summary>
    [EnumMember(Value = "LEV3")]
    [IsoId("_YmocqNp-Ed-ak6NoX_4Aeg_-530643751")]
    [Description(@"Code for level 3 services.")]
    Level3Services = TradeFinanceServiceCode.Level3Services, // same ordinal as derivation source for type conversions
    
}
