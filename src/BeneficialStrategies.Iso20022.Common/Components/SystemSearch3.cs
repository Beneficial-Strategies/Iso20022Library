// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Search for a system and a member of a system.
/// </summary>
[IsoId("_78ydAqMgEeCJ6YNENx4h-w_2055220463")]
[DisplayName("System Search")]
public partial record SystemSearch3
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_78ydA6MgEeCJ6YNENx4h-w_910345184")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public ClearingSystemIdentification3Choice_? SystemIdentification { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_78ydBKMgEeCJ6YNENx4h-w_-338846521")]
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    public BranchAndFinancialInstitutionIdentification5? MemberIdentification { get; init; } 
    
    /// <summary>
    /// Country in which the system is located.
    /// </summary>
    [IsoId("_78ydBaMgEeCJ6YNENx4h-w_-1260552200")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_78ydBqMgEeCJ6YNENx4h-w_-1434638953")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
