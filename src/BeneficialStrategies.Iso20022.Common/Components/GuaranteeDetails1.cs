// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the details of a guarantee.
/// </summary>
[IsoId("_OTgzMzc0-AOSNFX-8224501")]
[DisplayName("Guarantee Details")]
public partial record GuaranteeDetails1
{
    #nullable enable
    
    /// <summary>
    /// Party issuing the guarantee.
    /// </summary>
    [IsoId("_OTgzMzg4-AOSNFX-8224502")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public QualifiedPartyIdentification1? Issuer { get; init; } 
    
    /// <summary>
    /// Rank of the guarantee provider. A value of 1 means highest rank. Providers may have the same position.
    /// </summary>
    [IsoId("_OTgzMzg5-AOSNFX-8224502")]
    [DisplayName("Position")]
    [IsoXmlTag("Pos")]
    [IsoSimpleType(IsoSimpleType.positiveInteger)]
    public IsopositiveInteger? Position { get; init; } 
    
    /// <summary>
    /// Textual description of guarantee details.
    /// </summary>
    [IsoId("_OTgzMzkw-AOSNFX-8224502")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public IsoMax2000Text? Description { get; init; } 
    
    /// <summary>
    /// Amount by time periods, maximum value applies at any given date.
    /// </summary>
    [IsoId("_OTgzMzkx-AOSNFX-8224502")]
    [DisplayName("Guaranteed Amount")]
    [IsoXmlTag("GrntedAmt")]
    public AmountAndPeriod1? GuaranteedAmount { get; init; } 
    
    /// <summary>
    /// Amount not covered by the guarantee. Maximum value applies at any given date.
    /// </summary>
    [IsoId("_OTgzMzky-AOSNFX-8224502")]
    [DisplayName("Excess")]
    [IsoXmlTag("Xcss")]
    public AmountAndPeriod1? Excess { get; init; } 
    
    /// <summary>
    /// Covered percentage, the maximum value applies at any given date.
    /// </summary>
    [IsoId("_OTgzMzkz-AOSNFX-8224502")]
    [DisplayName("Covered Percentage")]
    [IsoXmlTag("CvrdPctg")]
    public PercentageAndPeriod1? CoveredPercentage { get; init; } 
    
    /// <summary>
    /// Associated free form document.
    /// </summary>
    [IsoId("_OTgzMzk0-AOSNFX-8224502")]
    [DisplayName("Associated Document")]
    [IsoXmlTag("AssoctdDoc")]
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    
    /// <summary>
    /// Additional information related to the demand.
    /// </summary>
    [IsoId("_OTgzMzk1-AOSNFX-8224503")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
    
    
    #nullable disable
    
}
