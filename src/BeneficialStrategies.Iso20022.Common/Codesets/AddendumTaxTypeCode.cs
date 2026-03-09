// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the specific type of tax(es) applicable to a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_o7g-JvJ7EeiJn9rM2Znz2w")]
[Description(@"Specifies the specific type of tax(es) applicable to a transaction.")]
[Derivations(typeof(AddendumTaxType1Code),typeof(AddendumTaxType2Code))]
public enum AddendumTaxTypeCode
{
    /// <summary>
    /// Tax for which a zero rate applies.
    /// Encoded/decoded by serializers as &quot;VATB&quot;.
    /// </summary>
    [EnumMember(Value = "VATB")]
    [IsoId("_o7kBRPJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax for which a zero rate applies.")]
    ValueAddedTaxOfZeroRate,
    
    /// <summary>
    /// Provincial tax
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_o7kBS_J7EeiJn9rM2Znz2w")]
    [Description(@"Provincial tax")]
    ProvincialTax,
    
    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_o7kBMvJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax is a national tax.")]
    NationalTax,
    
    /// <summary>
    /// State tax.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_o7kBMfJ7EeiJn9rM2Znz2w")]
    [Description(@"State tax.")]
    StateTax,
    
    /// <summary>
    /// Income tax withheld or deducted from the amount due to the recipient, and paid to the government by the payer rather than the recipient. May apply to salaries, interest, and other types of proceeds. 
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_o7kBSfJ7EeiJn9rM2Znz2w")]
    [Description(@"Income tax withheld or deducted from the amount due to the recipient, and paid to the government by the payer rather than the recipient. May apply to salaries, interest, and other types of proceeds. ")]
    WithholdingTax,
    
    /// <summary>
    /// Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.
    /// Encoded/decoded by serializers as &quot;KAPA&quot;.
    /// </summary>
    [EnumMember(Value = "KAPA")]
    [IsoId("_o7kBOPJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.")]
    CapitalGainTax,
    
    /// <summary>
    /// Tax levied on the sum of all earnings/revenues accrued since the last dividend distribution.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_o7g-J_J7EeiJn9rM2Znz2w")]
    [Description(@"Tax levied on the sum of all earnings/revenues accrued since the last dividend distribution.")]
    InterimProfitTax,
    
    /// <summary>
    /// Tax levied on certain types of documents and transactions.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_o7koQPJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax levied on certain types of documents and transactions.")]
    StampDuty,
    
    /// <summary>
    /// Tax levied only when the value of assets or categories of assets owned by an entity are above a given limit as defined by the tax authority. Wealth tax is not linked to income.
    /// Encoded/decoded by serializers as &quot;WTAX&quot;.
    /// </summary>
    [EnumMember(Value = "WTAX")]
    [IsoId("_o7kBNvJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax levied only when the value of assets or categories of assets owned by an entity are above a given limit as defined by the tax authority. Wealth tax is not linked to income.")]
    WealthTax,
    
    /// <summary>
    /// Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.
    /// Encoded/decoded by serializers as &quot;INHT&quot;.
    /// </summary>
    [EnumMember(Value = "INHT")]
    [IsoId("_o7kBRfJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.")]
    InheritanceTax,
    
    /// <summary>
    /// Direct reduction of an individual&apos;s tax liability.
    /// Encoded/decoded by serializers as &quot;CTAX&quot;.
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_o7koRPJ7EeiJn9rM2Znz2w")]
    [Description(@"Direct reduction of an individual's tax liability.")]
    TaxCredit,
    
    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_o7kBN_J7EeiJn9rM2Znz2w")]
    [Description(@"Part of an investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.")]
    Equalisation,
    
    /// <summary>
    /// Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.
    /// Encoded/decoded by serializers as &quot;GIFT&quot;.
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_o7kBMPJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.")]
    GiftTax,
    
    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_o7kBTfJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax that is levied on goods and services purchased by customers, and is added to the retail price.")]
    ConsumptionTax,
    
    /// <summary>
    /// Tax is an alternative minimum tax.
    /// Encoded/decoded by serializers as &quot;ALMI&quot;.
    /// </summary>
    [EnumMember(Value = "ALMI")]
    [IsoId("_o7kBO_J7EeiJn9rM2Znz2w")]
    [Description(@"Tax is an alternative minimum tax.")]
    AlternativeMinimumTax,
    
    /// <summary>
    /// Tax is a country, national, or federal tax usually levied by the custodian.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_o7kBPfJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax is a country, national, or federal tax usually levied by the custodian.")]
    NationalFederalTax,
    
    /// <summary>
    /// Tax levied on a payment.
    /// Encoded/decoded by serializers as &quot;LEVY&quot;.
    /// </summary>
    [EnumMember(Value = "LEVY")]
    [IsoId("_o7kBOfJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax levied on a payment.")]
    PaymentLevyTax,
    
    /// <summary>
    /// Tax levied by a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_o7kBNfJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax levied by a stock exchange.")]
    StockExchangeTax,
    
    /// <summary>
    /// Tax levied on a transaction.
    /// Encoded/decoded by serializers as &quot;TRAX&quot;.
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_o7g-KPJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax levied on a transaction.")]
    TransactionTax,
    
    /// <summary>
    /// Tax levied on a transfer.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_o7kBSPJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax levied on a transfer.")]
    TransferTax,
    
    /// <summary>
    /// Value added tax
    /// Encoded/decoded by serializers as &quot;VATA&quot;.
    /// </summary>
    [EnumMember(Value = "VATA")]
    [IsoId("_o7kBOvJ7EeiJn9rM2Znz2w")]
    [Description(@"Value added tax")]
    ValueAddedTax,
    
    /// <summary>
    /// Local broker&apos;s commission amount.
    /// Encoded/decoded by serializers as &quot;LOCO&quot;.
    /// </summary>
    [EnumMember(Value = "LOCO")]
    [IsoId("_o7kBQvJ7EeiJn9rM2Znz2w")]
    [Description(@"Local broker's commission amount.")]
    LocalBrokerCommission,
    
    /// <summary>
    /// Executing broker&apos;s commission amount.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_o7kBQfJ7EeiJn9rM2Znz2w")]
    [Description(@"Executing broker's commission amount.")]
    ExecutingBrokerCommission,
    
    /// <summary>
    /// Tax levied on imports or exports by a country&apos;s customs authority. 
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_o7kBR_J7EeiJn9rM2Znz2w")]
    [Description(@"Tax levied on imports or exports by a country's customs authority. ")]
    CustomsTax,
    
    /// <summary>
    /// Other type of tax not elsewhere classified.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_o7kBM_J7EeiJn9rM2Znz2w")]
    [Description(@"Other type of tax not elsewhere classified.")]
    Other,
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITF&quot;.
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_o7koQfJ7EeiJn9rM2Znz2w")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfForeignTax,
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITL&quot;.
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_o7kBQPJ7EeiJn9rM2Znz2w")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfLocalTax,
    
    /// <summary>
    /// Tax recovery is due to capital loss.
    /// Encoded/decoded by serializers as &quot;NKAP&quot;.
    /// </summary>
    [EnumMember(Value = "NKAP")]
    [IsoId("_o7kBP_J7EeiJn9rM2Znz2w")]
    [Description(@"Tax recovery is due to capital loss.")]
    CapitalLossCredit,
    
    /// <summary>
    /// Tax levied on products and services
    /// Encoded/decoded by serializers as &quot;PSTX&quot;.
    /// </summary>
    [EnumMember(Value = "PSTX")]
    [IsoId("_o7koQvJ7EeiJn9rM2Znz2w")]
    [Description(@"Tax levied on products and services")]
    ProductAndServicesTax,
    
    /// <summary>
    /// Total of all applicable taxes
    /// Encoded/decoded by serializers as &quot;TOTL&quot;.
    /// </summary>
    [EnumMember(Value = "TOTL")]
    [IsoId("_GKBuYPKbEei1r_AoF1Xfwg")]
    [Description(@"Total of all applicable taxes")]
    TotalTaxes,
    
    /// <summary>
    /// Assessment
    /// Encoded/decoded by serializers as &quot;ASNT&quot;.
    /// </summary>
    [EnumMember(Value = "ASNT")]
    [IsoId("_OvZowPKbEei1r_AoF1Xfwg")]
    [Description(@"Assessment")]
    Assessment,
    
    /// <summary>
    /// Tax imposed on non-American Indian businesses for the privilege of conducting business on an American Indian Reservation
    /// Encoded/decoded by serializers as &quot;BPTX&quot;.
    /// </summary>
    [EnumMember(Value = "BPTX")]
    [IsoId("_XVacUPKbEei1r_AoF1Xfwg")]
    [Description(@"Tax imposed on non-American Indian businesses for the privilege of conducting business on an American Indian Reservation")]
    BusinessPrivilegeTax,
    
    /// <summary>
    /// Service tax imposed by a city
    /// Encoded/decoded by serializers as &quot;CITX&quot;.
    /// </summary>
    [EnumMember(Value = "CITX")]
    [IsoId("_daN3YPKbEei1r_AoF1Xfwg")]
    [Description(@"Service tax imposed by a city")]
    CityTax,
    
    /// <summary>
    /// Levied by a county government against the periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_oZSNAPKbEei1r_AoF1Xfwg")]
    [Description(@"Levied by a county government against the periodic fee paid by a customer in return for the right to use the property of another party.")]
    CountyRentalTax,
    
    /// <summary>
    /// Service tax levied by a county
    /// Encoded/decoded by serializers as &quot;COTX&quot;.
    /// </summary>
    [EnumMember(Value = "COTX")]
    [IsoId("_xtAbIPKbEei1r_AoF1Xfwg")]
    [Description(@"Service tax levied by a county")]
    CountyTax,
    
    /// <summary>
    /// Service tax imposed by a County or Parish
    /// Encoded/decoded by serializers as &quot;CPST&quot;.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_5036IPKbEei1r_AoF1Xfwg")]
    [Description(@"Service tax imposed by a County or Parish")]
    CountyParishSalesTax,
    
    /// <summary>
    /// Levied by a city government against the periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;CRTX&quot;.
    /// </summary>
    [EnumMember(Value = "CRTX")]
    [IsoId("_QIBMEPKcEei1r_AoF1Xfwg")]
    [Description(@"Levied by a city government against the periodic fee paid by a customer in return for the right to use the property of another party.")]
    CityRentalTax,
    
    /// <summary>
    /// Sales tax imposed by a city
    /// Encoded/decoded by serializers as &quot;CSTX&quot;.
    /// </summary>
    [EnumMember(Value = "CSTX")]
    [IsoId("_cMPL4PKcEei1r_AoF1Xfwg")]
    [Description(@"Sales tax imposed by a city")]
    CitySalesTax,
    
    /// <summary>
    /// Default Labour Tax
    /// Encoded/decoded by serializers as &quot;DLTX&quot;.
    /// </summary>
    [EnumMember(Value = "DLTX")]
    [IsoId("_ptmfIPKcEei1r_AoF1Xfwg")]
    [Description(@"Default Labour Tax")]
    DefaultLabourTax,
    
    /// <summary>
    /// Ad valorem tax levied on products or services that are deemed to be non-essential or unneeded.
    /// Encoded/decoded by serializers as &quot;LUTX&quot;.
    /// </summary>
    [EnumMember(Value = "LUTX")]
    [IsoId("_592agPKcEei1r_AoF1Xfwg")]
    [Description(@"Ad valorem tax levied on products or services that are deemed to be non-essential or unneeded.")]
    LuxuryTax,
    
    /// <summary>
    /// Ad valorem property tax levied on real or personal property by local government units such as counties, municipalities, school districts, and special taxing districts.
    /// Encoded/decoded by serializers as &quot;PPTX&quot;.
    /// </summary>
    [EnumMember(Value = "PPTX")]
    [IsoId("_nnFCEPKdEei1r_AoF1Xfwg")]
    [Description(@"Ad valorem property tax levied on real or personal property by local government units such as counties, municipalities, school districts, and special taxing districts.")]
    PropertyTax,
    
    /// <summary>
    /// A tax levied on goods that typically though not exclusively transit across a geographic border. 
    /// Encoded/decoded by serializers as &quot;DUTY&quot;.
    /// </summary>
    [EnumMember(Value = "DUTY")]
    [IsoId("_44RdEPKdEei1r_AoF1Xfwg")]
    [Description(@"A tax levied on goods that typically though not exclusively transit across a geographic border. ")]
    Duty,
    
    /// <summary>
    /// Usage tax levied to recover the cost of telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMET&quot;.
    /// </summary>
    [EnumMember(Value = "EMET")]
    [IsoId("_r-sGEPKeEei1r_AoF1Xfwg")]
    [Description(@"Usage tax levied to recover the cost of telephone emergency assistance service (for example, 112, 911, 999).")]
    EmergencyAssistanceExciseTax,
    
    /// <summary>
    /// Tax levied by a city to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMIT&quot;.
    /// </summary>
    [EnumMember(Value = "EMIT")]
    [IsoId("_pMensPKfEei1r_AoF1Xfwg")]
    [Description(@"Tax levied by a city to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).")]
    EmergencyAssistanceCityTax,
    
    /// <summary>
    /// Tax levied by a state to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMST&quot;.
    /// </summary>
    [EnumMember(Value = "EMST")]
    [IsoId("_TcIO4PKhEei1r_AoF1Xfwg")]
    [Description(@"Tax levied by a state to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).")]
    EmergencyAssistanceStateTax,
    
    /// <summary>
    /// Tax levied to recover the cost of providing telephone emergency assistance service (for example,112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMRT&quot;.
    /// </summary>
    [EnumMember(Value = "EMRT")]
    [IsoId("_Y5Zv4PKhEei1r_AoF1Xfwg")]
    [Description(@"Tax levied to recover the cost of providing telephone emergency assistance service (for example,112, 911, 999).")]
    EmergencyAssistanceTax,
    
    /// <summary>
    /// Tax levied by a county to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).
    /// Encoded/decoded by serializers as &quot;EMUT&quot;.
    /// </summary>
    [EnumMember(Value = "EMUT")]
    [IsoId("_uQ5R4PKhEei1r_AoF1Xfwg")]
    [Description(@"Tax levied by a county to recover the cost of providing telephone emergency assistance service (for example, 112, 911, 999).")]
    EmergencyAssistanceCountyTax,
    
    /// <summary>
    /// Tax levied by a state to recover the cost of providing enhanced telephone emergency assistance services (for example, 112, 911, 999) such as automatic call identification.
    /// Encoded/decoded by serializers as &quot;ESET&quot;.
    /// </summary>
    [EnumMember(Value = "ESET")]
    [IsoId("_DbVPUPKiEei1r_AoF1Xfwg")]
    [Description(@"Tax levied by a state to recover the cost of providing enhanced telephone emergency assistance services (for example, 112, 911, 999) such as automatic call identification.")]
    EnhancedEmergencyAssistanceStateExciseTax,
    
    /// <summary>
    /// Usage tax levied by federal (US and Canadian) government.
    /// Encoded/decoded by serializers as &quot;FETX&quot;.
    /// </summary>
    [EnumMember(Value = "FETX")]
    [IsoId("_XSXEIPKiEei1r_AoF1Xfwg")]
    [Description(@"Usage tax levied by federal (US and Canadian) government.")]
    FederalTax,
    
    /// <summary>
    /// Excise tax levied by a federal government.
    /// Encoded/decoded by serializers as &quot;FEXT&quot;.
    /// </summary>
    [EnumMember(Value = "FEXT")]
    [IsoId("_9HdBAPKiEei1r_AoF1Xfwg")]
    [Description(@"Excise tax levied by a federal government.")]
    FederalExciseTax,
    
    /// <summary>
    /// Tax applied to the utility and petroleum industries. 
    /// Encoded/decoded by serializers as &quot;ENTX&quot;.
    /// </summary>
    [EnumMember(Value = "ENTX")]
    [IsoId("_UVPrYPKlEei1r_AoF1Xfwg")]
    [Description(@"Tax applied to the utility and petroleum industries. ")]
    EnergyTax,
    
    /// <summary>
    /// Tax levied on activities which are considered to have negative impacts on an environment. 
    /// Encoded/decoded by serializers as &quot;ENVT&quot;.
    /// </summary>
    [EnumMember(Value = "ENVT")]
    [IsoId("_ZeT28PKlEei1r_AoF1Xfwg")]
    [Description(@"Tax levied on activities which are considered to have negative impacts on an environment. ")]
    EnvironmentalTax,
    
    /// <summary>
    /// Equipment Tax
    /// Encoded/decoded by serializers as &quot;EQTX&quot;.
    /// </summary>
    [EnumMember(Value = "EQTX")]
    [IsoId("_U47KwPKmEei1r_AoF1Xfwg")]
    [Description(@"Equipment Tax")]
    EquipmentTax,
    
    /// <summary>
    /// USA Federal Insurance Contributions Act tax.
    /// Encoded/decoded by serializers as &quot;FICA&quot;.
    /// </summary>
    [EnumMember(Value = "FICA")]
    [IsoId("_hP4gYPKmEei1r_AoF1Xfwg")]
    [Description(@"USA Federal Insurance Contributions Act tax.")]
    FICATax,
    
    /// <summary>
    /// USA Federal Insurance Contributions Act tax levied to assist in the funding of Medicare.
    /// Encoded/decoded by serializers as &quot;FIMT&quot;.
    /// </summary>
    [EnumMember(Value = "FIMT")]
    [IsoId("_k2nWgPKmEei1r_AoF1Xfwg")]
    [Description(@"USA Federal Insurance Contributions Act tax levied to assist in the funding of Medicare.")]
    FICAMedicareTax,
    
    /// <summary>
    /// Federal tax levied in the USA to fund the clean-up activities associated with leaking underground storage tanks.
    /// Encoded/decoded by serializers as &quot;FLST&quot;.
    /// </summary>
    [EnumMember(Value = "FLST")]
    [IsoId("_4l5IEPKnEei1r_AoF1Xfwg")]
    [Description(@"Federal tax levied in the USA to fund the clean-up activities associated with leaking underground storage tanks.")]
    LeakyUndergroundStorageTankTax,
    
    /// <summary>
    /// Federal or National Sales Tax.
    /// Encoded/decoded by serializers as &quot;FNST&quot;.
    /// </summary>
    [EnumMember(Value = "FNST")]
    [IsoId("_geVcwPKoEei1r_AoF1Xfwg")]
    [Description(@"Federal or National Sales Tax.")]
    FederalNationalSalesTax,
    
    /// <summary>
    /// Tax levied by a municipality, on certain types of businesses for the right to exist as a legal entity and conduct business in a particular jurisdiction. 
    /// Encoded/decoded by serializers as &quot;FRTX&quot;.
    /// </summary>
    [EnumMember(Value = "FRTX")]
    [IsoId("_nPC7kPKoEei1r_AoF1Xfwg")]
    [Description(@"Tax levied by a municipality, on certain types of businesses for the right to exist as a legal entity and conduct business in a particular jurisdiction. ")]
    FranchiseTax,
    
    /// <summary>
    /// USA federal tax levied on certain types of businesses to provide funding for cleanup of hazardous waste sites. 
    /// Encoded/decoded by serializers as &quot;FSFT&quot;.
    /// </summary>
    [EnumMember(Value = "FSFT")]
    [IsoId("__0_WkPKoEei1r_AoF1Xfwg")]
    [Description(@"USA federal tax levied on certain types of businesses to provide funding for cleanup of hazardous waste sites. ")]
    FuelSuperFundTax,
    
    /// <summary>
    /// USA Federal Insurance Contributions Act tax levied to assist in the funding of social security.
    /// Encoded/decoded by serializers as &quot;FSST&quot;.
    /// </summary>
    [EnumMember(Value = "FSST")]
    [IsoId("_Cic7APKsEei1r_AoF1Xfwg")]
    [Description(@"USA Federal Insurance Contributions Act tax levied to assist in the funding of social security.")]
    FICASocialSecurityTax,
    
    /// <summary>
    /// Value Added Tax calculated at the half tax rate.
    /// Encoded/decoded by serializers as &quot;HVAT&quot;.
    /// </summary>
    [EnumMember(Value = "HVAT")]
    [IsoId("_FnR98PKsEei1r_AoF1Xfwg")]
    [Description(@"Value Added Tax calculated at the half tax rate.")]
    HalfVAT,
    
    /// <summary>
    /// Fuel Spill Tax.
    /// Encoded/decoded by serializers as &quot;FSTX&quot;.
    /// </summary>
    [EnumMember(Value = "FSTX")]
    [IsoId("_3FbMIPKtEei1r_AoF1Xfwg")]
    [Description(@"Fuel Spill Tax.")]
    FuelSpillTax,
    
    /// <summary>
    /// Value Added Tax calculated at the full tax rate.
    /// Encoded/decoded by serializers as &quot;FUVT&quot;.
    /// </summary>
    [EnumMember(Value = "FUVT")]
    [IsoId("_-WaGcPKtEei1r_AoF1Xfwg")]
    [Description(@"Value Added Tax calculated at the full tax rate.")]
    FullVAT,
    
    /// <summary>
    /// Federal Value-Added Tax (GST).
    /// Encoded/decoded by serializers as &quot;FVAT&quot;.
    /// </summary>
    [EnumMember(Value = "FVAT")]
    [IsoId("_V_fbIPKvEei1r_AoF1Xfwg")]
    [Description(@"Federal Value-Added Tax (GST).")]
    FederalValueAddedTax,
    
    /// <summary>
    /// Federal Value-Added Tax (GST) on Services
    /// Encoded/decoded by serializers as &quot;FVTS&quot;.
    /// </summary>
    [EnumMember(Value = "FVTS")]
    [IsoId("_jVrZIPKvEei1r_AoF1Xfwg")]
    [Description(@"Federal Value-Added Tax (GST) on Services")]
    FederalValueAddedTaxOnServices,
    
    /// <summary>
    /// Gross Receipts Tax.
    /// Encoded/decoded by serializers as &quot;GRTX&quot;.
    /// </summary>
    [EnumMember(Value = "GRTX")]
    [IsoId("_oluWcPKvEei1r_AoF1Xfwg")]
    [Description(@"Gross Receipts Tax.")]
    GrossReceiptsTax,
    
    /// <summary>
    /// Goods and Services Tax - Canadian value-added tax.
    /// Encoded/decoded by serializers as &quot;GCAT&quot;.
    /// </summary>
    [EnumMember(Value = "GCAT")]
    [IsoId("_Aw3Y4PK9Eei1r_AoF1Xfwg")]
    [Description(@"Goods and Services Tax - Canadian value-added tax.")]
    GoodsAndServicesTax,
    
    /// <summary>
    /// Tax assessed to assist the handicapped.
    /// Encoded/decoded by serializers as &quot;HATX&quot;.
    /// </summary>
    [EnumMember(Value = "HATX")]
    [IsoId("_mCwiEPK9Eei1r_AoF1Xfwg")]
    [Description(@"Tax assessed to assist the handicapped.")]
    HandicapTax,
    
    /// <summary>
    /// Harmonized Sales Tax (HST).
    /// Encoded/decoded by serializers as &quot;HSTX&quot;.
    /// </summary>
    [EnumMember(Value = "HSTX")]
    [IsoId("_r--B0PK9Eei1r_AoF1Xfwg")]
    [Description(@"Harmonized Sales Tax (HST).")]
    HarmonizedSalesTax,
    
    /// <summary>
    /// Tax levied on entities that produce, store, treat, transport or otherwise manage hazardous wastes and materials.
    /// Encoded/decoded by serializers as &quot;HWTX&quot;.
    /// </summary>
    [EnumMember(Value = "HWTX")]
    [IsoId("_xZvocPK9Eei1r_AoF1Xfwg")]
    [Description(@"Tax levied on entities that produce, store, treat, transport or otherwise manage hazardous wastes and materials.")]
    HazardousWasteTax,
    
    /// <summary>
    /// Tax levied by a government agency for the granting of a license to conduct an activity, such as driving a car, operating a business, selling liquor, hunting, or practicing certain vocations.
    /// Encoded/decoded by serializers as &quot;LITX&quot;.
    /// </summary>
    [EnumMember(Value = "LITX")]
    [IsoId("_j_BTQPK-Eei1r_AoF1Xfwg")]
    [Description(@"Tax levied by a government agency for the granting of a license to conduct an activity, such as driving a car, operating a business, selling liquor, hunting, or practicing certain vocations.")]
    LicenseTax,
    
    /// <summary>
    /// All applicable sales taxes levied by taxing authorities below the state level. Used only for sales tax. 
    /// Encoded/decoded by serializers as &quot;LSTX&quot;.
    /// </summary>
    [EnumMember(Value = "LSTX")]
    [IsoId("_E8RFgPLBEei1r_AoF1Xfwg")]
    [Description(@"All applicable sales taxes levied by taxing authorities below the state level. Used only for sales tax. ")]
    LocalSalesTax,
    
    /// <summary>
    /// Labour by Trade Tax
    /// Encoded/decoded by serializers as &quot;LTTX&quot;.
    /// </summary>
    [EnumMember(Value = "LTTX")]
    [IsoId("_VaBRYPLBEei1r_AoF1Xfwg")]
    [Description(@"Labour by Trade Tax")]
    LabourByTradeTax,
    
    /// <summary>
    /// Material Tax
    /// Encoded/decoded by serializers as &quot;MATX&quot;.
    /// </summary>
    [EnumMember(Value = "MATX")]
    [IsoId("_dtEFoPLBEei1r_AoF1Xfwg")]
    [Description(@"Material Tax")]
    MaterialTax,
    
    /// <summary>
    /// Metropolitan Transit Tax
    /// Encoded/decoded by serializers as &quot;METX&quot;.
    /// </summary>
    [EnumMember(Value = "METX")]
    [IsoId("_hNm0MPLBEei1r_AoF1Xfwg")]
    [Description(@"Metropolitan Transit Tax")]
    MetropolitanTransitTax,
    
    /// <summary>
    /// Minimum Tax
    /// Encoded/decoded by serializers as &quot;MITX&quot;.
    /// </summary>
    [EnumMember(Value = "MITX")]
    [IsoId("_oe4pcPLBEei1r_AoF1Xfwg")]
    [Description(@"Minimum Tax")]
    MinimumTax,
    
    /// <summary>
    /// Mutually Defined
    /// Encoded/decoded by serializers as &quot;MUDE&quot;.
    /// </summary>
    [EnumMember(Value = "MUDE")]
    [IsoId("_sNELYPLBEei1r_AoF1Xfwg")]
    [Description(@"Mutually Defined")]
    MutuallyDefinedTax,
    
    /// <summary>
    /// Service tax imposed by a municipality.
    /// Encoded/decoded by serializers as &quot;MUTX&quot;.
    /// </summary>
    [EnumMember(Value = "MUTX")]
    [IsoId("_zP4t4PLBEei1r_AoF1Xfwg")]
    [Description(@"Service tax imposed by a municipality.")]
    MunicipalTax,
    
    /// <summary>
    /// Tax levied for the privelage of occupying space for home or rental for a fixed period of time, as determined by a taxing authority. 
    /// Encoded/decoded by serializers as &quot;OCTX&quot;.
    /// </summary>
    [EnumMember(Value = "OCTX")]
    [IsoId("_4jmqQPLBEei1r_AoF1Xfwg")]
    [Description(@"Tax levied for the privelage of occupying space for home or rental for a fixed period of time, as determined by a taxing authority. |")]
    OccupancyTax,
    
    /// <summary>
    /// Type of gross receipts tax imposed for the privilege of carrying on a business, trade or profession.
    /// Encoded/decoded by serializers as &quot;OPTX&quot;.
    /// </summary>
    [EnumMember(Value = "OPTX")]
    [IsoId("_5ZtWYPLCEei1r_AoF1Xfwg")]
    [Description(@"Type of gross receipts tax imposed for the privilege of carrying on a business, trade or profession.|")]
    OccupationalTax,
    
    /// <summary>
    /// Other national use defined value
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_cCzRUPLDEei1r_AoF1Xfwg")]
    [Description(@"Other national use defined value")]
    OtherNational,
    
    /// <summary>
    /// Other private use defined value
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_cZ0qMPLDEei1r_AoF1Xfwg")]
    [Description(@"Other private use defined value")]
    OtherPrivate,
    
    /// <summary>
    /// Other taxes
    /// Encoded/decoded by serializers as &quot;OTTX&quot;.
    /// </summary>
    [EnumMember(Value = "OTTX")]
    [IsoId("_5v82sPLDEei1r_AoF1Xfwg")]
    [Description(@"Other taxes")]
    OtherTaxes,
    
    /// <summary>
    /// Canadian tax levied to fund public care and education. 
    /// Encoded/decoded by serializers as &quot;PHET&quot;.
    /// </summary>
    [EnumMember(Value = "PHET")]
    [IsoId("_-V_NsPLDEei1r_AoF1Xfwg")]
    [Description(@"Canadian tax levied to fund public care and education. ")]
    PublicHealthAndEducationTax,
    
    /// <summary>
    /// Post-threshold Tax
    /// Encoded/decoded by serializers as &quot;POTX&quot;.
    /// </summary>
    [EnumMember(Value = "POTX")]
    [IsoId("_FdD-EPLEEei1r_AoF1Xfwg")]
    [Description(@"Post-threshold Tax")]
    PostThresholdTax,
    
    /// <summary>
    /// Pre-threshold tax
    /// Encoded/decoded by serializers as &quot;PRTX&quot;.
    /// </summary>
    [EnumMember(Value = "PRTX")]
    [IsoId("_Mrrg4PLEEei1r_AoF1Xfwg")]
    [Description(@"Pre-threshold tax")]
    PreThresholdTax,
    
    /// <summary>
    /// Quebec Sales Tax (QST)
    /// Encoded/decoded by serializers as &quot;QUST&quot;.
    /// </summary>
    [EnumMember(Value = "QUST")]
    [IsoId("_SvYIsPLEEei1r_AoF1Xfwg")]
    [Description(@"Quebec Sales Tax (QST)")]
    QuebecSalesTax,
    
    /// <summary>
    /// Room Country Subdivision1
    /// Encoded/decoded by serializers as &quot;RCSB&quot;.
    /// </summary>
    [EnumMember(Value = "RCSB")]
    [IsoId("_YBil4PLEEei1r_AoF1Xfwg")]
    [Description(@"Room Country Subdivision1")]
    RoomCountrySubdivision1,
    
    /// <summary>
    /// Room Country Subdivision2
    /// Encoded/decoded by serializers as &quot;RCSD&quot;.
    /// </summary>
    [EnumMember(Value = "RCSD")]
    [IsoId("_fGIqAPLEEei1r_AoF1Xfwg")]
    [Description(@"Room Country Subdivision2")]
    RoomCountrySubdivision2,
    
    /// <summary>
    /// Room City
    /// Encoded/decoded by serializers as &quot;ROCI&quot;.
    /// </summary>
    [EnumMember(Value = "ROCI")]
    [IsoId("_jgQE4PLEEei1r_AoF1Xfwg")]
    [Description(@"Room City")]
    RoomCity,
    
    /// <summary>
    /// Room Tax
    /// Encoded/decoded by serializers as &quot;ROTX&quot;.
    /// </summary>
    [EnumMember(Value = "ROTX")]
    [IsoId("_oidagPLEEei1r_AoF1Xfwg")]
    [Description(@"Room Tax")]
    RoomTax,
    
    /// <summary>
    /// Room Visitor
    /// Encoded/decoded by serializers as &quot;ROVI&quot;.
    /// </summary>
    [EnumMember(Value = "ROVI")]
    [IsoId("_uNlKQPLEEei1r_AoF1Xfwg")]
    [Description(@"Room Visitor")]
    RoomVisitor,
    
    /// <summary>
    /// Room VAT
    /// Encoded/decoded by serializers as &quot;RVAT&quot;.
    /// </summary>
    [EnumMember(Value = "RVAT")]
    [IsoId("_xv-6APLEEei1r_AoF1Xfwg")]
    [Description(@"Room VAT")]
    RoomVAT,
    
    /// <summary>
    /// Tax levied by taxing authority for schools
    /// Encoded/decoded by serializers as &quot;SCTX&quot;.
    /// </summary>
    [EnumMember(Value = "SCTX")]
    [IsoId("_2_jWMPLEEei1r_AoF1Xfwg")]
    [Description(@"Tax levied by taxing authority for schools")]
    SchoolTax,
    
    /// <summary>
    /// Usage tax imposed by state or provincial government authorities.
    /// Encoded/decoded by serializers as &quot;SETX&quot;.
    /// </summary>
    [EnumMember(Value = "SETX")]
    [IsoId("_BRRdoPLFEei1r_AoF1Xfwg")]
    [Description(@"Usage tax imposed by state or provincial government authorities.")]
    StateExciseTax,
    
    /// <summary>
    /// State and Local Sales Tax
    /// Encoded/decoded by serializers as &quot;SLST&quot;.
    /// </summary>
    [EnumMember(Value = "SLST")]
    [IsoId("_IKG9sPLFEei1r_AoF1Xfwg")]
    [Description(@"State and Local Sales Tax")]
    StateAndLocalSalesTax,
    
    /// <summary>
    /// State and local tax levies, exclusive of state and local sales tax. 
    /// Encoded/decoded by serializers as &quot;SLTX&quot;.
    /// </summary>
    [EnumMember(Value = "SLTX")]
    [IsoId("_NhEbUPLFEei1r_AoF1Xfwg")]
    [Description(@"State and local tax levies, exclusive of state and local sales tax. ")]
    StateAndLocalTax,
    
    /// <summary>
    /// State or Provincial Fuel Tax
    /// Encoded/decoded by serializers as &quot;SPFT&quot;.
    /// </summary>
    [EnumMember(Value = "SPFT")]
    [IsoId("_Zq23oPLFEei1r_AoF1Xfwg")]
    [Description(@"State or Provincial Fuel Tax")]
    StateProvincialFuelTax,
    
    /// <summary>
    /// State or Provincial Tax on Goods
    /// Encoded/decoded by serializers as &quot;SPTG&quot;.
    /// </summary>
    [EnumMember(Value = "SPTG")]
    [IsoId("_eMFnIPLFEei1r_AoF1Xfwg")]
    [Description(@"State or Provincial Tax on Goods")]
    StateProvincialTaxOnGoods,
    
    /// <summary>
    /// State or Provincial tax on services
    /// Encoded/decoded by serializers as &quot;SPTS&quot;.
    /// </summary>
    [EnumMember(Value = "SPTS")]
    [IsoId("_j4izoPLFEei1r_AoF1Xfwg")]
    [Description(@"State or Provincial tax on services")]
    StateOrProvincialTaxOnServices,
    
    /// <summary>
    /// Well Service
    /// Encoded/decoded by serializers as &quot;WESV&quot;.
    /// </summary>
    [EnumMember(Value = "WESV")]
    [IsoId("_tQ64QPLFEei1r_AoF1Xfwg")]
    [Description(@"Well Service")]
    WellService,
    
    /// <summary>
    /// Tax levied on consumers by a city or county for the use of natural gas. 
    /// Encoded/decoded by serializers as &quot;UUTX&quot;.
    /// </summary>
    [EnumMember(Value = "UUTX")]
    [IsoId("_tS2K4PLFEei1r_AoF1Xfwg")]
    [Description(@"Tax levied on consumers by a city or county for the use of natural gas. ")]
    UtilityUsersTax,
    
    /// <summary>
    /// Unspecified tax type
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_tTedAPLFEei1r_AoF1Xfwg")]
    [Description(@"Unspecified tax type")]
    Unspecified,
    
    /// <summary>
    /// Threshold Tax
    /// Encoded/decoded by serializers as &quot;THTX&quot;.
    /// </summary>
    [EnumMember(Value = "THTX")]
    [IsoId("_tU6ncPLFEei1r_AoF1Xfwg")]
    [Description(@"Threshold Tax")]
    ThresholdTax,
    
    /// <summary>
    /// Tax levied on telecommunications companies for the right to provide services. May be a usage or excise tax.
    /// Encoded/decoded by serializers as &quot;TELT&quot;.
    /// </summary>
    [EnumMember(Value = "TELT")]
    [IsoId("_tWbDUPLFEei1r_AoF1Xfwg")]
    [Description(@"Tax levied on telecommunications companies for the right to provide services. May be a usage or excise tax.")]
    TelecommunicationsTax,
    
    /// <summary>
    /// Excise tax levied to recover the cost of providing Telecommunications Device for the Deaf (TDD) Equipment. 
    /// Encoded/decoded by serializers as &quot;TDDT&quot;.
    /// </summary>
    [EnumMember(Value = "TDDT")]
    [IsoId("_tYLW0PLFEei1r_AoF1Xfwg")]
    [Description(@"Excise tax levied to recover the cost of providing Telecommunications Device for the Deaf (TDD) Equipment. ")]
    TDDServiceExciseTax,
    
    /// <summary>
    /// Tax levied for the use of equipment and service provided
    /// Encoded/decoded by serializers as &quot;SAUT&quot;.
    /// </summary>
    [EnumMember(Value = "SAUT")]
    [IsoId("_tZVNYPLFEei1r_AoF1Xfwg")]
    [Description(@"Tax levied for the use of equipment and service provided")]
    SalesAndUseTax,
    
    /// <summary>
    /// Surtax
    /// Encoded/decoded by serializers as &quot;SUTX&quot;.
    /// </summary>
    [EnumMember(Value = "SUTX")]
    [IsoId("_tbeicPLFEei1r_AoF1Xfwg")]
    [Description(@"Surtax")]
    Surtax,
    
    /// <summary>
    /// Stadium Tax
    /// Encoded/decoded by serializers as &quot;STTA&quot;.
    /// </summary>
    [EnumMember(Value = "STTA")]
    [IsoId("_tcsDYPLFEei1r_AoF1Xfwg")]
    [Description(@"Stadium Tax")]
    StadiumTax,
    
    /// <summary>
    /// State Tax on Specific Labour
    /// Encoded/decoded by serializers as &quot;STSL&quot;.
    /// </summary>
    [EnumMember(Value = "STSL")]
    [IsoId("_tecW4PLFEei1r_AoF1Xfwg")]
    [Description(@"State Tax on Specific Labour")]
    StateTaxOnSpecificLabour,
    
    /// <summary>
    /// Sales tax levied by a State or Province that excludes sales or excise taxes.
    /// Encoded/decoded by serializers as &quot;STPT&quot;.
    /// </summary>
    [EnumMember(Value = "STPT")]
    [IsoId("_tfwlgPLFEei1r_AoF1Xfwg")]
    [Description(@"Sales tax levied by a State or Province that excludes sales or excise taxes.")]
    StateOrProvincialTax,
    
    /// <summary>
    /// State Sales Tax
    /// Encoded/decoded by serializers as &quot;SSTX&quot;.
    /// </summary>
    [EnumMember(Value = "SSTX")]
    [IsoId("_thUrwPLFEei1r_AoF1Xfwg")]
    [Description(@"State Sales Tax")]
    StateSalesTax,
    
    /// <summary>
    /// Tax levied by a state government against a periodic fee paid by a customer in return for the right to use the property of another party.
    /// Encoded/decoded by serializers as &quot;SRTX&quot;.
    /// </summary>
    [EnumMember(Value = "SRTX")]
    [IsoId("_ti8cYPLFEei1r_AoF1Xfwg")]
    [Description(@"Tax levied by a state government against a periodic fee paid by a customer in return for the right to use the property of another party.")]
    StateRentalTax,
    
    /// <summary>
    /// Secondary Percentage Tax
    /// Encoded/decoded by serializers as &quot;SPTX&quot;.
    /// </summary>
    [EnumMember(Value = "SPTX")]
    [IsoId("_tkZN4PLFEei1r_AoF1Xfwg")]
    [Description(@"Secondary Percentage Tax")]
    SecondaryPercentageTax,
    
    /// <summary>
    /// Service tax levied by a local government or taxation agency. Not a sales tax. 
    /// Encoded/decoded by serializers as &quot;LOCL&quot;.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_xZJDIPLLEei1r_AoF1Xfwg")]
    [Description(@"Service tax levied by a local government or taxation agency. Not a sales tax. ")]
    LocalTax,
    
    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as &quot;EUTR&quot;.
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_3ECJYPLLEei1r_AoF1Xfwg")]
    [Description(@"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.")]
    EUTaxRetention,
    
    /// <summary>
    /// Tax levied on non-room expenditures.
    /// Encoded/decoded by serializers as &quot;TNRT&quot;.
    /// </summary>
    [EnumMember(Value = "TNRT")]
    [IsoId("_fYcwsCB_Eey8XKHwKquEQw")]
    [Description(@"Tax levied on non-room expenditures.")]
    TotalNonRoomTax,
    
}
