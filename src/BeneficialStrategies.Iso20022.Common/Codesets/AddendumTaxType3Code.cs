// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the specific type of tax applicable to a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AddendumTaxType3Code")]
[Description(@"Specifies the specific type of tax applicable to a transaction.")]
[DerivedFrom(typeof(AddendumTaxTypeCode))]
public enum AddendumTaxType3Code
{
    /// <summary>
    /// Tax is an alternative minimum tax.
    /// Encoded/decoded by serializers as &quot;ALMI&quot;.
    /// </summary>
    [EnumMember(Value = "ALMI")]
    [IsoId("_AddendumTaxType3Code_AlternativeMinimumTax")]
    [Description(@"Tax is an alternative minimum tax.")]
    AlternativeMinimumTax = AddendumTaxTypeCode.AlternativeMinimumTax,

    /// <summary>
    /// Assessment
    /// Encoded/decoded by serializers as &quot;ASNT&quot;.
    /// </summary>
    [EnumMember(Value = "ASNT")]
    [IsoId("_AddendumTaxType3Code_Assessment")]
    [Description(@"Assessment")]
    Assessment = AddendumTaxTypeCode.Assessment,

    /// <summary>
    /// Tax imposed on non-American Indian businesses for the privilege of conducting business on an American Indian Reservation
    /// Encoded/decoded by serializers as &quot;BPTX&quot;.
    /// </summary>
    [EnumMember(Value = "BPTX")]
    [IsoId("_AddendumTaxType3Code_BusinessPrivilegeTax")]
    [Description(
        @"Tax imposed on non-American Indian businesses for the privilege of conducting business on an American Indian Reservation"
    )]
    BusinessPrivilegeTax = AddendumTaxTypeCode.BusinessPrivilegeTax,

    /// <summary>
    /// Service tax imposed by a city
    /// Encoded/decoded by serializers as &quot;CITX&quot;.
    /// </summary>
    [EnumMember(Value = "CITX")]
    [IsoId("_AddendumTaxType3Code_CityTax")]
    [Description(@"Service tax imposed by a city")]
    CityTax = AddendumTaxTypeCode.CityTax,

    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_AddendumTaxType3Code_ConsumptionTax")]
    [Description(
        @"Tax that is levied on goods and services purchased by customers, and is added to the retail price."
    )]
    ConsumptionTax = AddendumTaxTypeCode.ConsumptionTax,

    /// <summary>
    /// Levied by a county government against the periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_AddendumTaxType3Code_CountyRentalTax")]
    [Description(
        @"Levied by a county government against the periodic fee paid by a customer in return for the right to use the property of another party."
    )]
    CountyRentalTax = AddendumTaxTypeCode.CountyRentalTax,

    /// <summary>
    /// Service tax levied by a county
    /// Encoded/decoded by serializers as &quot;COTX&quot;.
    /// </summary>
    [EnumMember(Value = "COTX")]
    [IsoId("_AddendumTaxType3Code_CountyTax")]
    [Description(@"Service tax levied by a county")]
    CountyTax = AddendumTaxTypeCode.CountyTax,

    /// <summary>
    /// Tax is a country, national, or federal tax usually levied by the custodian.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_AddendumTaxType3Code_NationalFederalTax")]
    [Description(@"Tax is a country, national, or federal tax usually levied by the custodian.")]
    NationalFederalTax = AddendumTaxTypeCode.NationalFederalTax,

    /// <summary>
    /// Service tax imposed by a County or Parish
    /// Encoded/decoded by serializers as &quot;CPST&quot;.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_AddendumTaxType3Code_CountyParishSalesTax")]
    [Description(@"Service tax imposed by a County or Parish")]
    CountyParishSalesTax = AddendumTaxTypeCode.CountyParishSalesTax,

    /// <summary>
    /// Levied by a city government against the periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;CRTX&quot;.
    /// </summary>
    [EnumMember(Value = "CRTX")]
    [IsoId("_AddendumTaxType3Code_CityRentalTax")]
    [Description(
        @"Levied by a city government against the periodic fee paid by a customer in return for the right to use the property of another party."
    )]
    CityRentalTax = AddendumTaxTypeCode.CityRentalTax,

    /// <summary>
    /// Sales tax imposed by a city
    /// Encoded/decoded by serializers as &quot;CSTX&quot;.
    /// </summary>
    [EnumMember(Value = "CSTX")]
    [IsoId("_AddendumTaxType3Code_CitySalesTax")]
    [Description(@"Sales tax imposed by a city")]
    CitySalesTax = AddendumTaxTypeCode.CitySalesTax,

    /// <summary>
    /// Direct reduction of an individual’s tax liability.
    /// Encoded/decoded by serializers as &quot;CTAX&quot;.
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_AddendumTaxType3Code_TaxCredit")]
    [Description(@"Direct reduction of an individual’s tax liability.")]
    TaxCredit = AddendumTaxTypeCode.TaxCredit,

    /// <summary>
    /// Tax levied on imports or exports by a country’s customs authority.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_AddendumTaxType3Code_CustomsTax")]
    [Description(@"Tax levied on imports or exports by a country’s customs authority.")]
    CustomsTax = AddendumTaxTypeCode.CustomsTax,

    /// <summary>
    /// Default Labour Tax
    /// Encoded/decoded by serializers as &quot;DLTX&quot;.
    /// </summary>
    [EnumMember(Value = "DLTX")]
    [IsoId("_AddendumTaxType3Code_DefaultLabourTax")]
    [Description(@"Default Labour Tax")]
    DefaultLabourTax = AddendumTaxTypeCode.DefaultLabourTax,

    /// <summary>
    /// Departure Tax
    /// Encoded/decoded by serializers as &quot;DPTX&quot;.
    /// </summary>
    [EnumMember(Value = "DPTX")]
    [IsoId("_AddendumTaxType3Code_DepartureTax")]
    [Description(@"Departure Tax")]
    DepartureTax,

    /// <summary>
    /// A tax levied on goods that typically though not exclusively transit across a geographic border.
    /// Encoded/decoded by serializers as &quot;DUTY&quot;.
    /// </summary>
    [EnumMember(Value = "DUTY")]
    [IsoId("_AddendumTaxType3Code_Duty")]
    [Description(
        @"A tax levied on goods that typically though not exclusively transit across a geographic border."
    )]
    Duty = AddendumTaxTypeCode.Duty,

    /// <summary>
    /// Usage tax levied to recover the cost of telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMET&quot;.
    /// </summary>
    [EnumMember(Value = "EMET")]
    [IsoId("_AddendumTaxType3Code_EmergencyAssistanceExciseTax")]
    [Description(
        @"Usage tax levied to recover the cost of telephone emergency assistance service (for example, 112, 911, 999)."
    )]
    EmergencyAssistanceExciseTax = AddendumTaxTypeCode.EmergencyAssistanceExciseTax,

    /// <summary>
    /// Tax levied by a city to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMIT&quot;.
    /// </summary>
    [EnumMember(Value = "EMIT")]
    [IsoId("_AddendumTaxType3Code_EmergencyAssistanceCityTax")]
    [Description(
        @"Tax levied by a city to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999)."
    )]
    EmergencyAssistanceCityTax = AddendumTaxTypeCode.EmergencyAssistanceCityTax,

    /// <summary>
    /// Tax levied to recover the cost of providing telephone emergency assistance service (for example,112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMRT&quot;.
    /// </summary>
    [EnumMember(Value = "EMRT")]
    [IsoId("_AddendumTaxType3Code_EmergencyAssistanceTax")]
    [Description(
        @"Tax levied to recover the cost of providing telephone emergency assistance service (for example,112, 911, 999)."
    )]
    EmergencyAssistanceTax = AddendumTaxTypeCode.EmergencyAssistanceTax,

    /// <summary>
    /// Tax levied by a state to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMST&quot;.
    /// </summary>
    [EnumMember(Value = "EMST")]
    [IsoId("_AddendumTaxType3Code_EmergencyAssistanceStateTax")]
    [Description(
        @"Tax levied by a state to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999)."
    )]
    EmergencyAssistanceStateTax = AddendumTaxTypeCode.EmergencyAssistanceStateTax,

    /// <summary>
    /// Tax levied by a county to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMUT&quot;.
    /// </summary>
    [EnumMember(Value = "EMUT")]
    [IsoId("_AddendumTaxType3Code_EmergencyAssistanceCountyTax")]
    [Description(
        @"Tax levied by a county to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999)."
    )]
    EmergencyAssistanceCountyTax = AddendumTaxTypeCode.EmergencyAssistanceCountyTax,

    /// <summary>
    /// Tax applied to the utility and petroleum industries.
    /// Encoded/decoded by serializers as &quot;ENTX&quot;.
    /// </summary>
    [EnumMember(Value = "ENTX")]
    [IsoId("_AddendumTaxType3Code_EnergyTax")]
    [Description(@"Tax applied to the utility and petroleum industries.")]
    EnergyTax = AddendumTaxTypeCode.EnergyTax,

    /// <summary>
    /// Tax levied on activities which are considered to have negative impacts on an environment.
    /// Encoded/decoded by serializers as &quot;ENVT&quot;.
    /// </summary>
    [EnumMember(Value = "ENVT")]
    [IsoId("_AddendumTaxType3Code_EnvironmentalTax")]
    [Description(
        @"Tax levied on activities which are considered to have negative impacts on an environment."
    )]
    EnvironmentalTax = AddendumTaxTypeCode.EnvironmentalTax,

    /// <summary>
    /// Equipment Tax
    /// Encoded/decoded by serializers as &quot;EQTX&quot;.
    /// </summary>
    [EnumMember(Value = "EQTX")]
    [IsoId("_AddendumTaxType3Code_EquipmentTax")]
    [Description(@"Equipment Tax")]
    EquipmentTax = AddendumTaxTypeCode.EquipmentTax,

    /// <summary>
    /// Part of an investor’s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_AddendumTaxType3Code_Equalisation")]
    [Description(
        @"Part of an investor’s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year."
    )]
    Equalisation = AddendumTaxTypeCode.Equalisation,

    /// <summary>
    /// Tax levied by a state to recover the cost of providing enhanced telephone emergency assistance services (for example, 112, 911, 999) such as automatic call identification.
    /// Encoded/decoded by serializers as &quot;ESET&quot;.
    /// </summary>
    [EnumMember(Value = "ESET")]
    [IsoId("_AddendumTaxType3Code_EnhancedEmergencyAssistanceStateExciseTax")]
    [Description(
        @"Tax levied by a state to recover the cost of providing enhanced telephone emergency assistance services (for example, 112, 911, 999) such as automatic call identification."
    )]
    EnhancedEmergencyAssistanceStateExciseTax =
        AddendumTaxTypeCode.EnhancedEmergencyAssistanceStateExciseTax,

    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as &quot;EUTR&quot;.
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_AddendumTaxType3Code_EUTaxRetention")]
    [Description(
        @"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments."
    )]
    EUTaxRetention = AddendumTaxTypeCode.EUTaxRetention,

    /// <summary>
    /// Executing broker’s commission amount.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_AddendumTaxType3Code_ExecutingBrokerCommission")]
    [Description(@"Executing broker’s commission amount.")]
    ExecutingBrokerCommission = AddendumTaxTypeCode.ExecutingBrokerCommission,

    /// <summary>
    /// Usage tax levied by federal (US and Canadian) government.
    /// Encoded/decoded by serializers as &quot;FETX&quot;.
    /// </summary>
    [EnumMember(Value = "FETX")]
    [IsoId("_AddendumTaxType3Code_FederalTax")]
    [Description(@"Usage tax levied by federal (US and Canadian) government.")]
    FederalTax = AddendumTaxTypeCode.FederalTax,

    /// <summary>
    /// Excise tax levied by a federal government.
    /// Encoded/decoded by serializers as &quot;FEXT&quot;.
    /// </summary>
    [EnumMember(Value = "FEXT")]
    [IsoId("_AddendumTaxType3Code_FederalExciseTax")]
    [Description(@"Excise tax levied by a federal government.")]
    FederalExciseTax = AddendumTaxTypeCode.FederalExciseTax,

    /// <summary>
    /// USA Federal Insurance Contributions Act tax.
    /// Encoded/decoded by serializers as &quot;FICA&quot;.
    /// </summary>
    [EnumMember(Value = "FICA")]
    [IsoId("_AddendumTaxType3Code_FICATax")]
    [Description(@"USA Federal Insurance Contributions Act tax.")]
    FICATax = AddendumTaxTypeCode.FICATax,

    /// <summary>
    /// USA Federal Insurance Contributions Act tax levied to assist in the funding of Medicare.
    /// Encoded/decoded by serializers as &quot;FIMT&quot;.
    /// </summary>
    [EnumMember(Value = "FIMT")]
    [IsoId("_AddendumTaxType3Code_FICAMedicareTax")]
    [Description(
        @"USA Federal Insurance Contributions Act tax levied to assist in the funding of Medicare."
    )]
    FICAMedicareTax = AddendumTaxTypeCode.FICAMedicareTax,

    /// <summary>
    /// Federal tax levied in the USA to fund the clean-up activities associated with leaking underground storage tanks.
    /// Encoded/decoded by serializers as &quot;FLST&quot;.
    /// </summary>
    [EnumMember(Value = "FLST")]
    [IsoId("_AddendumTaxType3Code_LeakyUndergroundStorageTankTax")]
    [Description(
        @"Federal tax levied in the USA to fund the clean-up activities associated with leaking underground storage tanks."
    )]
    LeakyUndergroundStorageTankTax = AddendumTaxTypeCode.LeakyUndergroundStorageTankTax,

    /// <summary>
    /// Federal or National Sales Tax.
    /// Encoded/decoded by serializers as &quot;FNST&quot;.
    /// </summary>
    [EnumMember(Value = "FNST")]
    [IsoId("_AddendumTaxType3Code_FederalNationalSalesTax")]
    [Description(@"Federal or National Sales Tax.")]
    FederalNationalSalesTax = AddendumTaxTypeCode.FederalNationalSalesTax,

    /// <summary>
    /// Tax levied by a municipality, on certain types of businesses for the right to exist as a legal entity and conduct business in a particular jurisdiction.
    /// Encoded/decoded by serializers as &quot;FRTX&quot;.
    /// </summary>
    [EnumMember(Value = "FRTX")]
    [IsoId("_AddendumTaxType3Code_FranchiseTax")]
    [Description(
        @"Tax levied by a municipality, on certain types of businesses for the right to exist as a legal entity and conduct business in a particular jurisdiction."
    )]
    FranchiseTax = AddendumTaxTypeCode.FranchiseTax,

    /// <summary>
    /// USA federal tax levied on certain types of businesses to provide funding for cleanup of hazardous waste sites.
    /// Encoded/decoded by serializers as &quot;FSFT&quot;.
    /// </summary>
    [EnumMember(Value = "FSFT")]
    [IsoId("_AddendumTaxType3Code_FuelSuperFundTax")]
    [Description(
        @"USA federal tax levied on certain types of businesses to provide funding for cleanup of hazardous waste sites."
    )]
    FuelSuperFundTax = AddendumTaxTypeCode.FuelSuperFundTax,

    /// <summary>
    /// USA Federal Insurance Contributions Act tax levied to assist in the funding of social security.
    /// Encoded/decoded by serializers as &quot;FSST&quot;.
    /// </summary>
    [EnumMember(Value = "FSST")]
    [IsoId("_AddendumTaxType3Code_FICASocialSecurityTax")]
    [Description(
        @"USA Federal Insurance Contributions Act tax levied to assist in the funding of social security."
    )]
    FICASocialSecurityTax = AddendumTaxTypeCode.FICASocialSecurityTax,

    /// <summary>
    /// Fuel Spill Tax.
    /// Encoded/decoded by serializers as &quot;FSTX&quot;.
    /// </summary>
    [EnumMember(Value = "FSTX")]
    [IsoId("_AddendumTaxType3Code_FuelSpillTax")]
    [Description(@"Fuel Spill Tax.")]
    FuelSpillTax = AddendumTaxTypeCode.FuelSpillTax,

    /// <summary>
    /// Value Added Tax calculated at the full tax rate.
    /// Encoded/decoded by serializers as &quot;FUVT&quot;.
    /// </summary>
    [EnumMember(Value = "FUVT")]
    [IsoId("_AddendumTaxType3Code_FullVAT")]
    [Description(@"Value Added Tax calculated at the full tax rate.")]
    FullVAT = AddendumTaxTypeCode.FullVAT,

    /// <summary>
    /// Federal Value-Added Tax (GST).
    /// Encoded/decoded by serializers as &quot;FVAT&quot;.
    /// </summary>
    [EnumMember(Value = "FVAT")]
    [IsoId("_AddendumTaxType3Code_FederalValueAddedTax")]
    [Description(@"Federal Value-Added Tax (GST).")]
    FederalValueAddedTax = AddendumTaxTypeCode.FederalValueAddedTax,

    /// <summary>
    /// Federal Value-Added Tax (GST) on Services
    /// Encoded/decoded by serializers as &quot;FVTS&quot;.
    /// </summary>
    [EnumMember(Value = "FVTS")]
    [IsoId("_AddendumTaxType3Code_FederalValueAddedTaxOnServices")]
    [Description(@"Federal Value-Added Tax (GST) on Services")]
    FederalValueAddedTaxOnServices = AddendumTaxTypeCode.FederalValueAddedTaxOnServices,

    /// <summary>
    /// Goods and Services Tax - Canadian value-added tax.
    /// Encoded/decoded by serializers as &quot;GCAT&quot;.
    /// </summary>
    [EnumMember(Value = "GCAT")]
    [IsoId("_AddendumTaxType3Code_GoodsAndServicesTax")]
    [Description(@"Goods and Services Tax - Canadian value-added tax.")]
    GoodsAndServicesTax = AddendumTaxTypeCode.GoodsAndServicesTax,

    /// <summary>
    /// Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.
    /// Encoded/decoded by serializers as &quot;GIFT&quot;.
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_AddendumTaxType3Code_GiftTax")]
    [Description(
        @"Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth."
    )]
    GiftTax = AddendumTaxTypeCode.GiftTax,

    /// <summary>
    /// Gross Receipts Tax.
    /// Encoded/decoded by serializers as &quot;GRTX&quot;.
    /// </summary>
    [EnumMember(Value = "GRTX")]
    [IsoId("_AddendumTaxType3Code_GrossReceiptsTax")]
    [Description(@"Gross Receipts Tax.")]
    GrossReceiptsTax = AddendumTaxTypeCode.GrossReceiptsTax,

    /// <summary>
    /// Tax assessed to assist the handicapped.
    /// Encoded/decoded by serializers as &quot;HATX&quot;.
    /// </summary>
    [EnumMember(Value = "HATX")]
    [IsoId("_AddendumTaxType3Code_HandicapTax")]
    [Description(@"Tax assessed to assist the handicapped.")]
    HandicapTax = AddendumTaxTypeCode.HandicapTax,

    /// <summary>
    /// Harmonized Sales Tax (HST).
    /// Encoded/decoded by serializers as &quot;HSTX&quot;.
    /// </summary>
    [EnumMember(Value = "HSTX")]
    [IsoId("_AddendumTaxType3Code_HarmonizedSalesTax")]
    [Description(@"Harmonized Sales Tax (HST).")]
    HarmonizedSalesTax = AddendumTaxTypeCode.HarmonizedSalesTax,

    /// <summary>
    /// Value Added Tax calculated at the half tax rate.
    /// Encoded/decoded by serializers as &quot;HVAT&quot;.
    /// </summary>
    [EnumMember(Value = "HVAT")]
    [IsoId("_AddendumTaxType3Code_HalfVAT")]
    [Description(@"Value Added Tax calculated at the half tax rate.")]
    HalfVAT = AddendumTaxTypeCode.HalfVAT,

    /// <summary>
    /// Tax levied on entities that produce, store, treat, transport or otherwise manage hazardous wastes and materials.
    /// Encoded/decoded by serializers as &quot;HWTX&quot;.
    /// </summary>
    [EnumMember(Value = "HWTX")]
    [IsoId("_AddendumTaxType3Code_HazardousWasteTax")]
    [Description(
        @"Tax levied on entities that produce, store, treat, transport or otherwise manage hazardous wastes and materials."
    )]
    HazardousWasteTax = AddendumTaxTypeCode.HazardousWasteTax,

    /// <summary>
    /// Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.
    /// Encoded/decoded by serializers as &quot;INHT&quot;.
    /// </summary>
    [EnumMember(Value = "INHT")]
    [IsoId("_AddendumTaxType3Code_InheritanceTax")]
    [Description(
        @"Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death."
    )]
    InheritanceTax = AddendumTaxTypeCode.InheritanceTax,

    /// <summary>
    /// Tax levied on the sum of all earnings/revenues accrued since the last dividend distribution.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_AddendumTaxType3Code_InterimProfitTax")]
    [Description(
        @"Tax levied on the sum of all earnings/revenues accrued since the last dividend distribution."
    )]
    InterimProfitTax = AddendumTaxTypeCode.InterimProfitTax,

    /// <summary>
    /// Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.
    /// Encoded/decoded by serializers as &quot;KAPA&quot;.
    /// </summary>
    [EnumMember(Value = "KAPA")]
    [IsoId("_AddendumTaxType3Code_CapitalGainTax")]
    [Description(
        @"Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument."
    )]
    CapitalGainTax = AddendumTaxTypeCode.CapitalGainTax,

    /// <summary>
    /// Tax levied on a payment.
    /// Encoded/decoded by serializers as &quot;LEVY&quot;.
    /// </summary>
    [EnumMember(Value = "LEVY")]
    [IsoId("_AddendumTaxType3Code_PaymentLevyTax")]
    [Description(@"Tax levied on a payment.")]
    PaymentLevyTax = AddendumTaxTypeCode.PaymentLevyTax,

    /// <summary>
    /// Tax levied by a government agency for the granting of a license to conduct an activity, such as driving a car, operating a business, selling liquor, hunting, or practicing certain vocations.
    /// Encoded/decoded by serializers as &quot;LITX&quot;.
    /// </summary>
    [EnumMember(Value = "LITX")]
    [IsoId("_AddendumTaxType3Code_LicenseTax")]
    [Description(
        @"Tax levied by a government agency for the granting of a license to conduct an activity, such as driving a car, operating a business, selling liquor, hunting, or practicing certain vocations."
    )]
    LicenseTax = AddendumTaxTypeCode.LicenseTax,

    /// <summary>
    /// Service tax levied by a local government or taxation agency. Not a sales tax.
    /// Encoded/decoded by serializers as &quot;LOCL&quot;.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_AddendumTaxType3Code_LocalTax")]
    [Description(@"Service tax levied by a local government or taxation agency. Not a sales tax.")]
    LocalTax = AddendumTaxTypeCode.LocalTax,

    /// <summary>
    /// Local broker’s commission amount.
    /// Encoded/decoded by serializers as &quot;LOCO&quot;.
    /// </summary>
    [EnumMember(Value = "LOCO")]
    [IsoId("_AddendumTaxType3Code_LocalBrokerCommission")]
    [Description(@"Local broker’s commission amount.")]
    LocalBrokerCommission = AddendumTaxTypeCode.LocalBrokerCommission,

    /// <summary>
    /// All applicable sales taxes levied by taxing authorities below the state level. Used only for sales tax.
    /// Encoded/decoded by serializers as &quot;LSTX&quot;.
    /// </summary>
    [EnumMember(Value = "LSTX")]
    [IsoId("_AddendumTaxType3Code_LocalSalesTax")]
    [Description(
        @"All applicable sales taxes levied by taxing authorities below the state level. Used only for sales tax."
    )]
    LocalSalesTax = AddendumTaxTypeCode.LocalSalesTax,

    /// <summary>
    /// Labour by Trade Tax
    /// Encoded/decoded by serializers as &quot;LTTX&quot;.
    /// </summary>
    [EnumMember(Value = "LTTX")]
    [IsoId("_AddendumTaxType3Code_LabourByTradeTax")]
    [Description(@"Labour by Trade Tax")]
    LabourByTradeTax = AddendumTaxTypeCode.LabourByTradeTax,

    /// <summary>
    /// Ad valorem tax levied on products or services that are deemed to be non-essential or unneeded.
    /// Encoded/decoded by serializers as &quot;LUTX&quot;.
    /// </summary>
    [EnumMember(Value = "LUTX")]
    [IsoId("_AddendumTaxType3Code_LuxuryTax")]
    [Description(
        @"Ad valorem tax levied on products or services that are deemed to be non-essential or unneeded."
    )]
    LuxuryTax = AddendumTaxTypeCode.LuxuryTax,

    /// <summary>
    /// Material Tax
    /// Encoded/decoded by serializers as &quot;MATX&quot;.
    /// </summary>
    [EnumMember(Value = "MATX")]
    [IsoId("_AddendumTaxType3Code_MaterialTax")]
    [Description(@"Material Tax")]
    MaterialTax = AddendumTaxTypeCode.MaterialTax,

    /// <summary>
    /// Metropolitan Transit Tax
    /// Encoded/decoded by serializers as &quot;METX&quot;.
    /// </summary>
    [EnumMember(Value = "METX")]
    [IsoId("_AddendumTaxType3Code_MetropolitanTransitTax")]
    [Description(@"Metropolitan Transit Tax")]
    MetropolitanTransitTax = AddendumTaxTypeCode.MetropolitanTransitTax,

    /// <summary>
    /// Minimum Tax
    /// Encoded/decoded by serializers as &quot;MITX&quot;.
    /// </summary>
    [EnumMember(Value = "MITX")]
    [IsoId("_AddendumTaxType3Code_MinimumTax")]
    [Description(@"Minimum Tax")]
    MinimumTax = AddendumTaxTypeCode.MinimumTax,

    /// <summary>
    /// Mutually Defined
    /// Encoded/decoded by serializers as &quot;MUDE&quot;.
    /// </summary>
    [EnumMember(Value = "MUDE")]
    [IsoId("_AddendumTaxType3Code_MutuallyDefinedTax")]
    [Description(@"Mutually Defined")]
    MutuallyDefinedTax = AddendumTaxTypeCode.MutuallyDefinedTax,

    /// <summary>
    /// Service tax imposed by a municipality.
    /// Encoded/decoded by serializers as &quot;MUTX&quot;.
    /// </summary>
    [EnumMember(Value = "MUTX")]
    [IsoId("_AddendumTaxType3Code_MunicipalTax")]
    [Description(@"Service tax imposed by a municipality.")]
    MunicipalTax = AddendumTaxTypeCode.MunicipalTax,

    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_AddendumTaxType3Code_NationalTax")]
    [Description(@"Tax is a national tax.")]
    NationalTax = AddendumTaxTypeCode.NationalTax,

    /// <summary>
    /// Tax recovery is due to capital loss.
    /// Encoded/decoded by serializers as &quot;NKAP&quot;.
    /// </summary>
    [EnumMember(Value = "NKAP")]
    [IsoId("_AddendumTaxType3Code_CapitalLossCredit")]
    [Description(@"Tax recovery is due to capital loss.")]
    CapitalLossCredit = AddendumTaxTypeCode.CapitalLossCredit,

    /// <summary>
    /// Tax levied for the privelage of occupying space for home or rental for a fixed period of time, as determined by a taxing authority.
    /// Encoded/decoded by serializers as &quot;OCTX&quot;.
    /// </summary>
    [EnumMember(Value = "OCTX")]
    [IsoId("_AddendumTaxType3Code_OccupancyTax")]
    [Description(
        @"Tax levied for the privelage of occupying space for home or rental for a fixed period of time, as determined by a taxing authority."
    )]
    OccupancyTax = AddendumTaxTypeCode.OccupancyTax,

    /// <summary>
    /// Type of gross receipts tax imposed for the privilege of carrying on a business, trade or profession.
    /// Encoded/decoded by serializers as &quot;OPTX&quot;.
    /// </summary>
    [EnumMember(Value = "OPTX")]
    [IsoId("_AddendumTaxType3Code_OccupationalTax")]
    [Description(
        @"Type of gross receipts tax imposed for the privilege of carrying on a business, trade or profession."
    )]
    OccupationalTax = AddendumTaxTypeCode.OccupationalTax,

    /// <summary>
    /// Other national use defined value
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_AddendumTaxType3Code_OtherNational")]
    [Description(@"Other national use defined value")]
    OtherNational = AddendumTaxTypeCode.OtherNational,

    /// <summary>
    /// Other private use defined value
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_AddendumTaxType3Code_OtherPrivate")]
    [Description(@"Other private use defined value")]
    OtherPrivate = AddendumTaxTypeCode.OtherPrivate,

    /// <summary>
    /// Other type of tax not elsewhere classified.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_AddendumTaxType3Code_Other")]
    [Description(@"Other type of tax not elsewhere classified.")]
    Other = AddendumTaxTypeCode.Other,

    /// <summary>
    /// Other taxes
    /// Encoded/decoded by serializers as &quot;OTTX&quot;.
    /// </summary>
    [EnumMember(Value = "OTTX")]
    [IsoId("_AddendumTaxType3Code_OtherTaxes")]
    [Description(@"Other taxes")]
    OtherTaxes = AddendumTaxTypeCode.OtherTaxes,

    /// <summary>
    /// Canadian tax levied to fund public care and education.
    /// Encoded/decoded by serializers as &quot;PHET&quot;.
    /// </summary>
    [EnumMember(Value = "PHET")]
    [IsoId("_AddendumTaxType3Code_PublicHealthAndEducationTax")]
    [Description(@"Canadian tax levied to fund public care and education.")]
    PublicHealthAndEducationTax = AddendumTaxTypeCode.PublicHealthAndEducationTax,

    /// <summary>
    /// Post-threshold Tax
    /// Encoded/decoded by serializers as &quot;POTX&quot;.
    /// </summary>
    [EnumMember(Value = "POTX")]
    [IsoId("_AddendumTaxType3Code_PostThresholdTax")]
    [Description(@"Post-threshold Tax")]
    PostThresholdTax = AddendumTaxTypeCode.PostThresholdTax,

    /// <summary>
    /// Ad valorem property tax levied on real or personal property by local government units such as counties, municipalities, school districts, and special taxing districts.
    /// Encoded/decoded by serializers as &quot;PPTX&quot;.
    /// </summary>
    [EnumMember(Value = "PPTX")]
    [IsoId("_AddendumTaxType3Code_PropertyTax")]
    [Description(
        @"Ad valorem property tax levied on real or personal property by local government units such as counties, municipalities, school districts, and special taxing districts."
    )]
    PropertyTax = AddendumTaxTypeCode.PropertyTax,

    /// <summary>
    /// Provincial tax
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_AddendumTaxType3Code_ProvincialTax")]
    [Description(@"Provincial tax")]
    ProvincialTax = AddendumTaxTypeCode.ProvincialTax,

    /// <summary>
    /// Pre-threshold tax
    /// Encoded/decoded by serializers as &quot;PRTX&quot;.
    /// </summary>
    [EnumMember(Value = "PRTX")]
    [IsoId("_AddendumTaxType3Code_PreThresholdTax")]
    [Description(@"Pre-threshold tax")]
    PreThresholdTax = AddendumTaxTypeCode.PreThresholdTax,

    /// <summary>
    /// Tax levied on products and services
    /// Encoded/decoded by serializers as &quot;PSTX&quot;.
    /// </summary>
    [EnumMember(Value = "PSTX")]
    [IsoId("_AddendumTaxType3Code_ProductAndServicesTax")]
    [Description(@"Tax levied on products and services")]
    ProductAndServicesTax = AddendumTaxTypeCode.ProductAndServicesTax,

    /// <summary>
    /// Quebec Sales Tax (QST)
    /// Encoded/decoded by serializers as &quot;QUST&quot;.
    /// </summary>
    [EnumMember(Value = "QUST")]
    [IsoId("_AddendumTaxType3Code_QuebecSalesTax")]
    [Description(@"Quebec Sales Tax (QST)")]
    QuebecSalesTax = AddendumTaxTypeCode.QuebecSalesTax,

    /// <summary>
    /// Room Country Subdivision1
    /// Encoded/decoded by serializers as &quot;RCSB&quot;.
    /// </summary>
    [EnumMember(Value = "RCSB")]
    [IsoId("_AddendumTaxType3Code_RoomCountrySubdivision1")]
    [Description(@"Room Country Subdivision1")]
    RoomCountrySubdivision1 = AddendumTaxTypeCode.RoomCountrySubdivision1,

    /// <summary>
    /// Room Country Subdivision2
    /// Encoded/decoded by serializers as &quot;RCSD&quot;.
    /// </summary>
    [EnumMember(Value = "RCSD")]
    [IsoId("_AddendumTaxType3Code_RoomCountrySubdivision2")]
    [Description(@"Room Country Subdivision2")]
    RoomCountrySubdivision2 = AddendumTaxTypeCode.RoomCountrySubdivision2,

    /// <summary>
    /// Room City
    /// Encoded/decoded by serializers as &quot;ROCI&quot;.
    /// </summary>
    [EnumMember(Value = "ROCI")]
    [IsoId("_AddendumTaxType3Code_RoomCity")]
    [Description(@"Room City")]
    RoomCity = AddendumTaxTypeCode.RoomCity,

    /// <summary>
    /// Room Tax
    /// Encoded/decoded by serializers as &quot;ROTX&quot;.
    /// </summary>
    [EnumMember(Value = "ROTX")]
    [IsoId("_AddendumTaxType3Code_RoomTax")]
    [Description(@"Room Tax")]
    RoomTax = AddendumTaxTypeCode.RoomTax,

    /// <summary>
    /// Room Visitor
    /// Encoded/decoded by serializers as &quot;ROVI&quot;.
    /// </summary>
    [EnumMember(Value = "ROVI")]
    [IsoId("_AddendumTaxType3Code_RoomVisitor")]
    [Description(@"Room Visitor")]
    RoomVisitor = AddendumTaxTypeCode.RoomVisitor,

    /// <summary>
    /// Room VAT
    /// Encoded/decoded by serializers as &quot;RVAT&quot;.
    /// </summary>
    [EnumMember(Value = "RVAT")]
    [IsoId("_AddendumTaxType3Code_RoomVAT")]
    [Description(@"Room VAT")]
    RoomVAT = AddendumTaxTypeCode.RoomVAT,

    /// <summary>
    /// Tax levied for the use of equipment and service provided
    /// Encoded/decoded by serializers as &quot;SAUT&quot;.
    /// </summary>
    [EnumMember(Value = "SAUT")]
    [IsoId("_AddendumTaxType3Code_SalesAndUseTax")]
    [Description(@"Tax levied for the use of equipment and service provided")]
    SalesAndUseTax = AddendumTaxTypeCode.SalesAndUseTax,

    /// <summary>
    /// Tax levied by taxing authority for schools
    /// Encoded/decoded by serializers as &quot;SCTX&quot;.
    /// </summary>
    [EnumMember(Value = "SCTX")]
    [IsoId("_AddendumTaxType3Code_SchoolTax")]
    [Description(@"Tax levied by taxing authority for schools")]
    SchoolTax = AddendumTaxTypeCode.SchoolTax,

    /// <summary>
    /// Usage tax imposed by state or provincial government authorities.
    /// Encoded/decoded by serializers as &quot;SETX&quot;.
    /// </summary>
    [EnumMember(Value = "SETX")]
    [IsoId("_AddendumTaxType3Code_StateExciseTax")]
    [Description(@"Usage tax imposed by state or provincial government authorities.")]
    StateExciseTax = AddendumTaxTypeCode.StateExciseTax,

    /// <summary>
    /// State and Local Sales Tax
    /// Encoded/decoded by serializers as &quot;SLST&quot;.
    /// </summary>
    [EnumMember(Value = "SLST")]
    [IsoId("_AddendumTaxType3Code_StateAndLocalSalesTax")]
    [Description(@"State and Local Sales Tax")]
    StateAndLocalSalesTax = AddendumTaxTypeCode.StateAndLocalSalesTax,

    /// <summary>
    /// State and local tax levies, exclusive of state and local sales tax.
    /// Encoded/decoded by serializers as &quot;SLTX&quot;.
    /// </summary>
    [EnumMember(Value = "SLTX")]
    [IsoId("_AddendumTaxType3Code_StateAndLocalTax")]
    [Description(@"State and local tax levies, exclusive of state and local sales tax.")]
    StateAndLocalTax = AddendumTaxTypeCode.StateAndLocalTax,

    /// <summary>
    /// State or Provincial Fuel Tax
    /// Encoded/decoded by serializers as &quot;SPFT&quot;.
    /// </summary>
    [EnumMember(Value = "SPFT")]
    [IsoId("_AddendumTaxType3Code_StateProvincialFuelTax")]
    [Description(@"State or Provincial Fuel Tax")]
    StateProvincialFuelTax = AddendumTaxTypeCode.StateProvincialFuelTax,

    /// <summary>
    /// State or Provincial Tax on Goods
    /// Encoded/decoded by serializers as &quot;SPTG&quot;.
    /// </summary>
    [EnumMember(Value = "SPTG")]
    [IsoId("_AddendumTaxType3Code_StateProvincialTaxOnGoods")]
    [Description(@"State or Provincial Tax on Goods")]
    StateProvincialTaxOnGoods = AddendumTaxTypeCode.StateProvincialTaxOnGoods,

    /// <summary>
    /// State or Provincial tax on services
    /// Encoded/decoded by serializers as &quot;SPTS&quot;.
    /// </summary>
    [EnumMember(Value = "SPTS")]
    [IsoId("_AddendumTaxType3Code_StateOrProvincialTaxOnServices")]
    [Description(@"State or Provincial tax on services")]
    StateOrProvincialTaxOnServices = AddendumTaxTypeCode.StateOrProvincialTaxOnServices,

    /// <summary>
    /// Secondary Percentage Tax
    /// Encoded/decoded by serializers as &quot;SPTX&quot;.
    /// </summary>
    [EnumMember(Value = "SPTX")]
    [IsoId("_AddendumTaxType3Code_SecondaryPercentageTax")]
    [Description(@"Secondary Percentage Tax")]
    SecondaryPercentageTax = AddendumTaxTypeCode.SecondaryPercentageTax,

    /// <summary>
    /// Tax levied by a state government against a periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;SRTX&quot;.
    /// </summary>
    [EnumMember(Value = "SRTX")]
    [IsoId("_AddendumTaxType3Code_StateRentalTax")]
    [Description(
        @"Tax levied by a state government against a periodic fee paid by a customer in return for the right to use the property of another party."
    )]
    StateRentalTax = AddendumTaxTypeCode.StateRentalTax,

    /// <summary>
    /// State Sales Tax
    /// Encoded/decoded by serializers as &quot;SSTX&quot;.
    /// </summary>
    [EnumMember(Value = "SSTX")]
    [IsoId("_AddendumTaxType3Code_StateSalesTax")]
    [Description(@"State Sales Tax")]
    StateSalesTax = AddendumTaxTypeCode.StateSalesTax,

    /// <summary>
    /// Tax levied on certain types of documents and transactions.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_AddendumTaxType3Code_StampDuty")]
    [Description(@"Tax levied on certain types of documents and transactions.")]
    StampDuty = AddendumTaxTypeCode.StampDuty,

    /// <summary>
    /// State tax.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_AddendumTaxType3Code_StateTax")]
    [Description(@"State tax.")]
    StateTax = AddendumTaxTypeCode.StateTax,

    /// <summary>
    /// Tax levied by a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_AddendumTaxType3Code_StockExchangeTax")]
    [Description(@"Tax levied by a stock exchange.")]
    StockExchangeTax = AddendumTaxTypeCode.StockExchangeTax,

    /// <summary>
    /// Sales tax levied by a State or Province that excludes sales or excise taxes.
    /// Encoded/decoded by serializers as &quot;STPT&quot;.
    /// </summary>
    [EnumMember(Value = "STPT")]
    [IsoId("_AddendumTaxType3Code_StateOrProvincialTax")]
    [Description(@"Sales tax levied by a State or Province that excludes sales or excise taxes.")]
    StateOrProvincialTax = AddendumTaxTypeCode.StateOrProvincialTax,

    /// <summary>
    /// State Tax on Specific Labour
    /// Encoded/decoded by serializers as &quot;STSL&quot;.
    /// </summary>
    [EnumMember(Value = "STSL")]
    [IsoId("_AddendumTaxType3Code_StateTaxOnSpecificLabour")]
    [Description(@"State Tax on Specific Labour")]
    StateTaxOnSpecificLabour = AddendumTaxTypeCode.StateTaxOnSpecificLabour,

    /// <summary>
    /// Stadium Tax
    /// Encoded/decoded by serializers as &quot;STTA&quot;.
    /// </summary>
    [EnumMember(Value = "STTA")]
    [IsoId("_AddendumTaxType3Code_StadiumTax")]
    [Description(@"Stadium Tax")]
    StadiumTax = AddendumTaxTypeCode.StadiumTax,

    /// <summary>
    /// Surtax
    /// Encoded/decoded by serializers as &quot;SUTX&quot;.
    /// </summary>
    [EnumMember(Value = "SUTX")]
    [IsoId("_AddendumTaxType3Code_Surtax")]
    [Description(@"Surtax")]
    Surtax = AddendumTaxTypeCode.Surtax,

    /// <summary>
    /// Excise tax levied to recover the cost of providing Telecommunications Device for the Deaf (TDD) Equipment.
    /// Encoded/decoded by serializers as &quot;TDDT&quot;.
    /// </summary>
    [EnumMember(Value = "TDDT")]
    [IsoId("_AddendumTaxType3Code_TDDServiceExciseTax")]
    [Description(
        @"Excise tax levied to recover the cost of providing Telecommunications Device for the Deaf (TDD) Equipment."
    )]
    TDDServiceExciseTax = AddendumTaxTypeCode.TDDServiceExciseTax,

    /// <summary>
    /// Tax levied on telecommunications companies for the right to provide services. May be a usage or excise tax.
    /// Encoded/decoded by serializers as &quot;TELT&quot;.
    /// </summary>
    [EnumMember(Value = "TELT")]
    [IsoId("_AddendumTaxType3Code_TelecommunicationsTax")]
    [Description(
        @"Tax levied on telecommunications companies for the right to provide services. May be a usage or excise tax."
    )]
    TelecommunicationsTax = AddendumTaxTypeCode.TelecommunicationsTax,

    /// <summary>
    /// Threshold Tax
    /// Encoded/decoded by serializers as &quot;THTX&quot;.
    /// </summary>
    [EnumMember(Value = "THTX")]
    [IsoId("_AddendumTaxType3Code_ThresholdTax")]
    [Description(@"Threshold Tax")]
    ThresholdTax = AddendumTaxTypeCode.ThresholdTax,

    /// <summary>
    /// Tax levied on non-room expenditures.
    /// Encoded/decoded by serializers as &quot;TNRT&quot;.
    /// </summary>
    [EnumMember(Value = "TNRT")]
    [IsoId("_AddendumTaxType3Code_TotalNonRoomTax")]
    [Description(@"Tax levied on non-room expenditures.")]
    TotalNonRoomTax = AddendumTaxTypeCode.TotalNonRoomTax,

    /// <summary>
    /// Total of all applicable taxes
    /// Encoded/decoded by serializers as &quot;TOTL&quot;.
    /// </summary>
    [EnumMember(Value = "TOTL")]
    [IsoId("_AddendumTaxType3Code_TotalTaxes")]
    [Description(@"Total of all applicable taxes")]
    TotalTaxes = AddendumTaxTypeCode.TotalTaxes,

    /// <summary>
    /// Tax levied on a transfer.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_AddendumTaxType3Code_TransferTax")]
    [Description(@"Tax levied on a transfer.")]
    TransferTax = AddendumTaxTypeCode.TransferTax,

    /// <summary>
    /// Tax levied on a transaction.
    /// Encoded/decoded by serializers as &quot;TRAX&quot;.
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_AddendumTaxType3Code_TransactionTax")]
    [Description(@"Tax levied on a transaction.")]
    TransactionTax = AddendumTaxTypeCode.TransactionTax,

    /// <summary>
    /// Unspecified tax type
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_AddendumTaxType3Code_Unspecified")]
    [Description(@"Unspecified tax type")]
    Unspecified = AddendumTaxTypeCode.Unspecified,

    /// <summary>
    /// Tax levied on consumers by a city or county for the use of natural gas.
    /// Encoded/decoded by serializers as &quot;UUTX&quot;.
    /// </summary>
    [EnumMember(Value = "UUTX")]
    [IsoId("_AddendumTaxType3Code_UtilityUsersTax")]
    [Description(@"Tax levied on consumers by a city or county for the use of natural gas.")]
    UtilityUsersTax = AddendumTaxTypeCode.UtilityUsersTax,

    /// <summary>
    /// Value added tax
    /// Encoded/decoded by serializers as &quot;VATA&quot;.
    /// </summary>
    [EnumMember(Value = "VATA")]
    [IsoId("_AddendumTaxType3Code_ValueAddedTax")]
    [Description(@"Value added tax")]
    ValueAddedTax = AddendumTaxTypeCode.ValueAddedTax,

    /// <summary>
    /// Tax for which a zero rate applies.
    /// Encoded/decoded by serializers as &quot;VATB&quot;.
    /// </summary>
    [EnumMember(Value = "VATB")]
    [IsoId("_AddendumTaxType3Code_ValueAddedTaxOfZeroRate")]
    [Description(@"Tax for which a zero rate applies.")]
    ValueAddedTaxOfZeroRate = AddendumTaxTypeCode.ValueAddedTaxOfZeroRate,

    /// <summary>
    /// Well Service
    /// Encoded/decoded by serializers as &quot;WESV&quot;.
    /// </summary>
    [EnumMember(Value = "WESV")]
    [IsoId("_AddendumTaxType3Code_WellService")]
    [Description(@"Well Service")]
    WellService = AddendumTaxTypeCode.WellService,

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITF&quot;.
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_AddendumTaxType3Code_WithholdingOfForeignTax")]
    [Description(
        @"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible."
    )]
    WithholdingOfForeignTax = AddendumTaxTypeCode.WithholdingOfForeignTax,

    /// <summary>
    /// Income tax withheld or deducted from the amount due to the recipient, and paid to the government by the payer rather than the recipient. May apply to salaries, interest, and other types of proceeds.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_AddendumTaxType3Code_WithholdingTax")]
    [Description(
        @"Income tax withheld or deducted from the amount due to the recipient, and paid to the government by the payer rather than the recipient. May apply to salaries, interest, and other types of proceeds."
    )]
    WithholdingTax = AddendumTaxTypeCode.WithholdingTax,

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITL&quot;.
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_AddendumTaxType3Code_WithholdingOfLocalTax")]
    [Description(
        @"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible."
    )]
    WithholdingOfLocalTax = AddendumTaxTypeCode.WithholdingOfLocalTax,

    /// <summary>
    /// Tax levied only when the value of assets or categories of assets owned by an entity are above a given limit as defined by the tax authority. Wealth tax is not linked to income.
    /// Encoded/decoded by serializers as &quot;WTAX&quot;.
    /// </summary>
    [EnumMember(Value = "WTAX")]
    [IsoId("_AddendumTaxType3Code_WealthTax")]
    [Description(
        @"Tax levied only when the value of assets or categories of assets owned by an entity are above a given limit as defined by the tax authority. Wealth tax is not linked to income."
    )]
    WealthTax = AddendumTaxTypeCode.WealthTax,
}
