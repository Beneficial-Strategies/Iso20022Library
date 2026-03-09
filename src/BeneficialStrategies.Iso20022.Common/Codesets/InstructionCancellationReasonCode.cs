// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction is cancelled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aXSh99p-Ed-ak6NoX_4Aeg_-840499374")]
[Description(@"Specifies the reason why the instruction is cancelled.")]
[Derivations(typeof(InstructionCancellationReason1Code),typeof(InstructionCancellationReason2Code))]
public enum InstructionCancellationReasonCode
{
    /// <summary>
    /// Instruction has been cancelled as per your request.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_aXSh-Np-Ed-ak6NoX_4Aeg_-771235883")]
    [Description(@"Instruction has been cancelled as per your request.")]
    CancelledByYourselves,
    
    /// <summary>
    /// Instruction has been cancelled by the settlement system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_aXSh-dp-Ed-ak6NoX_4Aeg_-770312763")]
    [Description(@"Instruction has been cancelled by the settlement system.")]
    CancelledBySystem,
    
    /// <summary>
    /// Instruction has been cancelled by the agent.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_aXbr4Np-Ed-ak6NoX_4Aeg_-770309481")]
    [Description(@"Instruction has been cancelled by the agent.")]
    CancelledByAgent,
    
    /// <summary>
    /// Instruction has been cancelled by another party than the instructing party, for example, market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_aXbr4dp-Ed-ak6NoX_4Aeg_-1704654533")]
    [Description(@"Instruction has been cancelled by another party than the instructing party, for example, market infrastructure such as a stock exchange.")]
    CancelledByAnotherParty,
    
    /// <summary>
    /// Original instruction has been cancelled and replaced due to a corporate action.
    /// Encoded/decoded by serializers as &quot;CANT&quot;.
    /// </summary>
    [EnumMember(Value = "CANT")]
    [IsoId("_aXbr4tp-Ed-ak6NoX_4Aeg_1715801321")]
    [Description(@"Original instruction has been cancelled and replaced due to a corporate action.")]
    CancelledDueToTransformation,
    
    /// <summary>
    /// Original instruction has been cancelled and replaced to allow a partial or split settlement.
    /// Encoded/decoded by serializers as &quot;CANZ&quot;.
    /// </summary>
    [EnumMember(Value = "CANZ")]
    [IsoId("_aXbr49p-Ed-ak6NoX_4Aeg_2120300731")]
    [Description(@"Original instruction has been cancelled and replaced to allow a partial or split settlement.")]
    CancelledDueToSplitPartialSettlement,
    
    /// <summary>
    /// Instruction has been cancelled due to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_aXbr5Np-Ed-ak6NoX_4Aeg_-2115560426")]
    [Description(@"Instruction has been cancelled due to a corporate action.")]
    CancelledDueToCorporateAction,
    
    /// <summary>
    /// Instruction has been cancelled by the issuer/registrar.
    /// Encoded/decoded by serializers as &quot;CREG&quot;.
    /// </summary>
    [EnumMember(Value = "CREG")]
    [IsoId("_aXbr5dp-Ed-ak6NoX_4Aeg_-2108172228")]
    [Description(@"Instruction has been cancelled by the issuer/registrar.")]
    CancelledByIssuerRegistrar,
    
    /// <summary>
    /// Instruction has expired.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_aXbr5tp-Ed-ak6NoX_4Aeg_-2107248676")]
    [Description(@"Instruction has expired.")]
    Expired,
    
    /// <summary>
    /// Instruction has been cancelled; the security no longer exists or is no longer eligible on the market instructed. For corporate action related cancellation, CORP should be used.
    /// Encoded/decoded by serializers as &quot;SCEX&quot;.
    /// </summary>
    [EnumMember(Value = "SCEX")]
    [IsoId("_aXbr59p-Ed-ak6NoX_4Aeg_-2105401420")]
    [Description(@"Instruction has been cancelled; the security no longer exists or is no longer eligible on the market instructed. For corporate action related cancellation, CORP should be used.")]
    SecuritiesNoLongerEligible,
    
}
