// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external undertaking type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MrKBW7iEeKo25nLKvGr8w_48789685")]
[Description(
    @"Specifies the external undertaking type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalUndertakingTypeCode))]
public enum ExternalUndertakingType1Code
{
    /// <summary>
    /// Undertaking in support of an advance payment obligation.
    /// Encoded/decoded by serializers as &quot;APAY&quot;.
    /// </summary>
    [EnumMember(Value = "APAY")]
    [IsoId("_uR0Ly_RYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of an advance payment obligation.")]
    AdvancePayment = ExternalUndertakingTypeCode.AdvancePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of a commercial obligation.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uR98wvRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a commercial obligation.")]
    Commercial = ExternalUndertakingTypeCode.Commercial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of a customs duty obligation.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_uR98xfRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a customs duty obligation.")]
    Customs = ExternalUndertakingTypeCode.Customs, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking representing the primary means of payment.
    /// Encoded/decoded by serializers as &quot;DPAY&quot;.
    /// </summary>
    [EnumMember(Value = "DPAY")]
    [IsoId("_uR98yPRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking representing the primary means of payment.")]
    DirectPay = ExternalUndertakingTypeCode.DirectPay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of a financial obligation.
    /// Encoded/decoded by serializers as &quot;FINC&quot;.
    /// </summary>
    [EnumMember(Value = "FINC")]
    [IsoId("_uR98y_RYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a financial obligation.")]
    Financial = ExternalUndertakingTypeCode.Financial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of a insurance obligation.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_uR98zvRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a insurance obligation.")]
    Insurance = ExternalUndertakingTypeCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of an Industrial Revenue Board (IRB) obligation.
    /// Encoded/decoded by serializers as &quot;IRBO&quot;.
    /// </summary>
    [EnumMember(Value = "IRBO")]
    [IsoId("_uSHtwvRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of an Industrial Revenue Board (IRB) obligation.")]
    IndustrialRevenueBoard = ExternalUndertakingTypeCode.IndustrialRevenueBoard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of a maintenance obligation.
    /// Encoded/decoded by serializers as &quot;MAIN&quot;.
    /// </summary>
    [EnumMember(Value = "MAIN")]
    [IsoId("_uSHtxfRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a maintenance obligation.")]
    Maintenance = ExternalUndertakingTypeCode.Maintenance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of a payment obligation.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_uSHtyPRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a payment obligation.")]
    Payment = ExternalUndertakingTypeCode.Payment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of a performance obligation.
    /// Encoded/decoded by serializers as &quot;PERF&quot;.
    /// </summary>
    [EnumMember(Value = "PERF")]
    [IsoId("_uSHty_RYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a performance obligation.")]
    Performance = ExternalUndertakingTypeCode.Performance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of a monetary retention obligation.
    /// Encoded/decoded by serializers as &quot;RETN&quot;.
    /// </summary>
    [EnumMember(Value = "RETN")]
    [IsoId("_uSQ3svRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a monetary retention obligation.")]
    Retention = ExternalUndertakingTypeCode.Retention, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of a sea transportation obligation.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_uSQ3tfRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a sea transportation obligation.")]
    Shipping = ExternalUndertakingTypeCode.Shipping, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of a tender or bid obligation.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_uSQ3uPRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a tender or bid obligation.")]
    TenderOrBid = ExternalUndertakingTypeCode.TenderOrBid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Undertaking in support of a warranty obligation.
    /// Encoded/decoded by serializers as &quot;WARR&quot;.
    /// </summary>
    [EnumMember(Value = "WARR")]
    [IsoId("_uSQ3u_RYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a warranty obligation.")]
    Warranty = ExternalUndertakingTypeCode.Warranty, // same ordinal as derivation source for type conversions
}
