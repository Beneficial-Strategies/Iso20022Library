// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related specifically to credit derivatives attributes.
/// </summary>
[IsoId("_yvKMUbyOEeaUov4jN5X9Qw")]
[DisplayName("Credit Derivative")]
public partial record CreditDerivative2
{
    #nullable enable
    
    /// <summary>
    /// Classification of seniority in case of contract on index or on a single name entity.
    /// </summary>
    [IsoId("_y4Zn4byOEeaUov4jN5X9Qw")]
    [DisplayName("Seniority")]
    [IsoXmlTag("Snrty")]
    public DebtInstrumentSeniorityType2Code? Seniority { get; init; } 
    
    /// <summary>
    /// Designation of the underlying reference obligation.
    /// </summary>
    [IsoId("_y4Zn47yOEeaUov4jN5X9Qw")]
    [DisplayName("Reference Party")]
    [IsoXmlTag("RefPty")]
    public DerivativePartyIdentification1Choice_? ReferenceParty { get; init; } 
    
    /// <summary>
    /// Frequency of payment of the interest rate or coupon.
    /// </summary>
    [IsoId("_y4Zn5byOEeaUov4jN5X9Qw")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency8Code? PaymentFrequency { get; init; } 
    
    /// <summary>
    /// Calculation basis of the interest rate, such as Act/360.
    /// </summary>
    [IsoId("_y4Zn57yOEeaUov4jN5X9Qw")]
    [DisplayName("Calculation Basis")]
    [IsoXmlTag("ClctnBsis")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CalculationBasis { get; init; } 
    
    /// <summary>
    /// Indicates the series number of the composition of the index if applicable.
    /// </summary>
    [IsoId("_y4Zn6byOEeaUov4jN5X9Qw")]
    [DisplayName("Series")]
    [IsoXmlTag("Srs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Series { get; init; } 
    
    /// <summary>
    /// New version of a series is issued if one of the constituents defaults and the index has to be re-weighted to account for the new number of total constituents within the index.
    /// </summary>
    [IsoId("_y4Zn67yOEeaUov4jN5X9Qw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Factor to apply to the actual notional to adjust it to all the previous credit events in the index series. 
    /// Usage: The figure varies between 0 and 100.
    /// </summary>
    [IsoId("_y4Zn7byOEeaUov4jN5X9Qw")]
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? IndexFactor { get; init; } 
    
    /// <summary>
    /// Indicates whether the derivative contract is tranched or not.
    /// </summary>
    [IsoId("_y4Zn77yOEeaUov4jN5X9Qw")]
    [DisplayName("Tranche")]
    [IsoXmlTag("Trch")]
    public TrancheIndicator2Choice_? Tranche { get; init; } 
    
    
    #nullable disable
    
}
