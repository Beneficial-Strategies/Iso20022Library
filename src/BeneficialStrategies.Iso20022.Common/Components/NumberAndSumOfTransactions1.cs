// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing the total sum of entries.
/// </summary>
[IsoId("_RU-M4Np-Ed-ak6NoX_4Aeg_1799173241")]
[DisplayName("Number And Sum Of Transactions")]
public partial record NumberAndSumOfTransactions1
{
    #nullable enable
    
    /// <summary>
    /// Number of individual entries included in the report.
    /// </summary>
    [IsoId("_RU-M4dp-Ed-ak6NoX_4Aeg_-2019260221")]
    [DisplayName("Number Of Entries")]
    [IsoXmlTag("NbOfNtries")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfEntries { get; init; } 
    
    /// <summary>
    /// Total of all individual entries included in the report.
    /// </summary>
    [IsoId("_RU-M4tp-Ed-ak6NoX_4Aeg_-2019260161")]
    [DisplayName("Sum")]
    [IsoXmlTag("Sum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Sum { get; init; } 
    
    
    #nullable disable
    
}
