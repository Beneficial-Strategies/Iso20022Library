// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_EQv5d9L3EeSDLevdaFPXHw")]
[DisplayName("Registered Contract Journal")]
public partial record RegisteredContractJournal1
{
    #nullable enable
    
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_wUci0dOVEeSQ_-lmj1tzfw")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; } 
    
    /// <summary>
    /// Unique registered contract identification.
    /// </summary>
    [IsoId("_EQv5etL3EeSDLevdaFPXHw")]
    [DisplayName("Unique Identification")]
    [IsoXmlTag("UnqId")]
    public DocumentIdentification28? UniqueIdentification { get; init; } 
    
    /// <summary>
    /// Date of closure of the registered contract.
    /// </summary>
    [IsoId("_O228gNL3EeSDLevdaFPXHw")]
    [DisplayName("Closure Date")]
    [IsoXmlTag("ClsrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ClosureDate { get; init; } 
    
    /// <summary>
    /// Reason of closure 
    /// TBD - codes to be defined.
    /// </summary>
    [IsoId("_yo7RsNL3EeSDLevdaFPXHw")]
    [DisplayName("Closure Reason")]
    [IsoXmlTag("ClsrRsn")]
    public required ContractClosureReason1Choice_ ClosureReason { get; init; } 
    
    
    #nullable disable
    
}
