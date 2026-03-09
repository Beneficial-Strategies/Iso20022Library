// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used to settle the credit transfer instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZMCPxtp-Ed-ak6NoX_4Aeg_-673388484")]
[Description(@"Specifies the method used to settle the credit transfer instruction.")]
[DerivedFrom(typeof(SettlementMethodCode))]
public enum SettlementMethod2Code
{
    /// <summary>
    /// Settlement is done by the agent instructed to execute a payment instruction.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_ZMCPx9p-Ed-ak6NoX_4Aeg_-673388466")]
    [Description(@"Settlement is done by the agent instructed to execute a payment instruction.")]
    InstructedAgent = SettlementMethodCode.InstructedAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is done by the agent instructing and forwarding the payment to the next party in the payment chain.
    /// Encoded/decoded by serializers as &quot;INGA&quot;.
    /// </summary>
    [EnumMember(Value = "INGA")]
    [IsoId("_ZMCPyNp-Ed-ak6NoX_4Aeg_-673388449")]
    [Description(@"Settlement is done by the agent instructing and forwarding the payment to the next party in the payment chain.")]
    InstructingAgent = SettlementMethodCode.InstructingAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is done through a payment clearing system.
    /// Encoded/decoded by serializers as &quot;CLRG&quot;.
    /// </summary>
    [EnumMember(Value = "CLRG")]
    [IsoId("_ZMMAwNp-Ed-ak6NoX_4Aeg_-673388407")]
    [Description(@"Settlement is done through a payment clearing system.")]
    ClearingSystem = SettlementMethodCode.ClearingSystem, // same ordinal as derivation source for type conversions
    
}
