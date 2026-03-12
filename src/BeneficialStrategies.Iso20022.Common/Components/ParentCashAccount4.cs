// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash account elements of a parent cash account.
/// </summary>
[IsoId("_cTJ9i9cZEeqRFcf2R4bPBw")]
[DisplayName("Parent Cash Account")]
public partial record ParentCashAccount4
{
    #nullable enable
    
    /// <summary>
    /// Defines the parent account level within a hierarchy.
    /// </summary>
    [IsoId("_cUpLMdcZEeqRFcf2R4bPBw")]
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public AccountLevel1Code? Level { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification for the parent account between the parent account owner and the parent account servicer.
    /// </summary>
    [IsoId("_cUpLM9cZEeqRFcf2R4bPBw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required CashAccount40 Identification { get; init; } 
    
    /// <summary>
    /// Financial institution in which the parent account resides.
    /// </summary>
    [IsoId("_cUpLNdcZEeqRFcf2R4bPBw")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; init; } 
    
    
    #nullable disable
    
}
