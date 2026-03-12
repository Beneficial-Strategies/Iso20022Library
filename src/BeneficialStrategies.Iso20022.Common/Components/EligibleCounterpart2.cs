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
[IsoId("_jzsckeLXEeWFtOV72FbX9w")]
[DisplayName("Eligible Counterpart")]
public partial record EligibleCounterpart2
{
    #nullable enable
    
    /// <summary>
    /// Unique business identifier code used to identify the party providing the eligible counterpart information.
    /// </summary>
    [IsoId("_j_JeoeLXEeWFtOV72FbX9w")]
    [DisplayName("Issuer Identification")]
    [IsoXmlTag("IssrId")]
    public required SystemPartyIdentification1Choice_ IssuerIdentification { get; init; } 
    
    /// <summary>
    /// Unique business identifier code used to identify the central securities depository to be defined as eligible.
    /// </summary>
    [IsoId("_j_Jeo-LXEeWFtOV72FbX9w")]
    [DisplayName("Eligible Counterpart Identification")]
    [IsoXmlTag("ElgblCntrptId")]
    public required SystemPartyIdentification1Choice_ EligibleCounterpartIdentification { get; init; } 
    
    /// <summary>
    /// Date from when the eligible counterpart is valid.
    /// </summary>
    [IsoId("_j_JepeLXEeWFtOV72FbX9w")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValidFrom { get; init; } 
    
    /// <summary>
    /// Date until when the eligible counterpart is valid.
    /// </summary>
    [IsoId("_j_Jep-LXEeWFtOV72FbX9w")]
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidTo { get; init; } 
    
    /// <summary>
    /// Defines the type of eligibility.
    /// </summary>
    [IsoId("_j_JeqeLXEeWFtOV72FbX9w")]
    [DisplayName("Eligibility Type")]
    [IsoXmlTag("ElgbltyTp")]
    public required EligibilityType1Code EligibilityType { get; init; } 
    
    /// <summary>
    /// Unique identification of the eligible counterpart party.
    /// </summary>
    [IsoId("_j_Jeq-LXEeWFtOV72FbX9w")]
    [DisplayName("Eligibility Identification")]
    [IsoXmlTag("ElgbltyId")]
    public required EligibilityIdentification2Choice_ EligibilityIdentification { get; init; } 
    
    
    #nullable disable
    
}
