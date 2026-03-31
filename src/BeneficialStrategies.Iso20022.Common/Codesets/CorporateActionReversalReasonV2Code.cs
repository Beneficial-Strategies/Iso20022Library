// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// The reason why a reversal of payment is taking place in corporate action processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DUt1SjQVEe2o-K1dwNg8Gg")]
[Description(
    @"The reason why a reversal of payment is taking place in corporate action processing."
)]
[Derivations(typeof(CorporateActionReversalReason2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionReversalReasonV2Code>))]
#endif
public enum CorporateActionReversalReasonV2Code
{
    /// <summary>
    /// Difference in day count basis.
    /// Encoded/decoded by serializers as &quot;DCBD&quot;.
    /// </summary>
    [EnumMember(Value = "DCBD")]
    [IsoId("_DUt1SzQVEe2o-K1dwNg8Gg")]
    [Description(@"Difference in day count basis.")]
    DayCountBasisDifference,

    /// <summary>
    /// Value date is incorrect.
    /// Encoded/decoded by serializers as &quot;IVAD&quot;.
    /// </summary>
    [EnumMember(Value = "IVAD")]
    [IsoId("_DUt1UDQVEe2o-K1dwNg8Gg")]
    [Description(@"Value date is incorrect.")]
    IncorrectValueDate,

    /// <summary>
    /// Entitlement date is incorrect.
    /// Encoded/decoded by serializers as &quot;IRED&quot;.
    /// </summary>
    [EnumMember(Value = "IRED")]
    [IsoId("_DUt1TDQVEe2o-K1dwNg8Gg")]
    [Description(@"Entitlement date is incorrect.")]
    IncorrectEntitlementDate,

    /// <summary>
    /// Price is incorrect.
    /// Encoded/decoded by serializers as &quot;IPRI&quot;.
    /// </summary>
    [EnumMember(Value = "IPRI")]
    [IsoId("_DUt1TzQVEe2o-K1dwNg8Gg")]
    [Description(@"Price is incorrect.")]
    IncorrectPrice,

    /// <summary>
    /// Payment is not due.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_DUt1TTQVEe2o-K1dwNg8Gg")]
    [Description(@"Payment is not due.")]
    UnduePayment,

    /// <summary>
    /// Event level tax rate is incorrect.
    /// Encoded/decoded by serializers as &quot;IETR&quot;.
    /// </summary>
    [EnumMember(Value = "IETR")]
    [IsoId("_DUt1UTQVEe2o-K1dwNg8Gg")]
    [Description(@"Event level tax rate is incorrect.")]
    IncorrectEventLevelTaxRate,

    /// <summary>
    /// Funds have not been received.
    /// Encoded/decoded by serializers as &quot;FNRC&quot;.
    /// </summary>
    [EnumMember(Value = "FNRC")]
    [IsoId("_DUt1TjQVEe2o-K1dwNg8Gg")]
    [Description(@"Funds have not been received.")]
    FundsNotReceived,

    /// <summary>
    /// Payment will occur outside of clearing system.
    /// Encoded/decoded by serializers as &quot;POCS&quot;.
    /// </summary>
    [EnumMember(Value = "POCS")]
    [IsoId("_DUt1UjQVEe2o-K1dwNg8Gg")]
    [Description(@"Payment will occur outside of clearing system.")]
    PaymentOutsideClearingSystem,

    /// <summary>
    /// Payment currency is incorrect.
    /// Encoded/decoded by serializers as &quot;IPCU&quot;.
    /// </summary>
    [EnumMember(Value = "IPCU")]
    [IsoId("_DUt1UzQVEe2o-K1dwNg8Gg")]
    [Description(@"Payment currency is incorrect.")]
    IncorrectPaymentCurrency,
}
