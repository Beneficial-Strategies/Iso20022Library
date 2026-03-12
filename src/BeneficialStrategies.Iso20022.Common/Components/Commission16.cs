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
[IsoId("_AhmtsNokEeC60axPepSq7g_141814684")]
[DisplayName("Commission")]
public partial record Commission16
{
    #nullable enable
    
    /// <summary>
    /// Specification of the commission type.
    /// </summary>
    [IsoId("_AhmtsdokEeC60axPepSq7g_-1852330022")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CommissionType2Choice_ Type { get; init; } 
    
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_AhmtstokEeC60axPepSq7g_27975618")]
    [DisplayName("Commission")]
    [IsoXmlTag("Comssn")]
    public required AmountOrRate2Choice_ Commission { get; init; } 
    
    /// <summary>
    /// Information related to an identification, eg, party identification or account identification.
    /// </summary>
    [IsoId("_Ahmts9okEeC60axPepSq7g_-855257669")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification54? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Date at which an operation is triggered to calculate, for instance, a commission, fee, asset values, etc.
    /// </summary>
    [IsoId("_AhmttNokEeC60axPepSq7g_-1715858792")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CalculationDate { get; init; } 
    
    /// <summary>
    /// Total value of the commissions for a specific trade.
    /// </summary>
    [IsoId("_AhmttdokEeC60axPepSq7g_618424721")]
    [DisplayName("Total Commission")]
    [IsoXmlTag("TtlComssn")]
    public AmountAndDirection29? TotalCommission { get; init; } 
    
    /// <summary>
    /// Amount that results of the calculation of VAT on net fees, according to the transaction current tariffs.
    /// </summary>
    [IsoId("_AhwesNokEeC60axPepSq7g_-632238511")]
    [DisplayName("Total VAT Amount")]
    [IsoXmlTag("TtlVATAmt")]
    public ActiveCurrencyAndAmount? TotalVATAmount { get; init; } 
    
    /// <summary>
    /// Specifies the VAT rate.
    /// </summary>
    [IsoId("_AhwesdokEeC60axPepSq7g_232710671")]
    [DisplayName("VAT Rate")]
    [IsoXmlTag("VATRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? VATRate { get; init; } 
    
    
    #nullable disable
    
}
