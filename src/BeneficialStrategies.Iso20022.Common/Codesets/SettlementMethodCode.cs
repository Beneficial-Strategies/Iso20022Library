// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used to settle the payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZMMAwdp-Ed-ak6NoX_4Aeg_712208049")]
[Description(@"Specifies the method used to settle the payment instruction.")]
[Derivations(typeof(SettlementMethod1Code), typeof(SettlementMethod2Code))]
public enum SettlementMethodCode
{
    /// <summary>
    /// Settlement is done by the agent instructed to execute a payment instruction.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_ZMMAwtp-Ed-ak6NoX_4Aeg_712208109")]
    [Description(@"Settlement is done by the agent instructed to execute a payment instruction.")]
    InstructedAgent,

    /// <summary>
    /// Settlement is done by the agent instructing and forwarding the payment to the next party in the payment chain.
    /// Encoded/decoded by serializers as &quot;INGA&quot;.
    /// </summary>
    [EnumMember(Value = "INGA")]
    [IsoId("_ZMMAw9p-Ed-ak6NoX_4Aeg_712208401")]
    [Description(
        @"Settlement is done by the agent instructing and forwarding the payment to the next party in the payment chain."
    )]
    InstructingAgent,

    /// <summary>
    /// Settlement is done through a cover payment.
    /// Encoded/decoded by serializers as &quot;COVE&quot;.
    /// </summary>
    [EnumMember(Value = "COVE")]
    [IsoId("_ZMMAxNp-Ed-ak6NoX_4Aeg_712208436")]
    [Description(@"Settlement is done through a cover payment.")]
    CoverMethod,

    /// <summary>
    /// Settlement is done through a payment clearing system.
    /// Encoded/decoded by serializers as &quot;CLRG&quot;.
    /// </summary>
    [EnumMember(Value = "CLRG")]
    [IsoId("_ZMMAxdp-Ed-ak6NoX_4Aeg_712208478")]
    [Description(@"Settlement is done through a payment clearing system.")]
    ClearingSystem,
}
