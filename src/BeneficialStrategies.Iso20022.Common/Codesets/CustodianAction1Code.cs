// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies custodian activity codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_14n2MDL3EeKU9IrkkToqcw_-767286658")]
[Description(@"Specifies custodian activity codes.")]
[DerivedFrom(typeof(CustodianActionCode))]
public enum CustodianAction1Code
{
    /// <summary>
    /// Custodian is researching pending issues raised by the validation service.
    /// Encoded/decoded by serializers as &quot;RSCH&quot;.
    /// </summary>
    [EnumMember(Value = "RSCH")]
    [IsoId("_14n2MTL3EeKU9IrkkToqcw_-892224501")]
    [Description(@"Custodian is researching pending issues raised by the validation service.")]
    Research = CustodianActionCode.Research, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Custodian is expected to send updated information.
    /// Encoded/decoded by serializers as &quot;SEND&quot;.
    /// </summary>
    [EnumMember(Value = "SEND")]
    [IsoId("_14n2MjL3EeKU9IrkkToqcw_-146179494")]
    [Description(@"Custodian is expected to send updated information.")]
    SendInfo = CustodianActionCode.SendInfo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Custodian disagrees with the validation service and will take no further action.
    /// Encoded/decoded by serializers as &quot;DISS&quot;.
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("_14n2MzL3EeKU9IrkkToqcw_1320969269")]
    [Description(
        @"Custodian disagrees with the validation service and will take no further action."
    )]
    Disagrees = CustodianActionCode.Disagrees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No action required by the custodian.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_14n2NDL3EeKU9IrkkToqcw_-1838359691")]
    [Description(@"No action required by the custodian.")]
    NoAction = CustodianActionCode.NoAction, // same ordinal as derivation source for type conversions
}
