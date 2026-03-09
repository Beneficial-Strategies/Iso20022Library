// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// indicates if the Trade Regulatory Conditions is solicited or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__yN4JdojEeC60axPepSq7g_-544243991")]
[Description(@"indicates if the Trade Regulatory Conditions is solicited or not.")]
[DerivedFrom(typeof(TradeRegulatoryConditionsCode))]
public enum TradeRegulatoryConditions1Code
{
    /// <summary>
    /// Trade was solicited by the executing broker. The broker has suggested to his client to buy/sell financial instruments.
    /// Encoded/decoded by serializers as &quot;SOLI&quot;.
    /// </summary>
    [EnumMember(Value = "SOLI")]
    [IsoId("__yXpINojEeC60axPepSq7g_-382114460")]
    [Description(@"Trade was solicited by the executing broker. The broker has suggested to his client to buy/sell financial instruments.")]
    Solicited = TradeRegulatoryConditionsCode.Solicited, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade was unsolicited. The client acts on its own without advice from the executing broker.
    /// Encoded/decoded by serializers as &quot;USOL&quot;.
    /// </summary>
    [EnumMember(Value = "USOL")]
    [IsoId("__yXpIdojEeC60axPepSq7g_-393213237")]
    [Description(@"Trade was unsolicited. The client acts on its own without advice from the executing broker.")]
    Unsolicited = TradeRegulatoryConditionsCode.Unsolicited, // same ordinal as derivation source for type conversions
    
}
