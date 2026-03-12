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
[IsoId("_oFIs4TrAEeWZFYSPlduMhw")]
[DisplayName("Parent Cash Account")]
public partial record ParentCashAccount2
{
    #nullable enable
    
    /// <summary>
    /// Defines the parent account level within a hierarchy.
    /// </summary>
    [IsoId("_oMSdwTrAEeWZFYSPlduMhw")]
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public AccountLevel1Code? Level { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification for the parent account between the parent account owner and the parent account servicer.
    /// </summary>
    [IsoId("_oMSdwzrAEeWZFYSPlduMhw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required CashAccount24 Identification { get; init; } 
    
    /// <summary>
    /// Financial institution in which the parent account resides.
    /// </summary>
    [IsoId("_oMSdxTrAEeWZFYSPlduMhw")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public BranchAndFinancialInstitutionIdentification5? Servicer { get; init; } 
    
    
    #nullable disable
    
}
