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
[IsoId("_tsYf4FkyEeGeoaLUQk__nA_492898549")]
[DisplayName("Number And Sum Of Transactions")]
public partial record NumberAndSumOfTransactions3
{
    #nullable enable
    
    /// <summary>
    /// Number of individual entries included in the report.
    /// </summary>
    [IsoId("_tsYf4VkyEeGeoaLUQk__nA_-718764499")]
    [DisplayName("Number Of Entries")]
    [IsoXmlTag("NbOfNtries")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfEntries { get; init; } 
    
    /// <summary>
    /// Total of all individual entries included in the report.
    /// </summary>
    [IsoId("_tsYf4lkyEeGeoaLUQk__nA_-1829675918")]
    [DisplayName("Sum")]
    [IsoXmlTag("Sum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Sum { get; init; } 
    
    /// <summary>
    /// Resulting amount of the netted amounts for all debit and credit entries.
    /// </summary>
    [IsoId("_tsYf41kyEeGeoaLUQk__nA_181137167")]
    [DisplayName("Total Net Entry Amount")]
    [IsoXmlTag("TtlNetNtryAmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalNetEntryAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether the total net entry amount is a credit or a debit amount.
    /// </summary>
    [IsoId("_tshp0FkyEeGeoaLUQk__nA_-929774252")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    
    #nullable disable
    
}
