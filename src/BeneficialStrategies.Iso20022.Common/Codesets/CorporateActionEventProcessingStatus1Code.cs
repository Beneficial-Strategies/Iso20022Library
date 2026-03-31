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
[IsoId("_bDZaAtp-Ed-ak6NoX_4Aeg_771492585")]
[Description(@"Specifies the stage in the corporate action event life cycle.")]
[DerivedFrom(typeof(CorporateActionEventProcessingStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionEventProcessingStatus1Code>))]
#endif
public enum CorporateActionEventProcessingStatus1Code
{
    /// <summary>
    /// Specifies that a corporate action event processing has been completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_bDZaA9p-Ed-ak6NoX_4Aeg_772412579")]
    [Description(@"Specifies that a corporate action event processing has been completed.")]
    Complete = CorporateActionEventProcessingStatusCode.Complete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that a corporate action event processing has not been completed.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_bDZaBNp-Ed-ak6NoX_4Aeg_772412580")]
    [Description(@"Specifies that a corporate action event processing has not been completed.")]
    Pending = CorporateActionEventProcessingStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate action event processing specifying that the funds paid have been reconciled with the funds received from the agent (meaning that there is no more risk of payment to be reversed).
    /// Encoded/decoded by serializers as &quot;RECD&quot;.
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_bDZaBdp-Ed-ak6NoX_4Aeg_772412610")]
    [Description(
        @"Corporate action event processing specifying that the funds paid have been reconciled with the funds received from the agent (meaning that there is no more risk of payment to be reversed)."
    )]
    Reconciled = CorporateActionEventProcessingStatusCode.Reconciled, // same ordinal as derivation source for type conversions
}
