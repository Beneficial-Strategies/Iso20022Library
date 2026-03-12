// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a pension.
/// </summary>
[IsoId("_7NcYcTOTEeqLMcD_sEa8Xw")]
[DisplayName("Pension")]
public partial record Pension4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_7lP0cTOTEeqLMcD_sEa8Xw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PensionPolicy1? Identification { get; init; } 
    
    /// <summary>
    /// Type of pension policy, plan or scheme.
    /// </summary>
    [IsoId("_7lP0czOTEeqLMcD_sEa8Xw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PensionSchemeType2Choice_? Type { get; init; } 
    
    /// <summary>
    /// Scope of the pension policy, plan or scheme transfer.
    /// </summary>
    [IsoId("_7lP0dTOTEeqLMcD_sEa8Xw")]
    [DisplayName("Transfer Scope")]
    [IsoXmlTag("TrfScp")]
    public PensionTransferScope1Choice_? TransferScope { get; init; } 
    
    /// <summary>
    /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
    /// </summary>
    [IsoId("_7lP0dzOTEeqLMcD_sEa8Xw")]
    [DisplayName("Tax Reference")]
    [IsoXmlTag("TaxRef")]
    public TaxReference1? TaxReference { get; init; } 
    
    /// <summary>
    /// Reference of the drawdown.
    /// </summary>
    [IsoId("_7lP0eTOTEeqLMcD_sEa8Xw")]
    [DisplayName("Drawdown Tranche Identification")]
    [IsoXmlTag("DrwdwnTrchId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DrawdownTrancheIdentification { get; init; } 
    
    /// <summary>
    /// Additional information about the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_7lP0ezOTEeqLMcD_sEa8Xw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
