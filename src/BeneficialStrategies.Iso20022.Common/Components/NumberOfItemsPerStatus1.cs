// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the number of reported items with their respective acceptance status.
/// </summary>
[IsoId("_UtSF10ipEeSlHoYg_EudVQ")]
[DisplayName("Number Of Items Per Status")]
public partial record NumberOfItemsPerStatus1
{
    #nullable enable
    
    /// <summary>
    /// Common status of the report items for which the number of report items is specified in NumberOfItems.
    /// </summary>
    [IsoId("_U4cM9UipEeSlHoYg_EudVQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ReportItemStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Number of items for the status.
    /// </summary>
    [IsoId("_U4cM80ipEeSlHoYg_EudVQ")]
    [DisplayName("Number Of Items")]
    [IsoXmlTag("NbOfItms")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfItems { get; init; } 
    
    
    #nullable disable
    
}
