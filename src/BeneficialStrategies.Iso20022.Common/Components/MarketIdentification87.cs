// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the market and purpose for the settlement.
/// </summary>
[IsoId("_ZkmIMNTPEeKvJeoOII0e7w")]
[DisplayName("Market Identification")]
public partial record MarketIdentification87
{
    #nullable enable
    
    /// <summary>
    /// Country in which the financial instrument is to be settled.
    /// </summary>
    [IsoId("_hzs3oNTPEeKvJeoOII0e7w")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    /// <summary>
    /// Type of instrument covered by the SSI instruction.
    /// </summary>
    [IsoId("_rmMscNTPEeKvJeoOII0e7w")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public required ClassificationType1Choice_ ClassificationType { get; init; } 
    
    /// <summary>
    /// Purpose of the instruction, for example, whether for regular payments, margin payments related to a collateral movement, securities settlements, securities lending.
    /// </summary>
    [IsoId("_FcKBEtQQEeKSSosHwGnjNw")]
    [DisplayName("Settlement Purpose")]
    [IsoXmlTag("SttlmPurp")]
    public Purpose3Choice_? SettlementPurpose { get; init; } 
    
    
    #nullable disable
    
}
