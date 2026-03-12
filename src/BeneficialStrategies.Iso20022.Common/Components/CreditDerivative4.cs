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
[IsoId("_pAsKEZjeEeqkLZLH6DK3UQ")]
[DisplayName("Credit Derivative")]
public partial record CreditDerivative4
{
    #nullable enable
    
    /// <summary>
    /// Classification of seniority in case of contract on index or on a single name entity.
    /// </summary>
    [IsoId("_pBSnAZjeEeqkLZLH6DK3UQ")]
    [DisplayName("Seniority")]
    [IsoXmlTag("Snrty")]
    public DebtInstrumentSeniorityType2Code? Seniority { get; init; } 
    
    /// <summary>
    /// Designation of the underlying reference obligation.
    /// </summary>
    [IsoId("_pBSnA5jeEeqkLZLH6DK3UQ")]
    [DisplayName("Reference Party")]
    [IsoXmlTag("RefPty")]
    public DerivativePartyIdentification1Choice_? ReferenceParty { get; init; } 
    
    /// <summary>
    /// Specifies the time unit associated with the frequency of payments.
    /// </summary>
    [IsoId("_pBSnBZjeEeqkLZLH6DK3UQ")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency13Code? PaymentFrequency { get; init; } 
    
    /// <summary>
    /// Calculation basis of the interest rate, such as Act/360.
    /// </summary>
    [IsoId("_pBSnB5jeEeqkLZLH6DK3UQ")]
    [DisplayName("Calculation Basis")]
    [IsoXmlTag("ClctnBsis")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CalculationBasis { get; init; } 
    
    /// <summary>
    /// Indicates the series number of the composition of the index if applicable.
    /// </summary>
    [IsoId("_pBSnCZjeEeqkLZLH6DK3UQ")]
    [DisplayName("Series")]
    [IsoXmlTag("Srs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Series { get; init; } 
    
    /// <summary>
    /// New version of a series is issued if one of the constituents defaults and the index has to be re-weighted to account for the new number of total constituents within the index.
    /// </summary>
    [IsoId("_pBSnC5jeEeqkLZLH6DK3UQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Factor to apply to the actual notional to adjust it to all the previous credit events in the index series. 
    /// Usage: The figure varies between 0 and 100.
    /// </summary>
    [IsoId("_pBSnDZjeEeqkLZLH6DK3UQ")]
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? IndexFactor { get; init; } 
    
    /// <summary>
    /// Indicates whether the derivative contract is tranched or not.
    /// </summary>
    [IsoId("_pBSnD5jeEeqkLZLH6DK3UQ")]
    [DisplayName("Tranche")]
    [IsoXmlTag("Trch")]
    public TrancheIndicator3Choice_? Tranche { get; init; } 
    
    
    #nullable disable
    
}
