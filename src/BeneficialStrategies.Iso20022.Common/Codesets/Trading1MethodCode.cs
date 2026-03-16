// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used for the negotiation and execution of the trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YqgQAtp-Ed-ak6NoX_4Aeg_-258608744")]
[Description(@"Specifies the method used for the negotiation and execution of the trade.")]
[DerivedFrom(typeof(TradingMethodCode))]
public enum Trading1MethodCode
{
    /// <summary>
    /// Trade executed through an electronic trading system.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_YqgQA9p-Ed-ak6NoX_4Aeg_2750610")]
    [Description(@"Trade executed through an electronic trading system.")]
    Electronic = TradingMethodCode.Electronic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade executed over the phone.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_YqgQBNp-Ed-ak6NoX_4Aeg_32300524")]
    [Description(@"Trade executed over the phone.")]
    Phone = TradingMethodCode.Phone, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade executed through a broker.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_YqgQBdp-Ed-ak6NoX_4Aeg_48002593")]
    [Description(@"Trade executed through a broker.")]
    Broker = TradingMethodCode.Broker, // same ordinal as derivation source for type conversions
}
