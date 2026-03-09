// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of cost or charge.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__hv_IDcnEeidBoT_PugKiA")]
[Description(@"Specifies a type of cost or charge.")]
[DerivedFrom(typeof(InvestmentFundMiFIDFeeCode))]
public enum InvestmentFundMiFIDFee1Code
{
    /// <summary>
    /// Gross one-off maximum entry cost not acquired to the fund. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07020 and is a percentage of the amount to be invested. This fee is paid by the investor to the fund or fund management company. This is indicative and should be adapted by the distributor according to the agreement with the asset manager. In the European MiFID Template (EMT) v1, this is known as ‘one-off entry cost’ and exchange traded funds are excluded.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_BRxyUTcoEeidBoT_PugKiA")]
    [Description(@"Gross one-off maximum entry cost not acquired to the fund. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07020 and is a percentage of the amount to be invested. This fee is paid by the investor to the fund or fund management company. This is indicative and should be adapted by the distributor according to the agreement with the asset manager. In the European MiFID Template (EMT) v1, this is known as ‘one-off entry cost’ and exchange traded funds are excluded.|")]
    GrossOneOffMaximumEntryCostNonAcquired = InvestmentFundMiFIDFeeCode.GrossOneOffMaximumEntryCostNonAcquired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution fee. This fee is included in the total on going costs and is not included in the management fee. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07120 and 08060 and this a percentage of the NAV or the reference value, EMT reference 07150 and 08110, of the financial instrument expressed in annualised terms (rate of cost deduction to be applied).
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_7oxoAdYQEeiKusR0-SyV5w")]
    [Description(@"Distribution fee. This fee is included in the total on going costs and is not included in the management fee. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07120 and 08060 and this a percentage of the NAV or the reference value, EMT reference 07150 and 08110, of the financial instrument expressed in annualised terms (rate of cost deduction to be applied).|")]
    DistributionFee = InvestmentFundMiFIDFeeCode.DistributionFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financing costs related to borrowing for the purposes of gearing expressed as a percentage of the NAV. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07135 and 08075.
    /// Encoded/decoded by serializers as &quot;GEAR&quot;.
    /// </summary>
    [EnumMember(Value = "GEAR")]
    [IsoId("_7t1uMdYQEeiKusR0-SyV5w")]
    [Description(@"Financing costs related to borrowing for the purposes of gearing expressed as a percentage of the NAV. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07135 and 08075.|")]
    GearingCost = InvestmentFundMiFIDFeeCode.GearingCost, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Gross one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08010 and may be specified as an actual amount or a percentage of the reference value, EMT reference 08110, and should only incorporate manufacturer costs (that is, the cost of the financial instrument) and distributor costs upfront when known by the manufacturer. It should, however, not include distribution fees added on top of the product price by distributors that is out of control of the manufacturer.
    /// Encoded/decoded by serializers as &quot;FES3&quot;.
    /// </summary>
    [EnumMember(Value = "FES3")]
    [IsoId("_7y5NUdYQEeiKusR0-SyV5w")]
    [Description(@"Gross one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08010 and may be specified as an actual amount or a percentage of the reference value, EMT reference 08110, and should only incorporate manufacturer costs (that is, the cost of the financial instrument) and distributor costs upfront when known by the manufacturer. It should, however, not include distribution fees added on top of the product price by distributors that is out of control of the manufacturer.")]
    GrossOneOffEntryCostStructured = InvestmentFundMiFIDFeeCode.GrossOneOffEntryCostStructured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Gross maximum one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07020 and is the &apos;ask price&apos; or &apos;fair value&apos;. It may be specified as an actual amount or a percentage of the reference value, EMT reference 07150, and should only incorporate manufacturer costs (that is, the cost of the financial instrument) and distributor costs upfront when known by the manufacturer. It should, however, not include distribution fees added on top of the product price by distributors that are out of control of the manufacturer. 
    /// In EMT v1, this is known as ‘one-off entry cost’ and should only incorporate manufacturer costs, that is the cost of the financial instrument, and not a distribution fee taken upfront .
    /// Encoded/decoded by serializers as &quot;FES2&quot;.
    /// </summary>
    [EnumMember(Value = "FES2")]
    [IsoId("_77hk4dYQEeiKusR0-SyV5w")]
    [Description(@"Gross maximum one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07020 and is the 'ask price' or 'fair value'. It may be specified as an actual amount or a percentage of the reference value, EMT reference 07150, and should only incorporate manufacturer costs (that is, the cost of the financial instrument) and distributor costs upfront when known by the manufacturer. It should, however, not include distribution fees added on top of the product price by distributors that are out of control of the manufacturer. |In EMT v1, this is known as ‘one-off entry cost’ and should only incorporate manufacturer costs, that is the cost of the financial instrument, and not a distribution fee taken upfront .")]
    GrossOneOffMaximumEntryCostStructured = InvestmentFundMiFIDFeeCode.GrossOneOffMaximumEntryCostStructured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Gross on-going costs. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07100 and 08030 and is a percentage of the NAV or the reference value, EMT reference 07150, of the financial product, expressed in annualised terms (rate of cost deduction to be applied). This includes management fees and distribution fees and is expressed as a percentage of the NAV of the financial instrument per annum.
    /// Encoded/decoded by serializers as &quot;GOCF&quot;.
    /// </summary>
    [EnumMember(Value = "GOCF")]
    [IsoId("_8Au1AdYQEeiKusR0-SyV5w")]
    [Description(@"Gross on-going costs. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07100 and 08030 and is a percentage of the NAV or the reference value, EMT reference 07150, of the financial product, expressed in annualised terms (rate of cost deduction to be applied). This includes management fees and distribution fees and is expressed as a percentage of the NAV of the financial instrument per annum.|")]
    GrossOngoingCosts = InvestmentFundMiFIDFeeCode.GrossOngoingCosts, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Gross on-going costs for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07100 and 08030 and is expressed as a percentage of the NAV or currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150.
    /// Encoded/decoded by serializers as &quot;GOCS&quot;.
    /// </summary>
    [EnumMember(Value = "GOCS")]
    [IsoId("_8IUqwdYQEeiKusR0-SyV5w")]
    [Description(@"Gross on-going costs for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07100 and 08030 and is expressed as a percentage of the NAV or currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150.")]
    GrossOngoingCostsStructured = InvestmentFundMiFIDFeeCode.GrossOngoingCostsStructured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee that covers incidental costs. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07140 and 08080 and is expressed as a percentage of the NAV. Includes performance fees and other costs.
    /// Encoded/decoded by serializers as &quot;INCF&quot;.
    /// </summary>
    [EnumMember(Value = "INCF")]
    [IsoId("_8NrE0dYQEeiKusR0-SyV5w")]
    [Description(@"Fee that covers incidental costs. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07140 and 08080 and is expressed as a percentage of the NAV. Includes performance fees and other costs.|")]
    IncidentalCosts = InvestmentFundMiFIDFeeCode.IncidentalCosts, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee that covers incidental costs for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) v2 reference 07140 and 08080 and is expressed as a percentage of the NAV or a currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150 and 08110. In EMT v1, this is not supported.
    /// Encoded/decoded by serializers as &quot;INCS&quot;.
    /// </summary>
    [EnumMember(Value = "INCS")]
    [IsoId("_8SvLAdYQEeiKusR0-SyV5w")]
    [Description(@"Fee that covers incidental costs for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) v2 reference 07140 and 08080 and is expressed as a percentage of the NAV or a currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150 and 08110. In EMT v1, this is not supported.")]
    IncidentalCostsStructured = InvestmentFundMiFIDFeeCode.IncidentalCostsStructured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Management fee paid to an investment manager for services. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07110 and 08050 and is a percentage of the NAV or reference value (EMT reference 07150 and 08110) of the financial product expressed in annualised terms (rate of cost deduction to be applied). These fees are included in total ongoing costs and are fees used by distributors to calculate retrocession fees.
    /// Encoded/decoded by serializers as &quot;MANF&quot;.
    /// </summary>
    [EnumMember(Value = "MANF")]
    [IsoId("_8X8bIdYQEeiKusR0-SyV5w")]
    [Description(@"Management fee paid to an investment manager for services. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07110 and 08050 and is a percentage of the NAV or reference value (EMT reference 07150 and 08110) of the financial product expressed in annualised terms (rate of cost deduction to be applied). These fees are included in total ongoing costs and are fees used by distributors to calculate retrocession fees.")]
    ManagementFee = InvestmentFundMiFIDFeeCode.ManagementFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Management fee for a structured. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07110 and 08050 and is expressed as a percentage of the NAV or a currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150.
    /// Encoded/decoded by serializers as &quot;MANS&quot;.
    /// </summary>
    [EnumMember(Value = "MANS")]
    [IsoId("_8c_6QdYQEeiKusR0-SyV5w")]
    [Description(@"Management fee for a structured. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07110 and 08050 and is expressed as a percentage of the NAV or a currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150.")]
    ManagementFeeStructured = InvestmentFundMiFIDFeeCode.ManagementFeeStructured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Net one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07025 and 08015 and is minus the upfront distribution fee. The cost reported is a net disclosure and therefore the upfront distributor fee is equal to the difference between the one-off entry cost (EMT reference 07020 and 08010) and the net one-off entry (EMT reference 07025 and 08010). In EMT v1, this is not supported.
    /// Encoded/decoded by serializers as &quot;NETO&quot;.
    /// </summary>
    [EnumMember(Value = "NETO")]
    [IsoId("_8kJEEdYQEeiKusR0-SyV5w")]
    [Description(@"Net one-off entry cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07025 and 08015 and is minus the upfront distribution fee. The cost reported is a net disclosure and therefore the upfront distributor fee is equal to the difference between the one-off entry cost (EMT reference 07020 and 08010) and the net one-off entry (EMT reference 07025 and 08010). In EMT v1, this is not supported.|")]
    NetOneOffEntryCostStructured = InvestmentFundMiFIDFeeCode.NetOneOffEntryCostStructured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One-off exit cost prior to the recommended holding period (RHP). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07090 and may be specified as an actual amount or a percentage of the reference value, EMT reference 07150.
    /// Encoded/decoded by serializers as &quot;OOES&quot;.
    /// </summary>
    [EnumMember(Value = "OOES")]
    [IsoId("_8pMjMdYQEeiKusR0-SyV5w")]
    [Description(@"One-off exit cost prior to the recommended holding period (RHP). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07090 and may be specified as an actual amount or a percentage of the reference value, EMT reference 07150.")]
    OneOffExitCostPriorStructured = InvestmentFundMiFIDFeeCode.OneOffExitCostPriorStructured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One off exit cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08020 and when expressed as a percentage, this is a percentage of the reference value, EMT reference 08110.
    /// Encoded/decoded by serializers as &quot;BENS&quot;.
    /// </summary>
    [EnumMember(Value = "BENS")]
    [IsoId("_8uZzUdYQEeiKusR0-SyV5w")]
    [Description(@"One off exit cost for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08020 and when expressed as a percentage, this is a percentage of the reference value, EMT reference 08110.|")]
    OneOffExitCostStructured = InvestmentFundMiFIDFeeCode.OneOffExitCostStructured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum cost of the one-off entry fee. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07040 and is the subscription fees acquired to the fund. It is not included in the one off entry cost 07020. This maximum one-off entry cost acquired to the fund is specified as a percentage of the amount to be invested.
    /// Encoded/decoded by serializers as &quot;ENAC&quot;.
    /// </summary>
    [EnumMember(Value = "ENAC")]
    [IsoId("_8zd5gdYQEeiKusR0-SyV5w")]
    [Description(@"Maximum cost of the one-off entry fee. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07040 and is the subscription fees acquired to the fund. It is not included in the one off entry cost 07020. This maximum one-off entry cost acquired to the fund is specified as a percentage of the amount to be invested.")]
    OneOffMaximumEntryCostAcquired = InvestmentFundMiFIDFeeCode.OneOffMaximumEntryCostAcquired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum one-off entry cost fixed amount. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07030 and is a flat fee defined by the fund or fund management company. This is indicative and should be adapted by the distributor according to the relationship been the fund and the distribution. This cost is not taken into account in the gross one-off maximum entry cost (FEND), EMT reference 07020.
    /// Encoded/decoded by serializers as &quot;ENFX&quot;.
    /// </summary>
    [EnumMember(Value = "ENFX")]
    [IsoId("_84XnodYQEeiKusR0-SyV5w")]
    [Description(@"Maximum one-off entry cost fixed amount. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07030 and is a flat fee defined by the fund or fund management company. This is indicative and should be adapted by the distributor according to the relationship been the fund and the distribution. This cost is not taken into account in the gross one-off maximum entry cost (FEND), EMT reference 07020.")]
    OneOffMaximumEntryCostFixedAmountItaly = InvestmentFundMiFIDFeeCode.OneOffMaximumEntryCostFixedAmountItaly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum cost of the one-off exit fee not acquired to the fund that could happen at a certain time during the life of the product. This is a percentage of the NAV. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07050.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_89uowdYQEeiKusR0-SyV5w")]
    [Description(@"Maximum cost of the one-off exit fee not acquired to the fund that could happen at a certain time during the life of the product. This is a percentage of the NAV. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07050.")]
    OneOffMaximumExitCost = InvestmentFundMiFIDFeeCode.OneOffMaximumExitCost, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum cost of the one-off exit fee acquired to the fund. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07070. It is not included in the one off maximum exit cost EMT reference 07050. This is paid by the investor to the fund or fund management company. This is a percentage of the NAV. 
    /// Encoded/decoded by serializers as &quot;EXAC&quot;.
    /// </summary>
    [EnumMember(Value = "EXAC")]
    [IsoId("_9DFp4dYQEeiKusR0-SyV5w")]
    [Description(@"Maximum cost of the one-off exit fee acquired to the fund. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07070. It is not included in the one off maximum exit cost EMT reference 07050. This is paid by the investor to the fund or fund management company. This is a percentage of the NAV. ")]
    OneOffMaximumExitCostAcquired = InvestmentFundMiFIDFeeCode.OneOffMaximumExitCostAcquired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum one-off exit cost, a maximum fixed amount per redemption. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07060 and is flat fee defined by the fund or fund management company. It is indicative and should be adapted distributor according to the relationship been the fund and the distribution. This cost is not taken in account in the one-off maximum exit cost EMT reference 07050.
    /// Encoded/decoded by serializers as &quot;ENBX&quot;.
    /// </summary>
    [EnumMember(Value = "ENBX")]
    [IsoId("_9IS6AdYQEeiKusR0-SyV5w")]
    [Description(@"Maximum one-off exit cost, a maximum fixed amount per redemption. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07060 and is flat fee defined by the fund or fund management company. It is indicative and should be adapted distributor according to the relationship been the fund and the distribution. This cost is not taken in account in the one-off maximum exit cost EMT reference 07050.")]
    OneOffMaximumExitCostFixedAmountItaly = InvestmentFundMiFIDFeeCode.OneOffMaximumExitCostFixedAmountItaly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One-off typical exit current exit cost linked to the recommended holding period (RHP) or time to maturity. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07080 and are the ‘normal’ fees if the client holds the product until maturity or during the RHP.
    /// Example: a product with a 5 year maturity has exit costs of:
    /// - 4% after 1 and 2 years
    /// - 3% after 3 years
    /// - 1% after 4 years
    /// - 0 at maturity
    /// Then maximum exit cost: 4%.
    /// Typical cost : 0
    /// Typical cost : 0
    /// Encoded/decoded by serializers as &quot;PENO&quot;.
    /// </summary>
    [EnumMember(Value = "PENO")]
    [IsoId("_9NMoIdYQEeiKusR0-SyV5w")]
    [Description(@"One-off typical exit current exit cost linked to the recommended holding period (RHP) or time to maturity. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07080 and are the ‘normal’ fees if the client holds the product until maturity or during the RHP.|Example: a product with a 5 year maturity has exit costs of:|- 4% after 1 and 2 years|- 3% after 3 years|- 1% after 4 years|- 0 at maturity|Then maximum exit cost: 4%.|Typical cost : 0|Typical cost : 0")]
    OneOffTypicalExitCost = InvestmentFundMiFIDFeeCode.OneOffTypicalExitCost, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One-off typical exit cost linked to the recommended holding period (RHP) for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07080 and may be specified as an actual amount or a percentage of the reference value, EMT reference 07150.
    /// Encoded/decoded by serializers as &quot;OTES&quot;.
    /// </summary>
    [EnumMember(Value = "OTES")]
    [IsoId("_9StaQdYQEeiKusR0-SyV5w")]
    [Description(@"One-off typical exit cost linked to the recommended holding period (RHP) for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07080 and may be specified as an actual amount or a percentage of the reference value, EMT reference 07150.")]
    OneOffTypicalExitCostsStructured = InvestmentFundMiFIDFeeCode.OneOffTypicalExitCostsStructured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sum of daily recurring product costs accumulated during the year until the ex post reference date. This is typically specified as an actual amount. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08040.
    /// Encoded/decoded by serializers as &quot;OCAS&quot;.
    /// </summary>
    [EnumMember(Value = "OCAS")]
    [IsoId("_9Xw5YdYQEeiKusR0-SyV5w")]
    [Description(@"Sum of daily recurring product costs accumulated during the year until the ex post reference date. This is typically specified as an actual amount. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08040.")]
    OngoingCostsAccumulatedStructured = InvestmentFundMiFIDFeeCode.OngoingCostsAccumulatedStructured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Performance fee. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07145 and 08085 and is a percentage of the NAV or the reference value, EMT reference 07150 and 08110, of the financial instrument expressed in annualised terms (rate of cost deduction to be applied). This fee is included in the total incidental costs.
    /// In EMT v1, this is not supported.
    /// Encoded/decoded by serializers as &quot;PERF&quot;.
    /// </summary>
    [EnumMember(Value = "PERF")]
    [IsoId("_9da1cdYQEeiKusR0-SyV5w")]
    [Description(@"Performance fee. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07145 and 08085 and is a percentage of the NAV or the reference value, EMT reference 07150 and 08110, of the financial instrument expressed in annualised terms (rate of cost deduction to be applied). This fee is included in the total incidental costs.|In EMT v1, this is not supported.")]
    PerformanceFee = InvestmentFundMiFIDFeeCode.PerformanceFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Performance fee for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07145 and 08085 and is expressed as a percentage of the NAV or a currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150 and 08110. In EMT v1, this is not supported.
    /// Encoded/decoded by serializers as &quot;PERS&quot;.
    /// </summary>
    [EnumMember(Value = "PERS")]
    [IsoId("_9jN7cdYQEeiKusR0-SyV5w")]
    [Description(@"Performance fee for a structured product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07145 and 08085 and is expressed as a percentage of the NAV or a currency and amount for an absolute quotation of the financial product in annualised terms related to the reference value, EMT reference 07150 and 08110. In EMT v1, this is not supported.")]
    PerformanceFeeStructured = InvestmentFundMiFIDFeeCode.PerformanceFeeStructured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reference value. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07150 and 08110 and is the percentage of the NAV of the financial product expressed in annualised terms (rate of cost deduction to be applied).
    /// Encoded/decoded by serializers as &quot;REFV&quot;.
    /// </summary>
    [EnumMember(Value = "REFV")]
    [IsoId("_9uFHodYQEeiKusR0-SyV5w")]
    [Description(@"Reference value. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07150 and 08110 and is the percentage of the NAV of the financial product expressed in annualised terms (rate of cost deduction to be applied).")]
    ReferenceValue = InvestmentFundMiFIDFeeCode.ReferenceValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cost associated with the transaction. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07130 and 08070 and this is a percentage of the NAV or the reference value, EMT reference 07150 and 08110, of the financial instrument expressed in annualised terms (rate of cost deduction to be applied).
    /// Encoded/decoded by serializers as &quot;TRSF&quot;.
    /// </summary>
    [EnumMember(Value = "TRSF")]
    [IsoId("_907WgdYQEeiKusR0-SyV5w")]
    [Description(@"Cost associated with the transaction. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07130 and 08070 and this is a percentage of the NAV or the reference value, EMT reference 07150 and 08110, of the financial instrument expressed in annualised terms (rate of cost deduction to be applied).|")]
    TransactionCost = InvestmentFundMiFIDFeeCode.TransactionCost, // same ordinal as derivation source for type conversions
    
}
