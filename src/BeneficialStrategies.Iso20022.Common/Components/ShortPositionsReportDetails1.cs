// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about short positions.
/// </summary>
[IsoId("_shPDYAx3EeazkbJaoKTIIw")]
[DisplayName("Short Positions Report Details")]
public partial record ShortPositionsReportDetails1
{
    #nullable enable
    
    /// <summary>
    /// Identification of participant account.
    /// </summary>
    [IsoId("_CJhacAx4EeazkbJaoKTIIw")]
    [DisplayName("Participant Identification")]
    [IsoXmlTag("PtcptId")]
    public required BranchAndFinancialInstitutionIdentification5 ParticipantIdentification { get; init; } 
    
    /// <summary>
    /// Information about participant account number.
    /// </summary>
    [IsoId("_EJegAAx4EeazkbJaoKTIIw")]
    [DisplayName("Participant Account")]
    [IsoXmlTag("PtcptAcct")]
    public required CashAccount24 ParticipantAccount { get; init; } 
    
    /// <summary>
    /// Information about participant account balance.
    /// </summary>
    [IsoId("_Hri4kAx4EeazkbJaoKTIIw")]
    [DisplayName("Short Position Amount")]
    [IsoXmlTag("ShrtPosAmt")]
    public required ActiveCurrencyAndAmount ShortPositionAmount { get; init; } 
    
    
    #nullable disable
    
}
