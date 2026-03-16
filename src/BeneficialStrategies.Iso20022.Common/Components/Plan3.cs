// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Plan3.
/// </summary>
[IsoId("_KYvZYXG-Ee60F8I8TAMKmg")]
[DisplayName("Plan3")]
public partial record Plan3
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Amount Details.
    /// </summary>
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public ValueList<InstalmentAmountDetails3> AmountDetails { get; init; } = [];

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; } 

    /// <summary>
    /// Customer Selected Grace Period.
    /// </summary>
    [DisplayName("Customer Selected Grace Period")]
    [IsoXmlTag("CstmrSelctdGracePrd")]
    public IsoTrueFalseIndicator? CustomerSelectedGracePeriod { get; init; } 

    /// <summary>
    /// Deferred.
    /// </summary>
    [DisplayName("Deferred")]
    [IsoXmlTag("Dfrrd")]
    public IsoTrueFalseIndicator? Deferred { get; init; } 

    /// <summary>
    /// Deferred Periods.
    /// </summary>
    [DisplayName("Deferred Periods")]
    [IsoXmlTag("DfrrdPrds")]
    public IsoNumber? DeferredPeriods { get; init; } 

    /// <summary>
    /// First Amount.
    /// </summary>
    [DisplayName("First Amount")]
    [IsoXmlTag("FrstAmt")]
    public ImpliedCurrencyAndAmount? FirstAmount { get; init; } 

    /// <summary>
    /// First Payment Date.
    /// </summary>
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    public IsoISODate? FirstPaymentDate { get; init; } 

    /// <summary>
    /// Grace Period Unit Type.
    /// </summary>
    [DisplayName("Grace Period Unit Type")]
    [IsoXmlTag("GracePrdUnitTp")]
    public GracePeriodUnitType1Code? GracePeriodUnitType { get; init; } 

    /// <summary>
    /// Grand Total Amount.
    /// </summary>
    [DisplayName("Grand Total Amount")]
    [IsoXmlTag("GrdTtlAmt")]
    public ImpliedCurrencyAndAmount? GrandTotalAmount { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax70Text? Identification { get; init; } 

    /// <summary>
    /// Interest Rate.
    /// </summary>
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public ValueList<InterestRateDetails2> InterestRate { get; init; } = [];

    /// <summary>
    /// Normal Payment Amount.
    /// </summary>
    [DisplayName("Normal Payment Amount")]
    [IsoXmlTag("NrmlPmtAmt")]
    public ImpliedCurrencyAndAmount? NormalPaymentAmount { get; init; } 

    /// <summary>
    /// Number Of Grace Period Units.
    /// </summary>
    [DisplayName("Number Of Grace Period Units")]
    [IsoXmlTag("NbOfGracePrdUnits")]
    public IsoMax3NumericText? NumberOfGracePeriodUnits { get; init; } 

    /// <summary>
    /// Number Of Periods.
    /// </summary>
    [DisplayName("Number Of Periods")]
    [IsoXmlTag("NbOfPrds")]
    public IsoNumber? NumberOfPeriods { get; init; } 

    /// <summary>
    /// Other Grace Period Unit Type.
    /// </summary>
    [DisplayName("Other Grace Period Unit Type")]
    [IsoXmlTag("OthrGracePrdUnitTp")]
    public IsoMax35Text? OtherGracePeriodUnitType { get; init; } 

    /// <summary>
    /// Other Owner.
    /// </summary>
    [DisplayName("Other Owner")]
    [IsoXmlTag("OthrOwnr")]
    public IsoMax35Text? OtherOwner { get; init; } 

    /// <summary>
    /// Owner.
    /// </summary>
    [DisplayName("Owner")]
    [IsoXmlTag("Ownr")]
    public PlanOwner1Code? Owner { get; init; } 

    /// <summary>
    /// Owner Name.
    /// </summary>
    [DisplayName("Owner Name")]
    [IsoXmlTag("OwnrNm")]
    public IsoMax256Text? OwnerName { get; init; } 

    /// <summary>
    /// Payment Type.
    /// </summary>
    [DisplayName("Payment Type")]
    [IsoXmlTag("PmtTp")]
    public IsoMax35Text? PaymentType { get; init; } 

    /// <summary>
    /// Period Unit.
    /// </summary>
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public Frequency18Code? PeriodUnit { get; init; } 

    /// <summary>
    /// Registration System Identification.
    /// </summary>
    [DisplayName("Registration System Identification")]
    [IsoXmlTag("RegnSysId")]
    public IsoMax35Text? RegistrationSystemIdentification { get; init; } 

    /// <summary>
    /// Total Number Of Payments.
    /// </summary>
    [DisplayName("Total Number Of Payments")]
    [IsoXmlTag("TtlNbOfPmts")]
    public IsoNumber? TotalNumberOfPayments { get; init; } 

    
    #nullable disable
    
}
