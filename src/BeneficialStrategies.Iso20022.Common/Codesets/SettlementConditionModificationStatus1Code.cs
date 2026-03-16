// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a securities settlement condition modification request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZK1889p-Ed-ak6NoX_4Aeg_1791512487")]
[Description(@"Specifies the status of a securities settlement condition modification request.")]
[DerivedFrom(typeof(SettlementConditionModificationStatusStatusCode))]
public enum SettlementConditionModificationStatus1Code
{
    /// <summary>
    /// Instruction has been acknowledged/accepted by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZK189Np-Ed-ak6NoX_4Aeg_-858187374")]
    [Description(@"Instruction has been acknowledged/accepted by the account servicer.")]
    AcknowledgedAccepted = SettlementConditionModificationStatusStatusCode.AcknowledgedAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZK189dp-Ed-ak6NoX_4Aeg_794440134")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected = SettlementConditionModificationStatusStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification is pending. At this time, it is unknown whether the modification can be affected.
    /// Encoded/decoded by serializers as &quot;MODP&quot;.
    /// </summary>
    [EnumMember(Value = "MODP")]
    [IsoId("_ZK189tp-Ed-ak6NoX_4Aeg_1133726791")]
    [Description(
        @"Modification is pending. At this time, it is unknown whether the modification can be affected."
    )]
    Pending = SettlementConditionModificationStatusStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification Request will not be executed.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_ZK1899p-Ed-ak6NoX_4Aeg_-155303300")]
    [Description(@"Modification Request will not be executed.")]
    Denied = SettlementConditionModificationStatusStatusCode.Denied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification has been completed.
    /// Encoded/decoded by serializers as &quot;MODC&quot;.
    /// </summary>
    [EnumMember(Value = "MODC")]
    [IsoId("_ZK18-Np-Ed-ak6NoX_4Aeg_-974256981")]
    [Description(@"Modification has been completed.")]
    Completed = SettlementConditionModificationStatusStatusCode.Completed, // same ordinal as derivation source for type conversions
}
