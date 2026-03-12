// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the form of the financial Instrument.
/// </summary>
[IsoId("_dPETJeLxEeWOD7aAy2fAcA")]
[DisplayName("Financial Instrument Form")]
public partial record FinancialInstrumentForm2
{
    #nullable enable
    
    /// <summary>
    /// Indicates the booking appearance of the financial Instrument.
    /// </summary>
    [IsoId("_dYSgkeLxEeWOD7aAy2fAcA")]
    [DisplayName("Booking Appearance")]
    [IsoXmlTag("BookgApprnc")]
    public Appearance3Choice_? BookingAppearance { get; init; } 
    
    /// <summary>
    /// Specifies the form, ie, ownership, of the security.
    /// </summary>
    [IsoId("_dYSgk-LxEeWOD7aAy2fAcA")]
    [DisplayName("Legal Form")]
    [IsoXmlTag("LglForm")]
    public FormOfSecurity8Choice_? LegalForm { get; init; } 
    
    
    #nullable disable
    
}
