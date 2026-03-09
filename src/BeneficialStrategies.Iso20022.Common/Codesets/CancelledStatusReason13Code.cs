// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MrDa8f5DEeClUvPNHKL9Zw")]
[Description(@"Specifies the underlying reason for the cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
public enum CancelledStatusReason13Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_MrNL9f5DEeClUvPNHKL9Zw")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself = CancelledStatusReasonV2Code.CancelledByYourself, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_MrNL-f5DEeClUvPNHKL9Zw")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem = CancelledStatusReasonV2Code.CancelledBySystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been cancelled by the agent due to an event deadline extension.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_MrNL_f5DEeClUvPNHKL9Zw")]
    [Description(@"Instruction has been cancelled by the agent due to an event deadline extension.")]
    CancelledByAgent = CancelledStatusReasonV2Code.CancelledByAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is rejected by the executing party, the rejection is final therefore the order is cancelled in the system.
    /// Encoded/decoded by serializers as &quot;CXLR&quot;.
    /// </summary>
    [EnumMember(Value = "CXLR")]
    [IsoId("_MrNMAf5DEeClUvPNHKL9Zw")]
    [Description(@"Transaction is rejected by the executing party, the rejection is final therefore the order is cancelled in the system.")]
    EndOfLife = CancelledStatusReasonV2Code.EndOfLife, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original transaction has been cancelled and replaced due to a corporate action.
    /// Encoded/decoded by serializers as &quot;CANT&quot;.
    /// </summary>
    [EnumMember(Value = "CANT")]
    [IsoId("_MrNMBf5DEeClUvPNHKL9Zw")]
    [Description(@"Original transaction has been cancelled and replaced due to a corporate action.")]
    CancelledDueToTransformation = CancelledStatusReasonV2Code.CancelledDueToTransformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original transaction has been cancelled and replaced to allow a partial or split settlement.
    /// Encoded/decoded by serializers as &quot;CANZ&quot;.
    /// </summary>
    [EnumMember(Value = "CANZ")]
    [IsoId("_MrNMCf5DEeClUvPNHKL9Zw")]
    [Description(@"Original transaction has been cancelled and replaced to allow a partial or split settlement.")]
    CancelledSplitPartialSettlement = CancelledStatusReasonV2Code.CancelledSplitPartialSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been cancelled due to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_MrNMDf5DEeClUvPNHKL9Zw")]
    [Description(@"Transaction has been cancelled due to a corporate action.")]
    CancelledDueToCorporateAction = CancelledStatusReasonV2Code.CancelledDueToCorporateAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been cancelled; the security no longer exists or is no longer eligible on the market instructed. For corporate action related cancellation, CORP should be used.
    /// Encoded/decoded by serializers as &quot;SCEX&quot;.
    /// </summary>
    [EnumMember(Value = "SCEX")]
    [IsoId("_MrNMEf5DEeClUvPNHKL9Zw")]
    [Description(@"Transaction has been cancelled; the security no longer exists or is no longer eligible on the market instructed. For corporate action related cancellation, CORP should be used.")]
    SecuritiesNoLongerEligible = CancelledStatusReasonV2Code.SecuritiesNoLongerEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_MrNMFf5DEeClUvPNHKL9Zw")]
    [Description(@"Other. See Narrative.")]
    Other = CancelledStatusReasonV2Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is cancelled by a Third party.
    /// Encoded/decoded by serializers as &quot;CTHP&quot;.
    /// </summary>
    [EnumMember(Value = "CTHP")]
    [IsoId("_aAG31v8EEeCQhsjxt9aFqg")]
    [Description(@"Instruction is cancelled by a Third party.")]
    CancelledByThirdParty = CancelledStatusReasonV2Code.CancelledByThirdParty, // same ordinal as derivation source for type conversions
    
}
