// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the amendment.
/// </summary>
[IsoId("_9_TXgXltEeG7BsjMvd1mEw_678552493")]
[DisplayName("Amendment")]
public partial record Amendment6
{
    #nullable enable
    
    /// <summary>
    /// Contents of the related proposed Undertaking Amendment message.
    /// </summary>
    [IsoId("_9_TXgnltEeG7BsjMvd1mEw_667453716")]
    [DisplayName("Undertaking Amendment Message")]
    [IsoXmlTag("UdrtkgAmdmntMsg")]
    public required UndertakingAmendmentMessage1 UndertakingAmendmentMessage { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    [IsoId("_9_TXg3ltEeG7BsjMvd1mEw_1382360300")]
    [DisplayName("Applicant Reference Number")]
    [IsoXmlTag("ApplcntRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ApplicantReferenceNumber { get; init; } 
    
    /// <summary>
    /// Additional information related to the notification.
    /// </summary>
    [IsoId("_9_dIgHltEeG7BsjMvd1mEw_105618459")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
