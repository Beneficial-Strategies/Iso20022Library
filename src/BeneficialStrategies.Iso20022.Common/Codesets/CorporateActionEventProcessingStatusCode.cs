// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the stage in the corporate action event life cycle.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bDZaBtp-Ed-ak6NoX_4Aeg_391924005")]
[Description(@"Specifies the stage in the corporate action event life cycle.")]
[Derivations(typeof(CorporateActionEventProcessingStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionEventProcessingStatusCode>))]
#endif
public enum CorporateActionEventProcessingStatusCode
{
    /// <summary>
    /// Specifies that a corporate action event processing has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_bDZaB9p-Ed-ak6NoX_4Aeg_428864814")]
    [Description(@"Specifies that a corporate action event processing has been completed.")]
    Complete,

    /// <summary>
    /// Specifies that a corporate action event processing has not been completed.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_bDZaCNp-Ed-ak6NoX_4Aeg_429787479")]
    [Description(@"Specifies that a corporate action event processing has not been completed.")]
    Pending,

    /// <summary>
    /// Corporate action event processing specifying that the funds paid have been reconciled with the funds received from the agent (meaning that there is no more risk of payment to be reversed).
    /// Encoded/decoded by serializers as &quot;RECD&quot;.
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_bDij8Np-Ed-ak6NoX_4Aeg_430710847")]
    [Description(
        @"Corporate action event processing specifying that the funds paid have been reconciled with the funds received from the agent (meaning that there is no more risk of payment to be reversed)."
    )]
    Reconciled,
}
