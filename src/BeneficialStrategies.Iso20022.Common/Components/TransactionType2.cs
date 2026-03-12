// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the transactions to be reported.
/// </summary>
[IsoId("_cVL34YaoEeeUws0ZryHQ2w")]
[DisplayName("Transaction Type")]
public partial record TransactionType2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status on the books of the account servicer of the transactions to be reported.
    /// </summary>
    [IsoId("_cdgtcYaoEeeUws0ZryHQ2w")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required EntryStatus1Choice_ Status { get; init; } 
    
    /// <summary>
    /// Indicates whether the reporting request refers to credit or debit entries.
    /// </summary>
    [IsoId("_cdgtc4aoEeeUws0ZryHQ2w")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the minimum value of entries to be reported in the requested message.
    /// </summary>
    [IsoId("_cdgtdYaoEeeUws0ZryHQ2w")]
    [DisplayName("Floor Limit")]
    [IsoXmlTag("FlrLmt")]
    public Limit2? FloorLimit { get; init; } 
    
    
    #nullable disable
    
}
