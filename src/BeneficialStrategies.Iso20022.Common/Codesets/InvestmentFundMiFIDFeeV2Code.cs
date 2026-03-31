// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of cost or charge.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ipm_QLSVEeq-6ssAXwSh-g")]
[Description(@"Specifies a type of cost or charge.")]
[Derivations(typeof(InvestmentFundMiFIDFee2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestmentFundMiFIDFeeV2Code>))]
#endif
public enum InvestmentFundMiFIDFeeV2Code
{
    /// <summary>
    /// Gross one-off maximum entry cost not acquired to the fund. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07020 and is a percentage of the amount to be invested. This fee is paid by the investor to the fund or fund management company. This is indicative and should be adapted by the distributor according to the agreement with the asset manager.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_6C3ksbSVEeq-6ssAXwSh-g")]
    [Description(
        @"Gross one-off maximum entry cost not acquired to the fund. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07020 and is a percentage of the amount to be invested. This fee is paid by the investor to the fund or fund management company. This is indicative and should be adapted by the distributor according to the agreement with the asset manager."
    )]
    GrossOneOffMaximumEntryCostNonAcquired,

    /// <summary>
    /// Gross maximum one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07020 or 08120, and is the &apos;ask price&apos; or &apos;fair value&apos;. It may be specified as an actual amount or a percentage of the reference value, EMT reference 07150, and should only incorporate manufacturer costs (that is, the cost of the financial instrument) and distributor costs upfront when known by the manufacturer. It should, however, not include distribution fees added on top of the product price by distributors that are out of control of the manufacturer.
    /// Encoded/decoded by serializers as &quot;FES2&quot;.
    /// </summary>
    [EnumMember(Value = "FES2")]
    [IsoId("_DGx1MbSWEeq-6ssAXwSh-g")]
    [Description(
        @"Gross maximum one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07020 or 08120, and is the 'ask price' or 'fair value'. It may be specified as an actual amount or a percentage of the reference value, EMT reference 07150, and should only incorporate manufacturer costs (that is, the cost of the financial instrument) and distributor costs upfront when known by the manufacturer. It should, however, not include distribution fees added on top of the product price by distributors that are out of control of the manufacturer."
    )]
    GrossOneOffMaximumEntryCostStructured,

    /// <summary>
    /// Gross one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08010 and may be specified as an actual amount or a percentage of the reference value, EMT reference 08110 or 08120, and should only incorporate manufacturer costs (that is, the cost of the financial instrument) and distributor costs upfront when known by the manufacturer. It should, however, not include distribution fees added on top of the product price by distributors that is out of control of the manufacturer.
    /// Encoded/decoded by serializers as &quot;FES3&quot;.
    /// </summary>
    [EnumMember(Value = "FES3")]
    [IsoId("_IwvuYbSWEeq-6ssAXwSh-g")]
    [Description(
        @"Gross one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08010 and may be specified as an actual amount or a percentage of the reference value, EMT reference 08110 or 08120, and should only incorporate manufacturer costs (that is, the cost of the financial instrument) and distributor costs upfront when known by the manufacturer. It should, however, not include distribution fees added on top of the product price by distributors that is out of control of the manufacturer."
    )]
    GrossOneOffEntryCostStructured,

    /// <summary>
    /// Net one-off entry cost for a structured fund. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07025. This is expressed as a percentage of the amount to be invested.
    /// Encoded/decoded by serializers as &quot;NESF&quot;.
    /// </summary>
    [EnumMember(Value = "NESF")]
    [IsoId("_UCcsILSWEeq-6ssAXwSh-g")]
    [Description(
        @"Net one-off entry cost for a structured fund. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07025. This is expressed as a percentage of the amount to be invested."
    )]
    NetOneOffEntryCostNonAcquiredStructuredFund,

    /// <summary>
    /// Net one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07025 and is minus the upfront distribution fee. The cost reported is a net disclosure and therefore the upfront distributor fee is equal to the difference between the one-off entry cost (EMT reference 07020) and the net one-off entry (EMT reference 07025).
    /// Encoded/decoded by serializers as &quot;NETO&quot;.
    /// </summary>
    [EnumMember(Value = "NETO")]
    [IsoId("_noAWcbSWEeq-6ssAXwSh-g")]
    [Description(
        @"Net one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07025 and is minus the upfront distribution fee. The cost reported is a net disclosure and therefore the upfront distributor fee is equal to the difference between the one-off entry cost (EMT reference 07020) and the net one-off entry (EMT reference 07025).|"
    )]
    NetOneOffEntryCostStructuredNonAcquired,

    /// <summary>
    /// Net one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08015 and is minus the upfront distribution fee. The cost reported is a net disclosure and therefore the upfront distributor fee is equal to the difference between the gross one-off entry cost (EMT reference 08010) and the net one-off entry (EMT reference 08015).
    /// Encoded/decoded by serializers as &quot;NET2&quot;.
    /// </summary>
    [EnumMember(Value = "NET2")]
    [IsoId("_tQx80LSWEeq-6ssAXwSh-g")]
    [Description(
        @"Net one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08015 and is minus the upfront distribution fee. The cost reported is a net disclosure and therefore the upfront distributor fee is equal to the difference between the gross one-off entry cost (EMT reference 08010) and the net one-off entry (EMT reference 08015)."
    )]
    NetOneOffEntryCostExPostStructured,

    /// <summary>
    /// Maximum one-off entry cost fixed amount. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07030 and is a flat fee defined by the fund or fund management company. This is indicative and should be adapted by the distributor according to the relationship been the fund and the distribution. This cost is not taken into account in the gross one-off maximum entry cost (FEND), EMT reference 07020.
    /// Encoded/decoded by serializers as &quot;ENFX&quot;.
    /// </summary>
    [EnumMember(Value = "ENFX")]
    [IsoId("_1cUa4bSWEeq-6ssAXwSh-g")]
    [Description(
        @"Maximum one-off entry cost fixed amount. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07030 and is a flat fee defined by the fund or fund management company. This is indicative and should be adapted by the distributor according to the relationship been the fund and the distribution. This cost is not taken into account in the gross one-off maximum entry cost (FEND), EMT reference 07020."
    )]
    OneOffMaximumEntryCostFixedAmountItaly,

    /// <summary>
    /// Maximum cost of the one-off entry fee. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07040 and is the subscription fees acquired to the fund. It is not included in the one off entry cost 07020. This maximum one-off entry cost acquired to the fund is specified as a percentage of the amount to be invested.
    /// Encoded/decoded by serializers as &quot;ENAC&quot;.
    /// </summary>
    [EnumMember(Value = "ENAC")]
    [IsoId("_K0vJ8bSXEeq-6ssAXwSh-g")]
    [Description(
        @"Maximum cost of the one-off entry fee. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07040 and is the subscription fees acquired to the fund. It is not included in the one off entry cost 07020. This maximum one-off entry cost acquired to the fund is specified as a percentage of the amount to be invested."
    )]
    OneOffMaximumEntryCostAcquired,

    /// <summary>
    /// Maximum cost of the one-off exit fee not acquired to the fund that could happen at a certain time during the life of the product. This is a percentage of the NAV. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07050.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_PVDTcbSXEeq-6ssAXwSh-g")]
    [Description(
        @"Maximum cost of the one-off exit fee not acquired to the fund that could happen at a certain time during the life of the product. This is a percentage of the NAV. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07050."
    )]
    OneOffMaximumExitCostNonAcquired,

    /// <summary>
    /// Maximum one-off exit cost, a maximum fixed amount per redemption. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07060 and is flat fee defined by the fund or fund management company. It is indicative and should be adapted distributor according to the relationship been the fund and the distribution. This cost is not taken in account in the one-off maximum exit cost EMT reference 07050.
    /// Encoded/decoded by serializers as &quot;ENBX&quot;.
    /// </summary>
    [EnumMember(Value = "ENBX")]
    [IsoId("_UMlqIbSXEeq-6ssAXwSh-g")]
    [Description(
        @"Maximum one-off exit cost, a maximum fixed amount per redemption. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07060 and is flat fee defined by the fund or fund management company. It is indicative and should be adapted distributor according to the relationship been the fund and the distribution. This cost is not taken in account in the one-off maximum exit cost EMT reference 07050."
    )]
    OneOffMaximumExitCostFixedAmountItaly,

    /// <summary>
    /// Maximum cost of the one-off exit fee acquired to the fund. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07070. It is not included in the one off maximum exit cost EMT reference 07050. This is paid by the investor to the fund or fund management company. This is a percentage of the NAV.
    /// Encoded/decoded by serializers as &quot;EXAC&quot;.
    /// </summary>
    [EnumMember(Value = "EXAC")]
    [IsoId("_X6BlMbSXEeq-6ssAXwSh-g")]
    [Description(
        @"Maximum cost of the one-off exit fee acquired to the fund. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07070. It is not included in the one off maximum exit cost EMT reference 07050. This is paid by the investor to the fund or fund management company. This is a percentage of the NAV. "
    )]
    OneOffMaximumExitCostAcquired,

    /// <summary>
    /// One-off typical exit current exit cost linked to the recommended holding period (RHP) or time to maturity. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07080 and are the ‘normal’ fees if the client holds the product until maturity or during the RHP.
    /// Example: a product with a 5 year maturity has exit costs of:
    /// - 4% after 1 and 2 years
    /// - 3% after 3 years
    /// - 1% after 4 years
    /// - 0 at maturity
    /// Then maximum exit cost: 4%.
    /// Typical cost : 0
    /// Encoded/decoded by serializers as &quot;PENO&quot;.
    /// </summary>
    [EnumMember(Value = "PENO")]
    [IsoId("_cwEuIbSXEeq-6ssAXwSh-g")]
    [Description(
        @"One-off typical exit current exit cost linked to the recommended holding period (RHP) or time to maturity. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07080 and are the ‘normal’ fees if the client holds the product until maturity or during the RHP.|Example: a product with a 5 year maturity has exit costs of:|- 4% after 1 and 2 years|- 3% after 3 years|- 1% after 4 years|- 0 at maturity|Then maximum exit cost: 4%.|Typical cost : 0"
    )]
    OneOffTypicalExitCost,

    /// <summary>
    /// One-off typical exit cost linked to the recommended holding period (RHP) for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07080 and may be specified as an actual amount or a percentage of the reference value, EMT reference 07150 or 07155.
    /// Encoded/decoded by serializers as &quot;OTES&quot;.
    /// </summary>
    [EnumMember(Value = "OTES")]
    [IsoId("_kUqg8bSXEeq-6ssAXwSh-g")]
    [Description(
        @"One-off typical exit cost linked to the recommended holding period (RHP) for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07080 and may be specified as an actual amount or a percentage of the reference value, EMT reference 07150 or 07155."
    )]
    OneOffTypicalExitCostsStructured,

    /// <summary>
    /// One-off exit cost prior to the recommended holding period (RHP). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07090 and may be specified as a percentage of the amount to be divested.
    /// Encoded/decoded by serializers as &quot;OOSF&quot;.
    /// </summary>
    [EnumMember(Value = "OOSF")]
    [IsoId("_wp9psLSXEeq-6ssAXwSh-g")]
    [Description(
        @"One-off exit cost prior to the recommended holding period (RHP). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07090 and may be specified as a percentage of the amount to be divested."
    )]
    OneOffExitCostPriorStructuredProductFund,

    /// <summary>
    /// One-off exit cost prior to the recommended holding period (RHP). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07090 and is specified as an actual amount or a percentage of the reference value, EMT reference 07150 or 07155.
    /// Encoded/decoded by serializers as &quot;OOSS&quot;.
    /// </summary>
    [EnumMember(Value = "OOSS")]
    [IsoId("_3KD5oLSXEeq-6ssAXwSh-g")]
    [Description(
        @"One-off exit cost prior to the recommended holding period (RHP). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07090 and is specified as an actual amount or a percentage of the reference value, EMT reference 07150 or 07155."
    )]
    OneOffExitCostPriorStructuredSecurities,

    /// <summary>
    /// Gross on-going costs. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07100 and 08030 and is a percentage of the NAV of the financial product, expressed in annualised terms (rate of cost deduction to be applied). This includes management fees and distribution fees and excludes all transaction costs, incidental costs and performance fees. Costs reported should reflect current running ongoing costs. The gross on-going costs is expressed as a percentage of the NAV of the financial instrument per annum.
    /// Encoded/decoded by serializers as &quot;GOC1&quot;.
    /// </summary>
    [EnumMember(Value = "GOC1")]
    [IsoId("_9YSWcLSXEeq-6ssAXwSh-g")]
    [Description(
        @"Gross on-going costs. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07100 and 08030 and is a percentage of the NAV of the financial product, expressed in annualised terms (rate of cost deduction to be applied). This includes management fees and distribution fees and excludes all transaction costs, incidental costs and performance fees. Costs reported should reflect current running ongoing costs. The gross on-going costs is expressed as a percentage of the NAV of the financial instrument per annum."
    )]
    GrossOngoingCosts,

    /// <summary>
    /// Gross on-going costs for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07100 and 08030 and is expressed as a percentage of the NAV or currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150 or 07155 or 08110.
    /// Encoded/decoded by serializers as &quot;GOCS&quot;.
    /// </summary>
    [EnumMember(Value = "GOCS")]
    [IsoId("_GRSXcbSYEeq-6ssAXwSh-g")]
    [Description(
        @"Gross on-going costs for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07100 and 08030 and is expressed as a percentage of the NAV or currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150 or 07155 or 08110."
    )]
    GrossOngoingCostsStructured,

    /// <summary>
    /// Financing costs related to borrowing for the purposes of gearing expressed as a percentage of the NAV. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07105 and 08045.
    /// Encoded/decoded by serializers as &quot;BORF&quot;.
    /// </summary>
    [EnumMember(Value = "BORF")]
    [IsoId("_Vn8YYLSYEeq-6ssAXwSh-g")]
    [Description(
        @"Financing costs related to borrowing for the purposes of gearing expressed as a percentage of the NAV. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07105 and 08045."
    )]
    BorrowingCostFund,

    /// <summary>
    /// Management fee paid to an investment manager for services. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07110 and 08050 and is a percentage of the NAV of the financial product expressed in annualised terms (rate of cost deduction to be applied). These fees are included in total ongoing costs and are fees used by distributors to calculate retrocession fees. The costs reported should reflect current running management costs.
    /// Encoded/decoded by serializers as &quot;MNF1&quot;.
    /// </summary>
    [EnumMember(Value = "MNF1")]
    [IsoId("_ZetOkLSYEeq-6ssAXwSh-g")]
    [Description(
        @"Management fee paid to an investment manager for services. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07110 and 08050 and is a percentage of the NAV of the financial product expressed in annualised terms (rate of cost deduction to be applied). These fees are included in total ongoing costs and are fees used by distributors to calculate retrocession fees. The costs reported should reflect current running management costs."
    )]
    ManagementFee,

    /// <summary>
    /// Management fee for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07110 and 08050 and is expressed as a percentage of the NAV or a currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150 or 07155 or 08110.
    /// Encoded/decoded by serializers as &quot;MANS&quot;.
    /// </summary>
    [EnumMember(Value = "MANS")]
    [IsoId("_dU1yobSYEeq-6ssAXwSh-g")]
    [Description(
        @"Management fee for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07110 and 08050 and is expressed as a percentage of the NAV or a currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150 or 07155 or 08110."
    )]
    ManagementFeeStructured,

    /// <summary>
    /// Distribution fee. This fee is included in the total on going costs and is not included in the management fee. It is only applicable if the product has this feature. The cost reported should reflect the current running distribution fee. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07120 and 08060 and this a percentage of the NAV of the financial instrument expressed in annualised terms (rate of cost deduction to be applied).
    /// Encoded/decoded by serializers as &quot;DIS2&quot;.
    /// </summary>
    [EnumMember(Value = "DIS2")]
    [IsoId("_g8Dw8LSYEeq-6ssAXwSh-g")]
    [Description(
        @"Distribution fee. This fee is included in the total on going costs and is not included in the management fee. It is only applicable if the product has this feature. The cost reported should reflect the current running distribution fee. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07120 and 08060 and this a percentage of the NAV of the financial instrument expressed in annualised terms (rate of cost deduction to be applied)."
    )]
    DistributionFee,

    /// <summary>
    /// Cost associated with the transaction. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07130 and 08070 and this is a percentage of the NAV of the financial instrument expressed in annualised terms (rate of cost deduction to be applied).
    /// Encoded/decoded by serializers as &quot;TRS1&quot;.
    /// </summary>
    [EnumMember(Value = "TRS1")]
    [IsoId("_j8SAsLSYEeq-6ssAXwSh-g")]
    [Description(
        @"Cost associated with the transaction. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07130 and 08070 and this is a percentage of the NAV of the financial instrument expressed in annualised terms (rate of cost deduction to be applied)."
    )]
    TransactionCost,

    /// <summary>
    /// Fee that covers incidental costs. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07140 and 08080 and is expressed as a percentage of the NAV. Includes performance fees and other costs.
    /// Encoded/decoded by serializers as &quot;INCF&quot;.
    /// </summary>
    [EnumMember(Value = "INCF")]
    [IsoId("_oEhBYbSYEeq-6ssAXwSh-g")]
    [Description(
        @"Fee that covers incidental costs. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07140 and 08080 and is expressed as a percentage of the NAV. Includes performance fees and other costs.|"
    )]
    IncidentalCosts,

    /// <summary>
    /// Fee that covers incidental costs for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07140 and 08080 and is expressed as a percentage of the NAV or a currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150 or 07155 and 08110.
    /// Encoded/decoded by serializers as &quot;INCS&quot;.
    /// </summary>
    [EnumMember(Value = "INCS")]
    [IsoId("_tY66QbSYEeq-6ssAXwSh-g")]
    [Description(
        @"Fee that covers incidental costs for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07140 and 08080 and is expressed as a percentage of the NAV or a currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150 or 07155 and 08110. "
    )]
    IncidentalCostsStructured,

    /// <summary>
    /// Reference Price. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07150 and 08110 and is the instrument price to which a unit disclosed ex-post cost is based and to which a percentage disclosed cost should be multiplied in order to retrieve the unit cost.
    /// Encoded/decoded by serializers as &quot;RPSS&quot;.
    /// </summary>
    [EnumMember(Value = "RPSS")]
    [IsoId("_3v3f8LSYEeq-6ssAXwSh-g")]
    [Description(
        @"Reference Price. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07150 and 08110 and is the instrument price to which a unit disclosed ex-post cost is based and to which a percentage disclosed cost should be multiplied in order to retrieve the unit cost. "
    )]
    ReferencePrice,

    /// <summary>
    /// Notional reference amount. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07155 and 08120. This is the amount expressed as a number of currency units to which a unit disclosed ex-post cost is based and to which a percentage disclosed cost should be multiplied in order to retrieve the unit cost.
    /// Encoded/decoded by serializers as &quot;NRAM&quot;.
    /// </summary>
    [EnumMember(Value = "NRAM")]
    [IsoId("_74_RcLSYEeq-6ssAXwSh-g")]
    [Description(
        @"Notional reference amount. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07155 and 08120. This is the amount expressed as a number of currency units to which a unit disclosed ex-post cost is based and to which a percentage disclosed cost should be multiplied in order to retrieve the unit cost."
    )]
    NotionalReferenceAmount,

    /// <summary>
    /// One off exit cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08020 and when expressed as a percentage, this is a percentage of the reference value, EMT reference 08110 or 08120.
    /// Encoded/decoded by serializers as &quot;BENS&quot;.
    /// </summary>
    [EnumMember(Value = "BENS")]
    [IsoId("_BA4_YbSZEeq-6ssAXwSh-g")]
    [Description(
        @"One off exit cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08020 and when expressed as a percentage, this is a percentage of the reference value, EMT reference 08110 or 08120.|"
    )]
    OneOffExitCostStructured,

    /// <summary>
    /// Percentage of the NAV. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08025.
    /// Encoded/decoded by serializers as &quot;OOEA&quot;.
    /// </summary>
    [EnumMember(Value = "OOEA")]
    [IsoId("_FkyBULSZEeq-6ssAXwSh-g")]
    [Description(
        @"Percentage of the NAV. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08025."
    )]
    OneOffEntryCostAcquired,

    /// <summary>
    /// Sum of daily recurring product costs accumulated during the year until the ex post reference date. This is typically specified as an actual amount. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08040.
    /// Encoded/decoded by serializers as &quot;OCAS&quot;.
    /// </summary>
    [EnumMember(Value = "OCAS")]
    [IsoId("_Ixf08bSZEeq-6ssAXwSh-g")]
    [Description(
        @"Sum of daily recurring product costs accumulated during the year until the ex post reference date. This is typically specified as an actual amount. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08040."
    )]
    OngoingCostsAccumulatedStructured,
}
