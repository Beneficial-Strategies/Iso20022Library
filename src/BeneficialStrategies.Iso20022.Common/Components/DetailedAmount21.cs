// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("_6c6g8QxjEeqEbo60f0v6aw")]
[DisplayName("Detailed Amount")]
public partial record DetailedAmount21
{
    #nullable enable
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_6nFJkQxjEeqEbo60f0v6aw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Date and time of the payment.
    /// </summary>
    [IsoId("_6nFJkwxjEeqEbo60f0v6aw")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateTime { get; init; } 
    
    /// <summary>
    /// Card data entry mode for the related payment.
    /// </summary>
    [IsoId("_6nFJlQxjEeqEbo60f0v6aw")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading8Code? CardDataEntryMode { get; init; } 
    
    /// <summary>
    /// Data of an integrated circuit card application for the related payment.
    /// </summary>
    [IsoId("_6nFJlwxjEeqEbo60f0v6aw")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Short description of the amount to display or print.
    /// </summary>
    [IsoId("_6nFJmQxjEeqEbo60f0v6aw")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Label { get; init; } 
    
    
    #nullable disable
    
}
