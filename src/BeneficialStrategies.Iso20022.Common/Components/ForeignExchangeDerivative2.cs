// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Foreign Exchange Derivative which is either deliverable or non-deliverable.
/// </summary>
[IsoId("_TzPS8X5iEeaGiOUFl5b1oQ")]
[DisplayName("Foreign Exchange Derivative")]
public partial record ForeignExchangeDerivative2
{
    #nullable enable
    
    /// <summary>
    /// Type of deliverable and non-deliverable forwards, options and swaps contract.	.
    /// </summary>
    [IsoId("_UA7JoX5iEeaGiOUFl5b1oQ")]
    [DisplayName("Contract Sub Type")]
    [IsoXmlTag("CtrctSubTp")]
    public required AssetClassSubProductType19Code ContractSubType { get; init; } 
    
    
    #nullable disable
    
}
