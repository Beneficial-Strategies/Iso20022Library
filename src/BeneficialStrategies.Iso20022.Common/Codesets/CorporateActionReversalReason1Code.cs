// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// The reason why a reversal of payment is taking place in corporate action processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bSvdk9p-Ed-ak6NoX_4Aeg_-1715926142")]
[Description(@"The reason why a reversal of payment is taking place in corporate action processing.")]
[DerivedFrom(typeof(CorporateActionReversalReasonCode))]
public enum CorporateActionReversalReason1Code
{
    /// <summary>
    /// Difference in day count basis.
    /// Encoded/decoded by serializers as &quot;DCBD&quot;.
    /// </summary>
    [EnumMember(Value = "DCBD")]
    [IsoId("_bSvdlNp-Ed-ak6NoX_4Aeg_-788141094")]
    [Description(@"Difference in day count basis.")]
    DayCountBasisDifference = CorporateActionReversalReasonCode.DayCountBasisDifference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value date is incorrect.
    /// Encoded/decoded by serializers as &quot;IVAD&quot;.
    /// </summary>
    [EnumMember(Value = "IVAD")]
    [IsoId("_bSvdldp-Ed-ak6NoX_4Aeg_262991978")]
    [Description(@"Value date is incorrect.")]
    IncorrectValueDate = CorporateActionReversalReasonCode.IncorrectValueDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Record date is incorrect.
    /// Encoded/decoded by serializers as &quot;IRED&quot;.
    /// </summary>
    [EnumMember(Value = "IRED")]
    [IsoId("_bSvdltp-Ed-ak6NoX_4Aeg_1730140741")]
    [Description(@"Record date is incorrect.")]
    IncorrectRecordDate = CorporateActionReversalReasonCode.IncorrectRecordDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is incorrect.
    /// Encoded/decoded by serializers as &quot;IPRI&quot;.
    /// </summary>
    [EnumMember(Value = "IPRI")]
    [IsoId("_bSvdl9p-Ed-ak6NoX_4Aeg_-801672235")]
    [Description(@"Price is incorrect.")]
    IncorrectPrice = CorporateActionReversalReasonCode.IncorrectPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is not due.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_bSvdmNp-Ed-ak6NoX_4Aeg_2118370049")]
    [Description(@"Payment is not due.")]
    UnduePayment = CorporateActionReversalReasonCode.UnduePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event level tax rate is incorrect.
    /// Encoded/decoded by serializers as &quot;IETR&quot;.
    /// </summary>
    [EnumMember(Value = "IETR")]
    [IsoId("_bS5OkNp-Ed-ak6NoX_4Aeg_-709448484")]
    [Description(@"Event level tax rate is incorrect.")]
    IncorrectEventLevelTaxRate = CorporateActionReversalReasonCode.IncorrectEventLevelTaxRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Funds have not been received.
    /// Encoded/decoded by serializers as &quot;FNRC&quot;.
    /// </summary>
    [EnumMember(Value = "FNRC")]
    [IsoId("_bS5Okdp-Ed-ak6NoX_4Aeg_1483338203")]
    [Description(@"Funds have not been received.")]
    FundsNotReceived = CorporateActionReversalReasonCode.FundsNotReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment will occur outside of clearing system.
    /// Encoded/decoded by serializers as &quot;POCS&quot;.
    /// </summary>
    [EnumMember(Value = "POCS")]
    [IsoId("_bS5Oktp-Ed-ak6NoX_4Aeg_-1344480330")]
    [Description(@"Payment will occur outside of clearing system.")]
    PaymentOutsideClearingSystem = CorporateActionReversalReasonCode.PaymentOutsideClearingSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment currency is incorrect.
    /// Encoded/decoded by serializers as &quot;IPCU&quot;.
    /// </summary>
    [EnumMember(Value = "IPCU")]
    [IsoId("_bS5Ok9p-Ed-ak6NoX_4Aeg_486265850")]
    [Description(@"Payment currency is incorrect.")]
    IncorrectPaymentCurrency = CorporateActionReversalReasonCode.IncorrectPaymentCurrency, // same ordinal as derivation source for type conversions
    
}
