// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the date from which the financial instrument identification is valid.
/// </summary>
[IsoId("_hW9wVGliEeGaMcKyqKNRfQ_288608342")]
[DisplayName("Financial Instrument Identification Validity")]
public partial record FinancialInstrumentIdentificationValidity1
{
    #nullable enable
    
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    [IsoId("_hW9wVWliEeGaMcKyqKNRfQ_1938517514")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Defines the date from which the instrument code is valid. This date can be before the actual issue date of an instrument for &apos;when-issued&apos; securities, but may not be a date in the future for a new security.
    /// </summary>
    [IsoId("_hW9wVmliEeGaMcKyqKNRfQ_-12545399")]
    [DisplayName("ISIN Valid From")]
    [IsoXmlTag("ISINVldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ISINValidFrom { get; init; } 
    
    
    #nullable disable
    
}
