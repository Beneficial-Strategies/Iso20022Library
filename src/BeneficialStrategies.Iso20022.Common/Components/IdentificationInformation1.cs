// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide identification information.
/// </summary>
[IsoId("_QpdKstp-Ed-ak6NoX_4Aeg_1272136822")]
[DisplayName("Identification Information")]
public partial record IdentificationInformation1
{
    #nullable enable
    
    /// <summary>
    /// Account owner that owes an amount of money or to whom an amount of money is due.
    /// </summary>
    [IsoId("_QpdKs9p-Ed-ak6NoX_4Aeg_-1790848731")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public PartyIdentification32? Party { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the account of a party.
    /// </summary>
    [IsoId("_QpdKtNp-Ed-ak6NoX_4Aeg_-1697737128")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public AccountIdentification4Choice_? Account { get; init; } 
    
    /// <summary>
    /// Financial institution servicing an account for a party.
    /// </summary>
    [IsoId("_QpdKtdp-Ed-ak6NoX_4Aeg_-574496207")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public BranchAndFinancialInstitutionIdentification4? Agent { get; init; } 
    
    
    #nullable disable
    
}
