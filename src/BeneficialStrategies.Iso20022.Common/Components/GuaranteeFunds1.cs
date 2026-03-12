// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Guarantee funds details.
/// </summary>
[IsoId("_IhrDAB92EeapDZRA0Hb6ow")]
[DisplayName("Guarantee Funds")]
public partial record GuaranteeFunds1
{
    #nullable enable
    
    /// <summary>
    /// Type for the guarantee funds used.
    /// </summary>
    [IsoId("_V6KHEB92EeapDZRA0Hb6ow")]
    [DisplayName("Guarantee Funds Usage Type")]
    [IsoXmlTag("GrntFndsUsgTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text GuaranteeFundsUsageType { get; init; } 
    
    /// <summary>
    /// Owner and account number of the guarantee fund.
    /// </summary>
    [IsoId("_VZlMICciEeaBPexHR4QTEw")]
    [DisplayName("Guarantee Fund Information")]
    [IsoXmlTag("GrntFndInf")]
    public GuaranteeFundInformation1? GuaranteeFundInformation { get; init; } 
    
    
    #nullable disable
    
}
