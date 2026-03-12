// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[IsoId("_AO07p9okEeC60axPepSq7g_-1676881321")]
[DisplayName("Party Identification And Account")]
public partial record PartyIdentificationAndAccount80
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_AO-soNokEeC60axPepSq7g_-1790720387")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification32Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_AO-sodokEeC60axPepSq7g_1621013622")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification5? AlternateIdentification { get; init; } 
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_AO-sotokEeC60axPepSq7g_623941269")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    
    /// <summary>
    /// Account to be used for charges/fees if different from the account for payment.
    /// </summary>
    [IsoId("_AO-so9okEeC60axPepSq7g_-373131084")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccountIdentification5Choice_? ChargesAccount { get; init; } 
    
    /// <summary>
    /// Account to be used for commission if different from the account for payment.
    /// </summary>
    [IsoId("_AO-spNokEeC60axPepSq7g_-1370203437")]
    [DisplayName("Commission Account")]
    [IsoXmlTag("ComssnAcct")]
    public CashAccountIdentification5Choice_? CommissionAccount { get; init; } 
    
    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    [IsoId("_AO-spdokEeC60axPepSq7g_1927691506")]
    [DisplayName("Tax Account")]
    [IsoXmlTag("TaxAcct")]
    public CashAccountIdentification5Choice_? TaxAccount { get; init; } 
    
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_APIdoNokEeC60axPepSq7g_1007657854")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation2? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
