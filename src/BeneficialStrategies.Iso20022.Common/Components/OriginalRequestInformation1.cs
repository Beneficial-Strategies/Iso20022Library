// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics that unambiguously identify the original global invoice financing request.
/// </summary>
[IsoId("_TiOuodp-Ed-ak6NoX_4Aeg_1502660608")]
[DisplayName("Original Request Information")]
public partial record OriginalRequestInformation1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the original request message as assigned by the original sending party.
    /// </summary>
    [IsoId("_TiOuotp-Ed-ak6NoX_4Aeg_1331216430")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Date and time at which the original request message was created.
    /// </summary>
    [IsoId("_TiOuo9p-Ed-ak6NoX_4Aeg_822273349")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Party that requests the invoice financing, on behalf of a creditor, as indicated in the original request message.
    /// </summary>
    [IsoId("_TiOupNp-Ed-ak6NoX_4Aeg_1500618546")]
    [DisplayName("Financing Requestor")]
    [IsoXmlTag("FincgRqstr")]
    public PartyIdentificationAndAccount6? FinancingRequestor { get; init; } 
    
    /// <summary>
    /// Financial institution that receives the request from the financing requestor and forwards it to the first agent for execution, as indicated in the original request message.
    /// </summary>
    [IsoId("_TiOupdp-Ed-ak6NoX_4Aeg_745955200")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public FinancialInstitutionIdentification6? IntermediaryAgent { get; init; } 
    
    /// <summary>
    /// Financial institution of financing requestor to which an invoice financing request is addressed, as indicated in the original request message.
    /// </summary>
    [IsoId("_TiOuptp-Ed-ak6NoX_4Aeg_989766263")]
    [DisplayName("First Agent")]
    [IsoXmlTag("FrstAgt")]
    public FinancialInstitutionIdentification6? FirstAgent { get; init; } 
    
    /// <summary>
    /// Information about the validation status of the request message.
    /// </summary>
    [IsoId("_TiOup9p-Ed-ak6NoX_4Aeg_-1776871398")]
    [DisplayName("Validation Status Information")]
    [IsoXmlTag("VldtnStsInf")]
    public required ValidationStatusInformation1 ValidationStatusInformation { get; init; } 
    
    /// <summary>
    /// Information on the business status of the cancellation.
    /// </summary>
    [IsoId("_TiOuqNp-Ed-ak6NoX_4Aeg_-219603516")]
    [DisplayName("Cancellation Status Information")]
    [IsoXmlTag("CxlStsInf")]
    public CancellationStatusInformation1? CancellationStatusInformation { get; init; } 
    
    
    #nullable disable
    
}
