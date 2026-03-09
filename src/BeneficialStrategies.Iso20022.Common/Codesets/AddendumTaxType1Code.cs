// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the specific type of tax applicable to a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ppyW4PMwEei4qfiLgRIZBA")]
[Description(@"Specifies the specific type of tax applicable to a transaction.")]
[DerivedFrom(typeof(AddendumTaxTypeCode))]
public enum AddendumTaxType1Code
{
    /// <summary>
    /// Total of all applicable taxes
    /// Encoded/decoded by serializers as &quot;TOTL&quot;.
    /// </summary>
    [EnumMember(Value = "TOTL")]
    [IsoId("_sm_u4fMwEei4qfiLgRIZBA")]
    [Description(@"Total of all applicable taxes")]
    TotalTaxes = AddendumTaxTypeCode.TotalTaxes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is an alternative minimum tax.
    /// Encoded/decoded by serializers as &quot;ALMI&quot;.
    /// </summary>
    [EnumMember(Value = "ALMI")]
    [IsoId("_tXU_ofMwEei4qfiLgRIZBA")]
    [Description(@"Tax is an alternative minimum tax.")]
    AlternativeMinimumTax = AddendumTaxTypeCode.AlternativeMinimumTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Assessment
    /// Encoded/decoded by serializers as &quot;ASNT&quot;.
    /// </summary>
    [EnumMember(Value = "ASNT")]
    [IsoId("_teySgfMwEei4qfiLgRIZBA")]
    [Description(@"Assessment")]
    Assessment = AddendumTaxTypeCode.Assessment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax imposed on non-American Indian businesses for the privilege of conducting business on an American Indian Reservation
    /// Encoded/decoded by serializers as &quot;BPTX&quot;.
    /// </summary>
    [EnumMember(Value = "BPTX")]
    [IsoId("_tia1UfMwEei4qfiLgRIZBA")]
    [Description(@"Tax imposed on non-American Indian businesses for the privilege of conducting business on an American Indian Reservation")]
    BusinessPrivilegeTax = AddendumTaxTypeCode.BusinessPrivilegeTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.
    /// Encoded/decoded by serializers as &quot;KAPA&quot;.
    /// </summary>
    [EnumMember(Value = "KAPA")]
    [IsoId("_tl3K4fMwEei4qfiLgRIZBA")]
    [Description(@"Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.")]
    CapitalGainTax = AddendumTaxTypeCode.CapitalGainTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax recovery is due to capital loss.
    /// Encoded/decoded by serializers as &quot;NKAP&quot;.
    /// </summary>
    [EnumMember(Value = "NKAP")]
    [IsoId("_tpNZ0fMwEei4qfiLgRIZBA")]
    [Description(@"Tax recovery is due to capital loss.")]
    CapitalLossCredit = AddendumTaxTypeCode.CapitalLossCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Levied by a city government against the periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;CRTX&quot;.
    /// </summary>
    [EnumMember(Value = "CRTX")]
    [IsoId("_tsrkkfMwEei4qfiLgRIZBA")]
    [Description(@"Levied by a city government against the periodic fee paid by a customer in return for the right to use the property of another party.")]
    CityRentalTax = AddendumTaxTypeCode.CityRentalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sales tax imposed by a city
    /// Encoded/decoded by serializers as &quot;CSTX&quot;.
    /// </summary>
    [EnumMember(Value = "CSTX")]
    [IsoId("_twDosfMwEei4qfiLgRIZBA")]
    [Description(@"Sales tax imposed by a city")]
    CitySalesTax = AddendumTaxTypeCode.CitySalesTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service tax imposed by a city
    /// Encoded/decoded by serializers as &quot;CITX&quot;.
    /// </summary>
    [EnumMember(Value = "CITX")]
    [IsoId("_tztZofMwEei4qfiLgRIZBA")]
    [Description(@"Service tax imposed by a city")]
    CityTax = AddendumTaxTypeCode.CityTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_t3OAofMwEei4qfiLgRIZBA")]
    [Description(@"Tax that is levied on goods and services purchased by customers, and is added to the retail price.")]
    ConsumptionTax = AddendumTaxTypeCode.ConsumptionTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service tax imposed by a County or Parish
    /// Encoded/decoded by serializers as &quot;CPST&quot;.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_t6mr0fMwEei4qfiLgRIZBA")]
    [Description(@"Service tax imposed by a County or Parish")]
    CountyParishSalesTax = AddendumTaxTypeCode.CountyParishSalesTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Levied by a county government against the periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_t-GrwfMwEei4qfiLgRIZBA")]
    [Description(@"Levied by a county government against the periodic fee paid by a customer in return for the right to use the property of another party.")]
    CountyRentalTax = AddendumTaxTypeCode.CountyRentalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service tax levied by a county
    /// Encoded/decoded by serializers as &quot;COTX&quot;.
    /// </summary>
    [EnumMember(Value = "COTX")]
    [IsoId("_uBeI0fMwEei4qfiLgRIZBA")]
    [Description(@"Service tax levied by a county")]
    CountyTax = AddendumTaxTypeCode.CountyTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on imports or exports by a country&apos;s customs authority. 
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_uE20AfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied on imports or exports by a country's customs authority. ")]
    CustomsTax = AddendumTaxTypeCode.CustomsTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Default Labour Tax
    /// Encoded/decoded by serializers as &quot;DLTX&quot;.
    /// </summary>
    [EnumMember(Value = "DLTX")]
    [IsoId("_uIL00fMwEei4qfiLgRIZBA")]
    [Description(@"Default Labour Tax")]
    DefaultLabourTax = AddendumTaxTypeCode.DefaultLabourTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A tax levied on goods that typically though not exclusively transit across a geographic border. 
    /// Encoded/decoded by serializers as &quot;DUTY&quot;.
    /// </summary>
    [EnumMember(Value = "DUTY")]
    [IsoId("_uLgOkfMwEei4qfiLgRIZBA")]
    [Description(@"A tax levied on goods that typically though not exclusively transit across a geographic border. ")]
    Duty = AddendumTaxTypeCode.Duty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied by a city to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMIT&quot;.
    /// </summary>
    [EnumMember(Value = "EMIT")]
    [IsoId("_uPFuEfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied by a city to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).")]
    EmergencyAssistanceCityTax = AddendumTaxTypeCode.EmergencyAssistanceCityTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied by a county to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMUT&quot;.
    /// </summary>
    [EnumMember(Value = "EMUT")]
    [IsoId("_uSoxUfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied by a county to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).")]
    EmergencyAssistanceCountyTax = AddendumTaxTypeCode.EmergencyAssistanceCountyTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Usage tax levied to recover the cost of telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMET&quot;.
    /// </summary>
    [EnumMember(Value = "EMET")]
    [IsoId("_uWLNgfMwEei4qfiLgRIZBA")]
    [Description(@"Usage tax levied to recover the cost of telephone emergency assistance service (for example, 112, 911, 999).")]
    EmergencyAssistanceExciseTax = AddendumTaxTypeCode.EmergencyAssistanceExciseTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied by a state to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMST&quot;.
    /// </summary>
    [EnumMember(Value = "EMST")]
    [IsoId("_uZtCofMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied by a state to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).")]
    EmergencyAssistanceStateTax = AddendumTaxTypeCode.EmergencyAssistanceStateTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied to recover the cost of providing telephone emergency assistance service (for example,112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMRT&quot;.
    /// </summary>
    [EnumMember(Value = "EMRT")]
    [IsoId("_udYBsfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied to recover the cost of providing telephone emergency assistance service (for example,112, 911, 999).")]
    EmergencyAssistanceTax = AddendumTaxTypeCode.EmergencyAssistanceTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax applied to the utility and petroleum industries. 
    /// Encoded/decoded by serializers as &quot;ENTX&quot;.
    /// </summary>
    [EnumMember(Value = "ENTX")]
    [IsoId("_ug6d4fMwEei4qfiLgRIZBA")]
    [Description(@"Tax applied to the utility and petroleum industries. ")]
    EnergyTax = AddendumTaxTypeCode.EnergyTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied by a state to recover the cost of providing enhanced telephone emergency assistance services (for example, 112, 911, 999) such as automatic call identification.
    /// Encoded/decoded by serializers as &quot;ESET&quot;.
    /// </summary>
    [EnumMember(Value = "ESET")]
    [IsoId("_ukgkcfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied by a state to recover the cost of providing enhanced telephone emergency assistance services (for example, 112, 911, 999) such as automatic call identification.")]
    EnhancedEmergencyAssistanceStateExciseTax = AddendumTaxTypeCode.EnhancedEmergencyAssistanceStateExciseTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on activities which are considered to have negative impacts on an environment. 
    /// Encoded/decoded by serializers as &quot;ENVT&quot;.
    /// </summary>
    [EnumMember(Value = "ENVT")]
    [IsoId("_uoBygfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied on activities which are considered to have negative impacts on an environment. ")]
    EnvironmentalTax = AddendumTaxTypeCode.EnvironmentalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_urrjcfMwEei4qfiLgRIZBA")]
    [Description(@"Part of an investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.")]
    Equalisation = AddendumTaxTypeCode.Equalisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Equipment Tax
    /// Encoded/decoded by serializers as &quot;EQTX&quot;.
    /// </summary>
    [EnumMember(Value = "EQTX")]
    [IsoId("_uvQb4fMwEei4qfiLgRIZBA")]
    [Description(@"Equipment Tax")]
    EquipmentTax = AddendumTaxTypeCode.EquipmentTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as &quot;EUTR&quot;.
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_uy17YfMwEei4qfiLgRIZBA")]
    [Description(@"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.")]
    EUTaxRetention = AddendumTaxTypeCode.EUTaxRetention, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Executing broker&apos;s commission amount.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_u2S4AfMwEei4qfiLgRIZBA")]
    [Description(@"Executing broker's commission amount.")]
    ExecutingBrokerCommission = AddendumTaxTypeCode.ExecutingBrokerCommission, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Excise tax levied by a federal government.
    /// Encoded/decoded by serializers as &quot;FEXT&quot;.
    /// </summary>
    [EnumMember(Value = "FEXT")]
    [IsoId("_u51UMfMwEei4qfiLgRIZBA")]
    [Description(@"Excise tax levied by a federal government.")]
    FederalExciseTax = AddendumTaxTypeCode.FederalExciseTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Federal or National Sales Tax.
    /// Encoded/decoded by serializers as &quot;FNST&quot;.
    /// </summary>
    [EnumMember(Value = "FNST")]
    [IsoId("_u9UGAfMwEei4qfiLgRIZBA")]
    [Description(@"Federal or National Sales Tax.")]
    FederalNationalSalesTax = AddendumTaxTypeCode.FederalNationalSalesTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Usage tax levied by federal (US and Canadian) government.
    /// Encoded/decoded by serializers as &quot;FETX&quot;.
    /// </summary>
    [EnumMember(Value = "FETX")]
    [IsoId("_wh3pAfMwEei4qfiLgRIZBA")]
    [Description(@"Usage tax levied by federal (US and Canadian) government.")]
    FederalTax = AddendumTaxTypeCode.FederalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Federal Value-Added Tax (GST).
    /// Encoded/decoded by serializers as &quot;FVAT&quot;.
    /// </summary>
    [EnumMember(Value = "FVAT")]
    [IsoId("_wppsAfMwEei4qfiLgRIZBA")]
    [Description(@"Federal Value-Added Tax (GST).")]
    FederalValueAddedTax = AddendumTaxTypeCode.FederalValueAddedTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Federal Value-Added Tax (GST) on Services
    /// Encoded/decoded by serializers as &quot;FVTS&quot;.
    /// </summary>
    [EnumMember(Value = "FVTS")]
    [IsoId("_wtBJEfMwEei4qfiLgRIZBA")]
    [Description(@"Federal Value-Added Tax (GST) on Services")]
    FederalValueAddedTaxOnServices = AddendumTaxTypeCode.FederalValueAddedTaxOnServices, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// USA Federal Insurance Contributions Act tax levied to assist in the funding of Medicare.
    /// Encoded/decoded by serializers as &quot;FIMT&quot;.
    /// </summary>
    [EnumMember(Value = "FIMT")]
    [IsoId("_wwbpcfMwEei4qfiLgRIZBA")]
    [Description(@"USA Federal Insurance Contributions Act tax levied to assist in the funding of Medicare.")]
    FICAMedicareTax = AddendumTaxTypeCode.FICAMedicareTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// USA Federal Insurance Contributions Act tax levied to assist in the funding of social security.
    /// Encoded/decoded by serializers as &quot;FSST&quot;.
    /// </summary>
    [EnumMember(Value = "FSST")]
    [IsoId("_wzzGgfMwEei4qfiLgRIZBA")]
    [Description(@"USA Federal Insurance Contributions Act tax levied to assist in the funding of social security.")]
    FICASocialSecurityTax = AddendumTaxTypeCode.FICASocialSecurityTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// USA Federal Insurance Contributions Act tax.
    /// Encoded/decoded by serializers as &quot;FICA&quot;.
    /// </summary>
    [EnumMember(Value = "FICA")]
    [IsoId("_w3RRQfMwEei4qfiLgRIZBA")]
    [Description(@"USA Federal Insurance Contributions Act tax.")]
    FICATax = AddendumTaxTypeCode.FICATax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied by a municipality, on certain types of businesses for the right to exist as a legal entity and conduct business in a particular jurisdiction. 
    /// Encoded/decoded by serializers as &quot;FRTX&quot;.
    /// </summary>
    [EnumMember(Value = "FRTX")]
    [IsoId("_w6wqIfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied by a municipality, on certain types of businesses for the right to exist as a legal entity and conduct business in a particular jurisdiction. ")]
    FranchiseTax = AddendumTaxTypeCode.FranchiseTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fuel Spill Tax.
    /// Encoded/decoded by serializers as &quot;FSTX&quot;.
    /// </summary>
    [EnumMember(Value = "FSTX")]
    [IsoId("_w-Fq8fMwEei4qfiLgRIZBA")]
    [Description(@"Fuel Spill Tax.")]
    FuelSpillTax = AddendumTaxTypeCode.FuelSpillTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// USA federal tax levied on certain types of businesses to provide funding for cleanup of hazardous waste sites. 
    /// Encoded/decoded by serializers as &quot;FSFT&quot;.
    /// </summary>
    [EnumMember(Value = "FSFT")]
    [IsoId("_xBiAgfMwEei4qfiLgRIZBA")]
    [Description(@"USA federal tax levied on certain types of businesses to provide funding for cleanup of hazardous waste sites. ")]
    FuelSuperFundTax = AddendumTaxTypeCode.FuelSuperFundTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value Added Tax calculated at the full tax rate.
    /// Encoded/decoded by serializers as &quot;FUVT&quot;.
    /// </summary>
    [EnumMember(Value = "FUVT")]
    [IsoId("_xE4PcfMwEei4qfiLgRIZBA")]
    [Description(@"Value Added Tax calculated at the full tax rate.")]
    FullVAT = AddendumTaxTypeCode.FullVAT, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.
    /// Encoded/decoded by serializers as &quot;GIFT&quot;.
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_xIVzIfMwEei4qfiLgRIZBA")]
    [Description(@"Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.")]
    GiftTax = AddendumTaxTypeCode.GiftTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Goods and Services Tax - Canadian value-added tax.
    /// Encoded/decoded by serializers as &quot;GCAT&quot;.
    /// </summary>
    [EnumMember(Value = "GCAT")]
    [IsoId("_xL3oQfMwEei4qfiLgRIZBA")]
    [Description(@"Goods and Services Tax - Canadian value-added tax.")]
    GoodsAndServicesTax = AddendumTaxTypeCode.GoodsAndServicesTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Gross Receipts Tax.
    /// Encoded/decoded by serializers as &quot;GRTX&quot;.
    /// </summary>
    [EnumMember(Value = "GRTX")]
    [IsoId("_xPTWwfMwEei4qfiLgRIZBA")]
    [Description(@"Gross Receipts Tax.")]
    GrossReceiptsTax = AddendumTaxTypeCode.GrossReceiptsTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value Added Tax calculated at the half tax rate.
    /// Encoded/decoded by serializers as &quot;HVAT&quot;.
    /// </summary>
    [EnumMember(Value = "HVAT")]
    [IsoId("_xS2aAfMwEei4qfiLgRIZBA")]
    [Description(@"Value Added Tax calculated at the half tax rate.")]
    HalfVAT = AddendumTaxTypeCode.HalfVAT, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax assessed to assist the handicapped.
    /// Encoded/decoded by serializers as &quot;HATX&quot;.
    /// </summary>
    [EnumMember(Value = "HATX")]
    [IsoId("_xWbScfMwEei4qfiLgRIZBA")]
    [Description(@"Tax assessed to assist the handicapped.")]
    HandicapTax = AddendumTaxTypeCode.HandicapTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Harmonized Sales Tax (HST).
    /// Encoded/decoded by serializers as &quot;HSTX&quot;.
    /// </summary>
    [EnumMember(Value = "HSTX")]
    [IsoId("_xZ7SYfMwEei4qfiLgRIZBA")]
    [Description(@"Harmonized Sales Tax (HST).")]
    HarmonizedSalesTax = AddendumTaxTypeCode.HarmonizedSalesTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on entities that produce, store, treat, transport or otherwise manage hazardous wastes and materials.
    /// Encoded/decoded by serializers as &quot;HWTX&quot;.
    /// </summary>
    [EnumMember(Value = "HWTX")]
    [IsoId("_xdWZ0fMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied on entities that produce, store, treat, transport or otherwise manage hazardous wastes and materials.")]
    HazardousWasteTax = AddendumTaxTypeCode.HazardousWasteTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.
    /// Encoded/decoded by serializers as &quot;INHT&quot;.
    /// </summary>
    [EnumMember(Value = "INHT")]
    [IsoId("_xgzWcfMwEei4qfiLgRIZBA")]
    [Description(@"Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.")]
    InheritanceTax = AddendumTaxTypeCode.InheritanceTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on the sum of all earnings/revenues accrued since the last dividend distribution.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_xkWZsfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied on the sum of all earnings/revenues accrued since the last dividend distribution.")]
    InterimProfitTax = AddendumTaxTypeCode.InterimProfitTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Labour by Trade Tax
    /// Encoded/decoded by serializers as &quot;LTTX&quot;.
    /// </summary>
    [EnumMember(Value = "LTTX")]
    [IsoId("_xn9uYfMwEei4qfiLgRIZBA")]
    [Description(@"Labour by Trade Tax")]
    LabourByTradeTax = AddendumTaxTypeCode.LabourByTradeTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Federal tax levied in the USA to fund the clean-up activities associated with leaking underground storage tanks.
    /// Encoded/decoded by serializers as &quot;FLST&quot;.
    /// </summary>
    [EnumMember(Value = "FLST")]
    [IsoId("_xrarAfMwEei4qfiLgRIZBA")]
    [Description(@"Federal tax levied in the USA to fund the clean-up activities associated with leaking underground storage tanks.")]
    LeakyUndergroundStorageTankTax = AddendumTaxTypeCode.LeakyUndergroundStorageTankTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied by a government agency for the granting of a license to conduct an activity, such as driving a car, operating a business, selling liquor, hunting, or practicing certain vocations.
    /// Encoded/decoded by serializers as &quot;LITX&quot;.
    /// </summary>
    [EnumMember(Value = "LITX")]
    [IsoId("_xu1LYfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied by a government agency for the granting of a license to conduct an activity, such as driving a car, operating a business, selling liquor, hunting, or practicing certain vocations.")]
    LicenseTax = AddendumTaxTypeCode.LicenseTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Local broker&apos;s commission amount.
    /// Encoded/decoded by serializers as &quot;LOCO&quot;.
    /// </summary>
    [EnumMember(Value = "LOCO")]
    [IsoId("_xySIAfMwEei4qfiLgRIZBA")]
    [Description(@"Local broker's commission amount.")]
    LocalBrokerCommission = AddendumTaxTypeCode.LocalBrokerCommission, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All applicable sales taxes levied by taxing authorities below the state level. Used only for sales tax. 
    /// Encoded/decoded by serializers as &quot;LSTX&quot;.
    /// </summary>
    [EnumMember(Value = "LSTX")]
    [IsoId("_x1w50fMwEei4qfiLgRIZBA")]
    [Description(@"All applicable sales taxes levied by taxing authorities below the state level. Used only for sales tax. ")]
    LocalSalesTax = AddendumTaxTypeCode.LocalSalesTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service tax levied by a local government or taxation agency. Not a sales tax. 
    /// Encoded/decoded by serializers as &quot;LOCL&quot;.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_x5XAYfMwEei4qfiLgRIZBA")]
    [Description(@"Service tax levied by a local government or taxation agency. Not a sales tax. ")]
    LocalTax = AddendumTaxTypeCode.LocalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ad valorem tax levied on products or services that are deemed to be non-essential or unneeded.
    /// Encoded/decoded by serializers as &quot;LUTX&quot;.
    /// </summary>
    [EnumMember(Value = "LUTX")]
    [IsoId("_x8zV8fMwEei4qfiLgRIZBA")]
    [Description(@"Ad valorem tax levied on products or services that are deemed to be non-essential or unneeded.")]
    LuxuryTax = AddendumTaxTypeCode.LuxuryTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Material Tax
    /// Encoded/decoded by serializers as &quot;MATX&quot;.
    /// </summary>
    [EnumMember(Value = "MATX")]
    [IsoId("_yAPrgfMwEei4qfiLgRIZBA")]
    [Description(@"Material Tax")]
    MaterialTax = AddendumTaxTypeCode.MaterialTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Metropolitan Transit Tax
    /// Encoded/decoded by serializers as &quot;METX&quot;.
    /// </summary>
    [EnumMember(Value = "METX")]
    [IsoId("_yD2ZIfMwEei4qfiLgRIZBA")]
    [Description(@"Metropolitan Transit Tax")]
    MetropolitanTransitTax = AddendumTaxTypeCode.MetropolitanTransitTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Minimum Tax
    /// Encoded/decoded by serializers as &quot;MITX&quot;.
    /// </summary>
    [EnumMember(Value = "MITX")]
    [IsoId("_yHZcYfMwEei4qfiLgRIZBA")]
    [Description(@"Minimum Tax")]
    MinimumTax = AddendumTaxTypeCode.MinimumTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service tax imposed by a municipality.
    /// Encoded/decoded by serializers as &quot;MUTX&quot;.
    /// </summary>
    [EnumMember(Value = "MUTX")]
    [IsoId("_yK-U0fMwEei4qfiLgRIZBA")]
    [Description(@"Service tax imposed by a municipality.")]
    MunicipalTax = AddendumTaxTypeCode.MunicipalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mutually Defined
    /// Encoded/decoded by serializers as &quot;MUDE&quot;.
    /// </summary>
    [EnumMember(Value = "MUDE")]
    [IsoId("_yOaqYfMwEei4qfiLgRIZBA")]
    [Description(@"Mutually Defined")]
    MutuallyDefinedTax = AddendumTaxTypeCode.MutuallyDefinedTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is a country, national, or federal tax usually levied by the custodian.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_yR5cMfMwEei4qfiLgRIZBA")]
    [Description(@"Tax is a country, national, or federal tax usually levied by the custodian.")]
    NationalFederalTax = AddendumTaxTypeCode.NationalFederalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_yVZcIfMwEei4qfiLgRIZBA")]
    [Description(@"Tax is a national tax.")]
    NationalTax = AddendumTaxTypeCode.NationalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied for the privelage of occupying space for home or rental for a fixed period of time, as determined by a taxing authority. 
    /// Encoded/decoded by serializers as &quot;OCTX&quot;.
    /// </summary>
    [EnumMember(Value = "OCTX")]
    [IsoId("_yZAJwfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied for the privelage of occupying space for home or rental for a fixed period of time, as determined by a taxing authority. |")]
    OccupancyTax = AddendumTaxTypeCode.OccupancyTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of gross receipts tax imposed for the privilege of carrying on a business, trade or profession.
    /// Encoded/decoded by serializers as &quot;OPTX&quot;.
    /// </summary>
    [EnumMember(Value = "OPTX")]
    [IsoId("_ycil8fMwEei4qfiLgRIZBA")]
    [Description(@"Type of gross receipts tax imposed for the privilege of carrying on a business, trade or profession.|")]
    OccupationalTax = AddendumTaxTypeCode.OccupationalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of tax not elsewhere classified.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ygIsgfMwEei4qfiLgRIZBA")]
    [Description(@"Other type of tax not elsewhere classified.")]
    Other = AddendumTaxTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other national use defined value
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_yjqhofMwEei4qfiLgRIZBA")]
    [Description(@"Other national use defined value")]
    OtherNational = AddendumTaxTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other private use defined value
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_ynGQIfMwEei4qfiLgRIZBA")]
    [Description(@"Other private use defined value")]
    OtherPrivate = AddendumTaxTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other taxes
    /// Encoded/decoded by serializers as &quot;OTTX&quot;.
    /// </summary>
    [EnumMember(Value = "OTTX")]
    [IsoId("_yqilsfMwEei4qfiLgRIZBA")]
    [Description(@"Other taxes")]
    OtherTaxes = AddendumTaxTypeCode.OtherTaxes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on a payment.
    /// Encoded/decoded by serializers as &quot;LEVY&quot;.
    /// </summary>
    [EnumMember(Value = "LEVY")]
    [IsoId("_yuFB4fMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied on a payment.")]
    PaymentLevyTax = AddendumTaxTypeCode.PaymentLevyTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Post-threshold Tax
    /// Encoded/decoded by serializers as &quot;POTX&quot;.
    /// </summary>
    [EnumMember(Value = "POTX")]
    [IsoId("_yxpTQPMwEei4qfiLgRIZBA")]
    [Description(@"Post-threshold Tax")]
    PostThresholdTax = AddendumTaxTypeCode.PostThresholdTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pre-threshold tax
    /// Encoded/decoded by serializers as &quot;PRTX&quot;.
    /// </summary>
    [EnumMember(Value = "PRTX")]
    [IsoId("_y1OLsfMwEei4qfiLgRIZBA")]
    [Description(@"Pre-threshold tax")]
    PreThresholdTax = AddendumTaxTypeCode.PreThresholdTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on products and services
    /// Encoded/decoded by serializers as &quot;PSTX&quot;.
    /// </summary>
    [EnumMember(Value = "PSTX")]
    [IsoId("_y4sWcfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied on products and services")]
    ProductAndServicesTax = AddendumTaxTypeCode.ProductAndServicesTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ad valorem property tax levied on real or personal property by local government units such as counties, municipalities, school districts, and special taxing districts.
    /// Encoded/decoded by serializers as &quot;PPTX&quot;.
    /// </summary>
    [EnumMember(Value = "PPTX")]
    [IsoId("_y8Qn0fMwEei4qfiLgRIZBA")]
    [Description(@"Ad valorem property tax levied on real or personal property by local government units such as counties, municipalities, school districts, and special taxing districts.")]
    PropertyTax = AddendumTaxTypeCode.PropertyTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Provincial tax
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_y_uykfMwEei4qfiLgRIZBA")]
    [Description(@"Provincial tax")]
    ProvincialTax = AddendumTaxTypeCode.ProvincialTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Canadian tax levied to fund public care and education. 
    /// Encoded/decoded by serializers as &quot;PHET&quot;.
    /// </summary>
    [EnumMember(Value = "PHET")]
    [IsoId("_zDMWQfMwEei4qfiLgRIZBA")]
    [Description(@"Canadian tax levied to fund public care and education. ")]
    PublicHealthAndEducationTax = AddendumTaxTypeCode.PublicHealthAndEducationTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quebec Sales Tax (QST)
    /// Encoded/decoded by serializers as &quot;QUST&quot;.
    /// </summary>
    [EnumMember(Value = "QUST")]
    [IsoId("_zGwnofMwEei4qfiLgRIZBA")]
    [Description(@"Quebec Sales Tax (QST)")]
    QuebecSalesTax = AddendumTaxTypeCode.QuebecSalesTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Room City
    /// Encoded/decoded by serializers as &quot;ROCI&quot;.
    /// </summary>
    [EnumMember(Value = "ROCI")]
    [IsoId("_zKNkQfMwEei4qfiLgRIZBA")]
    [Description(@"Room City")]
    RoomCity = AddendumTaxTypeCode.RoomCity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Room Country Subdivision1
    /// Encoded/decoded by serializers as &quot;RCSB&quot;.
    /// </summary>
    [EnumMember(Value = "RCSB")]
    [IsoId("_zNuLQfMwEei4qfiLgRIZBA")]
    [Description(@"Room Country Subdivision1")]
    RoomCountrySubdivision1 = AddendumTaxTypeCode.RoomCountrySubdivision1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Room Country Subdivision2
    /// Encoded/decoded by serializers as &quot;RCSD&quot;.
    /// </summary>
    [EnumMember(Value = "RCSD")]
    [IsoId("_zSJ_UfMwEei4qfiLgRIZBA")]
    [Description(@"Room Country Subdivision2")]
    RoomCountrySubdivision2 = AddendumTaxTypeCode.RoomCountrySubdivision2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Room Tax
    /// Encoded/decoded by serializers as &quot;ROTX&quot;.
    /// </summary>
    [EnumMember(Value = "ROTX")]
    [IsoId("_zVws8fMwEei4qfiLgRIZBA")]
    [Description(@"Room Tax")]
    RoomTax = AddendumTaxTypeCode.RoomTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Room VAT
    /// Encoded/decoded by serializers as &quot;RVAT&quot;.
    /// </summary>
    [EnumMember(Value = "RVAT")]
    [IsoId("_zZO3sfMwEei4qfiLgRIZBA")]
    [Description(@"Room VAT")]
    RoomVAT = AddendumTaxTypeCode.RoomVAT, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Room Visitor
    /// Encoded/decoded by serializers as &quot;ROVI&quot;.
    /// </summary>
    [EnumMember(Value = "ROVI")]
    [IsoId("_zc2zcfMwEei4qfiLgRIZBA")]
    [Description(@"Room Visitor")]
    RoomVisitor = AddendumTaxTypeCode.RoomVisitor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied for the use of equipment and service provided
    /// Encoded/decoded by serializers as &quot;SAUT&quot;.
    /// </summary>
    [EnumMember(Value = "SAUT")]
    [IsoId("_zgfWQfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied for the use of equipment and service provided")]
    SalesAndUseTax = AddendumTaxTypeCode.SalesAndUseTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied by taxing authority for schools
    /// Encoded/decoded by serializers as &quot;SCTX&quot;.
    /// </summary>
    [EnumMember(Value = "SCTX")]
    [IsoId("_zj6dsfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied by taxing authority for schools")]
    SchoolTax = AddendumTaxTypeCode.SchoolTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Secondary Percentage Tax
    /// Encoded/decoded by serializers as &quot;SPTX&quot;.
    /// </summary>
    [EnumMember(Value = "SPTX")]
    [IsoId("_znWMMfMwEei4qfiLgRIZBA")]
    [Description(@"Secondary Percentage Tax")]
    SecondaryPercentageTax = AddendumTaxTypeCode.SecondaryPercentageTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stadium Tax
    /// Encoded/decoded by serializers as &quot;STTA&quot;.
    /// </summary>
    [EnumMember(Value = "STTA")]
    [IsoId("_zq4oYfMwEei4qfiLgRIZBA")]
    [Description(@"Stadium Tax")]
    StadiumTax = AddendumTaxTypeCode.StadiumTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on certain types of documents and transactions.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_zuYBQfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied on certain types of documents and transactions.")]
    StampDuty = AddendumTaxTypeCode.StampDuty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State and Local Sales Tax
    /// Encoded/decoded by serializers as &quot;SLST&quot;.
    /// </summary>
    [EnumMember(Value = "SLST")]
    [IsoId("_zx6dcfMwEei4qfiLgRIZBA")]
    [Description(@"State and Local Sales Tax")]
    StateAndLocalSalesTax = AddendumTaxTypeCode.StateAndLocalSalesTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State and local tax levies, exclusive of state and local sales tax. 
    /// Encoded/decoded by serializers as &quot;SLTX&quot;.
    /// </summary>
    [EnumMember(Value = "SLTX")]
    [IsoId("_z1hyIfMwEei4qfiLgRIZBA")]
    [Description(@"State and local tax levies, exclusive of state and local sales tax. ")]
    StateAndLocalTax = AddendumTaxTypeCode.StateAndLocalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Usage tax imposed by state or provincial government authorities.
    /// Encoded/decoded by serializers as &quot;SETX&quot;.
    /// </summary>
    [EnumMember(Value = "SETX")]
    [IsoId("_z5GqkfMwEei4qfiLgRIZBA")]
    [Description(@"Usage tax imposed by state or provincial government authorities.")]
    StateExciseTax = AddendumTaxTypeCode.StateExciseTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sales tax levied by a State or Province that excludes sales or excise taxes.
    /// Encoded/decoded by serializers as &quot;STPT&quot;.
    /// </summary>
    [EnumMember(Value = "STPT")]
    [IsoId("_z8k1UfMwEei4qfiLgRIZBA")]
    [Description(@"Sales tax levied by a State or Province that excludes sales or excise taxes.")]
    StateOrProvincialTax = AddendumTaxTypeCode.StateOrProvincialTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State or Provincial tax on services
    /// Encoded/decoded by serializers as &quot;SPTS&quot;.
    /// </summary>
    [EnumMember(Value = "SPTS")]
    [IsoId("_0ABx8fMwEei4qfiLgRIZBA")]
    [Description(@"State or Provincial tax on services")]
    StateOrProvincialTaxOnServices = AddendumTaxTypeCode.StateOrProvincialTaxOnServices, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State or Provincial Fuel Tax
    /// Encoded/decoded by serializers as &quot;SPFT&quot;.
    /// </summary>
    [EnumMember(Value = "SPFT")]
    [IsoId("_0DlcQfMwEei4qfiLgRIZBA")]
    [Description(@"State or Provincial Fuel Tax")]
    StateProvincialFuelTax = AddendumTaxTypeCode.StateProvincialFuelTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State or Provincial Tax on Goods
    /// Encoded/decoded by serializers as &quot;SPTG&quot;.
    /// </summary>
    [EnumMember(Value = "SPTG")]
    [IsoId("_0G_VkfMwEei4qfiLgRIZBA")]
    [Description(@"State or Provincial Tax on Goods")]
    StateProvincialTaxOnGoods = AddendumTaxTypeCode.StateProvincialTaxOnGoods, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied by a state government against a periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;SRTX&quot;.
    /// </summary>
    [EnumMember(Value = "SRTX")]
    [IsoId("_0Kk1EfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied by a state government against a periodic fee paid by a customer in return for the right to use the property of another party.")]
    StateRentalTax = AddendumTaxTypeCode.StateRentalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State Sales Tax
    /// Encoded/decoded by serializers as &quot;SSTX&quot;.
    /// </summary>
    [EnumMember(Value = "SSTX")]
    [IsoId("_0OGDIfMwEei4qfiLgRIZBA")]
    [Description(@"State Sales Tax")]
    StateSalesTax = AddendumTaxTypeCode.StateSalesTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State tax.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_0RlcAfMwEei4qfiLgRIZBA")]
    [Description(@"State tax.")]
    StateTax = AddendumTaxTypeCode.StateTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State Tax on Specific Labour
    /// Encoded/decoded by serializers as &quot;STSL&quot;.
    /// </summary>
    [EnumMember(Value = "STSL")]
    [IsoId("_0VEN0fMwEei4qfiLgRIZBA")]
    [Description(@"State Tax on Specific Labour")]
    StateTaxOnSpecificLabour = AddendumTaxTypeCode.StateTaxOnSpecificLabour, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied by a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_0YmqAfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied by a stock exchange.")]
    StockExchangeTax = AddendumTaxTypeCode.StockExchangeTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Surtax
    /// Encoded/decoded by serializers as &quot;SUTX&quot;.
    /// </summary>
    [EnumMember(Value = "SUTX")]
    [IsoId("_0cGC4fMwEei4qfiLgRIZBA")]
    [Description(@"Surtax")]
    Surtax = AddendumTaxTypeCode.Surtax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Direct reduction of an individual&apos;s tax liability.
    /// Encoded/decoded by serializers as &quot;CTAX&quot;.
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_0fnQ8fMwEei4qfiLgRIZBA")]
    [Description(@"Direct reduction of an individual's tax liability.")]
    TaxCredit = AddendumTaxTypeCode.TaxCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Excise tax levied to recover the cost of providing Telecommunications Device for the Deaf (TDD) Equipment. 
    /// Encoded/decoded by serializers as &quot;TDDT&quot;.
    /// </summary>
    [EnumMember(Value = "TDDT")]
    [IsoId("_0jH38fMwEei4qfiLgRIZBA")]
    [Description(@"Excise tax levied to recover the cost of providing Telecommunications Device for the Deaf (TDD) Equipment. ")]
    TDDServiceExciseTax = AddendumTaxTypeCode.TDDServiceExciseTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on telecommunications companies for the right to provide services. May be a usage or excise tax.
    /// Encoded/decoded by serializers as &quot;TELT&quot;.
    /// </summary>
    [EnumMember(Value = "TELT")]
    [IsoId("_0nEj0fMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied on telecommunications companies for the right to provide services. May be a usage or excise tax.")]
    TelecommunicationsTax = AddendumTaxTypeCode.TelecommunicationsTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Threshold Tax
    /// Encoded/decoded by serializers as &quot;THTX&quot;.
    /// </summary>
    [EnumMember(Value = "THTX")]
    [IsoId("_0qiukfMwEei4qfiLgRIZBA")]
    [Description(@"Threshold Tax")]
    ThresholdTax = AddendumTaxTypeCode.ThresholdTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on a transaction.
    /// Encoded/decoded by serializers as &quot;TRAX&quot;.
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_1t1XkfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied on a transaction.")]
    TransactionTax = AddendumTaxTypeCode.TransactionTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on a transfer.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_1zkMIfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied on a transfer.")]
    TransferTax = AddendumTaxTypeCode.TransferTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unspecified tax type
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_1283UfMwEei4qfiLgRIZBA")]
    [Description(@"Unspecified tax type")]
    Unspecified = AddendumTaxTypeCode.Unspecified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on consumers by a city or county for the use of natural gas. 
    /// Encoded/decoded by serializers as &quot;UUTX&quot;.
    /// </summary>
    [EnumMember(Value = "UUTX")]
    [IsoId("_16hvwfMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied on consumers by a city or county for the use of natural gas. ")]
    UtilityUsersTax = AddendumTaxTypeCode.UtilityUsersTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value added tax
    /// Encoded/decoded by serializers as &quot;VATA&quot;.
    /// </summary>
    [EnumMember(Value = "VATA")]
    [IsoId("_2NiLUfMwEei4qfiLgRIZBA")]
    [Description(@"Value added tax")]
    ValueAddedTax = AddendumTaxTypeCode.ValueAddedTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax for which a zero rate applies.
    /// Encoded/decoded by serializers as &quot;VATB&quot;.
    /// </summary>
    [EnumMember(Value = "VATB")]
    [IsoId("_2Q_H8fMwEei4qfiLgRIZBA")]
    [Description(@"Tax for which a zero rate applies.")]
    ValueAddedTaxOfZeroRate = AddendumTaxTypeCode.ValueAddedTaxOfZeroRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied only when the value of assets or categories of assets owned by an entity are above a given limit as defined by the tax authority. Wealth tax is not linked to income.
    /// Encoded/decoded by serializers as &quot;WTAX&quot;.
    /// </summary>
    [EnumMember(Value = "WTAX")]
    [IsoId("_2ovgofMwEei4qfiLgRIZBA")]
    [Description(@"Tax levied only when the value of assets or categories of assets owned by an entity are above a given limit as defined by the tax authority. Wealth tax is not linked to income.")]
    WealthTax = AddendumTaxTypeCode.WealthTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Well Service
    /// Encoded/decoded by serializers as &quot;WESV&quot;.
    /// </summary>
    [EnumMember(Value = "WESV")]
    [IsoId("_2sJZ8fMwEei4qfiLgRIZBA")]
    [Description(@"Well Service")]
    WellService = AddendumTaxTypeCode.WellService, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITF&quot;.
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_3BafUfMwEei4qfiLgRIZBA")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfForeignTax = AddendumTaxTypeCode.WithholdingOfForeignTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITL&quot;.
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_3EzxkfMwEei4qfiLgRIZBA")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfLocalTax = AddendumTaxTypeCode.WithholdingOfLocalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Income tax withheld or deducted from the amount due to the recipient, and paid to the government by the payer rather than the recipient. May apply to salaries, interest, and other types of proceeds. 
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_3ITKcfMwEei4qfiLgRIZBA")]
    [Description(@"Income tax withheld or deducted from the amount due to the recipient, and paid to the government by the payer rather than the recipient. May apply to salaries, interest, and other types of proceeds. ")]
    WithholdingTax = AddendumTaxTypeCode.WithholdingTax, // same ordinal as derivation source for type conversions
    
}
