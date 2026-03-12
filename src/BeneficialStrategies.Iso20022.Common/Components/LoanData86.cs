// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction.
/// </summary>
[IsoId("_mUNDEK0oEemlgIolf65eZg")]
[DisplayName("Loan Data")]
public partial record LoanData86
{
    #nullable enable
    
    /// <summary>
    /// Unique reference assigned to the transaction to identify the trade.
    /// </summary>
    [IsoId("_uz06w60oEemlgIolf65eZg")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
    
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_uz06xK0oEemlgIolf65eZg")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EventDate { get; init; } 
    
    /// <summary>
    /// Termination date in the case of a full early termination of the SFT.
    /// </summary>
    [IsoId("_uz06xa0oEemlgIolf65eZg")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; } 
    
    
    #nullable disable
    
}
