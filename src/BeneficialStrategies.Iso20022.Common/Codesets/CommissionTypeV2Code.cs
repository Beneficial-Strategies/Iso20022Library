// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service for which the commission is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bAHcidp-Ed-ak6NoX_4Aeg_-432346988")]
[Description(@"Type of service for which the commission is asked or paid.")]
[Derivations(typeof(CommissionType7Code),typeof(CommissionType9Code),typeof(CommissionType6Code),typeof(CommissionType8Code))]
public enum CommissionTypeV2Code
{
    /// <summary>
    /// Commission is as per client agreement.
    /// Encoded/decoded by serializers as &quot;CLDI&quot;.
    /// </summary>
    [EnumMember(Value = "CLDI")]
    [IsoId("_bAQmcNp-Ed-ak6NoX_4Aeg_-1399219470")]
    [Description(@"Commission is as per client agreement.")]
    ClientDirected,
    
    /// <summary>
    /// Commission for a step-out trade, charged by the step-out broker.
    /// Encoded/decoded by serializers as &quot;STEP&quot;.
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("_bAQmcdp-Ed-ak6NoX_4Aeg_-1358582222")]
    [Description(@"Commission for a step-out trade, charged by the step-out broker.")]
    StepOut,
    
    /// <summary>
    /// Commission for subscribing to an investment, paid at the time of the subscription.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_bAQmctp-Ed-ak6NoX_4Aeg_-17686913")]
    [Description(@"Commission for subscribing to an investment, paid at the time of the subscription.")]
    FrontEndLoad,
    
    /// <summary>
    /// Commission paid at the time of first subscription.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_bAQmc9p-Ed-ak6NoX_4Aeg_-312665787")]
    [Description(@"Commission paid at the time of first subscription.")]
    Initial,
    
    /// <summary>
    /// Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_bAQmdNp-Ed-ak6NoX_4Aeg_-17686912")]
    [Description(@"Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time.")]
    BackEndLoad,
    
    /// <summary>
    /// Commission that is calculated on the position of an account.
    /// Encoded/decoded by serializers as &quot;TRAI&quot;.
    /// </summary>
    [EnumMember(Value = "TRAI")]
    [IsoId("_bAQmddp-Ed-ak6NoX_4Aeg_24796866")]
    [Description(@"Commission that is calculated on the position of an account.")]
    Trailer,
    
    /// <summary>
    /// Commission that is regular.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_bAQmdtp-Ed-ak6NoX_4Aeg_-1056301507")]
    [Description(@"Commission that is regular.")]
    Regular,
    
    /// <summary>
    /// Commission for a step-in trade, charged by the step-in broker.
    /// Encoded/decoded by serializers as &quot;STEI&quot;.
    /// </summary>
    [EnumMember(Value = "STEI")]
    [IsoId("_bAQmd9p-Ed-ak6NoX_4Aeg_-1056301506")]
    [Description(@"Commission for a step-in trade, charged by the step-in broker.")]
    StepIn,
    
    /// <summary>
    /// Commission designated by the broker for third party services. The soft dollar arrangement refers to an arrangement wherean investment manager directs transactions to a brokerand, in exchange, the broker provides brokerage and research services to the investment manager. Soft dollar arrangements include proprietary and third party research arrangements, but do not include client-directed brokerage arrangements. The U.S. Securities Exchange Act of 1934, Section 238(e), created a &quot;safe harbor&quot; to protect investment managers from claims that they had breached their fiduciary duties by using their client commissions to pay a higher commission than they might have paid for execution services to acquire investment research. The SEC defines soft dollars as: The Commission has defined soft dollar practices as arrangements under which products or services, other than execution of securities transactions, are obtained through an adviser or a broker-dealer in exchange for the direction by the adviser of client brokerage transactions to the broker-dealer. An individual or firm must exercise &quot;investment discretion&quot; over an account, as defined in Section 3(a)(35) of the Exchange Act, in order to use client commissions to obtain research under Section 28(e) of the Exchange Act (&quot;Section 28(e)&quot;).
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_bAaXcNp-Ed-ak6NoX_4Aeg_-1056301505")]
    [Description(@"Commission designated by the broker for third party services. The soft dollar arrangement refers to an arrangement wherean investment manager directs transactions to a brokerand, in exchange, the broker provides brokerage and research services to the investment manager. Soft dollar arrangements include proprietary and third party research arrangements, but do not include client-directed brokerage arrangements. The U.S. Securities Exchange Act of 1934, Section 238(e), created a ""safe harbor"" to protect investment managers from claims that they had breached their fiduciary duties by using their client commissions to pay a higher commission than they might have paid for execution services to acquire investment research. The SEC defines soft dollars as: The Commission has defined soft dollar practices as arrangements under which products or services, other than execution of securities transactions, are obtained through an adviser or a broker-dealer in exchange for the direction by the adviser of client brokerage transactions to the broker-dealer. An individual or firm must exercise ""investment discretion"" over an account, as defined in Section 3(a)(35) of the Exchange Act, in order to use client commissions to obtain research under Section 28(e) of the Exchange Act (""Section 28(e)"").")]
    SoftDollar,
    
    /// <summary>
    /// Commission that combines soft dollar and step-in commission characteristics.
    /// Encoded/decoded by serializers as &quot;SOIN&quot;.
    /// </summary>
    [EnumMember(Value = "SOIN")]
    [IsoId("_bAaXcdp-Ed-ak6NoX_4Aeg_-1056301504")]
    [Description(@"Commission that combines soft dollar and step-in commission characteristics.")]
    SoftDollarStepIn,
    
    /// <summary>
    /// Commission that combines soft dollar and step-out commission characteristics.
    /// Encoded/decoded by serializers as &quot;SOUT&quot;.
    /// </summary>
    [EnumMember(Value = "SOUT")]
    [IsoId("_bAaXctp-Ed-ak6NoX_4Aeg_-1056301503")]
    [Description(@"Commission that combines soft dollar and step-out commission characteristics.")]
    SoftDollarStepOut,
    
    /// <summary>
    /// Commission for a plan sponsor&apos;s services.
    /// Encoded/decoded by serializers as &quot;PLAN&quot;.
    /// </summary>
    [EnumMember(Value = "PLAN")]
    [IsoId("_bAaXc9p-Ed-ak6NoX_4Aeg_-1056301502")]
    [Description(@"Commission for a plan sponsor's services.")]
    PlanSponsor,
    
    /// <summary>
    /// Commission is a percentage of principal.
    /// Encoded/decoded by serializers as &quot;PERN&quot;.
    /// </summary>
    [EnumMember(Value = "PERN")]
    [IsoId("_bAaXdNp-Ed-ak6NoX_4Aeg_-1549709072")]
    [Description(@"Commission is a percentage of principal.")]
    PercentageOfPrincipal,
    
    /// <summary>
    /// Amount or percentage that is added to an offer price when an investor buys from a broker or market maker. In this case, the price is adjusted to reflect changing market conditions.
    /// Encoded/decoded by serializers as &quot;MARK&quot;.
    /// </summary>
    [EnumMember(Value = "MARK")]
    [IsoId("_bAaXddp-Ed-ak6NoX_4Aeg_240631783")]
    [Description(@"Amount or percentage that is added to an offer price when an investor buys from a broker or market maker. In this case, the price is adjusted to reflect changing market conditions.")]
    Markup,
    
    /// <summary>
    /// Amount of cash due to an intermediary for selling a product, or services, to a third party.
    /// Encoded/decoded by serializers as &quot;CDPL&quot;.
    /// </summary>
    [EnumMember(Value = "CDPL")]
    [IsoId("_bAaXdtp-Ed-ak6NoX_4Aeg_-566862987")]
    [Description(@"Amount of cash due to an intermediary for selling a product, or services, to a third party.")]
    CommissionDePlacement,
    
    /// <summary>
    /// Amount financed to cover the back-end load.
    /// Encoded/decoded by serializers as &quot;BCRD&quot;.
    /// </summary>
    [EnumMember(Value = "BCRD")]
    [IsoId("_bAaXd9p-Ed-ak6NoX_4Aeg_1764003120")]
    [Description(@"Amount financed to cover the back-end load.")]
    BrokerCredit,
    
    /// <summary>
    /// Commission is another type of transaction.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bAaXeNp-Ed-ak6NoX_4Aeg_-114245563")]
    [Description(@"Commission is another type of transaction.")]
    Other,
    
    /// <summary>
    /// Annual fund based renewal commission, expressed as a percentage of the deal.
    /// Encoded/decoded by serializers as &quot;RNEW&quot;.
    /// </summary>
    [EnumMember(Value = "RNEW")]
    [IsoId("_bAkIcNp-Ed-ak6NoX_4Aeg_-1070220668")]
    [Description(@"Annual fund based renewal commission, expressed as a percentage of the deal.")]
    FundBasedRenewal,
    
    /// <summary>
    /// Commission is a flat fee.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("__-bvMNojEeC60axPepSq7g_-2119623066")]
    [Description(@"Commission is a flat fee.")]
    FlatFee,
    
    /// <summary>
    /// Commission is based on points per bond or contract.
    /// Encoded/decoded by serializers as &quot;PBOC&quot;.
    /// </summary>
    [EnumMember(Value = "PBOC")]
    [IsoId("__-bvMdojEeC60axPepSq7g_-1403020196")]
    [Description(@"Commission is based on points per bond or contract.")]
    PointsPerBondOrContract,
    
    /// <summary>
    /// Differential or deferred payment commission rate.  .
    /// Encoded/decoded by serializers as &quot;DFDP&quot;.
    /// </summary>
    [EnumMember(Value = "DFDP")]
    [IsoId("__-bvMtojEeC60axPepSq7g_-261811583")]
    [Description(@"Differential or deferred payment commission rate.  .")]
    DifferentialOrDeferredPayment,
    
    /// <summary>
    /// Brokerage commission.
    /// Encoded/decoded by serializers as &quot;BRKR&quot;.
    /// </summary>
    [EnumMember(Value = "BRKR")]
    [IsoId("__-bvM9ojEeC60axPepSq7g_-1165731267")]
    [Description(@"Brokerage commission.")]
    BrokerageRate,
    
    /// <summary>
    /// Commission is per unit of financial instrument.
    /// Encoded/decoded by serializers as &quot;PERU&quot;.
    /// </summary>
    [EnumMember(Value = "PERU")]
    [IsoId("__-bvNNojEeC60axPepSq7g_297510507")]
    [Description(@"Commission is per unit of financial instrument.")]
    PerUnit,
    
    /// <summary>
    /// Commission is a percentage commission waived as cash discount.
    /// Encoded/decoded by serializers as &quot;PWCD&quot;.
    /// </summary>
    [EnumMember(Value = "PWCD")]
    [IsoId("__-bvNdojEeC60axPepSq7g_-968188880")]
    [Description(@"Commission is a percentage commission waived as cash discount.")]
    PercentageCommissionWaivedAsCashDiscount,
    
    /// <summary>
    /// Commission is a percentage commission waived as additional units.
    /// Encoded/decoded by serializers as &quot;PWEU&quot;.
    /// </summary>
    [EnumMember(Value = "PWEU")]
    [IsoId("__-bvNtojEeC60axPepSq7g_1964671520")]
    [Description(@"Commission is a percentage commission waived as additional units.")]
    PercentageCommissionWaivedAsAdditionalUnits,
    
}
