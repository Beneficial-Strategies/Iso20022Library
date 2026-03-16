// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Credit Derivative7.
/// </summary>
[IsoId("_KJgQUSyuEe6J0v6OMXVc7g")]
[DisplayName("Credit Derivative7")]
public partial record CreditDerivative7
{
    #nullable enable

    /// <summary>
    /// Calculation Basis.
    /// </summary>
    [DisplayName("Calculation Basis")]
    [IsoXmlTag("ClctnBsis")]
    public IsoMax35Text? CalculationBasis { get; init; } 

    /// <summary>
    /// Index Factor.
    /// </summary>
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    public IsoPercentageRate? IndexFactor { get; init; } 

    /// <summary>
    /// Payment Frequency.
    /// </summary>
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public Frequency13Code? PaymentFrequency { get; init; } 

    /// <summary>
    /// Reference Party.
    /// </summary>
    [DisplayName("Reference Party")]
    [IsoXmlTag("RefPty")]
    public DerivativePartyIdentification1Choice_? ReferenceParty { get; init; } 

    /// <summary>
    /// Seniority.
    /// </summary>
    [DisplayName("Seniority")]
    [IsoXmlTag("Snrty")]
    public DebtInstrumentSeniorityType2Code? Seniority { get; init; } 

    /// <summary>
    /// Series.
    /// </summary>
    [DisplayName("Series")]
    [IsoXmlTag("Srs")]
    public IsoNumber? Series { get; init; } 

    /// <summary>
    /// Tranche Indicator.
    /// </summary>
    [DisplayName("Tranche Indicator")]
    [IsoXmlTag("TrchInd")]
    public IsoTrueFalseIndicator? TrancheIndicator { get; init; } 

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoNumber? Version { get; init; } 

    
    #nullable disable
    
}
