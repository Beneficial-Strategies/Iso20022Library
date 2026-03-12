// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restrictions, remarks or notes that may be applied to an account or investment plan.
/// </summary>
[IsoId("_yM6pYUzZEea8fovz_9xSTQ")]
[DisplayName("Additiononal Information")]
public partial record AdditiononalInformation12
{
    #nullable enable
    
    /// <summary>
    /// Restrictions and/or limitations on the account or party.
    /// </summary>
    [IsoId("_ymNTIUzZEea8fovz_9xSTQ")]
    [DisplayName("Limitation")]
    [IsoXmlTag("Lmttn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Limitation { get; init; } 
    
    /// <summary>
    /// Additional information such as remarks or notes that must be conveyed about the account management activity or party.
    /// </summary>
    [IsoId("_ymNTI0zZEea8fovz_9xSTQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Information or instructions for the by-passing of validations in the account registration process.
    /// </summary>
    [IsoId("_ymNTJUzZEea8fovz_9xSTQ")]
    [DisplayName("Account Validation")]
    [IsoXmlTag("AcctVldtn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AccountValidation { get; init; } 
    
    /// <summary>
    /// Type or identification of the remark, note, limitation or restriction.
    /// </summary>
    [IsoId("_ymNTJ0zZEea8fovz_9xSTQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Regulator that may have to be informed about the remark, note, limitation or restriction.
    /// </summary>
    [IsoId("_ymNTKUzZEea8fovz_9xSTQ")]
    [DisplayName("Regulator")]
    [IsoXmlTag("Rgltr")]
    public PartyIdentification70Choice_? Regulator { get; init; } 
    
    /// <summary>
    /// Status of the remark, note, limitation or restriction.
    /// </summary>
    [IsoId("_ymNTK0zZEea8fovz_9xSTQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public RestrictionStatus1Choice_? Status { get; init; } 
    
    /// <summary>
    /// Period of the restriction.
    /// </summary>
    [IsoId("_ymNTLUzZEea8fovz_9xSTQ")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public DateTimePeriodDetails1? Period { get; init; } 
    
    
    #nullable disable
    
}
