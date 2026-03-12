// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Represents a party to be identified as eligible for the instructing party.
/// </summary>
[IsoId("_jA3FAu5NEeCisYr99QEiWA_640889809")]
[DisplayName("Eligible Counterpart")]
public partial record EligibleCounterpart1
{
    #nullable enable
    
    /// <summary>
    /// Unique business identifier code used to identify the party providing the eligible counterpart information.
    /// </summary>
    [IsoId("_jA3FA-5NEeCisYr99QEiWA_1268620979")]
    [DisplayName("Issuer Identification")]
    [IsoXmlTag("IssrId")]
    public required SystemPartyIdentification1Choice_ IssuerIdentification { get; init; } 
    
    /// <summary>
    /// Unique business identifier code used to identify the central securities depository to be defined as eligible.
    /// </summary>
    [IsoId("_jA3FBO5NEeCisYr99QEiWA_758214850")]
    [DisplayName("Eligible Counterpart Identification")]
    [IsoXmlTag("ElgblCntrptId")]
    public required SystemPartyIdentification1Choice_ EligibleCounterpartIdentification { get; init; } 
    
    /// <summary>
    /// Date from when the eligible counterpart is valid.
    /// </summary>
    [IsoId("_jBA2AO5NEeCisYr99QEiWA_1781725699")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValidFrom { get; init; } 
    
    /// <summary>
    /// Date until when the eligible counterpart is valid.
    /// </summary>
    [IsoId("_jBA2Ae5NEeCisYr99QEiWA_-852427203")]
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidTo { get; init; } 
    
    /// <summary>
    /// Defines the type of eligibility.
    /// </summary>
    [IsoId("_jBA2Au5NEeCisYr99QEiWA_208099130")]
    [DisplayName("Eligibility Type")]
    [IsoXmlTag("ElgbltyTp")]
    public required EligibilityType1Code EligibilityType { get; init; } 
    
    /// <summary>
    /// Unique identification of the eligible counterpart party.
    /// </summary>
    [IsoId("_jBA2A-5NEeCisYr99QEiWA_-730913403")]
    [DisplayName("Eligibility Identification")]
    [IsoXmlTag("ElgbltyId")]
    public required EligibilityIdentification1Choice_ EligibilityIdentification { get; init; } 
    
    
    #nullable disable
    
}
