// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used for the negotiation and execution of a trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrGs8Np-Ed-ak6NoX_4Aeg_627416882")]
[Description(@"Specifies the method used for the negotiation and execution of a trade.")]
[Derivations(typeof(Trading1MethodCode))]
public enum TradingMethodCode
{
    /// <summary>
    /// Trade executed through an electronic trading system.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_YrGs8dp-Ed-ak6NoX_4Aeg_627416883")]
    [Description(@"Trade executed through an electronic trading system.")]
    Electronic,
    
    /// <summary>
    /// Trade executed over the phone.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_YrGs8tp-Ed-ak6NoX_4Aeg_627416884")]
    [Description(@"Trade executed over the phone.")]
    Phone,
    
    /// <summary>
    /// Trade executed through a broker.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_YrGs89p-Ed-ak6NoX_4Aeg_627416885")]
    [Description(@"Trade executed through a broker.")]
    Broker,
    
}
