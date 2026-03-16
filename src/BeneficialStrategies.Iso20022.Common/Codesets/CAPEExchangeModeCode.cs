// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of exchange supported by a host.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CAPEExchangeModeCode")]
[Description(@"Type of exchange supported by a host.")]
public enum CAPEExchangeModeCode
{
    /// <summary>
    /// With this protocol, the communication is done through calls to API.
    /// Encoded/decoded by serializers as &quot;APIE&quot;.
    /// </summary>
    [EnumMember(Value = "APIE")]
    [IsoId("_CAPEExchangeModeCode_ExchangeByAPI")]
    [Description(@"With this protocol, the communication is done through calls to API.")]
    ExchangeByAPI,

    /// <summary>
    /// With this protocol, the communication is done through message exchanges.
    /// Encoded/decoded by serializers as &quot;MSGE&quot;.
    /// </summary>
    [EnumMember(Value = "MSGE")]
    [IsoId("_CAPEExchangeModeCode_ExchangeByMessage")]
    [Description(@"With this protocol, the communication is done through message exchanges.")]
    ExchangeByMessage,
}
