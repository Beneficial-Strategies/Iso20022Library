// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Service provided by the card payment transaction, in addition to the main service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DgRJ8TAXEeOqioR9srQH1g")]
[Description(@"Service provided by the card payment transaction, in addition to the main service.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType6Code
{
    /// <summary>
    /// Aggregation of low payments.
    /// Encoded/decoded by serializers as &quot;AGGR&quot;.
    /// </summary>
    [EnumMember(Value = "AGGR")]
    [IsoId("_DwySMTAXEeOqioR9srQH1g")]
    [Description(@"Aggregation of low payments.")]
    Aggregation = CardPaymentServiceTypeCode.Aggregation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dynamic currency conversion (DCC).
    /// Encoded/decoded by serializers as &quot;DCCV&quot;.
    /// </summary>
    [EnumMember(Value = "DCCV")]
    [IsoId("_DwySMzAXEeOqioR9srQH1g")]
    [Description(@"Dynamic currency conversion (DCC).")]
    DCC = CardPaymentServiceTypeCode.DCC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment with gratuity.
    /// Encoded/decoded by serializers as &quot;GRTT&quot;.
    /// </summary>
    [EnumMember(Value = "GRTT")]
    [IsoId("_DwySNTAXEeOqioR9srQH1g")]
    [Description(@"Card payment with gratuity.")]
    Gratuity = CardPaymentServiceTypeCode.Gratuity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loyalty services.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_DwySOTAXEeOqioR9srQH1g")]
    [Description(@"Loyalty services.")]
    Loyalty = CardPaymentServiceTypeCode.Loyalty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No show after reservation.
    /// Encoded/decoded by serializers as &quot;NRES&quot;.
    /// </summary>
    [EnumMember(Value = "NRES")]
    [IsoId("_DwySOzAXEeOqioR9srQH1g")]
    [Description(@"No show after reservation.")]
    NoShow = CardPaymentServiceTypeCode.NoShow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Purchase and corporate data.
    /// Encoded/decoded by serializers as &quot;PUCO&quot;.
    /// </summary>
    [EnumMember(Value = "PUCO")]
    [IsoId("_DwySPTAXEeOqioR9srQH1g")]
    [Description(@"Purchase and corporate data.")]
    PurchaseCorporate = CardPaymentServiceTypeCode.PurchaseCorporate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Recurring payment.
    /// Encoded/decoded by serializers as &quot;RECP&quot;.
    /// </summary>
    [EnumMember(Value = "RECP")]
    [IsoId("_DwySPzAXEeOqioR9srQH1g")]
    [Description(@"Recurring payment.")]
    RecurringPayment = CardPaymentServiceTypeCode.RecurringPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Solicited available funds.
    /// Encoded/decoded by serializers as &quot;SOAF&quot;.
    /// </summary>
    [EnumMember(Value = "SOAF")]
    [IsoId("_DwySQTAXEeOqioR9srQH1g")]
    [Description(@"Solicited available funds.")]
    SolicitedAvailableFunds = CardPaymentServiceTypeCode.SolicitedAvailableFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Voice authorisation.
    /// Encoded/decoded by serializers as &quot;VCAU&quot;.
    /// </summary>
    [EnumMember(Value = "VCAU")]
    [IsoId("_DwySRTAXEeOqioR9srQH1g")]
    [Description(@"Voice authorisation.")]
    VoiceAuthorisation = CardPaymentServiceTypeCode.VoiceAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instalment payment transaction performed by the card issuer.
    /// Encoded/decoded by serializers as &quot;INSI&quot;.
    /// </summary>
    [EnumMember(Value = "INSI")]
    [IsoId("_HS68MTAXEeOqioR9srQH1g")]
    [Description(@"Instalment payment transaction performed by the card issuer.")]
    IssuerInstalment = CardPaymentServiceTypeCode.IssuerInstalment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instalment payment transaction performed by the acceptor or the acquirer.
    /// Encoded/decoded by serializers as &quot;INSA&quot;.
    /// </summary>
    [EnumMember(Value = "INSA")]
    [IsoId("_Hvx3UzAXEeOqioR9srQH1g")]
    [Description(@"Instalment payment transaction performed by the acceptor or the acquirer.")]
    AcceptorInstalment = CardPaymentServiceTypeCode.AcceptorInstalment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment with cash-back.
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_Yf8poUuGEeOC3MFxIpMwug")]
    [Description(@"Card payment with cash-back.")]
    CashBack = CardPaymentServiceTypeCode.CashBack, // same ordinal as derivation source for type conversions
}
