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
[IsoId("_-M07AG7iEeKo25nLKvGr8w_-1585779072")]
[Description(
    @"Specifies the external undertaking type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalUndertakingType1Code))]
public enum ExternalUndertakingTypeCode
{
    /// <summary>
    /// Undertaking in support of an advance payment obligation.
    /// Encoded/decoded by serializers as &quot;APAY&quot;.
    /// </summary>
    [EnumMember(Value = "APAY")]
    [IsoId("_uR0LyfRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of an advance payment obligation.")]
    AdvancePayment,

    /// <summary>
    /// Undertaking in support of a commercial obligation.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uR98wPRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a commercial obligation.")]
    Commercial,

    /// <summary>
    /// Undertaking in support of a customs duty obligation.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_uR98w_RYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a customs duty obligation.")]
    Customs,

    /// <summary>
    /// Undertaking representing the primary means of payment.
    /// Encoded/decoded by serializers as &quot;DPAY&quot;.
    /// </summary>
    [EnumMember(Value = "DPAY")]
    [IsoId("_uR98xvRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking representing the primary means of payment.")]
    DirectPay,

    /// <summary>
    /// Undertaking in support of a financial obligation.
    /// Encoded/decoded by serializers as &quot;FINC&quot;.
    /// </summary>
    [EnumMember(Value = "FINC")]
    [IsoId("_uR98yfRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a financial obligation.")]
    Financial,

    /// <summary>
    /// Undertaking in support of a insurance obligation.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_uR98zPRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a insurance obligation.")]
    Insurance,

    /// <summary>
    /// Undertaking in support of an Industrial Revenue Board (IRB) obligation.
    /// Encoded/decoded by serializers as &quot;IRBO&quot;.
    /// </summary>
    [EnumMember(Value = "IRBO")]
    [IsoId("_uSHtwPRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of an Industrial Revenue Board (IRB) obligation.")]
    IndustrialRevenueBoard,

    /// <summary>
    /// Undertaking in support of a maintenance obligation.
    /// Encoded/decoded by serializers as &quot;MAIN&quot;.
    /// </summary>
    [EnumMember(Value = "MAIN")]
    [IsoId("_uSHtw_RYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a maintenance obligation.")]
    Maintenance,

    /// <summary>
    /// Undertaking in support of a payment obligation.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_uSHtxvRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a payment obligation.")]
    Payment,

    /// <summary>
    /// Undertaking in support of a performance obligation.
    /// Encoded/decoded by serializers as &quot;PERF&quot;.
    /// </summary>
    [EnumMember(Value = "PERF")]
    [IsoId("_uSHtyfRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a performance obligation.")]
    Performance,

    /// <summary>
    /// Undertaking in support of a monetary retention obligation.
    /// Encoded/decoded by serializers as &quot;RETN&quot;.
    /// </summary>
    [EnumMember(Value = "RETN")]
    [IsoId("_uSQ3sPRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a monetary retention obligation.")]
    Retention,

    /// <summary>
    /// Undertaking in support of a sea transportation obligation.
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_uSQ3s_RYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a sea transportation obligation.")]
    Shipping,

    /// <summary>
    /// Undertaking in support of a tender or bid obligation.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_uSQ3tvRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a tender or bid obligation.")]
    TenderOrBid,

    /// <summary>
    /// Undertaking in support of a warranty obligation.
    /// Encoded/decoded by serializers as &quot;WARR&quot;.
    /// </summary>
    [EnumMember(Value = "WARR")]
    [IsoId("_uSQ3ufRYEeuLhpyIdtJzwg")]
    [Description(@"Undertaking in support of a warranty obligation.")]
    Warranty,
}
