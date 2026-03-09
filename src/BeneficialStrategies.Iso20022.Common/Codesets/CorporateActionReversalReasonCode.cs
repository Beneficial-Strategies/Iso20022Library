// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// The reason why a reversal of payment is taking place in corporate action processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bS5OlNp-Ed-ak6NoX_4Aeg_-778821731")]
[Description(@"The reason why a reversal of payment is taking place in corporate action processing.")]
[Derivations(typeof(CorporateActionReversalReason1Code))]
public enum CorporateActionReversalReasonCode
{
    /// <summary>
    /// Difference in day count basis.
    /// Encoded/decoded by serializers as &quot;DCBD&quot;.
    /// </summary>
    [EnumMember(Value = "DCBD")]
    [IsoId("_bS5Oldp-Ed-ak6NoX_4Aeg_-1428563859")]
    [Description(@"Difference in day count basis.")]
    DayCountBasisDifference,
    
    /// <summary>
    /// Value date is incorrect.
    /// Encoded/decoded by serializers as &quot;IVAD&quot;.
    /// </summary>
    [EnumMember(Value = "IVAD")]
    [IsoId("_bS5Oltp-Ed-ak6NoX_4Aeg_799981597")]
    [Description(@"Value date is incorrect.")]
    IncorrectValueDate,
    
    /// <summary>
    /// Record date is incorrect.
    /// Encoded/decoded by serializers as &quot;IRED&quot;.
    /// </summary>
    [EnumMember(Value = "IRED")]
    [IsoId("_bS5Ol9p-Ed-ak6NoX_4Aeg_1884344473")]
    [Description(@"Record date is incorrect.")]
    IncorrectRecordDate,
    
    /// <summary>
    /// Price is incorrect.
    /// Encoded/decoded by serializers as &quot;IPRI&quot;.
    /// </summary>
    [EnumMember(Value = "IPRI")]
    [IsoId("_bS5OmNp-Ed-ak6NoX_4Aeg_105995277")]
    [Description(@"Price is incorrect.")]
    IncorrectPrice,
    
    /// <summary>
    /// Payment is not due.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_bTCYgNp-Ed-ak6NoX_4Aeg_-184661511")]
    [Description(@"Payment is not due.")]
    UnduePayment,
    
    /// <summary>
    /// Event level tax rate is incorrect.
    /// Encoded/decoded by serializers as &quot;IETR&quot;.
    /// </summary>
    [EnumMember(Value = "IETR")]
    [IsoId("_bTCYgdp-Ed-ak6NoX_4Aeg_-877803107")]
    [Description(@"Event level tax rate is incorrect.")]
    IncorrectEventLevelTaxRate,
    
    /// <summary>
    /// Funds have not been received.
    /// Encoded/decoded by serializers as &quot;FNRC&quot;.
    /// </summary>
    [EnumMember(Value = "FNRC")]
    [IsoId("_bTCYgtp-Ed-ak6NoX_4Aeg_1770618939")]
    [Description(@"Funds have not been received.")]
    FundsNotReceived,
    
    /// <summary>
    /// Payment will occur outside of clearing system.
    /// Encoded/decoded by serializers as &quot;POCS&quot;.
    /// </summary>
    [EnumMember(Value = "POCS")]
    [IsoId("_bTCYg9p-Ed-ak6NoX_4Aeg_1852575497")]
    [Description(@"Payment will occur outside of clearing system.")]
    PaymentOutsideClearingSystem,
    
    /// <summary>
    /// Payment currency is incorrect.
    /// Encoded/decoded by serializers as &quot;IPCU&quot;.
    /// </summary>
    [EnumMember(Value = "IPCU")]
    [IsoId("_bTCYhNp-Ed-ak6NoX_4Aeg_-283866971")]
    [Description(@"Payment currency is incorrect.")]
    IncorrectPaymentCurrency,
    
}
