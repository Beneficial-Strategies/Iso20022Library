// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details on the margin report per margin account, and optionally per non-clearing member.
/// </summary>
[IsoId("_-eDlF6MOEeCojJW5vEuTEQ_-651188683")]
[DisplayName("Margin Report")]
public partial record MarginReport2
{
    #nullable enable
    
    /// <summary>
    /// Specifies if the margin is related to equities or fixed income.
    /// </summary>
    [IsoId("_-eDlGKMOEeCojJW5vEuTEQ_1535794841")]
    [DisplayName("Margin Product")]
    [IsoXmlTag("MrgnPdct")]
    public MarginProductType1Choice_? MarginProduct { get; init; } 
    
    /// <summary>
    /// Identifies the clearing member&apos;s account.
    /// </summary>
    [IsoId("_-eDlGaMOEeCojJW5vEuTEQ_-765027749")]
    [DisplayName("Margin Account")]
    [IsoXmlTag("MrgnAcct")]
    public required SecuritiesAccount18 MarginAccount { get; init; } 
    
    /// <summary>
    /// Used to indicate whether the reported margin account is collateralised or not. If not collateralised, the account is configured for informational reporting.
    /// </summary>
    [IsoId("_-eMvAKMOEeCojJW5vEuTEQ_1274385428")]
    [DisplayName("Collateralised Margin Account Indicator")]
    [IsoXmlTag("CollsdMrgnAcctInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CollateralisedMarginAccountIndicator { get; init; } 
    
    /// <summary>
    /// Provides details about the non clearing member identification and account.
    /// </summary>
    [IsoId("_-eMvAaMOEeCojJW5vEuTEQ_-1762100102")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    
    /// <summary>
    /// Provides the margin calculation summary per margin account.
    /// </summary>
    [IsoId("_-eMvAqMOEeCojJW5vEuTEQ_-403792512")]
    [DisplayName("Margin Calculation Summary")]
    [IsoXmlTag("MrgnClctnSummry")]
    public MarginCalculation1? MarginCalculationSummary { get; init; } 
    
    /// <summary>
    /// Provides the margin details such as the exposure amount and the initial margin.
    /// </summary>
    [IsoId("_-eMvA6MOEeCojJW5vEuTEQ_538722488")]
    [DisplayName("Margin Calculation")]
    [IsoXmlTag("MrgnClctn")]
    public ValueList<MarginCalculation2> MarginCalculation { get; init; } = new ValueList<MarginCalculation2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _-eMvA6MOEeCojJW5vEuTEQ_538722488
    
    
    #nullable disable
    
}
