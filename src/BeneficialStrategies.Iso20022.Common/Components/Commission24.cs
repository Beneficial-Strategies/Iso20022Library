// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_pLNREY-wEeaEa8S_GI1QNA")]
[DisplayName("Commission")]
public partial record Commission24
{
    #nullable enable
    
    /// <summary>
    /// Specification of the commission type.
    /// </summary>
    [IsoId("_paqpY4-wEeaEa8S_GI1QNA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CommissionType6Choice_ Type { get; init; } 
    
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_paqpa4-wEeaEa8S_GI1QNA")]
    [DisplayName("Commission")]
    [IsoXmlTag("Comssn")]
    public required AmountOrRate2Choice_ Commission { get; init; } 
    
    /// <summary>
    /// Information related to an identification, eg, party identification or account identification.
    /// </summary>
    [IsoId("_paqpeY-wEeaEa8S_GI1QNA")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification117? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Date at which an operation is triggered to calculate, for instance, a commission, fee, asset values, etc.
    /// </summary>
    [IsoId("_paqpgY-wEeaEa8S_GI1QNA")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CalculationDate { get; init; } 
    
    /// <summary>
    /// Total value of the commissions for a specific trade.
    /// </summary>
    [IsoId("_paqpg4-wEeaEa8S_GI1QNA")]
    [DisplayName("Total Commission")]
    [IsoXmlTag("TtlComssn")]
    public AmountAndDirection29? TotalCommission { get; init; } 
    
    /// <summary>
    /// Amount that results of the calculation of VAT on net fees, according to the transaction current tariffs.
    /// </summary>
    [IsoId("_paqphY-wEeaEa8S_GI1QNA")]
    [DisplayName("Total VAT Amount")]
    [IsoXmlTag("TtlVATAmt")]
    public ActiveCurrencyAndAmount? TotalVATAmount { get; init; } 
    
    /// <summary>
    /// Specifies the VAT rate.
    /// </summary>
    [IsoId("_paqph4-wEeaEa8S_GI1QNA")]
    [DisplayName("VAT Rate")]
    [IsoXmlTag("VATRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? VATRate { get; init; } 
    
    
    #nullable disable
    
}
