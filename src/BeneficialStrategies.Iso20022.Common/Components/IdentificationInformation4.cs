// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the identification information.
/// </summary>
[IsoId("_d4SvRdcZEeqRFcf2R4bPBw")]
[DisplayName("Identification Information")]
public partial record IdentificationInformation4
{
    #nullable enable
    
    /// <summary>
    /// Account owner that owes an amount of money or to whom an amount of money is due.
    /// </summary>
    [IsoId("_d5tEg9cZEeqRFcf2R4bPBw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public PartyIdentification135? Party { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the account of a party.
    /// </summary>
    [IsoId("_d5tEhdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; } 
    
    /// <summary>
    /// Financial institution servicing an account for a party.
    /// </summary>
    [IsoId("_d5tEh9cZEeqRFcf2R4bPBw")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public BranchAndFinancialInstitutionIdentification6? Agent { get; init; } 
    
    
    #nullable disable
    
}
