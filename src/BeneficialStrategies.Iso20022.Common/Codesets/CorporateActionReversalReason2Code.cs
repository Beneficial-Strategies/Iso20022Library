// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why a reversal of payment is taking place in corporate action processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WIh5kDQVEe2o-K1dwNg8Gg")]
[Description(
    @"Specifies the reason why a reversal of payment is taking place in corporate action processing."
)]
[DerivedFrom(typeof(CorporateActionReversalReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionReversalReason2Code>))]
#endif
public enum CorporateActionReversalReason2Code
{
    /// <summary>
    /// Difference in day count basis.
    /// Encoded/decoded by serializers as &quot;DCBD&quot;.
    /// </summary>
    [EnumMember(Value = "DCBD")]
    [IsoId("_bu5sMTQVEe2o-K1dwNg8Gg")]
    [Description(@"Difference in day count basis.")]
    DayCountBasisDifference = CorporateActionReversalReasonV2Code.DayCountBasisDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds have not been received.
    /// Encoded/decoded by serializers as &quot;FNRC&quot;.
    /// </summary>
    [EnumMember(Value = "FNRC")]
    [IsoId("_b8T2EjQVEe2o-K1dwNg8Gg")]
    [Description(@"Funds have not been received.")]
    FundsNotReceived = CorporateActionReversalReasonV2Code.FundsNotReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entitlement date is incorrect.
    /// Encoded/decoded by serializers as &quot;IRED&quot;.
    /// </summary>
    [EnumMember(Value = "IRED")]
    [IsoId("_cI-ZEjQVEe2o-K1dwNg8Gg")]
    [Description(@"Entitlement date is incorrect.")]
    IncorrectEntitlementDate = CorporateActionReversalReasonV2Code.IncorrectEntitlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event level tax rate is incorrect.
    /// Encoded/decoded by serializers as &quot;IETR&quot;.
    /// </summary>
    [EnumMember(Value = "IETR")]
    [IsoId("_cLqgsTQVEe2o-K1dwNg8Gg")]
    [Description(@"Event level tax rate is incorrect.")]
    IncorrectEventLevelTaxRate = CorporateActionReversalReasonV2Code.IncorrectEventLevelTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment currency is incorrect.
    /// Encoded/decoded by serializers as &quot;IPCU&quot;.
    /// </summary>
    [EnumMember(Value = "IPCU")]
    [IsoId("_cVDGMTQVEe2o-K1dwNg8Gg")]
    [Description(@"Payment currency is incorrect.")]
    IncorrectPaymentCurrency = CorporateActionReversalReasonV2Code.IncorrectPaymentCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is incorrect.
    /// Encoded/decoded by serializers as &quot;IPRI&quot;.
    /// </summary>
    [EnumMember(Value = "IPRI")]
    [IsoId("_celcsjQVEe2o-K1dwNg8Gg")]
    [Description(@"Price is incorrect.")]
    IncorrectPrice = CorporateActionReversalReasonV2Code.IncorrectPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value date is incorrect.
    /// Encoded/decoded by serializers as &quot;IVAD&quot;.
    /// </summary>
    [EnumMember(Value = "IVAD")]
    [IsoId("_chRkUTQVEe2o-K1dwNg8Gg")]
    [Description(@"Value date is incorrect.")]
    IncorrectValueDate = CorporateActionReversalReasonV2Code.IncorrectValueDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment will occur outside of clearing system.
    /// Encoded/decoded by serializers as &quot;POCS&quot;.
    /// </summary>
    [EnumMember(Value = "POCS")]
    [IsoId("_cj9E4TQVEe2o-K1dwNg8Gg")]
    [Description(@"Payment will occur outside of clearing system.")]
    PaymentOutsideClearingSystem = CorporateActionReversalReasonV2Code.PaymentOutsideClearingSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is not due.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_cmyWcTQVEe2o-K1dwNg8Gg")]
    [Description(@"Payment is not due.")]
    UnduePayment = CorporateActionReversalReasonV2Code.UnduePayment, // same ordinal as derivation source for type conversions
}
