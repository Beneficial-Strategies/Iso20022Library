// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the securities compensation such as the depository and the total settlement amount.
/// </summary>
[IsoId("_Uot1kdp-Ed-ak6NoX_4Aeg_-1569066973")]
[DisplayName("Securities Compensation")]
public partial record SecuritiesCompensation1
{
    #nullable enable
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_Uot1ktp-Ed-ak6NoX_4Aeg_2036151037")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public required PartyIdentification34Choice_ Depository { get; init; } 
    
    /// <summary>
    /// Provides the total amount of money to be settled.
    /// </summary>
    [IsoId("_Uot1k9p-Ed-ak6NoX_4Aeg_-183187365")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection20 SettlementAmount { get; init; } 
    
    /// <summary>
    /// Amount of money related to the fees for the securities compensation.
    /// </summary>
    [IsoId("_Uot1lNp-Ed-ak6NoX_4Aeg_-846472432")]
    [DisplayName("Fees")]
    [IsoXmlTag("Fees")]
    public AmountAndDirection20? Fees { get; init; } 
    
    
    #nullable disable
    
}
