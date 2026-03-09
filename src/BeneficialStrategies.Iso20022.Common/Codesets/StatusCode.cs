// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YgFIuNp-Ed-ak6NoX_4Aeg_-740656164")]
[Description(@"Specifies the status of an instruction.")]
[Derivations(typeof(Status7Code),typeof(Status2Code),typeof(Status6Code),typeof(Status8Code),typeof(Status5Code),typeof(Status3Code),typeof(Status4Code),typeof(Status1Code))]
public enum StatusCode
{
    /// <summary>
    /// Processing of the instruction is pending.
    /// Encoded/decoded by serializers as &quot;PPRC&quot;.
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_YgOSoNp-Ed-ak6NoX_4Aeg_1500868011")]
    [Description(@"Processing of the instruction is pending.")]
    PendingProcessing,
    
    /// <summary>
    /// Instruction has been acknowledged and accepted and is validated for further processing.
    /// Encoded/decoded by serializers as &quot;PAAC&quot;.
    /// </summary>
    [EnumMember(Value = "PAAC")]
    [IsoId("_YgOSodp-Ed-ak6NoX_4Aeg_-446967552")]
    [Description(@"Instruction has been acknowledged and accepted and is validated for further processing.")]
    AcknowledgedAccepted,
    
    /// <summary>
    /// Instruction has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_YgOSotp-Ed-ak6NoX_4Aeg_-698172830")]
    [Description(@"Instruction has been rejected.")]
    Rejected,
    
    /// <summary>
    /// Instruction has been accepted and is validated for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_YgOSo9p-Ed-ak6NoX_4Aeg_-694479303")]
    [Description(@"Instruction has been accepted and is validated for further processing.")]
    Accepted,
    
    /// <summary>
    /// Processing has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_YgOSpNp-Ed-ak6NoX_4Aeg_-685244451")]
    [Description(@"Processing has been completed.")]
    Completed,
    
    /// <summary>
    /// No instruction has been received (to be used in a reminder).
    /// Encoded/decoded by serializers as &quot;NOIN&quot;.
    /// </summary>
    [EnumMember(Value = "NOIN")]
    [IsoId("_YgOSpdp-Ed-ak6NoX_4Aeg_758432688")]
    [Description(@"No instruction has been received (to be used in a reminder).")]
    NotReceived,
    
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_YgOSptp-Ed-ak6NoX_4Aeg_1043799155")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled,
    
    /// <summary>
    /// Cancel request is being processed.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_YgOSp9p-Ed-ak6NoX_4Aeg_1129688256")]
    [Description(@"Cancel request is being processed.")]
    BeingCancelled,
    
    /// <summary>
    /// Instruction has been received by Issuer.
    /// Encoded/decoded by serializers as &quot;RCIS&quot;.
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("_YgOSqNp-Ed-ak6NoX_4Aeg_-1954902093")]
    [Description(@"Instruction has been received by Issuer.")]
    ReceivedByIssuerOrRegistrar,
    
    /// <summary>
    /// Instruction is pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_YgYDoNp-Ed-ak6NoX_4Aeg_794512687")]
    [Description(@"Instruction is pending.")]
    Pending,
    
    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as &quot;STIN&quot;.
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_YgYDodp-Ed-ak6NoX_4Aeg_1776839959")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction,
    
    /// <summary>
    /// Instruction is queued.
    /// Encoded/decoded by serializers as &quot;QUED&quot;.
    /// </summary>
    [EnumMember(Value = "QUED")]
    [IsoId("_kpnyk-5NEeCisYr99QEiWA_-1012013712")]
    [Description(@"Instruction is queued.")]
    Queued,
    
    /// <summary>
    /// Instruction has been cancelled by the agent, for example, due to an event deadline extension.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_FK-_IF6uEeSyc4g_pm5hbw")]
    [Description(@"Instruction has been cancelled by the agent, for example, due to an event deadline extension.")]
    CancelledBySubcustodian,
    
    /// <summary>
    /// Accepted and sent along the chain.
    /// Encoded/decoded by serializers as &quot;FRWD&quot;.
    /// </summary>
    [EnumMember(Value = "FRWD")]
    [IsoId("_CRchELUsEem2T48lBgJbww")]
    [Description(@"Accepted and sent along the chain.")]
    Forwarded,
    
}
