// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a suspended status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQ9MANp-Ed-ak6NoX_4Aeg_-174233081")]
[Description(@"Specifies the reason for a suspended status.")]
[Derivations(typeof(SuspendedStatusReason1Code),typeof(SuspendedStatusReason2Code),typeof(SuspendedStatusReason3Code))]
public enum SuspendedStatusReasonCode
{
    /// <summary>
    /// There is a suspension of pricing. The order will stay on the books until the next pricing.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_ZQ9MAdp-Ed-ak6NoX_4Aeg_-102197550")]
    [Description(@"There is a suspension of pricing. The order will stay on the books until the next pricing.")]
    PriceSuspension,
    
    /// <summary>
    /// There is a fund overflow.
    /// Encoded/decoded by serializers as &quot;FLOW&quot;.
    /// </summary>
    [EnumMember(Value = "FLOW")]
    [IsoId("_ZQ9MAtp-Ed-ak6NoX_4Aeg_-102197438")]
    [Description(@"There is a fund overflow.")]
    Overflow,
    
    /// <summary>
    /// Transaction/instruction is suspended following your earlier suspension instruction.
    /// Encoded/decoded by serializers as &quot;SUBY&quot;.
    /// </summary>
    [EnumMember(Value = "SUBY")]
    [IsoId("_ZQ9MA9p-Ed-ak6NoX_4Aeg_-83724631")]
    [Description(@"Transaction/instruction is suspended following your earlier suspension instruction.")]
    SuspendedByYourself,
    
    /// <summary>
    /// Transaction/instruction is suspended following a system suspension instruction.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ZQ9MBNp-Ed-ak6NoX_4Aeg_-75415371")]
    [Description(@"Transaction/instruction is suspended following a system suspension instruction.")]
    SuspendedBySystem,
    
    /// <summary>
    /// Another reason for the status suspended.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZQ9MBdp-Ed-ak6NoX_4Aeg_82201992")]
    [Description(@"Another reason for the status suspended.")]
    Other,
    
}
