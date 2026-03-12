// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_OHaRYRQrEeKebsB9eKJSkA")]
[DisplayName("Modification Scope")]
public partial record ModificationScope16
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_OcuaFRQrEeKebsB9eKJSkA")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
    /// </summary>
    [IsoId("_OcuaGRQrEeKebsB9eKJSkA")]
    [DisplayName("Investment Plan")]
    [IsoXmlTag("InvstmtPlan")]
    public required InvestmentPlan7 InvestmentPlan { get; init; } 
    
    
    #nullable disable
    
}
