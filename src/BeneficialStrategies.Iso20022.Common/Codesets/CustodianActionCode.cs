// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies custodian activity codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_14eFMTL3EeKU9IrkkToqcw_2034050184")]
[Description(@"Specifies custodian activity codes.")]
[Derivations(typeof(CustodianAction1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CustodianActionCode>))]
#endif
public enum CustodianActionCode
{
    /// <summary>
    /// Custodian is researching pending issues raised by the validation service.
    /// Encoded/decoded by serializers as &quot;RSCH&quot;.
    /// </summary>
    [EnumMember(Value = "RSCH")]
    [IsoId("_14eFMjL3EeKU9IrkkToqcw_-1836075387")]
    [Description(@"Custodian is researching pending issues raised by the validation service.")]
    Research,

    /// <summary>
    /// Custodian is expected to send updated information.
    /// Encoded/decoded by serializers as &quot;SEND&quot;.
    /// </summary>
    [EnumMember(Value = "SEND")]
    [IsoId("_14eFMzL3EeKU9IrkkToqcw_2034977918")]
    [Description(@"Custodian is expected to send updated information.")]
    SendInfo,

    /// <summary>
    /// Custodian disagrees with the validation service and will take no further action.
    /// Encoded/decoded by serializers as &quot;DISS&quot;.
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("_14eFNDL3EeKU9IrkkToqcw_1016644254")]
    [Description(
        @"Custodian disagrees with the validation service and will take no further action."
    )]
    Disagrees,

    /// <summary>
    /// No action required by the custodian.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_14eFNTL3EeKU9IrkkToqcw_-878516849")]
    [Description(@"No action required by the custodian.")]
    NoAction,
}
