// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing specific information on the direct debit transaction and the related mandate.
/// </summary>
[IsoId("_TEIdZNp-Ed-ak6NoX_4Aeg_-328923835")]
[DisplayName("Direct Debit Transaction")]
public partial record DirectDebitTransaction1
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide further details related to a direct debit mandate signed between the creditor and the debtor.||Usage: Mandate related information is to be used only when the direct debit relates to a mandate signed between the debtor and the creditor.
    /// </summary>
    [IsoId("_TEIdZdp-Ed-ak6NoX_4Aeg_-89731386")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation1? MandateRelatedInformation { get; init; } 
    
    /// <summary>
    /// Credit party that signs the direct debit mandate.
    /// </summary>
    [IsoId("_TEIdZtp-Ed-ak6NoX_4Aeg_-88808758")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification8? CreditorSchemeIdentification { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the pre-notification which is sent separately from the direct debit instruction.||Usage: The direct debit pre-notification is used to reconcile separately sent collection information with the direct debit transaction information.
    /// </summary>
    [IsoId("_TEIdZ9p-Ed-ak6NoX_4Aeg_-328922905")]
    [DisplayName("Pre Notification Identification")]
    [IsoXmlTag("PreNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PreNotificationIdentification { get; init; } 
    
    /// <summary>
    /// Date on which the creditor notifies the debtor about the amount and date on which the direct debit instruction will be presented to the debtor&apos;s agent.
    /// </summary>
    [IsoId("_TEIdaNp-Ed-ak6NoX_4Aeg_-89732436")]
    [DisplayName("Pre Notification Date")]
    [IsoXmlTag("PreNtfctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PreNotificationDate { get; init; } 
    
    
    #nullable disable
    
}
