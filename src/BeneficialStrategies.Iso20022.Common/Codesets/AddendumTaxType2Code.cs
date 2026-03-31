// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the specific type of tax applicable to a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qEe1kSB_Eey8XKHwKquEQw")]
[Description(@"Specifies the specific type of tax applicable to a transaction.")]
[DerivedFrom(typeof(AddendumTaxTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AddendumTaxType2Code>))]
#endif
public enum AddendumTaxType2Code
{
    /// <summary>
    /// Total of all applicable taxes
    /// Encoded/decoded by serializers as &quot;TOTL&quot;.
    /// </summary>
    [EnumMember(Value = "TOTL")]
    [IsoId("_qJ-ZkSB_Eey8XKHwKquEQw")]
    [Description(@"Total of all applicable taxes")]
    TotalTaxes = AddendumTaxTypeCode.TotalTaxes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is an alternative minimum tax.
    /// Encoded/decoded by serializers as &quot;ALMI&quot;.
    /// </summary>
    [EnumMember(Value = "ALMI")]
    [IsoId("_qJ-ZkyB_Eey8XKHwKquEQw")]
    [Description(@"Tax is an alternative minimum tax.")]
    AlternativeMinimumTax = AddendumTaxTypeCode.AlternativeMinimumTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Assessment
    /// Encoded/decoded by serializers as &quot;ASNT&quot;.
    /// </summary>
    [EnumMember(Value = "ASNT")]
    [IsoId("_qJ-ZlSB_Eey8XKHwKquEQw")]
    [Description(@"Assessment")]
    Assessment = AddendumTaxTypeCode.Assessment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax imposed on non-American Indian businesses for the privilege of conducting business on an American Indian Reservation
    /// Encoded/decoded by serializers as &quot;BPTX&quot;.
    /// </summary>
    [EnumMember(Value = "BPTX")]
    [IsoId("_qJ-ZlyB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax imposed on non-American Indian businesses for the privilege of conducting business on an American Indian Reservation"
    )]
    BusinessPrivilegeTax = AddendumTaxTypeCode.BusinessPrivilegeTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.
    /// Encoded/decoded by serializers as &quot;KAPA&quot;.
    /// </summary>
    [EnumMember(Value = "KAPA")]
    [IsoId("_qJ-ZmSB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument."
    )]
    CapitalGainTax = AddendumTaxTypeCode.CapitalGainTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax recovery is due to capital loss.
    /// Encoded/decoded by serializers as &quot;NKAP&quot;.
    /// </summary>
    [EnumMember(Value = "NKAP")]
    [IsoId("_qJ-ZmyB_Eey8XKHwKquEQw")]
    [Description(@"Tax recovery is due to capital loss.")]
    CapitalLossCredit = AddendumTaxTypeCode.CapitalLossCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Levied by a city government against the periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;CRTX&quot;.
    /// </summary>
    [EnumMember(Value = "CRTX")]
    [IsoId("_qJ-ZnSB_Eey8XKHwKquEQw")]
    [Description(
        @"Levied by a city government against the periodic fee paid by a customer in return for the right to use the property of another party."
    )]
    CityRentalTax = AddendumTaxTypeCode.CityRentalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sales tax imposed by a city
    /// Encoded/decoded by serializers as &quot;CSTX&quot;.
    /// </summary>
    [EnumMember(Value = "CSTX")]
    [IsoId("_qJ-ZnyB_Eey8XKHwKquEQw")]
    [Description(@"Sales tax imposed by a city")]
    CitySalesTax = AddendumTaxTypeCode.CitySalesTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service tax imposed by a city
    /// Encoded/decoded by serializers as &quot;CITX&quot;.
    /// </summary>
    [EnumMember(Value = "CITX")]
    [IsoId("_qJ-ZoSB_Eey8XKHwKquEQw")]
    [Description(@"Service tax imposed by a city")]
    CityTax = AddendumTaxTypeCode.CityTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_qJ-ZoyB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax that is levied on goods and services purchased by customers, and is added to the retail price."
    )]
    ConsumptionTax = AddendumTaxTypeCode.ConsumptionTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service tax imposed by a County or Parish
    /// Encoded/decoded by serializers as &quot;CPST&quot;.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_qJ-ZpSB_Eey8XKHwKquEQw")]
    [Description(@"Service tax imposed by a County or Parish")]
    CountyParishSalesTax = AddendumTaxTypeCode.CountyParishSalesTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Levied by a county government against the periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_qJ-ZpyB_Eey8XKHwKquEQw")]
    [Description(
        @"Levied by a county government against the periodic fee paid by a customer in return for the right to use the property of another party."
    )]
    CountyRentalTax = AddendumTaxTypeCode.CountyRentalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service tax levied by a county
    /// Encoded/decoded by serializers as &quot;COTX&quot;.
    /// </summary>
    [EnumMember(Value = "COTX")]
    [IsoId("_qJ-ZqSB_Eey8XKHwKquEQw")]
    [Description(@"Service tax levied by a county")]
    CountyTax = AddendumTaxTypeCode.CountyTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on imports or exports by a country&apos;s customs authority.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_qJ-ZqyB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied on imports or exports by a country's customs authority. ")]
    CustomsTax = AddendumTaxTypeCode.CustomsTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Default Labour Tax
    /// Encoded/decoded by serializers as &quot;DLTX&quot;.
    /// </summary>
    [EnumMember(Value = "DLTX")]
    [IsoId("_qJ-ZrSB_Eey8XKHwKquEQw")]
    [Description(@"Default Labour Tax")]
    DefaultLabourTax = AddendumTaxTypeCode.DefaultLabourTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A tax levied on goods that typically though not exclusively transit across a geographic border.
    /// Encoded/decoded by serializers as &quot;DUTY&quot;.
    /// </summary>
    [EnumMember(Value = "DUTY")]
    [IsoId("_qJ-ZryB_Eey8XKHwKquEQw")]
    [Description(
        @"A tax levied on goods that typically though not exclusively transit across a geographic border. "
    )]
    Duty = AddendumTaxTypeCode.Duty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied by a city to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMIT&quot;.
    /// </summary>
    [EnumMember(Value = "EMIT")]
    [IsoId("_qJ-ZsSB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied by a city to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999)."
    )]
    EmergencyAssistanceCityTax = AddendumTaxTypeCode.EmergencyAssistanceCityTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied by a county to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMUT&quot;.
    /// </summary>
    [EnumMember(Value = "EMUT")]
    [IsoId("_qJ-ZsyB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied by a county to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999)."
    )]
    EmergencyAssistanceCountyTax = AddendumTaxTypeCode.EmergencyAssistanceCountyTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Usage tax levied to recover the cost of telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMET&quot;.
    /// </summary>
    [EnumMember(Value = "EMET")]
    [IsoId("_qJ-ZtSB_Eey8XKHwKquEQw")]
    [Description(
        @"Usage tax levied to recover the cost of telephone emergency assistance service (for example, 112, 911, 999)."
    )]
    EmergencyAssistanceExciseTax = AddendumTaxTypeCode.EmergencyAssistanceExciseTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied by a state to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMST&quot;.
    /// </summary>
    [EnumMember(Value = "EMST")]
    [IsoId("_qJ-ZtyB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied by a state to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999)."
    )]
    EmergencyAssistanceStateTax = AddendumTaxTypeCode.EmergencyAssistanceStateTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied to recover the cost of providing telephone emergency assistance service (for example,112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMRT&quot;.
    /// </summary>
    [EnumMember(Value = "EMRT")]
    [IsoId("_qJ-ZuSB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied to recover the cost of providing telephone emergency assistance service (for example,112, 911, 999)."
    )]
    EmergencyAssistanceTax = AddendumTaxTypeCode.EmergencyAssistanceTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax applied to the utility and petroleum industries.
    /// Encoded/decoded by serializers as &quot;ENTX&quot;.
    /// </summary>
    [EnumMember(Value = "ENTX")]
    [IsoId("_qJ-ZuyB_Eey8XKHwKquEQw")]
    [Description(@"Tax applied to the utility and petroleum industries. ")]
    EnergyTax = AddendumTaxTypeCode.EnergyTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied by a state to recover the cost of providing enhanced telephone emergency assistance services (for example, 112, 911, 999) such as automatic call identification.
    /// Encoded/decoded by serializers as &quot;ESET&quot;.
    /// </summary>
    [EnumMember(Value = "ESET")]
    [IsoId("_qJ-ZvSB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied by a state to recover the cost of providing enhanced telephone emergency assistance services (for example, 112, 911, 999) such as automatic call identification."
    )]
    EnhancedEmergencyAssistanceStateExciseTax =
        AddendumTaxTypeCode.EnhancedEmergencyAssistanceStateExciseTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on activities which are considered to have negative impacts on an environment.
    /// Encoded/decoded by serializers as &quot;ENVT&quot;.
    /// </summary>
    [EnumMember(Value = "ENVT")]
    [IsoId("_qJ-ZvyB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied on activities which are considered to have negative impacts on an environment. "
    )]
    EnvironmentalTax = AddendumTaxTypeCode.EnvironmentalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_qJ-ZwSB_Eey8XKHwKquEQw")]
    [Description(
        @"Part of an investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year."
    )]
    Equalisation = AddendumTaxTypeCode.Equalisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equipment Tax
    /// Encoded/decoded by serializers as &quot;EQTX&quot;.
    /// </summary>
    [EnumMember(Value = "EQTX")]
    [IsoId("_qJ-ZwyB_Eey8XKHwKquEQw")]
    [Description(@"Equipment Tax")]
    EquipmentTax = AddendumTaxTypeCode.EquipmentTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as &quot;EUTR&quot;.
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_qJ-ZxSB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments."
    )]
    EUTaxRetention = AddendumTaxTypeCode.EUTaxRetention, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Executing broker&apos;s commission amount.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_qJ-ZxyB_Eey8XKHwKquEQw")]
    [Description(@"Executing broker's commission amount.")]
    ExecutingBrokerCommission = AddendumTaxTypeCode.ExecutingBrokerCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Excise tax levied by a federal government.
    /// Encoded/decoded by serializers as &quot;FEXT&quot;.
    /// </summary>
    [EnumMember(Value = "FEXT")]
    [IsoId("_qJ-ZzyB_Eey8XKHwKquEQw")]
    [Description(@"Excise tax levied by a federal government.")]
    FederalExciseTax = AddendumTaxTypeCode.FederalExciseTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Federal or National Sales Tax.
    /// Encoded/decoded by serializers as &quot;FNST&quot;.
    /// </summary>
    [EnumMember(Value = "FNST")]
    [IsoId("_qJ-Z0SB_Eey8XKHwKquEQw")]
    [Description(@"Federal or National Sales Tax.")]
    FederalNationalSalesTax = AddendumTaxTypeCode.FederalNationalSalesTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Usage tax levied by federal (US and Canadian) government.
    /// Encoded/decoded by serializers as &quot;FETX&quot;.
    /// </summary>
    [EnumMember(Value = "FETX")]
    [IsoId("_qJ-Z0yB_Eey8XKHwKquEQw")]
    [Description(@"Usage tax levied by federal (US and Canadian) government.")]
    FederalTax = AddendumTaxTypeCode.FederalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Federal Value-Added Tax (GST).
    /// Encoded/decoded by serializers as &quot;FVAT&quot;.
    /// </summary>
    [EnumMember(Value = "FVAT")]
    [IsoId("_qJ-Z1SB_Eey8XKHwKquEQw")]
    [Description(@"Federal Value-Added Tax (GST).")]
    FederalValueAddedTax = AddendumTaxTypeCode.FederalValueAddedTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Federal Value-Added Tax (GST) on Services
    /// Encoded/decoded by serializers as &quot;FVTS&quot;.
    /// </summary>
    [EnumMember(Value = "FVTS")]
    [IsoId("_qJ-Z1yB_Eey8XKHwKquEQw")]
    [Description(@"Federal Value-Added Tax (GST) on Services")]
    FederalValueAddedTaxOnServices = AddendumTaxTypeCode.FederalValueAddedTaxOnServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// USA Federal Insurance Contributions Act tax levied to assist in the funding of Medicare.
    /// Encoded/decoded by serializers as &quot;FIMT&quot;.
    /// </summary>
    [EnumMember(Value = "FIMT")]
    [IsoId("_qJ-Z2SB_Eey8XKHwKquEQw")]
    [Description(
        @"USA Federal Insurance Contributions Act tax levied to assist in the funding of Medicare."
    )]
    FICAMedicareTax = AddendumTaxTypeCode.FICAMedicareTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// USA Federal Insurance Contributions Act tax levied to assist in the funding of social security.
    /// Encoded/decoded by serializers as &quot;FSST&quot;.
    /// </summary>
    [EnumMember(Value = "FSST")]
    [IsoId("_qJ-Z2yB_Eey8XKHwKquEQw")]
    [Description(
        @"USA Federal Insurance Contributions Act tax levied to assist in the funding of social security."
    )]
    FICASocialSecurityTax = AddendumTaxTypeCode.FICASocialSecurityTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// USA Federal Insurance Contributions Act tax.
    /// Encoded/decoded by serializers as &quot;FICA&quot;.
    /// </summary>
    [EnumMember(Value = "FICA")]
    [IsoId("_qJ-Z3SB_Eey8XKHwKquEQw")]
    [Description(@"USA Federal Insurance Contributions Act tax.")]
    FICATax = AddendumTaxTypeCode.FICATax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied by a municipality, on certain types of businesses for the right to exist as a legal entity and conduct business in a particular jurisdiction.
    /// Encoded/decoded by serializers as &quot;FRTX&quot;.
    /// </summary>
    [EnumMember(Value = "FRTX")]
    [IsoId("_qJ-Z3yB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied by a municipality, on certain types of businesses for the right to exist as a legal entity and conduct business in a particular jurisdiction. "
    )]
    FranchiseTax = AddendumTaxTypeCode.FranchiseTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fuel Spill Tax.
    /// Encoded/decoded by serializers as &quot;FSTX&quot;.
    /// </summary>
    [EnumMember(Value = "FSTX")]
    [IsoId("_qJ-Z4SB_Eey8XKHwKquEQw")]
    [Description(@"Fuel Spill Tax.")]
    FuelSpillTax = AddendumTaxTypeCode.FuelSpillTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// USA federal tax levied on certain types of businesses to provide funding for cleanup of hazardous waste sites.
    /// Encoded/decoded by serializers as &quot;FSFT&quot;.
    /// </summary>
    [EnumMember(Value = "FSFT")]
    [IsoId("_qJ-Z4yB_Eey8XKHwKquEQw")]
    [Description(
        @"USA federal tax levied on certain types of businesses to provide funding for cleanup of hazardous waste sites. "
    )]
    FuelSuperFundTax = AddendumTaxTypeCode.FuelSuperFundTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value Added Tax calculated at the full tax rate.
    /// Encoded/decoded by serializers as &quot;FUVT&quot;.
    /// </summary>
    [EnumMember(Value = "FUVT")]
    [IsoId("_qJ-Z5SB_Eey8XKHwKquEQw")]
    [Description(@"Value Added Tax calculated at the full tax rate.")]
    FullVAT = AddendumTaxTypeCode.FullVAT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.
    /// Encoded/decoded by serializers as &quot;GIFT&quot;.
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_qJ-Z5yB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth."
    )]
    GiftTax = AddendumTaxTypeCode.GiftTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Goods and Services Tax - Canadian value-added tax.
    /// Encoded/decoded by serializers as &quot;GCAT&quot;.
    /// </summary>
    [EnumMember(Value = "GCAT")]
    [IsoId("_qJ-Z6SB_Eey8XKHwKquEQw")]
    [Description(@"Goods and Services Tax - Canadian value-added tax.")]
    GoodsAndServicesTax = AddendumTaxTypeCode.GoodsAndServicesTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gross Receipts Tax.
    /// Encoded/decoded by serializers as &quot;GRTX&quot;.
    /// </summary>
    [EnumMember(Value = "GRTX")]
    [IsoId("_qJ-Z6yB_Eey8XKHwKquEQw")]
    [Description(@"Gross Receipts Tax.")]
    GrossReceiptsTax = AddendumTaxTypeCode.GrossReceiptsTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value Added Tax calculated at the half tax rate.
    /// Encoded/decoded by serializers as &quot;HVAT&quot;.
    /// </summary>
    [EnumMember(Value = "HVAT")]
    [IsoId("_qJ-Z7SB_Eey8XKHwKquEQw")]
    [Description(@"Value Added Tax calculated at the half tax rate.")]
    HalfVAT = AddendumTaxTypeCode.HalfVAT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax assessed to assist the handicapped.
    /// Encoded/decoded by serializers as &quot;HATX&quot;.
    /// </summary>
    [EnumMember(Value = "HATX")]
    [IsoId("_qJ-Z7yB_Eey8XKHwKquEQw")]
    [Description(@"Tax assessed to assist the handicapped.")]
    HandicapTax = AddendumTaxTypeCode.HandicapTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Harmonized Sales Tax (HST).
    /// Encoded/decoded by serializers as &quot;HSTX&quot;.
    /// </summary>
    [EnumMember(Value = "HSTX")]
    [IsoId("_qJ-Z8SB_Eey8XKHwKquEQw")]
    [Description(@"Harmonized Sales Tax (HST).")]
    HarmonizedSalesTax = AddendumTaxTypeCode.HarmonizedSalesTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on entities that produce, store, treat, transport or otherwise manage hazardous wastes and materials.
    /// Encoded/decoded by serializers as &quot;HWTX&quot;.
    /// </summary>
    [EnumMember(Value = "HWTX")]
    [IsoId("_qJ-Z8yB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied on entities that produce, store, treat, transport or otherwise manage hazardous wastes and materials."
    )]
    HazardousWasteTax = AddendumTaxTypeCode.HazardousWasteTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.
    /// Encoded/decoded by serializers as &quot;INHT&quot;.
    /// </summary>
    [EnumMember(Value = "INHT")]
    [IsoId("_qJ-Z9SB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death."
    )]
    InheritanceTax = AddendumTaxTypeCode.InheritanceTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on the sum of all earnings/revenues accrued since the last dividend distribution.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_qJ-Z9yB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied on the sum of all earnings/revenues accrued since the last dividend distribution."
    )]
    InterimProfitTax = AddendumTaxTypeCode.InterimProfitTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Labour by Trade Tax
    /// Encoded/decoded by serializers as &quot;LTTX&quot;.
    /// </summary>
    [EnumMember(Value = "LTTX")]
    [IsoId("_qJ-Z-SB_Eey8XKHwKquEQw")]
    [Description(@"Labour by Trade Tax")]
    LabourByTradeTax = AddendumTaxTypeCode.LabourByTradeTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Federal tax levied in the USA to fund the clean-up activities associated with leaking underground storage tanks.
    /// Encoded/decoded by serializers as &quot;FLST&quot;.
    /// </summary>
    [EnumMember(Value = "FLST")]
    [IsoId("_qJ-Z-yB_Eey8XKHwKquEQw")]
    [Description(
        @"Federal tax levied in the USA to fund the clean-up activities associated with leaking underground storage tanks."
    )]
    LeakyUndergroundStorageTankTax = AddendumTaxTypeCode.LeakyUndergroundStorageTankTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied by a government agency for the granting of a license to conduct an activity, such as driving a car, operating a business, selling liquor, hunting, or practicing certain vocations.
    /// Encoded/decoded by serializers as &quot;LITX&quot;.
    /// </summary>
    [EnumMember(Value = "LITX")]
    [IsoId("_qJ-Z_SB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied by a government agency for the granting of a license to conduct an activity, such as driving a car, operating a business, selling liquor, hunting, or practicing certain vocations."
    )]
    LicenseTax = AddendumTaxTypeCode.LicenseTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Local broker&apos;s commission amount.
    /// Encoded/decoded by serializers as &quot;LOCO&quot;.
    /// </summary>
    [EnumMember(Value = "LOCO")]
    [IsoId("_qJ-Z_yB_Eey8XKHwKquEQw")]
    [Description(@"Local broker's commission amount.")]
    LocalBrokerCommission = AddendumTaxTypeCode.LocalBrokerCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All applicable sales taxes levied by taxing authorities below the state level. Used only for sales tax.
    /// Encoded/decoded by serializers as &quot;LSTX&quot;.
    /// </summary>
    [EnumMember(Value = "LSTX")]
    [IsoId("_qJ_AoyB_Eey8XKHwKquEQw")]
    [Description(
        @"All applicable sales taxes levied by taxing authorities below the state level. Used only for sales tax. "
    )]
    LocalSalesTax = AddendumTaxTypeCode.LocalSalesTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service tax levied by a local government or taxation agency. Not a sales tax.
    /// Encoded/decoded by serializers as &quot;LOCL&quot;.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_qJ_ApSB_Eey8XKHwKquEQw")]
    [Description(@"Service tax levied by a local government or taxation agency. Not a sales tax. ")]
    LocalTax = AddendumTaxTypeCode.LocalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ad valorem tax levied on products or services that are deemed to be non-essential or unneeded.
    /// Encoded/decoded by serializers as &quot;LUTX&quot;.
    /// </summary>
    [EnumMember(Value = "LUTX")]
    [IsoId("_qJ_ApyB_Eey8XKHwKquEQw")]
    [Description(
        @"Ad valorem tax levied on products or services that are deemed to be non-essential or unneeded."
    )]
    LuxuryTax = AddendumTaxTypeCode.LuxuryTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Material Tax
    /// Encoded/decoded by serializers as &quot;MATX&quot;.
    /// </summary>
    [EnumMember(Value = "MATX")]
    [IsoId("_qJ_AqSB_Eey8XKHwKquEQw")]
    [Description(@"Material Tax")]
    MaterialTax = AddendumTaxTypeCode.MaterialTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Metropolitan Transit Tax
    /// Encoded/decoded by serializers as &quot;METX&quot;.
    /// </summary>
    [EnumMember(Value = "METX")]
    [IsoId("_qJ_AqyB_Eey8XKHwKquEQw")]
    [Description(@"Metropolitan Transit Tax")]
    MetropolitanTransitTax = AddendumTaxTypeCode.MetropolitanTransitTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Minimum Tax
    /// Encoded/decoded by serializers as &quot;MITX&quot;.
    /// </summary>
    [EnumMember(Value = "MITX")]
    [IsoId("_qJ_ArSB_Eey8XKHwKquEQw")]
    [Description(@"Minimum Tax")]
    MinimumTax = AddendumTaxTypeCode.MinimumTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service tax imposed by a municipality.
    /// Encoded/decoded by serializers as &quot;MUTX&quot;.
    /// </summary>
    [EnumMember(Value = "MUTX")]
    [IsoId("_qJ_AryB_Eey8XKHwKquEQw")]
    [Description(@"Service tax imposed by a municipality.")]
    MunicipalTax = AddendumTaxTypeCode.MunicipalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mutually Defined
    /// Encoded/decoded by serializers as &quot;MUDE&quot;.
    /// </summary>
    [EnumMember(Value = "MUDE")]
    [IsoId("_qJ_AsSB_Eey8XKHwKquEQw")]
    [Description(@"Mutually Defined")]
    MutuallyDefinedTax = AddendumTaxTypeCode.MutuallyDefinedTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a country, national, or federal tax usually levied by the custodian.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_qJ_AsyB_Eey8XKHwKquEQw")]
    [Description(@"Tax is a country, national, or federal tax usually levied by the custodian.")]
    NationalFederalTax = AddendumTaxTypeCode.NationalFederalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_qJ_AuyB_Eey8XKHwKquEQw")]
    [Description(@"Tax is a national tax.")]
    NationalTax = AddendumTaxTypeCode.NationalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied for the privelage of occupying space for home or rental for a fixed period of time, as determined by a taxing authority.
    /// Encoded/decoded by serializers as &quot;OCTX&quot;.
    /// </summary>
    [EnumMember(Value = "OCTX")]
    [IsoId("_qJ_AvSB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied for the privelage of occupying space for home or rental for a fixed period of time, as determined by a taxing authority. |"
    )]
    OccupancyTax = AddendumTaxTypeCode.OccupancyTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of gross receipts tax imposed for the privilege of carrying on a business, trade or profession.
    /// Encoded/decoded by serializers as &quot;OPTX&quot;.
    /// </summary>
    [EnumMember(Value = "OPTX")]
    [IsoId("_qJ_AvyB_Eey8XKHwKquEQw")]
    [Description(
        @"Type of gross receipts tax imposed for the privilege of carrying on a business, trade or profession.|"
    )]
    OccupationalTax = AddendumTaxTypeCode.OccupationalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of tax not elsewhere classified.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_qJ_AwSB_Eey8XKHwKquEQw")]
    [Description(@"Other type of tax not elsewhere classified.")]
    Other = AddendumTaxTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other national use defined value
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_qJ_AwyB_Eey8XKHwKquEQw")]
    [Description(@"Other national use defined value")]
    OtherNational = AddendumTaxTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other private use defined value
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_qJ_AxSB_Eey8XKHwKquEQw")]
    [Description(@"Other private use defined value")]
    OtherPrivate = AddendumTaxTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other taxes
    /// Encoded/decoded by serializers as &quot;OTTX&quot;.
    /// </summary>
    [EnumMember(Value = "OTTX")]
    [IsoId("_qJ_AxyB_Eey8XKHwKquEQw")]
    [Description(@"Other taxes")]
    OtherTaxes = AddendumTaxTypeCode.OtherTaxes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on a payment.
    /// Encoded/decoded by serializers as &quot;LEVY&quot;.
    /// </summary>
    [EnumMember(Value = "LEVY")]
    [IsoId("_qJ_AySB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied on a payment.")]
    PaymentLevyTax = AddendumTaxTypeCode.PaymentLevyTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Post-threshold Tax
    /// Encoded/decoded by serializers as &quot;POTX&quot;.
    /// </summary>
    [EnumMember(Value = "POTX")]
    [IsoId("_qJ_A0SB_Eey8XKHwKquEQw")]
    [Description(@"Post-threshold Tax")]
    PostThresholdTax = AddendumTaxTypeCode.PostThresholdTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre-threshold tax
    /// Encoded/decoded by serializers as &quot;PRTX&quot;.
    /// </summary>
    [EnumMember(Value = "PRTX")]
    [IsoId("_qJ_A0yB_Eey8XKHwKquEQw")]
    [Description(@"Pre-threshold tax")]
    PreThresholdTax = AddendumTaxTypeCode.PreThresholdTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on products and services
    /// Encoded/decoded by serializers as &quot;PSTX&quot;.
    /// </summary>
    [EnumMember(Value = "PSTX")]
    [IsoId("_qJ_A1SB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied on products and services")]
    ProductAndServicesTax = AddendumTaxTypeCode.ProductAndServicesTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ad valorem property tax levied on real or personal property by local government units such as counties, municipalities, school districts, and special taxing districts.
    /// Encoded/decoded by serializers as &quot;PPTX&quot;.
    /// </summary>
    [EnumMember(Value = "PPTX")]
    [IsoId("_qJ_A1yB_Eey8XKHwKquEQw")]
    [Description(
        @"Ad valorem property tax levied on real or personal property by local government units such as counties, municipalities, school districts, and special taxing districts."
    )]
    PropertyTax = AddendumTaxTypeCode.PropertyTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Provincial tax
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_qJ_A2SB_Eey8XKHwKquEQw")]
    [Description(@"Provincial tax")]
    ProvincialTax = AddendumTaxTypeCode.ProvincialTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Canadian tax levied to fund public care and education.
    /// Encoded/decoded by serializers as &quot;PHET&quot;.
    /// </summary>
    [EnumMember(Value = "PHET")]
    [IsoId("_qJ_A2yB_Eey8XKHwKquEQw")]
    [Description(@"Canadian tax levied to fund public care and education. ")]
    PublicHealthAndEducationTax = AddendumTaxTypeCode.PublicHealthAndEducationTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quebec Sales Tax (QST)
    /// Encoded/decoded by serializers as &quot;QUST&quot;.
    /// </summary>
    [EnumMember(Value = "QUST")]
    [IsoId("_qJ_A3SB_Eey8XKHwKquEQw")]
    [Description(@"Quebec Sales Tax (QST)")]
    QuebecSalesTax = AddendumTaxTypeCode.QuebecSalesTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Room City
    /// Encoded/decoded by serializers as &quot;ROCI&quot;.
    /// </summary>
    [EnumMember(Value = "ROCI")]
    [IsoId("_qJ_A3yB_Eey8XKHwKquEQw")]
    [Description(@"Room City")]
    RoomCity = AddendumTaxTypeCode.RoomCity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Room Country Subdivision1
    /// Encoded/decoded by serializers as &quot;RCSB&quot;.
    /// </summary>
    [EnumMember(Value = "RCSB")]
    [IsoId("_qJ_A4SB_Eey8XKHwKquEQw")]
    [Description(@"Room Country Subdivision1")]
    RoomCountrySubdivision1 = AddendumTaxTypeCode.RoomCountrySubdivision1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Room Country Subdivision2
    /// Encoded/decoded by serializers as &quot;RCSD&quot;.
    /// </summary>
    [EnumMember(Value = "RCSD")]
    [IsoId("_qJ_A4yB_Eey8XKHwKquEQw")]
    [Description(@"Room Country Subdivision2")]
    RoomCountrySubdivision2 = AddendumTaxTypeCode.RoomCountrySubdivision2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Room Tax
    /// Encoded/decoded by serializers as &quot;ROTX&quot;.
    /// </summary>
    [EnumMember(Value = "ROTX")]
    [IsoId("_qJ_A5SB_Eey8XKHwKquEQw")]
    [Description(@"Room Tax")]
    RoomTax = AddendumTaxTypeCode.RoomTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Room VAT
    /// Encoded/decoded by serializers as &quot;RVAT&quot;.
    /// </summary>
    [EnumMember(Value = "RVAT")]
    [IsoId("_qJ_A5yB_Eey8XKHwKquEQw")]
    [Description(@"Room VAT")]
    RoomVAT = AddendumTaxTypeCode.RoomVAT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Room Visitor
    /// Encoded/decoded by serializers as &quot;ROVI&quot;.
    /// </summary>
    [EnumMember(Value = "ROVI")]
    [IsoId("_qJ_A6SB_Eey8XKHwKquEQw")]
    [Description(@"Room Visitor")]
    RoomVisitor = AddendumTaxTypeCode.RoomVisitor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied for the use of equipment and service provided
    /// Encoded/decoded by serializers as &quot;SAUT&quot;.
    /// </summary>
    [EnumMember(Value = "SAUT")]
    [IsoId("_qJ_A6yB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied for the use of equipment and service provided")]
    SalesAndUseTax = AddendumTaxTypeCode.SalesAndUseTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied by taxing authority for schools
    /// Encoded/decoded by serializers as &quot;SCTX&quot;.
    /// </summary>
    [EnumMember(Value = "SCTX")]
    [IsoId("_qJ_A7SB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied by taxing authority for schools")]
    SchoolTax = AddendumTaxTypeCode.SchoolTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secondary Percentage Tax
    /// Encoded/decoded by serializers as &quot;SPTX&quot;.
    /// </summary>
    [EnumMember(Value = "SPTX")]
    [IsoId("_qJ_A7yB_Eey8XKHwKquEQw")]
    [Description(@"Secondary Percentage Tax")]
    SecondaryPercentageTax = AddendumTaxTypeCode.SecondaryPercentageTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stadium Tax
    /// Encoded/decoded by serializers as &quot;STTA&quot;.
    /// </summary>
    [EnumMember(Value = "STTA")]
    [IsoId("_qJ_A8SB_Eey8XKHwKquEQw")]
    [Description(@"Stadium Tax")]
    StadiumTax = AddendumTaxTypeCode.StadiumTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on certain types of documents and transactions.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_qJ_A8yB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied on certain types of documents and transactions.")]
    StampDuty = AddendumTaxTypeCode.StampDuty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State and Local Sales Tax
    /// Encoded/decoded by serializers as &quot;SLST&quot;.
    /// </summary>
    [EnumMember(Value = "SLST")]
    [IsoId("_qJ_A9SB_Eey8XKHwKquEQw")]
    [Description(@"State and Local Sales Tax")]
    StateAndLocalSalesTax = AddendumTaxTypeCode.StateAndLocalSalesTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State and local tax levies, exclusive of state and local sales tax.
    /// Encoded/decoded by serializers as &quot;SLTX&quot;.
    /// </summary>
    [EnumMember(Value = "SLTX")]
    [IsoId("_qJ_A9yB_Eey8XKHwKquEQw")]
    [Description(@"State and local tax levies, exclusive of state and local sales tax. ")]
    StateAndLocalTax = AddendumTaxTypeCode.StateAndLocalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Usage tax imposed by state or provincial government authorities.
    /// Encoded/decoded by serializers as &quot;SETX&quot;.
    /// </summary>
    [EnumMember(Value = "SETX")]
    [IsoId("_qJ_A-SB_Eey8XKHwKquEQw")]
    [Description(@"Usage tax imposed by state or provincial government authorities.")]
    StateExciseTax = AddendumTaxTypeCode.StateExciseTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sales tax levied by a State or Province that excludes sales or excise taxes.
    /// Encoded/decoded by serializers as &quot;STPT&quot;.
    /// </summary>
    [EnumMember(Value = "STPT")]
    [IsoId("_qJ_A-yB_Eey8XKHwKquEQw")]
    [Description(@"Sales tax levied by a State or Province that excludes sales or excise taxes.")]
    StateOrProvincialTax = AddendumTaxTypeCode.StateOrProvincialTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State or Provincial tax on services
    /// Encoded/decoded by serializers as &quot;SPTS&quot;.
    /// </summary>
    [EnumMember(Value = "SPTS")]
    [IsoId("_qJ_A_SB_Eey8XKHwKquEQw")]
    [Description(@"State or Provincial tax on services")]
    StateOrProvincialTaxOnServices = AddendumTaxTypeCode.StateOrProvincialTaxOnServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State or Provincial Fuel Tax
    /// Encoded/decoded by serializers as &quot;SPFT&quot;.
    /// </summary>
    [EnumMember(Value = "SPFT")]
    [IsoId("_qJ_A_yB_Eey8XKHwKquEQw")]
    [Description(@"State or Provincial Fuel Tax")]
    StateProvincialFuelTax = AddendumTaxTypeCode.StateProvincialFuelTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State or Provincial Tax on Goods
    /// Encoded/decoded by serializers as &quot;SPTG&quot;.
    /// </summary>
    [EnumMember(Value = "SPTG")]
    [IsoId("_qJ_BASB_Eey8XKHwKquEQw")]
    [Description(@"State or Provincial Tax on Goods")]
    StateProvincialTaxOnGoods = AddendumTaxTypeCode.StateProvincialTaxOnGoods, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied by a state government against a periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;SRTX&quot;.
    /// </summary>
    [EnumMember(Value = "SRTX")]
    [IsoId("_qJ_BAyB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied by a state government against a periodic fee paid by a customer in return for the right to use the property of another party."
    )]
    StateRentalTax = AddendumTaxTypeCode.StateRentalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State Sales Tax
    /// Encoded/decoded by serializers as &quot;SSTX&quot;.
    /// </summary>
    [EnumMember(Value = "SSTX")]
    [IsoId("_qJ_BBSB_Eey8XKHwKquEQw")]
    [Description(@"State Sales Tax")]
    StateSalesTax = AddendumTaxTypeCode.StateSalesTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State tax.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_qJ_BByB_Eey8XKHwKquEQw")]
    [Description(@"State tax.")]
    StateTax = AddendumTaxTypeCode.StateTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State Tax on Specific Labour
    /// Encoded/decoded by serializers as &quot;STSL&quot;.
    /// </summary>
    [EnumMember(Value = "STSL")]
    [IsoId("_qJ_BCSB_Eey8XKHwKquEQw")]
    [Description(@"State Tax on Specific Labour")]
    StateTaxOnSpecificLabour = AddendumTaxTypeCode.StateTaxOnSpecificLabour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied by a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_qJ_BCyB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied by a stock exchange.")]
    StockExchangeTax = AddendumTaxTypeCode.StockExchangeTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Surtax
    /// Encoded/decoded by serializers as &quot;SUTX&quot;.
    /// </summary>
    [EnumMember(Value = "SUTX")]
    [IsoId("_qJ_BEyB_Eey8XKHwKquEQw")]
    [Description(@"Surtax")]
    Surtax = AddendumTaxTypeCode.Surtax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct reduction of an individual&apos;s tax liability.
    /// Encoded/decoded by serializers as &quot;CTAX&quot;.
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_qJ_BFSB_Eey8XKHwKquEQw")]
    [Description(@"Direct reduction of an individual's tax liability.")]
    TaxCredit = AddendumTaxTypeCode.TaxCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Excise tax levied to recover the cost of providing Telecommunications Device for the Deaf (TDD) Equipment.
    /// Encoded/decoded by serializers as &quot;TDDT&quot;.
    /// </summary>
    [EnumMember(Value = "TDDT")]
    [IsoId("_qJ_BFyB_Eey8XKHwKquEQw")]
    [Description(
        @"Excise tax levied to recover the cost of providing Telecommunications Device for the Deaf (TDD) Equipment. "
    )]
    TDDServiceExciseTax = AddendumTaxTypeCode.TDDServiceExciseTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on telecommunications companies for the right to provide services. May be a usage or excise tax.
    /// Encoded/decoded by serializers as &quot;TELT&quot;.
    /// </summary>
    [EnumMember(Value = "TELT")]
    [IsoId("_qJ_BGSB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied on telecommunications companies for the right to provide services. May be a usage or excise tax."
    )]
    TelecommunicationsTax = AddendumTaxTypeCode.TelecommunicationsTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Threshold Tax
    /// Encoded/decoded by serializers as &quot;THTX&quot;.
    /// </summary>
    [EnumMember(Value = "THTX")]
    [IsoId("_qJ_BGyB_Eey8XKHwKquEQw")]
    [Description(@"Threshold Tax")]
    ThresholdTax = AddendumTaxTypeCode.ThresholdTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on a transaction.
    /// Encoded/decoded by serializers as &quot;TRAX&quot;.
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_qJ_BHSB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied on a transaction.")]
    TransactionTax = AddendumTaxTypeCode.TransactionTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on a transfer.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_qJ_BJSB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied on a transfer.")]
    TransferTax = AddendumTaxTypeCode.TransferTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unspecified tax type
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_qJ_BLSB_Eey8XKHwKquEQw")]
    [Description(@"Unspecified tax type")]
    Unspecified = AddendumTaxTypeCode.Unspecified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on consumers by a city or county for the use of natural gas.
    /// Encoded/decoded by serializers as &quot;UUTX&quot;.
    /// </summary>
    [EnumMember(Value = "UUTX")]
    [IsoId("_qJ_BLyB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied on consumers by a city or county for the use of natural gas. ")]
    UtilityUsersTax = AddendumTaxTypeCode.UtilityUsersTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value added tax
    /// Encoded/decoded by serializers as &quot;VATA&quot;.
    /// </summary>
    [EnumMember(Value = "VATA")]
    [IsoId("_qJ_BMSB_Eey8XKHwKquEQw")]
    [Description(@"Value added tax")]
    ValueAddedTax = AddendumTaxTypeCode.ValueAddedTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax for which a zero rate applies.
    /// Encoded/decoded by serializers as &quot;VATB&quot;.
    /// </summary>
    [EnumMember(Value = "VATB")]
    [IsoId("_qJ_BOSB_Eey8XKHwKquEQw")]
    [Description(@"Tax for which a zero rate applies.")]
    ValueAddedTaxOfZeroRate = AddendumTaxTypeCode.ValueAddedTaxOfZeroRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied only when the value of assets or categories of assets owned by an entity are above a given limit as defined by the tax authority. Wealth tax is not linked to income.
    /// Encoded/decoded by serializers as &quot;WTAX&quot;.
    /// </summary>
    [EnumMember(Value = "WTAX")]
    [IsoId("_qJ_BOyB_Eey8XKHwKquEQw")]
    [Description(
        @"Tax levied only when the value of assets or categories of assets owned by an entity are above a given limit as defined by the tax authority. Wealth tax is not linked to income."
    )]
    WealthTax = AddendumTaxTypeCode.WealthTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Well Service
    /// Encoded/decoded by serializers as &quot;WESV&quot;.
    /// </summary>
    [EnumMember(Value = "WESV")]
    [IsoId("_qJ_BPSB_Eey8XKHwKquEQw")]
    [Description(@"Well Service")]
    WellService = AddendumTaxTypeCode.WellService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITF&quot;.
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_qJ_BPyB_Eey8XKHwKquEQw")]
    [Description(
        @"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible."
    )]
    WithholdingOfForeignTax = AddendumTaxTypeCode.WithholdingOfForeignTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITL&quot;.
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_qJ_BQSB_Eey8XKHwKquEQw")]
    [Description(
        @"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible."
    )]
    WithholdingOfLocalTax = AddendumTaxTypeCode.WithholdingOfLocalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income tax withheld or deducted from the amount due to the recipient, and paid to the government by the payer rather than the recipient. May apply to salaries, interest, and other types of proceeds.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_qJ_BQyB_Eey8XKHwKquEQw")]
    [Description(
        @"Income tax withheld or deducted from the amount due to the recipient, and paid to the government by the payer rather than the recipient. May apply to salaries, interest, and other types of proceeds. "
    )]
    WithholdingTax = AddendumTaxTypeCode.WithholdingTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on non-room expenditures.
    /// Encoded/decoded by serializers as &quot;TNRT&quot;.
    /// </summary>
    [EnumMember(Value = "TNRT")]
    [IsoId("_x8hv4SB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied on non-room expenditures.")]
    TotalNonRoomTax = AddendumTaxTypeCode.TotalNonRoomTax, // same ordinal as derivation source for type conversions
}
